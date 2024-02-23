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
    public partial class login : Form
    {
        private bool lembrarMeMarcado = false;
        public login()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_usrname.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("É necessário fornecer dados de login", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_usrname.Text;
                string pass = textBox_password.Text;

                // Verificação de credenciais aqui seria feita, mas como você não deseja mais a parte do banco de dados, 
                // não é necessário incluir esse código.

                // Exemplo de verificação simplificada:
                if (uname == "admin" && pass == "admin")
                {
                    main main = new main();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Seu nome de usuário ou senha não existe. Por favor, verifique suas credenciais.", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lembrarMeMarcado = checkBox1.Checked;
            // Mantenha o nome de usuário mesmo após a senha ser digitada
            if (lembrarMeMarcado && !string.IsNullOrEmpty(textBox_usrname.Text))
            {
                Properties.Settings.Default.Username = textBox_usrname.Text; //
                Properties.Settings.Default.Save();
            }
            // Aqui você pode adicionar qualquer código adicional que deseja executar quando o estado do CheckBox é alterado.
            // Por exemplo, você pode atualizar a interface do usuário com base no estado do CheckBox.
            // alterar senha atualizar
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
//BANCO  DE DADOS E EBIR SENHA / GUNA.ui2...
/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Transparent_Form
{
    public partial class LoginForm : Form
    {
        StudentClass student = new StudentClass();
        private bool lembrarMeMarcado = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_usrname.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("É necessário fornecer dados de login", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_usrname.Text;
                string pass = textBox_password.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + uname + "' AND `password`='" + pass + "'"));
                if (table.Rows.Count > 0)
                {

                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("Seu nome de usuário ou senha não existe.Por favor, verifique suas credenciais.", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // opção para alterar senha.
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lembrarMeMarcado = checkBox1.Checked;
            // Mantenha o nome de usuário mesmo após a senha ser digitada
            if (lembrarMeMarcado && !string.IsNullOrEmpty(textBox_usrname.Text))
            {
                Properties.Settings.Default.Username = textBox_usrname.Text;
                Properties.Settings.Default.Save();
            }
            // Aqui você pode adicionar qualquer código adicional que deseja executar quando o estado do CheckBox é alterado.
            // Por exemplo, você pode atualizar a interface do usuário com base no estado do CheckBox.
        }
    }
}
*/