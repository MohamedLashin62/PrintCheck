using PrintCheck.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintCheck.Trancaction
{
    internal class Program
    {
        public static class ProgramClass 
        {
            [STAThread]
            public static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormAddCheck());
            }
             

        
            

            }
        }
    }

