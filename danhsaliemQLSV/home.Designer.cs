namespace danhsaliemQLSV
{
    partial class home
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
            label1 = new Label();
            dataGridSinhVien = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            nganh = new DataGridViewTextBoxColumn();
            lop = new DataGridViewTextBoxColumn();
            Điểm = new DataGridViewTextBoxColumn();
            label = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaSV = new TextBox();
            txtLop = new TextBox();
            txtNganh = new TextBox();
            txtTenSV = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            label2 = new Label();
            txtdiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 45);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý SV";
            label1.Click += label1_Click;
            // 
            // dataGridSinhVien
            // 
            dataGridSinhVien.BackgroundColor = Color.LightGray;
            dataGridSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSinhVien.Columns.AddRange(new DataGridViewColumn[] { id, name, nganh, lop, Điểm });
            dataGridSinhVien.GridColor = SystemColors.ControlText;
            dataGridSinhVien.Location = new Point(162, 57);
            dataGridSinhVien.Name = "dataGridSinhVien";
            dataGridSinhVien.RowHeadersWidth = 51;
            dataGridSinhVien.Size = new Size(677, 199);
            dataGridSinhVien.TabIndex = 1;
            dataGridSinhVien.CellContentClick += dataGridView1_CellContentClick;
            dataGridSinhVien.SelectionChanged += dataGridSinhVien_SelectionChanged;
            // 
            // id
            // 
            id.DataPropertyName = "MaSV";
            id.HeaderText = "Mã sv";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // name
            // 
            name.DataPropertyName = "TenSV";
            name.HeaderText = "Tên sv";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // nganh
            // 
            nganh.DataPropertyName = "Nganh";
            nganh.HeaderText = "Ngành";
            nganh.MinimumWidth = 6;
            nganh.Name = "nganh";
            nganh.Width = 125;
            // 
            // lop
            // 
            lop.DataPropertyName = "Lop";
            lop.HeaderText = "Lớp";
            lop.MinimumWidth = 6;
            lop.Name = "lop";
            lop.Width = 125;
            // 
            // Điểm
            // 
            Điểm.DataPropertyName = "Điểm";
            Điểm.HeaderText = "Điểm";
            Điểm.MinimumWidth = 6;
            Điểm.Name = "Điểm";
            Điểm.Width = 125;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(31, 299);
            label.Name = "label";
            label.Size = new Size(49, 20);
            label.TabIndex = 2;
            label.Text = "Mã Sv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 383);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "ngành";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 299);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 4;
            label4.Text = "lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 347);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(378, 380);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 6;
            label6.Text = "tên sv";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(106, 292);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(191, 27);
            txtMaSV.TabIndex = 7;
            txtMaSV.TextChanged += txtMaSV_TextChanged;
            // 
            // txtLop
            // 
            txtLop.Location = new Point(431, 292);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(191, 27);
            txtLop.TabIndex = 8;
            // 
            // txtNganh
            // 
            txtNganh.Location = new Point(106, 380);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(191, 27);
            txtNganh.TabIndex = 9;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(431, 373);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(191, 27);
            txtTenSV.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(437, 438);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(551, 438);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(667, 438);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(799, 438);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(677, 335);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 18;
            label2.Text = "Điểm";
            // 
            // txtdiem
            // 
            txtdiem.Location = new Point(758, 328);
            txtdiem.Name = "txtdiem";
            txtdiem.Size = new Size(191, 27);
            txtdiem.TabIndex = 19;
            txtdiem.TextChanged += txtdiem_TextChanged;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(991, 488);
            Controls.Add(txtdiem);
            Controls.Add(label2);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtTenSV);
            Controls.Add(txtNganh);
            Controls.Add(txtLop);
            Controls.Add(txtMaSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(dataGridSinhVien);
            Controls.Add(label1);
            Name = "home";
            Text = "home";
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridSinhVien;
        private Label label;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaSV;
        private TextBox txtLop;
        private TextBox txtNganh;
        private TextBox txtTenSV;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Label label2;
        private TextBox txtdiem;
        private DataGridViewTextBoxColumn Gender;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn nganh;
        private DataGridViewTextBoxColumn lop;
        private DataGridViewTextBoxColumn Điểm;
    }
}