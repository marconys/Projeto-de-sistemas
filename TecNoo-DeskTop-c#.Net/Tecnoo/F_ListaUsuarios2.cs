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

namespace Tecnoo
{
    public partial class F_ListaUsuarios2 : Form
    {
        public F_ListaUsuarios2()
        {
            InitializeComponent();

            try
            {
                DataTable dt = new DataTable();
                dt = Usuario.ListaUsuarios();
                dgv_Usuarios.DataSource = dt;

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro" + erro);
            }
        }

        private void btnUsuarioSair_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Adm f_Adm = new F_Adm();
            f_Adm.ShowDialog();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            using (var fadicionarEditar = new F_AdicionarEditarUsuario(0))
            {
                fadicionarEditar.ShowDialog();
                dgv_Usuarios.DataSource = Usuario.ListaUsuarios();
                
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Usuarios.Rows.Count > 0)
                {

                    var id = Convert.ToInt32(dgv_Usuarios.Rows[dgv_Usuarios.CurrentCell.RowIndex].Cells["ID:"].Value);

                    using (var fadicionarEditar = new F_AdicionarEditarUsuario(id))
                    {
                        fadicionarEditar.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um usuário");
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao buscar usuário" + erro.Message);
            }
        }

        private void F_ListaUsuarios2_Load(object sender, EventArgs e)
        {

        }
    }
}
