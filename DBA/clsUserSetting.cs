using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace POS.DBA
{
    class clsUserSetting
    {
        public int USERID { get; set; }
        public string UNAME { get; set; }
        public string PASS{ get; set; }
        public string USERLEVEL{ get; set; }
        public string UPDATE { get; set; }
        public int ACTION { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();

        public void SaveData()
        {
            try
            {
                obj_clsMainDB.DatabaseConn();
                SqlCommand sql = new SqlCommand("SP_Insert_UserSetting", obj_clsMainDB.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@UserID", USERID);
                sql.Parameters.AddWithValue("@UserName", UNAME);
                sql.Parameters.AddWithValue("@Password", PASS);
                sql.Parameters.AddWithValue("@UserLevel", USERLEVEL);
                sql.Parameters.AddWithValue("@updateDate", UPDATE);
                sql.Parameters.AddWithValue("@action", ACTION);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In SaveData.");
            }
            finally
            {
                obj_clsMainDB.con.Close();
            }
        }

    }
}
