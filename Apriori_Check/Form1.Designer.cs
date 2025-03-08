namespace Apriori_Check
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choosefile = new System.Windows.Forms.Button();
            this.displayfile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinsup = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListView();
            this.lbtapphobien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // choosefile
            // 
            this.choosefile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.choosefile.Location = new System.Drawing.Point(468, 167);
            this.choosefile.Name = "choosefile";
            this.choosefile.Size = new System.Drawing.Size(87, 31);
            this.choosefile.TabIndex = 0;
            this.choosefile.Text = "Chọn File";
            this.choosefile.UseVisualStyleBackColor = true;
            this.choosefile.Click += new System.EventHandler(this.choosefile_Click);
            // 
            // displayfile
            // 
            this.displayfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayfile.Location = new System.Drawing.Point(162, 171);
            this.displayfile.Name = "displayfile";
            this.displayfile.Size = new System.Drawing.Size(288, 22);
            this.displayfile.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tid,
            this.itemset});
            this.dataGridView1.Location = new System.Drawing.Point(162, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 153);
            this.dataGridView1.TabIndex = 2;
            // 
            // tid
            // 
            this.tid.DataPropertyName = "tid";
            this.tid.HeaderText = "TID";
            this.tid.MinimumWidth = 6;
            this.tid.Name = "tid";
            this.tid.Width = 125;
            // 
            // itemset
            // 
            this.itemset.DataPropertyName = "itemset";
            this.itemset.HeaderText = "Itemset";
            this.itemset.MinimumWidth = 6;
            this.itemset.Name = "itemset";
            this.itemset.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "File .SVM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min Support (Ngưỡng hỗ trợ tối thiểu)";
            // 
            // txtMinsup
            // 
            this.txtMinsup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMinsup.Location = new System.Drawing.Point(162, 239);
            this.txtMinsup.Name = "txtMinsup";
            this.txtMinsup.Size = new System.Drawing.Size(288, 22);
            this.txtMinsup.TabIndex = 5;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAction.Location = new System.Drawing.Point(468, 235);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(87, 31);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Thực thi thuật toán";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // listResult
            // 
            this.listResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listResult.HideSelection = false;
            this.listResult.Location = new System.Drawing.Point(162, 490);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(714, 150);
            this.listResult.TabIndex = 6;
            this.listResult.UseCompatibleStateImageBehavior = false;
            // 
            // lbtapphobien
            // 
            this.lbtapphobien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtapphobien.AutoSize = true;
            this.lbtapphobien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtapphobien.Location = new System.Drawing.Point(157, 673);
            this.lbtapphobien.Name = "lbtapphobien";
            this.lbtapphobien.Size = new System.Drawing.Size(258, 25);
            this.lbtapphobien.TabIndex = 7;
            this.lbtapphobien.Text = "Số tập phổ biến tìm được là: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 731);
            this.Controls.Add(this.lbtapphobien);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.txtMinsup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.displayfile);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.choosefile);
            this.Name = "Form1";
            this.Text = "Tìm tập phổ biến bằng thuật toán Apriori";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button choosefile;
        private System.Windows.Forms.TextBox displayfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinsup;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn tid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemset;
        private System.Windows.Forms.Label lbtapphobien;
    }
}

