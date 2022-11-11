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
    public partial class F_Historico : Form
    {
        public F_Historico()
        {
            InitializeComponent();

            try
            {
                DataTable dt = new DataTable();
                dt = HistoricoChamado.listarHistoricos();
                dgv_Historico.DataSource = dt;

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro" + erro);
            }
        }

        private void btn_sairHistorico_Click(object sender, EventArgs e)
        {
            
            using (var fAdm = new F_Adm())
            {
                fAdm.ShowDialog();
            }

            this.Close();
        }

        private void dgv_Historico_Click(object sender, EventArgs e)
        {
            HistoricoChamado hist = new HistoricoChamado();

            if (dgv_Historico.Rows.Count > 0)
            {
                var id = Convert.ToInt32(dgv_Historico.Rows[dgv_Historico.CurrentCell.RowIndex].Cells["ID:"].Value);
                hist.ListaHitorico(id);
                textMostraIdHist.Text = hist.IdHistorico.ToString();
                textMostraIdCha.Text = hist.Id.ToString();
                textMostraIdUser.Text = hist.IdUser.ToString();
                textMostraData.Text = hist.DataHistorico.ToString();
                textMostraComentario.Text = hist.Comentario;
            }
        }
    }
}
