using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCheck.Trancaction
{
    internal class AddCheck
    {

        public SqlCommand cmd;
        public DataTable dtAddCheck=new DataTable();
        public void InsrtCheck(int CheckID,int CheckNo,DateTime CheckDate,decimal CheckAmount,
            int BankCod,int CurrenceyCod,int AlmustafidCod,int ExpensesCod,int CheckTypCod)
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
                cmd.Parameters.Add("@BankCod",SqlDbType.Int).Value=BankCod;
                cmd.Parameters.Add("@CurrenceyCod",SqlDbType.Int).Value=CurrenceyCod;
                cmd.Parameters.Add("@AlmustafidCod", SqlDbType.Int).Value = AlmustafidCod;
                cmd.Parameters.Add("@ExpensesCod",SqlDbType.Int).Value = ExpensesCod;
                cmd.Parameters.Add("@CheckTypCod",SqlDbType.Int).Value = CurrenceyCod;
                GenralConnection.con.Open();
                cmd.BeginExecuteNonQuery();
                GenralConnection.con.Close();
            }
        }


        }
    }

