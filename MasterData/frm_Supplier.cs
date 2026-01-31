using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.DBA;
namespace POS.MasterData
{
    public partial class frm_Supplier : Form
    {
        public frm_Supplier()
        {
            InitializeComponent();
        }

        clsMainDB obj_clsMainDB = new clsMainDB();
        clsSupplier obj_clsSupplier = new clsSupplier();

        DataTable DT = new DataTable();
        public bool _isEdit = false;
        public int _SupplierID = 0;
        string SPString = "";

        private void frm_Supplier_Load(object sender, EventArgs e)
        {
            string Day = string.Format("{0:D2}", DateTime.Now.Day);
            string Month = string.Format("{0:D2}", DateTime.Now.Month);
            string Year = string.Format("{0:D2}", DateTime.Now.Year);
            lblUpdateDate.Text = Month + "/" + Day + "/" + Year;
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Name");
                txtName.Focus();
            }
            else if (txtPhone.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Phone");
                txtPhone.Focus();
            }
            else if (txtAddress.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type Address");
                txtAddress.Focus();
            }
            else
            {
                SPString = string.Format("SP_Select_Supplier N'{0}',N'{1}',N'{2}'", txtName.Text.Trim().ToString(), txtAddress.Text.Trim().ToString(), "1");
                DT = obj_clsMainDB.SelectData(SPString);

                if ((DT.Rows.Count > 0) && (DT.Rows[0]["SupplierID"].ToString() != _SupplierID.ToString()))
                {
                    MessageBox.Show("This Supplier already exists");
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    obj_clsSupplier.SID = Convert.ToInt32(_SupplierID);
                    obj_clsSupplier.SNAME = txtName.Text;
                    obj_clsSupplier.ADDRESS = txtAddress.Text;
                    obj_clsSupplier.PHONE = txtPhone.Text;
                    obj_clsSupplier.UPDATE = lblUpdateDate.Text;

                    if (_isEdit)
                    {
                        obj_clsSupplier.ACTION = 1;
                        obj_clsSupplier.SaveData();
                        MessageBox.Show("Successfully Edited", "Successfully", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        obj_clsSupplier.ACTION = 0;
                        obj_clsSupplier.SaveData();
                        MessageBox.Show("Successfully Saved", "Successfully", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
        }
    }
}
