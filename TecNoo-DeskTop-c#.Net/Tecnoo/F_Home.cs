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
    public partial class F_Home : Form
    {
        public F_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_Home_Shown(object sender, EventArgs e)
        {
            using (var flogin = new F_Login())
            {
                flogin.ShowDialog();
            }

            lbUserLogado.Text = Program.usuario.Login;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            using (var fAdm = new F_Adm())
            {
                fAdm.ShowDialog();
            }
        }

        private void btnFPSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
