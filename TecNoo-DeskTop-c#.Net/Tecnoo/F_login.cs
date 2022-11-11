using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnoo.Entities;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Tecnoo
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Program.usuario = Usuario.login(textUsuario.Text);
                //Recebe a senha buscada no banco e tratibui a variável senhaBanco
                string senhabanco = Program.usuario.Senha;
                bool verificaSenha = BCrypt.Net.BCrypt.Verify(textSenha.Text, senhabanco);

                if (Program.usuario.Id > 0 && verificaSenha == true)
                {
                    this.Close();
                }
                else
                {
                    lbErroLogin.Text = "Usuário ou senha incorretos!";
                    textUsuario.Clear();
                    textSenha.Clear();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
           
        }

        private void F_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (String.IsNullOrEmpty(textUsuario.Text))
            {
                Application.Exit();
            }
            
        }
    }
}
