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
          class GenralConnection
    {
       public static SqlConnection con= new SqlConnection("Data Source=.;Initial Catalog=PrintCheck;Integrated Security=True");

    }
} 
