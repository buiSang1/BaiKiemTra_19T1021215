using BaiKiemTra_19T1021215.Model;
using BaiKiemTra_19T1021215.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BaiKiemTra_19T1021215
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            NapDSNhom();
        }
        void NapDSNhom()
        {
            var list = nhomView.GetList();
            for (int i = 0; i < list.Count; i++)
            {
                cbxChonNhom.Items.Add(list[i].TenNhom);
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm1));
            thread.Start();
            this.Close();
        }
        private void ShowForm1()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var list = nhomView.GetList();
            var id = 0;
            var chimuc = cbxChonNhom.SelectedIndex;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == chimuc)
                {
                    id = list[i].ID;
                }
            }
            var nguoi = new Nguoi
            {
                TenGoi = txtTenGoi.Text,
                Email = txtEmail.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                IDNhom = id,

            };
            nguoiView.ThemNguoi(nguoi);
            Thread thread = new Thread(new ThreadStart(ShowForm1));
            thread.Start();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
