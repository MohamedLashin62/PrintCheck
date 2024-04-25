using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PrintCheck.Trancaction
{
    internal class GenericClass
    {
        public DataTable dataTable = new DataTable();
        public void LoadPublic(String SPtext)
        {
            SqlCommand cmd = new SqlCommand();
            {
                cmd.Connection = GenralConnection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPtext;
                GenralConnection.con.Open();
                dataTable.Load(cmd.ExecuteReader());
                GenralConnection.con.Close();
            }
        }
        public int MaxIDPublic(string SPText)
        {
            int id;
            try
            {
                SqlCommand cmd = new SqlCommand();
                {
                    cmd.Connection = GenralConnection.con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = SPText;
                    GenralConnection.con.Open();
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    GenralConnection.con.Close();
                }            }
            catch
            {
                id = 0;
            }
            GenralConnection.con.Close();
            return id;
        }

      
    }              
  }
            

    
