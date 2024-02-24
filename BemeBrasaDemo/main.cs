using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BemeBrasaDemo
{
    public partial class main : Form
    {
        public main()//atenção sem referência ajeitar se der erro.
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            userretirada1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            entrega1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            viagem1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            pagamento1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            cliente1.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button18.Height;
            SidePanel.Top = button18.Top;
            adm1.BringToFront();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.ForeColor = Color.Red;
        }
        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.ForeColor = Color.Transparent;
        }
       
        private void button21_Click(object sender, EventArgs e)
        {
            // Maximizar o formulário
            this.WindowState = FormWindowState.Maximized;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            // Minimizar o formulário
            this.WindowState = FormWindowState.Minimized;

        }
        
    }
}
