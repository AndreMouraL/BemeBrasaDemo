using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BemeBrasaDemo
{
    static class Program
    {
        /// <summary>
        /// O ponto de entrada principal para a aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //Application.EnableVisualStyles();// att muda co diferentes computadores.
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new telainicial()); //main
        }
    }
}


