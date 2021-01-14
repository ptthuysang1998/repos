namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.cbMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLopHP = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGV = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewLop = new System.Windows.Forms.DataGridView();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMH
            // 
            this.cbMH.FormattingEnabled = true;
            this.cbMH.Location = new System.Drawing.Point(115, 30);
            this.cbMH.Name = "cbMH";
            this.cbMH.Size = new System.Drawing.Size(140, 21);
            this.cbMH.TabIndex = 9;
            this.cbMH.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã Lớp HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chọn môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lớp HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Định mức sv (min/max)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số lượng sv dky";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giáo viên phụ trách";
            // 
            // txtMaLopHP
            // 
            this.txtMaLopHP.Location = new System.Drawing.Point(428, 31);
            this.txtMaLopHP.Name = "txtMaLopHP";
            this.txtMaLopHP.Size = new System.Drawing.Size(100, 20);
            this.txtMaLopHP.TabIndex = 17;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(428, 53);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(45, 20);
            this.txtMin.TabIndex = 18;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(479, 53);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(49, 20);
            this.txtMax.TabIndex = 20;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(652, 53);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 16;
            // 
            // txtGV
            // 
            this.txtGV.Location = new System.Drawing.Point(652, 30);
            this.txtGV.Name = "txtGV";
            this.txtGV.Size = new System.Drawing.Size(100, 20);
            this.txtGV.TabIndex = 19;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(88, 58);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(50, 22);
            this.btnThemLop.TabIndex = 21;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(144, 58);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(52, 22);
            this.btnSuaLop.TabIndex = 22;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(202, 58);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(53, 22);
            this.btnXoaLop.TabIndex = 23;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(711, 92);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(630, 92);
            this.btnSua.Name = "btnSua";
            this.btnSua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(549, 92);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLop
            // 
            this.dataGridViewLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewLop.Location = new System.Drawing.Point(15, 92);
            this.dataGridViewLop.Name = "dataGridViewLop";
            this.dataGridViewLop.Size = new System.Drawing.Size(240, 278);
            this.dataGridViewLop.TabIndex = 27;
            this.dataGridViewLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLop_CellClick);
            this.dataGridViewLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.HoTen,
            this.Column5,
            this.Column4});
            this.dataGridViewSV.Location = new System.Drawing.Point(261, 141);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.Size = new System.Drawing.Size(491, 150);
            this.dataGridViewSV.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLopHP";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLopHP";
            this.Column2.HeaderText = "TenLopHP";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MaSV";
            this.Column3.HeaderText = "MaSV";
            this.Column3.Name = "Column3";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.Name = "HoTen";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "NgaySinh";
            this.Column5.HeaderText = "NgaySinh";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "QueQuan";
            this.Column4.HeaderText = "QueQuan";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSV);
            this.Controls.Add(this.dataGridViewLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.btnSuaLop);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.txtGV);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMaLopHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMH);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLopHP;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGV;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewLop;
        private System.Windows.Forms.BindingSource bdsLop;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.BindingSource bdsSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

