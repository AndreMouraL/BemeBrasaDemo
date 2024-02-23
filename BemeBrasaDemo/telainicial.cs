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
    public partial class telainicial : Form
    {
        public telainicial()
        {
            InitializeComponent();
            //progressBar1.ForeColor = Color.FromArgb(0, 71, 168);
            SetProgressBarColor();
        }
        private void SetProgressBarColor()
        {
            // Define a cor do ProgressBar para azul
            progressBar1.ForeColor = Color.FromArgb(0, 71, 168);
        }
        private void telainicial_Load(object sender, EventArgs e)
        {
            // Inicia o temporizador quando o formulário é carregado
            timer1.Start();

        }
        //int startpoint=0;
        // Evento Tick do temporizador
        private void timer1_Tick_1(object sender, EventArgs e)
        {   // Verifica se a barra de progresso não atingiu 100%
            if (progressBar1.Value < 100)
            {   // Incrementa o valor da barra de progresso
                progressBar1.Value += 1;
                // Atualiza o texto da label para mostrar o progresso em percentual
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                //timer1.Stop();

                //MessageBox.Show("Termine!");

                // Quando a barra de progresso atinge 100%

                // Cria uma instância do formulário de login
                login login = new login();
                //progressBar1.Stop();
                // Para o temporizador
                timer1.Stop();
                // Esconde o formulário de splash
                this.Hide();
                // Exibe o formulário de login
                login.Show();


        
            }
        }

        
    }
}




/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form
{
    public partial class SplashForm : Form
    {

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            // Inicia o temporizador quando o formulário é carregado
            timer1.Start();
        }
        //int startpoint=0;
        // Evento Tick do temporizador
        private void timer1_Tick_1(object sender, EventArgs e)
        {   // Verifica se a barra de progresso não atingiu 100%
            if (progressBar1.Value < 100)
            {   // Incrementa o valor da barra de progresso
                progressBar1.Value += 1;
                // Atualiza o texto da label para mostrar o progresso em percentual
                label3.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                //timer1.Stop();

                //MessageBox.Show("Termine!");

                // Quando a barra de progresso atinge 100%

                // Cria uma instância do formulário de login
                LoginForm login = new LoginForm();
                //progressBar1.Stop();
                // Para o temporizador
                timer1.Stop();
                // Esconde o formulário de splash
                this.Hide();
                // Exibe o formulário de login
                login.Show();


            }
        }


    }
}*/