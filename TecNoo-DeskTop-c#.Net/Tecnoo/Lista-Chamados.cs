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
    public partial class Lista_Chamados : Form
    {
        
        
        
        public Lista_Chamados()
        {
            InitializeComponent();

        }

        private void Lista_Chamados_Load(object sender, EventArgs e)
        {

        }
        // Fecha o form atual e chama o form principal
        private void btn_sair_chamaos_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Adm f_Adm = new F_Adm();
            f_Adm.ShowDialog();
        }

        // Chama o método Listar todos
        private void btn_listarTodosOsChamados_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = Chamado.listarChamados();
                dgv_chamados.DataSource = dt;
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("erro" + erro);
            }         



        }

        private void btn_novoChamado_Click(object sender, EventArgs e)
        {
            //Verifica a prioridade
            string prioridade = "Baixa";
            if (radioFunciona.Checked)
            {
                prioridade = "Baixa";
            }
            else if (radiofuncParcial.Checked)
            {
                prioridade = "Media";
            }
            else if (radionaoFunciona.Checked)
            {
                prioridade = "Alta";
            }

            //Gera um id aleatório para o protocolo
            string protocolo = Guid.NewGuid().ToString();

            //Captura data atual
            var dataAtual = DateTime.Now;
            //Atribui soma o razo em hora na variavel data atual e atribui o valor a datalimite.
            var dataLimite = dataAtual.AddHours(+72);

            var dataFinal = dataLimite;

            //Formata datas para o padrão do banco de dados
            String.Format("{0:yyyy-MM-dd HH:mm:ss}", dataAtual, dataLimite, dataLimite);

            //Verifica o local de atendimento
            string local = "";
            if (cb_domicilio.Checked)
            {
                local = "Domicilio";
            }else if (cb_laboratorio.Checked)
            {
                local = "Laboratorio";
            }
            else
            {
                local = "Remote";
            }

            //Atribui status padrão
            string status = "Aguardando equipamento";

            try
            {
                Chamado chamado = new Chamado(
                    protocolo,
                    textDescricao.Text,
                    textTitulo.Text,
                    Int32.Parse(textIdCliente.Text),
                    dataAtual,
                    dataFinal,
                    dataLimite,
                    status,
                    prioridade,
                    local);

                chamado.novoChamado();

                textIdCliente.Clear();
                textDescricao.Clear();
                textTitulo.Clear();

                MessageBox.Show("Chamado Aberto Com sucesso! \n Procolo:" + protocolo);

                //Seleciona e atualiza tabListaChamados com dados já existentes e recem inseridos na tabela tbchamados. 
                tabChmados.SelectedTab = tabListaChmados;
                dgv_chamados.DataSource = Chamado.listarChamados();
            }
            catch (Exception erro)
            {

                MessageBox.Show("erro na abertura do chamado!" + erro);
            }
        }

        private void dgv_chamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovoChamado_Click(object sender, EventArgs e)
        {
            tabChmados.SelectedTab = tabNovoChamado;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgv_chamados.Rows.Count > 0)
                {
                    var id = Convert.ToInt32(dgv_chamados.Rows[dgv_chamados.CurrentCell.RowIndex].Cells["ID:"].Value);

                    using (var f_EditaChamado = new F_EditaChamado(id))
                    {
                        f_EditaChamado.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um chamado");
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void dgv_chamados_Click(object sender, EventArgs e)
        {
            Chamado ch = new Chamado();
            if (dgv_chamados.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dgv_chamados.Rows[dgv_chamados.CurrentCell.RowIndex].Cells["ID:"].Value);
                ch.ListaChamadoId(id);
                textMostraId.Text = ch.Id.ToString();
                textMostraProtocolo.Text = ch.Protocolo;
                textMostraIdCli.Text = ch.IdCliente.ToString();
                textMostraTitulo.Text = ch.Titulo;
                textMostraPrioridade.Text = ch.Prioridade;
                textMostrastatus.Text = ch.Status;
                textMostraData.Text = ch.DataAbertura.ToString();
                textMostraLocal.Text = ch.LocalAtendimento;
                textMostraDescricao.Text = ch.Descricao;
            }
        }
    }
}
