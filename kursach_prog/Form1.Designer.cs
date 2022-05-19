namespace kursach_prog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.top = new System.Windows.Forms.RadioButton();
            this.sale = new System.Windows.Forms.RadioButton();
            this.from = new System.Windows.Forms.TextBox();
            this.before = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.fullList = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.AutoSize = true;
            this.top.Location = new System.Drawing.Point(12, 48);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(60, 19);
            this.top.TabIndex = 1;
            this.top.Text = "Топ 10";
            this.top.UseVisualStyleBackColor = true;
            this.top.CheckedChanged += new System.EventHandler(this.top_CheckedChanged);
            // 
            // sale
            // 
            this.sale.AutoSize = true;
            this.sale.Location = new System.Drawing.Point(12, 86);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(137, 19);
            this.sale.TabIndex = 2;
            this.sale.Text = "Сортировка по цене";
            this.sale.UseVisualStyleBackColor = true;
            this.sale.CheckedChanged += new System.EventHandler(this.sale_CheckedChanged);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(12, 137);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(60, 23);
            this.from.TabIndex = 3;
            this.from.TextChanged += new System.EventHandler(this.from_TextChanged);
            // 
            // before
            // 
            this.before.Location = new System.Drawing.Point(89, 137);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(60, 23);
            this.before.TabIndex = 4;
            this.before.TextChanged += new System.EventHandler(this.before_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "До";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(12, 177);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 15);
            this.errorText.TabIndex = 8;
            // 
            // fullList
            // 
            this.fullList.AutoSize = true;
            this.fullList.Location = new System.Drawing.Point(12, 10);
            this.fullList.Name = "fullList";
            this.fullList.Size = new System.Drawing.Size(95, 19);
            this.fullList.TabIndex = 9;
            this.fullList.Text = "Весь каталог";
            this.fullList.UseVisualStyleBackColor = true;
            this.fullList.CheckedChanged += new System.EventHandler(this.fullList_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(478, 443);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fullList);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.before);
            this.Controls.Add(this.from);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.top);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton top;
        private RadioButton sale;
        private TextBox from;
        private TextBox before;
        private Label label1;
        private Label label2;
        private Label errorText;
        private RadioButton fullList;
        private DataGridView dataGridView1;
    }
}