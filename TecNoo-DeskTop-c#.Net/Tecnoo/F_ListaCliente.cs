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
    public partial class F_ListaCliente : Form
    {
        public F_ListaCliente()
        {
            InitializeComponent();
        }

        private void btn_listarTodosOsClientes_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Cliente.ListaClientes();
                dgv_clientes.DataSource = dt;

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro" + erro);
            }
        }

        private void btn_sair_Clientes_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Adm f_Adm = new F_Adm();
            f_Adm.ShowDialog();
        }

        private void dgv_clientes_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();

            if (dgv_clientes.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dgv_clientes.Rows[dgv_clientes.CurrentCell.RowIndex].Cells["ID:"].Value);
                endereco.ListaEnderecoId(id);
                textCep.Text = endereco.Cep;
                textRua.Text = endereco.Rua;
                textNumero.Text = endereco.Numero;
                textComplemento.Text = endereco.Complemento;
                textBairro.Text = endereco.Bairro;
                textCidade.Text = endereco.Cidade;
                textEstado.Text = endereco.Estado;
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_clientes.Rows.Count > 0)
                {

                    var id = Convert.ToInt32(dgv_clientes.Rows[dgv_clientes.CurrentCell.RowIndex].Cells["ID:"].Value);

                    using (var fClienteNovo = new F_ClienteNovo(id))
                    {
                        fClienteNovo.ShowDialog();
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
    }
}
