using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.MasterData;
using POS.DBA;
namespace POS
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }



        private void mnuItem_Click(object sender, EventArgs e)
        {
            frm_ItemList frm = new frm_ItemList();
            frm.Show();
        }

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            frm_SupplierList frm = new frm_SupplierList();
            frm.Show();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            frm_UserSettingList frm = new frm_UserSettingList();
            frm.Show();
        }
        public void ShowMenu(String UserLevel)
        {
            string[] Arr_UserLevel = UserLevel.Split(',');
            for (int i = 1; i < menuStrip1.Items.Count; i++)
            {
                ToolStripMenuItem MainMenu = (ToolStripMenuItem)menuStrip1.Items[i];
                foreach (ToolStripItem SubMenu in MainMenu.DropDownItems)
                {
                    SubMenu.Enabled = false;
                    foreach (string Menu in Arr_UserLevel)
                    {
                        if (SubMenu.Text.ToString() == Menu.ToString())
                        {
                            SubMenu.Enabled = true;
                            break;
                        }
                    }
                }
            }
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            if (mnuLogin.Text == "Logout")
            {
                if (MessageBox.Show("Are You Sure You Want To Logout", "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
                {
                    mnuLogin.Text = "LogIn";
                    ShowMenu("");
                }
                return;
            }
            clsMainDB obj_clsMainDB = new clsMainDB();
            frm_Login obj_frmLogIn = new frm_Login();
            DataTable DT = new DataTable();
            String UserName = "";
            String Password = "";

            Start:
            obj_frmLogIn.txtUserName.Text = UserName;
            obj_frmLogIn.txtPassword.Text = Password;
            if (obj_frmLogIn.ShowDialog() == DialogResult.OK)
            {
                if (obj_frmLogIn.txtUserName.Text.Trim().ToString() == string.Empty)
                {
                    MessageBox.Show("Please Type User Name");
                    obj_frmLogIn.txtUserName.Focus();
                    goto Start;
                }
                UserName = obj_frmLogIn.txtUserName.Text;
                if (obj_frmLogIn.txtPassword.Text.Trim().ToString() == string.Empty)
                {
                    MessageBox.Show("Please Type Password");
                    obj_frmLogIn.txtPassword.Focus();
                    goto Start;
                }
                Password = obj_frmLogIn.txtPassword.Text;
                string SPString = string.Format("SP_Select_UserSetting N'{0}',N'{1}',N'{2}'",
                obj_frmLogIn.txtUserName.Text.Trim().ToString(), obj_frmLogIn.txtPassword.Text.Trim().ToString(), "1");

                DT = obj_clsMainDB.SelectData(SPString);
                if (DT.Rows.Count > 0)
                {
                    Program.UserID = Convert.ToInt32(DT.Rows[0]["UserID"].ToString());
                    string UserLevel = DT.Rows[0]["UserLevel"].ToString();
                    mnuLogin.Text = "Logout";
                    ShowMenu(UserLevel);
                }
                else
                {
                    MessageBox.Show("Invalid UserName And Password");
                    goto Start;
                }
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            ShowMenu("");
        }

        private void mnuProfitLoss_Click(object sender, EventArgs e)
        {
            frm_PurchaseList frm = new frm_PurchaseList();
            frm.ShowDialog();

        }

        private void mnuSale_Click(object sender, EventArgs e)
        {
            frm_PurchaseList frm = new frm_PurchaseList();
            frm.ShowDialog();
        }
    }
}
