﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class VayTien : Form
    {
        public VayTien()
        {
            InitializeComponent();
            loadmode();
            loaddate();
        }

        private void loaddate()
        {
            ngaylb.Text = DateTime.UtcNow.ToString("dd/mm/yyyy");
        }

        private void loadmode()
        {
            KHcombo.Items.Add("3");
            KHcombo.Items.Add("6");
            KHcombo.Items.Add("7");
            KHcombo.Items.Add("9");
        }

        private void KTbtn_Click(object sender, EventArgs e)
        {
            DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
            string d = STKtxt.Text;
            var item = (from u in NH.TaiKhoans
                        where u.SoTK == d
                        select u).FirstOrDefault();
            TKHtxt.Text = item.TenKH;
            SDTtxt.Text = item.SDT;
            cccdtxt.Text = item.Cccd;
            TienNotxt.Text = Convert.ToString(item.SoTienVay);
        }

        private void Luubtn_Click(object sender, EventArgs e)
        {
            DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
            //TaiKhoan TK = new TaiKhoan();
            //
            //LaiXuat LX = new LaiXuat();
            //TK.SoTK = Convert.ToString(STKtxt.Text);
            //TK.TenKH = TKHtxt.Text;
            //TK.SDT = SDTtxt.Text;
            //TK.SoTienVay = Convert.ToInt32(STVtxt.Text);
            //LX.KyHan = Convert.ToInt32(KHcombo.Text);
            //NH.TaiKhoans.InsertOnSubmit(TK);
            //NH.SubmitChanges();
            string d = STKtxt.Text;
            var item = (from u in NH.TaiKhoans
                        where u.SoTK == d
                        select u).FirstOrDefault();
            if (STVtxt.Text == null)
            {
                MessageBox.Show("Vui lòng nhập số tiền cần vay!");
            }
            else if (KHcombo.Text == null)
            {
                MessageBox.Show("Vui lòng nhập Kỳ hạn.");
            }
            else if (item.SoDu < Convert.ToDecimal(STVtxt.Text))
            {
                MessageBox.Show("Giao dịch thất bại! Số dư hiện có của bạn thấp hơn số tiền bạn muốn vay.");
            }
            else
            {
                item.SoTienVay = item.SoTienVay + Convert.ToDecimal(STVtxt.Text);
                NH.SubmitChanges();
                MessageBox.Show("Vay tiền thành công!");
            }
        }

        private void VayTien_Load(object sender, EventArgs e)
        {

        }
    }
}
