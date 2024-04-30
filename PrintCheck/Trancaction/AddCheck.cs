using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrintCheck.PrintCheckDataSet1;

namespace PrintCheck.Trancaction
{
    internal class AddCheck
    {

        public SqlCommand cmd;
        public DataTable dtAddCheck=new DataTable();
       public void InsertIntoCheckMovement(int CheckID,int CheckNo,DateTime CheckDate,decimal CheckAmount,
            string AlmustafidNam,int CurrenceyCod, int BankCod,int ExpensesCod,int CheckTypCod,string Manger)
        {
            cmd = new SqlCommand();
            {
                cmd.Connection = GenralConnection.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsrtCheckSP";

                cmd.Parameters.Add("@CheckID",SqlDbType.Int).Value=CheckID;
                cmd.Parameters.Add("@CheckNo",SqlDbType.Int).Value = CheckNo;
                cmd.Parameters.Add("@CheckDate",SqlDbType.Date).Value = CheckDate;
                cmd.Parameters.Add("@CheckAmount",SqlDbType.Decimal).Value = CheckAmount;
                cmd.Parameters.Add("@AlmustafidName",SqlDbType.NVarChar,50).Value = AlmustafidNam;
                cmd.Parameters.Add("@CurrenceyCod", SqlDbType.Int).Value = CurrenceyCod;
                cmd.Parameters.Add("@BankCod", SqlDbType.Int).Value = BankCod;
                cmd.Parameters.Add("@ExpensesCod", SqlDbType.Int).Value = ExpensesCod;
                cmd.Parameters.Add("@CheckTypCod", SqlDbType.Int).Value = CheckTypCod;
                cmd.Parameters.Add("@Manger", SqlDbType.NVarChar, 50).Value = Manger;
                GenralConnection.con.Open();
                cmd.ExecuteNonQuery();
                GenralConnection.con.Close();
            }
        }


        }
    }

