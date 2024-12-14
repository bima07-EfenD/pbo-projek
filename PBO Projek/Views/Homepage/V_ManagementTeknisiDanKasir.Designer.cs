namespace PBO_Projek.Views.Homepage
{
    partial class V_ManagementTeknisiDanKasir
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ManagementTeknisiDanKasir));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvManagement = new DataGridView();
            Coloumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            txtsKas = new TextBox();
            label2 = new Label();
            dgvKasir = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Hapus = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvManagement).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKasir).BeginInit();
            SuspendLayout();
            // 
            // dgvManagement
            // 
            dgvManagement.AllowUserToAddRows = false;
            dgvManagement.AllowUserToDeleteRows = false;
            dgvManagement.AllowUserToResizeColumns = false;
            dgvManagement.AllowUserToResizeRows = false;
            dgvManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManagement.BackgroundColor = Color.White;
            dgvManagement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LimeGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvManagement.ColumnHeadersHeight = 35;
            dgvManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvManagement.Columns.AddRange(new DataGridViewColumn[] { Coloumn1, Column1, Column2, Delete });
            dgvManagement.Dock = DockStyle.Top;
            dgvManagement.EnableHeadersVisualStyles = false;
            dgvManagement.Location = new Point(0, 0);
            dgvManagement.Name = "dgvManagement";
            dgvManagement.RowHeadersVisible = false;
            dgvManagement.RowHeadersWidth = 51;
            dgvManagement.Size = new Size(479, 690);
            dgvManagement.TabIndex = 0;
            dgvManagement.CellContentClick += dgvManagement_CellContentClick;
            // 
            // Coloumn1
            // 
            Coloumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Coloumn1.HeaderText = "No";
            Coloumn1.MinimumWidth = 6;
            Coloumn1.Name = "Coloumn1";
            Coloumn1.Width = 56;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "ID Teknisi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 99;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nama Teknisi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvManagement);
            panel1.Location = new Point(89, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 491);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LimeGreen;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 441);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 50);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(343, 12);
            button1.Name = "button1";
            button1.Size = new Size(122, 30);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(98, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(168, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(971, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 28);
            btnAdd.TabIndex = 2;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dgvKasir);
            panel3.Location = new Point(622, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(479, 491);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(txtsKas);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(479, 50);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(343, 10);
            button2.Name = "button2";
            button2.Size = new Size(122, 30);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // txtsKas
            // 
            txtsKas.Location = new Point(98, 13);
            txtsKas.Name = "txtsKas";
            txtsKas.Size = new Size(168, 27);
            txtsKas.TabIndex = 1;
            txtsKas.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // dgvKasir
            // 
            dgvKasir.AllowUserToAddRows = false;
            dgvKasir.AllowUserToDeleteRows = false;
            dgvKasir.AllowUserToResizeColumns = false;
            dgvKasir.AllowUserToResizeRows = false;
            dgvKasir.BackgroundColor = Color.White;
            dgvKasir.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LimeGreen;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvKasir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvKasir.ColumnHeadersHeight = 35;
            dgvKasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKasir.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column4, Password, Edit, Hapus });
            dgvKasir.Dock = DockStyle.Top;
            dgvKasir.EnableHeadersVisualStyles = false;
            dgvKasir.Location = new Point(0, 0);
            dgvKasir.Name = "dgvKasir";
            dgvKasir.RowHeadersVisible = false;
            dgvKasir.RowHeadersWidth = 51;
            dgvKasir.Size = new Size(479, 576);
            dgvKasir.TabIndex = 0;
            dgvKasir.CellContentClick += dgvKasir_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 49;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Nama Kasir";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Username";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 102;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 97;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Hapus.HeaderText = "";
            Hapus.Image = (Image)resources.GetObject("Hapus.Image");
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Width = 6;
            // 
            // V_ManagementTeknisiDanKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "V_ManagementTeknisiDanKasir";
            Size = new Size(1185, 970);
            Load += V_ManagementTeknisi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManagement).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKasir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvManagement;
        private Panel panel1;
        private Panel panel2;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label label1;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtsKas;
        private Label label2;
        public DataGridView dgvKasir;
        private Button button2;
        private DataGridViewTextBoxColumn Coloumn1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Hapus;
    }
}
