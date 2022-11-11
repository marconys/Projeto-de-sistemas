using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecnoo
{
    public partial class F_Adm : Form
    {
        public F_Adm()
        {
            InitializeComponent();

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            using (var fHome = new F_Home())
            {
                fHome.ShowDialog();
            }
        }

        private void btn_listarChamado_Click(object sender, EventArgs e)
        {
            Lista_Chamados listaChamados = new Lista_Chamados();
            listaChamados.ShowDialog();
            this.Close();



        }

        private void btn_listaCliente_Click(object sender, EventArgs e)
        {
            F_ListaCliente f_ListaCliente = new F_ListaCliente();
            f_ListaCliente.ShowDialog();
            this.Close();
        }

        private void btn_listaUsuarios_Click(object sender, EventArgs e)
        {
            F_ListaUsuarios2 f_ListaUsuarios2 = new F_ListaUsuarios2();
            f_ListaUsuarios2.ShowDialog();
            this.Close();
        }

        private void F_Adm_Shown(object sender, EventArgs e)
        {
            lb_usuario.Text = Program.usuario.Login;
        }

        private void btnListarHistorico_Click(object sender, EventArgs e)
        {
            this.Close();
            using(var fHistorico = new F_Historico())
            {
                fHistorico.ShowDialog();
            }
        }
    }
}
