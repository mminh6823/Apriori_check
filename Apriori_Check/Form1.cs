using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Apriori_Check
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> transactions = new Dictionary<string, List<string>>();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupListView();
        }
        private void SetupDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void SetupListView()
        {
            listResult.View = View.Details;
            listResult.Columns.Clear();
            listResult.Columns.Add("Itemset", 200, HorizontalAlignment.Left);
            listResult.Columns.Add("Support", 100, HorizontalAlignment.Right);
        }
        private void LoadTransactions(string filePath)
        {
            if (Path.GetExtension(filePath).ToLower() != ".svm")
            {
                MessageBox.Show("File không hợp lệ! Chỉ chấp nhận file .svm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            transactions.Clear();
            dataGridView1.Rows.Clear();

            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(new[] { ' ' }, 2);
                if (parts.Length == 2)
                {
                    string tid = parts[0];
                    List<string> items = parts[1].Split(',').Select(x => x.Trim()).ToList();
                    transactions[tid] = items;

                    dataGridView1.Rows.Add(tid, string.Join(", ", items));
                }
            }
        }

        private void choosefile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SVM Files (*.svm)|*.svm|All Files (*.*)|*.*";
                openFileDialog.Title = "Chọn file dữ liệu (.svm)";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(openFileDialog.FileName).ToLower() != ".svm")
                    {
                        MessageBox.Show("Chỉ hỗ trợ file .svm! Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    displayfile.Text = openFileDialog.FileName;
                    LoadTransactions(openFileDialog.FileName);
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMinsup.Text, out double minSupport) || minSupport <= 0 || minSupport > 1)
            {
                MessageBox.Show("Vui lòng nhập ngưỡng hỗ trợ hợp lệ (số thực từ 0 đến 1).");
                return;
            }

            var frequentItemsets = AprioriAlgorithm.Run(transactions.Values.ToList(), minSupport);
            listResult.Items.Clear();

            lbtapphobien.Text = $"Số tập phổ biến tìm được: {frequentItemsets.Count}";
            if (frequentItemsets.Count == 0)
            {
                MessageBox.Show("Không có tập phổ biến nào đạt ngưỡng hỗ trợ!");
                return;
            }

            foreach (var itemset in frequentItemsets)
            {
                var row = new ListViewItem(string.Join(", ", itemset.Key));
                row.SubItems.Add(itemset.Value.ToString("F4"));  
                listResult.Items.Add(row);
            }
        }


    }

    public static class AprioriAlgorithm
    {
        public static Dictionary<HashSet<string>, double> Run(List<List<string>> transactions, double minSupport)
        {
            Dictionary<HashSet<string>, double> frequentItemsets = new Dictionary<HashSet<string>, double>(HashSet<string>.CreateSetComparer());
            int totalTransactions = transactions.Count;

            var itemCounts = transactions.SelectMany(t => t)
                                         .GroupBy(i => i)
                                         .ToDictionary(g => new HashSet<string> { g.Key }, g => (double)g.Count() / totalTransactions);

            var currentItemsets = itemCounts.Where(i => i.Value >= minSupport)
                                            .ToDictionary(i => i.Key, i => i.Value);

            frequentItemsets = new Dictionary<HashSet<string>, double>(currentItemsets);

            int k = 2;
            while (currentItemsets.Count > 0)
            {
                var candidateItemsets = GenerateCandidates(currentItemsets.Keys.ToList(), k);
                var candidateCounts = new Dictionary<HashSet<string>, double>(HashSet<string>.CreateSetComparer());

                foreach (var transaction in transactions)
                {
                    foreach (var candidate in candidateItemsets)
                    {
                        if (candidate.IsSubsetOf(transaction))
                        {
                            if (!candidateCounts.ContainsKey(candidate))
                                candidateCounts[candidate] = 0;
                            candidateCounts[candidate] += 1.0 / totalTransactions;
                        }
                    }
                }
                currentItemsets = candidateCounts.Where(c => c.Value >= minSupport)
                                                 .ToDictionary(c => c.Key, c => c.Value);

                foreach (var item in currentItemsets)
                    frequentItemsets[item.Key] = item.Value;

                k++;
            }
            return frequentItemsets;
        }
        private static List<HashSet<string>> GenerateCandidates(List<HashSet<string>> prevItemsets, int k)
        {
            var candidates = new List<HashSet<string>>();
            for (int i = 0; i < prevItemsets.Count; i++)
            {
                for (int j = i + 1; j < prevItemsets.Count; j++)
                {
                    var unionSet = new HashSet<string>(prevItemsets[i]);
                    unionSet.UnionWith(prevItemsets[j]);
                    if (unionSet.Count == k && !candidates.Contains(unionSet))
                        candidates.Add(unionSet);
                }
            }
            return candidates;
        }
    }
}
