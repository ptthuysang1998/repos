namespace PhamThiThuySang16T
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lvshowTT = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvKhoa = new System.Windows.Forms.ListView();
            this.Masv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tensv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 353);
            this.panel1.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lvshowTT);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(199, 353);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "TTSinhVien";
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lvshowTT
            // 
            this.lvshowTT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvshowTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvshowTT.FullRowSelect = true;
            this.lvshowTT.GridLines = true;
            this.lvshowTT.Location = new System.Drawing.Point(3, 16);
            this.lvshowTT.Name = "lvshowTT";
            this.lvshowTT.Size = new System.Drawing.Size(193, 334);
            this.lvshowTT.TabIndex = 1;
            this.lvshowTT.UseCompatibleStateImageBehavior = false;
            this.lvshowTT.View = System.Windows.Forms.View.Details;
            this.lvshowTT.SelectedIndexChanged += new System.EventHandler(this.lvshowTT_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TenKhoa";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MaKhoa";
            this.columnHeader2.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ten SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia Chi";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(339, 37);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(180, 20);
            this.txtTen.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(339, 97);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(238, 337);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(398, 337);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(544, 337);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(544, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lvKhoa
            // 
            this.lvKhoa.AllowColumnReorder = true;
            this.lvKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Masv,
            this.tensv});
            this.lvKhoa.FullRowSelect = true;
            this.lvKhoa.GridLines = true;
            this.lvKhoa.Location = new System.Drawing.Point(238, 130);
            this.lvKhoa.Name = "lvKhoa";
            this.lvKhoa.Size = new System.Drawing.Size(381, 187);
            this.lvKhoa.TabIndex = 9;
            this.lvKhoa.UseCompatibleStateImageBehavior = false;
            this.lvKhoa.View = System.Windows.Forms.View.Details;
            this.lvKhoa.SelectedIndexChanged += new System.EventHandler(this.lvKhoa_SelectedIndexChanged);
            // 
            // Masv
            // 
            this.Masv.Text = "masv";
            // 
            // tensv
            // 
            this.tensv.Text = "tenSv";
            this.tensv.Width = 169;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 372);
            this.Controls.Add(this.lvKhoa);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListView lvshowTT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvKhoa;
        private System.Windows.Forms.ColumnHeader Masv;
        private System.Windows.Forms.ColumnHeader tensv;
    }
}

