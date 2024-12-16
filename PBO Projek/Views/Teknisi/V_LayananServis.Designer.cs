namespace PBO_Projek.Views.Teknisi
{
    partial class V_LayananServis
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LayananServis));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridViewLayanan = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            dataGridViewSukuCadang = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridViewPesanan = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            label9 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox3 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLayanan).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSukuCadang).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesanan).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 2;
            label1.Text = "Nama Kendaraan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 88);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Plat Nomor :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewLayanan);
            panel3.Location = new Point(40, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 491);
            panel3.TabIndex = 4;
            // 
            // dataGridViewLayanan
            // 
            dataGridViewLayanan.AllowUserToAddRows = false;
            dataGridViewLayanan.AllowUserToDeleteRows = false;
            dataGridViewLayanan.AllowUserToResizeColumns = false;
            dataGridViewLayanan.AllowUserToResizeRows = false;
            dataGridViewLayanan.BackgroundColor = Color.White;
            dataGridViewLayanan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LimeGreen;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewLayanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewLayanan.ColumnHeadersHeight = 35;
            dataGridViewLayanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewLayanan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, Column4 });
            dataGridViewLayanan.Dock = DockStyle.Top;
            dataGridViewLayanan.EnableHeadersVisualStyles = false;
            dataGridViewLayanan.Location = new Point(0, 0);
            dataGridViewLayanan.Name = "dataGridViewLayanan";
            dataGridViewLayanan.RowHeadersVisible = false;
            dataGridViewLayanan.RowHeadersWidth = 51;
            dataGridViewLayanan.Size = new Size(351, 491);
            dataGridViewLayanan.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Nama Layanan";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Harga";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 77;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewSukuCadang);
            panel1.Location = new Point(408, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 491);
            panel1.TabIndex = 5;
            // 
            // dataGridViewSukuCadang
            // 
            dataGridViewSukuCadang.AllowUserToAddRows = false;
            dataGridViewSukuCadang.AllowUserToDeleteRows = false;
            dataGridViewSukuCadang.AllowUserToResizeColumns = false;
            dataGridViewSukuCadang.AllowUserToResizeRows = false;
            dataGridViewSukuCadang.BackgroundColor = Color.White;
            dataGridViewSukuCadang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.LimeGreen;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewSukuCadang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewSukuCadang.ColumnHeadersHeight = 35;
            dataGridViewSukuCadang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewSukuCadang.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, Column2 });
            dataGridViewSukuCadang.Dock = DockStyle.Top;
            dataGridViewSukuCadang.EnableHeadersVisualStyles = false;
            dataGridViewSukuCadang.Location = new Point(0, 0);
            dataGridViewSukuCadang.Name = "dataGridViewSukuCadang";
            dataGridViewSukuCadang.RowHeadersVisible = false;
            dataGridViewSukuCadang.RowHeadersWidth = 51;
            dataGridViewSukuCadang.Size = new Size(351, 491);
            dataGridViewSukuCadang.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Nama Suku Cadang";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column2
            // 
            Column2.HeaderText = "Harga";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewPesanan);
            panel2.Location = new Point(828, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 491);
            panel2.TabIndex = 6;
            // 
            // dataGridViewPesanan
            // 
            dataGridViewPesanan.AllowUserToAddRows = false;
            dataGridViewPesanan.AllowUserToDeleteRows = false;
            dataGridViewPesanan.AllowUserToResizeColumns = false;
            dataGridViewPesanan.AllowUserToResizeRows = false;
            dataGridViewPesanan.BackgroundColor = Color.White;
            dataGridViewPesanan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.LimeGreen;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewPesanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewPesanan.ColumnHeadersHeight = 35;
            dataGridViewPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPesanan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column1, dataGridViewTextBoxColumn2 });
            dataGridViewPesanan.Dock = DockStyle.Top;
            dataGridViewPesanan.EnableHeadersVisualStyles = false;
            dataGridViewPesanan.Location = new Point(0, 0);
            dataGridViewPesanan.Name = "dataGridViewPesanan";
            dataGridViewPesanan.RowHeadersVisible = false;
            dataGridViewPesanan.RowHeadersWidth = 51;
            dataGridViewPesanan.Size = new Size(330, 491);
            dataGridViewPesanan.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Pesanan";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Qty";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 59;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Harga";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 77;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 166, 0);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(828, 739);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 44);
            panel4.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(101, 11);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(9, 11);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 0;
            label7.Text = "Total Harga:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 739);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(351, 28);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(408, 739);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(351, 28);
            comboBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(408, 820);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(351, 27);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 709);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 10;
            label3.Text = "Pilih Layanan ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 709);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 11;
            label4.Text = "Suku Cadang Yang Dipakai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 797);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 12;
            label5.Text = "Jumlah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 140);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 13;
            label6.Text = "Teknisi :";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(170, 137);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(205, 28);
            comboBox3.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(109, 889);
            button1.Name = "button1";
            button1.Size = new Size(191, 35);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(469, 889);
            button2.Name = "button2";
            button2.Size = new Size(191, 35);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(920, 889);
            button3.Name = "button3";
            button3.Size = new Size(130, 35);
            button3.TabIndex = 17;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(828, 788);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 19;
            label8.Text = "Bayar";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(828, 811);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(330, 27);
            textBox4.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(105, 12);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 2;
            label10.Click += label10_Click;
            // 
            // V_LayananServis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(panel4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "V_LayananServis";
            Size = new Size(1185, 970);
            Load += V_LayananServis_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLayanan).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSukuCadang).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesanan).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private DataGridView dataGridViewLayanan;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private Panel panel1;
        private DataGridView dataGridViewSukuCadang;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel2;
        private DataGridView dataGridViewPesanan;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel4;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label9;
        private Label label10;
    }
}
