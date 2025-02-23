using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Anh_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_21_Anh_Click(object sender, EventArgs e)
        {
            int a, b, res;
            a = int.Parse(txtSoThunhat_21_Anh.Text);
            b = int.Parse(txtSoThuhai_21_Anh.Text);
            Caculation c = new Caculation(a,b);
            res = c.Execute("+");
            txtKQ_21_Anh.Text = res.ToString();

        }

        private void btnTru_21_Anh_Click(object sender, EventArgs e)
        {
            int a, b, res;
            a = int.Parse(txtSoThunhat_21_Anh.Text);
            b = int.Parse(txtSoThuhai_21_Anh.Text);
            Caculation c = new Caculation(a, b);
            res = c.Execute("-");
            txtKQ_21_Anh.Text = res.ToString();
        }

        private void btnNhan_21_Anh_Click(object sender, EventArgs e)
        {
            int a, b, res;
            a = int.Parse(txtSoThunhat_21_Anh.Text);
            b = int.Parse(txtSoThuhai_21_Anh.Text);
            Caculation c = new Caculation(a, b);
            res = c.Execute("*");
            txtKQ_21_Anh.Text = res.ToString();

        }

        private void btnChia_21_Anh_Click(object sender, EventArgs e)
        {
            int a, b, res;
            a = int.Parse(txtSoThunhat_21_Anh.Text);
            b = int.Parse(txtSoThuhai_21_Anh.Text);
            Caculation c = new Caculation(a, b);
            res = c.Execute("/");
            txtKQ_21_Anh.Text = res.ToString();
        }
    }
}
