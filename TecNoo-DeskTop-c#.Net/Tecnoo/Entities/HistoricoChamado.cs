using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tecnoo.Entities
{
    internal class HistoricoChamado : Chamado
    {
        //Atributos
        private int _idHistorico;
        private int _idUser;
        private DateTime _dataHistorico;
        private string _comentario;

        //Propriedades
        public int IdHistorico { get { return _idHistorico; } set { _idHistorico = value; } }
        public int IdUser { get { return _idUser; } set { _idUser = value; } }
        public DateTime DataHistorico { get { return _dataHistorico; } set { _dataHistorico = value; } }
        public string Comentario { get { return _comentario; } set { _comentario = value; } }


        public HistoricoChamado()
        {

        }

        public HistoricoChamado(int idHistorico = 0)
        {
            IdHistorico = idHistorico;
        }

        public HistoricoChamado(int id, string status, string prioridade, string localAtendimento, int idUser, DateTime dataHistorico, string comentario) 
            
            : base(id, status, prioridade, localAtendimento)
        {
            IdUser = idUser;
            DataHistorico = dataHistorico;
            Comentario = comentario;
        }

        public HistoricoChamado(int idHistorico, int idUser, DateTime dataHistorico, string comentario)
        {
            IdHistorico = idHistorico;
            IdUser = idUser;
            DataHistorico = dataHistorico;
            Comentario = comentario;
        }

        public void novoHistorico()
        {
            var sql = "INSERT INTO hist_atend (id_chamado_hist_atend, id_usuario_hist_atend, comentario_hist, data_historico_chamado) VALUES(@idChamado, @idUser, @comentario, @data)";


            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        // adiciona os parâmetros de values da query no MySql
                        cmd.Parameters.AddWithValue("@idChamado", this.Id);
                        cmd.Parameters.AddWithValue("@idUser", this.IdUser);
                        cmd.Parameters.AddWithValue("@comentario", this.Comentario);
                        cmd.Parameters.AddWithValue("@data", this.DataHistorico);
                        cmd.ExecuteNonQuery();
                    }

                    cn.Close();

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        // Métodos / função ListaHistorico
        public static DataTable ListaHistorico()
        {
            var dt = new DataTable();

            var sql = "SELECT id_hist_atend AS 'ID-HISTORICO:', id_chamado_hist_atend AS 'ID-CHMADO:', id_usuario_hist_atend AS 'ID-USUARIO:', comentario_hist 'COMENTARIO:', data_historico_chamado AS 'DATA' FROM tecnoodb.hist_atend";

            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            return dt;
        }

        // Métodos / função listar históricos
        public static DataTable listarHistoricos()
        {
            var dt = new DataTable();

            var sql = "SELECT id_hist_atend AS 'ID:',id_chamado_hist_atend AS 'ID-CHAMADO:',id_usuario_hist_atend AS 'ID-USUARIO:', comentario_hist AS 'COMENTARIO:', data_historico_chamado AS 'DATA:' FROM tecnoodb.hist_atend ";

            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            return dt;
        }

        // Métodos / função listar chamados por Id
        public void ListaHitorico(int id)
        {
            var sql = "SELECT * FROM hist_atend WHERE id_hist_atend=" + id;

            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            //Verifica se encontrou alguma coisa na tabela
                            if (dr.HasRows)
                            {
                                //ler os valores encontrados
                                if (dr.Read())
                                {
                                    this.IdHistorico = Convert.ToInt32(dr["id_hist_atend"]);
                                    this.Id = Convert.ToInt32(dr["id_chamado_hist_atend"]);
                                    this.IdUser = Convert.ToInt32(dr["id_usuario_hist_atend"]);
                                    this.DataHistorico = Convert.ToDateTime(dr["data_historico_chamado"]);
                                    this.Comentario = dr["comentario_hist"].ToString();
                                }


                            }
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }


        // Métodos / função editar chamados herdado da classe Chamados
        public void EditarChamado()
        {
            var sql = "UPDATE tbchamados SET status_chamado=@status,prioridade_chamado=@prioridade,local_atend_chamado=@local_atend WHERE id_chamado=" + Id;

            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        //adiciona os parâmetros de values da query no MySql
                        cmd.Parameters.AddWithValue("@status", this.Status);
                        cmd.Parameters.AddWithValue("@prioridade", this.Prioridade);
                        cmd.Parameters.AddWithValue("@local_atend", this.LocalAtendimento);
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }


    }
}
