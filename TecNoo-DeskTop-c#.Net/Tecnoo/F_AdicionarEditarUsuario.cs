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
using System.Security.Cryptography;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Tecnoo
{
    public partial class F_AdicionarEditarUsuario : Form
    {
        int id;
        Usuario usuario = new Usuario();

        public F_AdicionarEditarUsuario(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                usuario.ListaUsuarioId(this.id);

                textIdUsuario.Text = usuario.Id.ToString();
                textNomeuser.Text = usuario.Nome;
                textEmailUser.Text = usuario.Email;
                textLoginUser.Text = usuario.Login;
                textSenhaUser.Text = usuario.Senha;
                //Verica o nível
                if (usuario.IdNivel == 1)
                {
                    cbNivelUser.Text = "SUPERVISOR";
                }
                else if (usuario.IdNivel == 2)
                {
                    cbNivelUser.Text = "TÉCNICO II";
                }
                else if (usuario.IdNivel == 3)
                {
                    cbNivelUser.Text = "TÉCNICO I";
                }
                else
                {
                    cbNivelUser.Text = "DESLIGADO";
                }
            }
        }

        private void btn_sairGerUser_Click(object sender, EventArgs e)
        {
            
            F_ListaUsuarios2 f_ListaUsuarios2 = new F_ListaUsuarios2();
            f_ListaUsuarios2.ShowDialog();
            this.Close();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            int nivel;

            //verifica o nível selecionado
            /*
            SUPERVISOR
            TÉCNICO I
            TÉCNICO II
            DESLIGADO
                         */
            if (cbNivelUser.Text == "SUPERVISOR")
            {
                nivel = 1;
            }
            else if (cbNivelUser.Text == "TÉCNICO II")
            {
                nivel = 2;
            }
            else if (cbNivelUser.Text == "TÉCNICO I")
            {
                nivel = 3;
            }
            else
            {
                nivel = 4;
            }

            //Instancia um objeto a partir da classe hash para critografar a senha
            //Hash hash = new Hash(SHA512.Create());

            //
            string senha = textSenhaUser.Text;
            //Criptografa a senha recebida atravéz do textSenhaUser.Text;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(senha);
            try
            {
                Usuario usuario = new Usuario(
                    textNomeuser.Text,
                    textEmailUser.Text,
                    nivel,
                    textLoginUser.Text,
                    passwordHash
                    //hash.CriptografarSenha(textSenhaUser.Text)
                    );

                if (this.id == 0)
                {
                    usuario.InserirUsuario();
                }
                else
                {
                    usuario.AtualizaUsuario(Int32.Parse(textIdUsuario.Text));
                }


                textIdUsuario.Clear();
                textNomeuser.Clear();
                textEmailUser.Clear();
                textLoginUser.Clear();
                textSenhaUser.Clear();

                MessageBox.Show("Usuário inserido/atualizado com sucesso!");

                F_ListaUsuarios2 f_ListaUsuarios2 = new F_ListaUsuarios2();
                this.Close();
                f_ListaUsuarios2.ShowDialog();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir novo usuário \n" + erro.Message);
            }

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
