using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrintCheck.Trancaction
{
    internal class Banks

    {
        public SqlCommand cmd;
        public DataTable dtAddBank = new DataTable();
        public void InsertBank(int BankCod, String BankName, string CheckName, Image PictureCheck)
        {
            cmd = new SqlCommand();
            {
                cmd.Connection = GenralConnection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertBankSP";

                cmd.Parameters.Add("@BankCod", SqlDbType.Int).Value = BankCod;
                cmd.Parameters.Add("@BankName", SqlDbType.NVarChar, 40).Value = BankName;
                cmd.Parameters.Add("@CheckName", SqlDbType.NVarChar, 20).Value = CheckName;
                //cmd.Parameters.Add("@PictureCheck", SqlDbType.Image).Value = PictureCheck;
                GenralConnection.con.Open();
                cmd.ExecuteNonQuery();
                GenralConnection.con.Close();
            }


        }
    }
}
