namespace BaiKiemTra_19T1021215
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clickThemNhom = new System.Windows.Forms.ToolStripLabel();
            this.clickXoaNhom = new System.Windows.Forms.ToolStripLabel();
            this.clickThemLienLac = new System.Windows.Forms.ToolStripLabel();
            this.clickXoaLienLac = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.txtTenGoi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridNguoi = new System.Windows.Forms.DataGridView();
            this.nguoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baiKiemTraDataSet1 = new BaiKiemTra_19T1021215.BaiKiemTraDataSet1();
            this.dataGridNhom = new System.Windows.Forms.DataGridView();
            this.nhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baiKiemTraDataSet = new BaiKiemTra_19T1021215.BaiKiemTraDataSet();
            this.nhomTableAdapter = new BaiKiemTra_19T1021215.BaiKiemTraDataSetTableAdapters.NhomTableAdapter();
            this.nguoiTableAdapter = new BaiKiemTra_19T1021215.BaiKiemTraDataSet1TableAdapters.NguoiTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiKiemTraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiKiemTraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.clickThemNhom,
            this.toolStripButton2,
            this.clickXoaNhom,
            this.toolStripButton3,
            this.clickThemLienLac,
            this.toolStripButton4,
            this.clickXoaLienLac});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1071, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clickThemNhom
            // 
            this.clickThemNhom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickThemNhom.Name = "clickThemNhom";
            this.clickThemNhom.Size = new System.Drawing.Size(103, 24);
            this.clickThemNhom.Text = "Thêm nhóm";
            this.clickThemNhom.Click += new System.EventHandler(this.clickThemNhom_Click);
            // 
            // clickXoaNhom
            // 
            this.clickXoaNhom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickXoaNhom.Name = "clickXoaNhom";
            this.clickXoaNhom.Size = new System.Drawing.Size(89, 24);
            this.clickXoaNhom.Text = "Xoá nhóm";
            this.clickXoaNhom.Click += new System.EventHandler(this.clickXoaNhom_Click);
            // 
            // clickThemLienLac
            // 
            this.clickThemLienLac.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickThemLienLac.Name = "clickThemLienLac";
            this.clickThemLienLac.Size = new System.Drawing.Size(111, 24);
            this.clickThemLienLac.Text = "Thêm liên lạc";
            this.clickThemLienLac.Click += new System.EventHandler(this.clickThemLienLac_Click);
            // 
            // clickXoaLienLac
            // 
            this.clickXoaLienLac.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickXoaLienLac.Name = "clickXoaLienLac";
            this.clickXoaLienLac.Size = new System.Drawing.Size(97, 24);
            this.clickXoaLienLac.Text = "Xoá liên lạc";
            this.clickXoaLienLac.Click += new System.EventHandler(this.clickXoaLienLac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập từ cần tìm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(800, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenGoi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridNguoi);
            this.panel1.Controls.Add(this.dataGridNhom);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 545);
            this.panel1.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(537, 474);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(0, 20);
            this.txtSDT.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(537, 424);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(0, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(536, 371);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(0, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.AutoSize = true;
            this.txtTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGoi.Location = new System.Drawing.Point(535, 323);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(0, 20);
            this.txtTenGoi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "[Tên gọi]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridNguoi
            // 
            this.dataGridNguoi.AutoGenerateColumns = false;
            this.dataGridNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNguoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGoi,
            this.Email,
            this.SDT});
            this.dataGridNguoi.DataSource = this.nguoiBindingSource;
            this.dataGridNguoi.Location = new System.Drawing.Point(331, 0);
            this.dataGridNguoi.Name = "dataGridNguoi";
            this.dataGridNguoi.RowHeadersWidth = 51;
            this.dataGridNguoi.RowTemplate.Height = 24;
            this.dataGridNguoi.Size = new System.Drawing.Size(740, 265);
            this.dataGridNguoi.TabIndex = 1;
            this.dataGridNguoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridNguoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNguoi_CellContentClick);
            // 
            // nguoiBindingSource
            // 
            this.nguoiBindingSource.DataMember = "Nguoi";
            this.nguoiBindingSource.DataSource = this.baiKiemTraDataSet1;
            // 
            // baiKiemTraDataSet1
            // 
            this.baiKiemTraDataSet1.DataSetName = "BaiKiemTraDataSet1";
            this.baiKiemTraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridNhom
            // 
            this.dataGridNhom.AutoGenerateColumns = false;
            this.dataGridNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhom});
            this.dataGridNhom.DataSource = this.nhomBindingSource;
            this.dataGridNhom.Location = new System.Drawing.Point(0, 0);
            this.dataGridNhom.Name = "dataGridNhom";
            this.dataGridNhom.RowHeadersWidth = 51;
            this.dataGridNhom.RowTemplate.Height = 24;
            this.dataGridNhom.Size = new System.Drawing.Size(325, 539);
            this.dataGridNhom.TabIndex = 0;
            this.dataGridNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nhomBindingSource
            // 
            this.nhomBindingSource.DataMember = "Nhom";
            this.nhomBindingSource.DataSource = this.baiKiemTraDataSet;
            // 
            // baiKiemTraDataSet
            // 
            this.baiKiemTraDataSet.DataSetName = "BaiKiemTraDataSet";
            this.baiKiemTraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // nguoiTableAdapter
            // 
            this.nguoiTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "TenNhom";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Width = 280;
            // 
            // TenGoi
            // 
            this.TenGoi.DataPropertyName = "TenGoi";
            this.TenGoi.HeaderText = "TenGoi";
            this.TenGoi.MinimumWidth = 6;
            this.TenGoi.Name = "TenGoi";
            this.TenGoi.Width = 180;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 330;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiKiemTraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiKiemTraDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel clickThemNhom;
        private System.Windows.Forms.ToolStripLabel clickXoaNhom;
        private System.Windows.Forms.ToolStripLabel clickThemLienLac;
        private System.Windows.Forms.ToolStripLabel clickXoaLienLac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridNguoi;
        private System.Windows.Forms.DataGridView dataGridNhom;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label txtTenGoi;
        private BaiKiemTraDataSet baiKiemTraDataSet;
        private System.Windows.Forms.BindingSource nhomBindingSource;
        private BaiKiemTraDataSetTableAdapters.NhomTableAdapter nhomTableAdapter;
        private BaiKiemTraDataSet1 baiKiemTraDataSet1;
        private System.Windows.Forms.BindingSource nguoiBindingSource;
        private BaiKiemTraDataSet1TableAdapters.NguoiTableAdapter nguoiTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
    }
}

