using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        USERS user;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ftmLogin_Load(object sender, EventArgs e)
        {
            user = new USERS();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtUserPass.Text;
            int login = user.Login(username, pass);

            if (login == 1)
            {

                All_Func.UserStatic = user.getItem(username);
                MainForm main =(MainForm) Application.OpenForms["MainForm"];
                main.lbFullname.Caption = All_Func.UserStatic.Fullname;
                this.Close();

            }
            else
            {
                MessageBox.Show("Ten Đang Nhap Hoac Mat Khau Khong Dung", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}