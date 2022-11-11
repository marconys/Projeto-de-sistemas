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
    internal class Chamado
    {
        //Atributos
        private int _id;
        private string _protocolo;
        private string _descricao;
        private string _titulo;
        private int _idCliente;
        private DateTime? _dataAbertura;
        private DateTime? _dataFinalizacao;
        private DateTime? _dataLimite;
        private string _status;
        private string _prioridade;
        private string _localAtendimento;
        private string _fotoErro;

        //Propriedades
        public int Id { get { return _id; } set { _id = value; } }
        public string Protocolo { get { return _protocolo; } set { _protocolo = value; } }
        public string Descricao { get { return _descricao; } set { _descricao = value; } }
        public string Titulo { get { return _titulo; } set { _titulo = value; } }
        public int IdCliente { get { return _idCliente; } set { _idCliente = value; } }
        public DateTime? DataAbertura { get { return _dataAbertura; } set { _dataAbertura = value; } }
        public DateTime? DataFinalizacao { get { return _dataFinalizacao; } set { _dataFinalizacao = value; } }
        public DateTime? DataLimite { get { return _dataLimite; } set { _dataLimite = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public string Prioridade { get { return _prioridade; } set { _prioridade = value; } }
        public string LocalAtendimento { get { return _localAtendimento; } set { _localAtendimento = value; } }
        public string FotoErro { get { return _fotoErro; } set { _fotoErro = value; } }

        //Métodos construtores
        public Chamado()
        {

        }

        public Chamado(int id = 0)
        {
            Id = id;
        }

        public Chamado(int id, string status, string prioridade, string localAtendimento) : this(id)
        {
            Status = status;
            Prioridade = prioridade;
            LocalAtendimento = localAtendimento;
        }

        public Chamado(int id, string protocolo, string descricao, string titulo, int idCliente)
        {
            Id = id;
            Protocolo = protocolo;
            Descricao = descricao;
            Titulo = titulo;
            IdCliente = idCliente;
        }

        public Chamado(int id, int idCliente, string status, string prioridade, string localAtendimento)
        {
            Id = id;
            IdCliente = idCliente;
            Status = status;
            Prioridade = prioridade;
            LocalAtendimento = localAtendimento;
        }

        public Chamado(string protocolo, string descricao, string titulo, int idCliente, DateTime? dataAbertura, DateTime? dataFinalizacao, DateTime? dataLimite, string status, string prioridade, string localAtendimento)
        {
            Protocolo = protocolo;
            Descricao = descricao;
            Titulo = titulo;
            IdCliente = idCliente;
            DataAbertura = dataAbertura;
            DataFinalizacao = dataFinalizacao;
            DataLimite = dataLimite;
            Status = status;
            Prioridade = prioridade;
            LocalAtendimento = localAtendimento;
        }

        public Chamado(int id, string protocolo, string descricao, string titulo, int idCliente, DateTime? dataAvertura, DateTime? dataFinalizacao, DateTime? dataLimite, string status, string prioridade, string localAtendimento) : this(id, protocolo, descricao, titulo, idCliente)
        {
            DataAbertura = dataAvertura;
            DataFinalizacao = dataFinalizacao;
            DataLimite = dataLimite;
            Status = status;
            Prioridade = prioridade;
            LocalAtendimento = localAtendimento;
        }

        public Chamado(int id, string protocolo, string descricao, string titulo, int idCliente, DateTime dataAbertura, DateTime dataFinalizacao, DateTime dataLimite, string status, string prioridade, string localAtendimento, string fotoErro) : this(id, protocolo, descricao, titulo, idCliente)
        {
            DataAbertura = dataAbertura;
            DataFinalizacao = dataFinalizacao;
            DataLimite = dataLimite;
            Status = status;
            Prioridade = prioridade;
            LocalAtendimento = localAtendimento;
            FotoErro = fotoErro;
        }

        // Métodos / função para alterar e inserir novo chamado
        public void novoChamado()
        {

            var sql = "INSERT INTO tbchamados(protocolo_chamado,descri_chamado,titulo_chamado,id_cliente_chamado,data_abertura_chamado,data_finalizacao_chamado,data_limite_chamado, status_chamado,prioridade_chamado,local_atend_chamado)" +
              " VALUES(@protocolo,@descricao,@titulo,@id_cliente,@data_abertura,@data_final,@data_limite,@status,@prioridade,@local_atend)";


            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        // adiciona os parâmetros de values da query no MySql
                        cmd.Parameters.AddWithValue("@protocolo", this.Protocolo);
                        cmd.Parameters.AddWithValue("@descricao", this.Descricao);
                        cmd.Parameters.AddWithValue("@titulo", this.Titulo);
                        cmd.Parameters.AddWithValue("@id_cliente", this.IdCliente);
                        cmd.Parameters.AddWithValue("@data_abertura", this.DataAbertura);
                        cmd.Parameters.AddWithValue("@data_final", this.DataFinalizacao);
                        cmd.Parameters.AddWithValue("@data_limite", this.DataLimite);
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

        // Métodos / função listar chamados
        public static DataTable listarChamados()
        {
            var dt = new DataTable();

            var sql = "SELECT id_chamado AS 'ID:',id_cliente_chamado AS 'ID-CLIENTE:', protocolo_chamado AS 'PROTOCOLO:', titulo_chamado AS 'TITULO:', descri_chamado AS 'DESCRICAO:', prioridade_chamado AS 'PRIORIDADE:',data_abertura_chamado AS 'DATA DE ABERTURA:', status_chamado AS 'STATUS:', local_atend_chamado AS 'LOCAL DO ATENDIMENTO:' FROM tecnoodb.tbchamados ";

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
        public void ListaChamadoId(int id)
        {
            var sql = "SELECT * FROM tbchamados WHERE id_chamado=" + id;

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
                                    this.Id = Convert.ToInt32(dr["id_chamado"]);
                                    this.Protocolo = dr["protocolo_chamado"].ToString();
                                    this.Prioridade = dr["prioridade_chamado"].ToString();
                                    this.Status = dr["status_chamado"].ToString();
                                    this.LocalAtendimento = dr["local_atend_chamado"].ToString();
                                    this.IdCliente = Convert.ToInt32(dr["id_cliente_chamado"]);
                                    this.DataAbertura = Convert.ToDateTime(dr["data_abertura_chamado"]);
                                    this.Descricao = dr["descri_chamado"].ToString();
                                    this.Titulo = dr["titulo_chamado"].ToString();

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

        // Métodos / função editar chamados
        public void editarChamado()
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
