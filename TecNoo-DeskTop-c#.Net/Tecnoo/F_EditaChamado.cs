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
    public partial class F_EditaChamado : Form
    {
        int id;
        Chamado chamado = new Chamado();

        public F_EditaChamado(int id)
        {
            InitializeComponent();

            this.id = id;

            if (this.id > 0)
            {
                chamado.ListaChamadoId(this.id);

                textIdChamado.Text = chamado.Id.ToString();
                textId_cliente.Text = chamado.IdCliente.ToString();
                cbPrioridade.Text = chamado.Prioridade;
                textProtocolo.Text = chamado.Protocolo;
                cbStatusChamado.Text = chamado.Status;
                cbLocalAtendimento.Text = chamado.LocalAtendimento;
            }
        }

        private void btn_sairChamado_Click(object sender, EventArgs e)
        {
            this.Close();
            Lista_Chamados lista_Chamados = new Lista_Chamados();
            lista_Chamados.ShowDialog();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            var dataHistorico = DateTime.Now;
            int idUser = Program.usuario.Id;
            //Formata datas para o padrão do banco de dados
            String.Format("{0:yyyy-MM-dd HH:mm:ss}", dataHistorico);
            try
            {
                HistoricoChamado historicoChamado = new HistoricoChamado(
                    Int32.Parse(textIdChamado.Text),
                    cbStatusChamado.Text,
                    cbPrioridade.Text,
                    cbLocalAtendimento.Text,
                    idUser,
                    dataHistorico,
                    textComentario.Text
                    );

                historicoChamado.novoHistorico();
                historicoChamado.EditarChamado();

                MessageBox.Show("Chamado Atualizado com sucesso");
                using (var flistChamado = new Lista_Chamados())
                {
                    flistChamado.ShowDialog();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao tentar Atualizar Chamado" + erro.Message);
            }
        }
    }
}
