using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecnoo.Entities
{
    internal class Cliente
    {
        //Atributos
        private int _id;
        private string _nome;
        private string _email;
        private string _cpf;
        private string _cnpj;
        private string _telefone;
        private string _rSocial;
        private int _idTipo;
        private int _idContrato;
        private string _senha;
        private string _foto;

        //Propriedades
        public int Id { get { return _id; } set { _id = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Cpf { get { return _cpf; } set { _cpf = value; } }
        public string Cnpj { get { return _cnpj; } set { _cnpj = value; } }
        public string Telefone { get { return _telefone; } set { _telefone = value; } }
        public string RSocial { get { return _rSocial; } set { _rSocial = value; } }
        public int IdTipo { get { return _idTipo; } set { _idTipo = value; } }
        public int IdContrato { get { return _idContrato; } set { _idContrato = value; } }
        public string Senha { get { return _senha; } set { _senha = value; } }
        public string Foto { get { return _foto; } set { _foto = value; } }


        //Métodos construtores
        public Cliente()
        {

        }

        public Cliente(int id)
        {
            Id = id;
        }

        public Cliente(string nome, string email, string cpf, string cnpj, string telefone, string rSocial, int idTipo, int idContrato, string senha)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Cnpj = cnpj;
            Telefone = telefone;
            RSocial = rSocial;
            IdTipo = idTipo;
            IdContrato = idContrato;
            Senha = senha;
        }

        public Cliente(int id, string nome, string email, string cpf, string cnpj, string telefone, string rSocial, int idTipo, int idContrato, string senha, string foto) : this(id)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Cnpj = cnpj;
            Telefone = telefone;
            RSocial = rSocial;
            IdTipo = idTipo;
            IdContrato = idContrato;
            Senha = senha;
            Foto = foto;
        }

        //Métodos da classe / Funções

        // Métodos / função insere cliente
        public void InserirCliente()
        {

            var sql = "INSERT INTO tbcliente (nome_cliente, cpf_cliente, telefone_cliente, cnpj_cliente, razao_social_cliente, id_tipo_cliente, id_contrato_cliente, email_cliente, senha_cliente) OUTPUT INSERTED.ID" +
                " VALUES (@nome, @cpf, @telefone, @cnpj, @rsocial, @idtipo, @idcontrato, @email, @senha) ";

            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        //adiciona os parâmetros de values da query no MySql
                        cmd.Parameters.AddWithValue("@nome", this.Nome);
                        cmd.Parameters.AddWithValue("@cpf", this.Cpf);
                        cmd.Parameters.AddWithValue("@telefone", this.Telefone);
                        cmd.Parameters.AddWithValue("@cnpj", this.Cnpj);
                        cmd.Parameters.AddWithValue("@rsocial", this.RSocial);
                        cmd.Parameters.AddWithValue("@idtipo", this.IdTipo);
                        cmd.Parameters.AddWithValue("@idcontrato", this.IdContrato);
                        cmd.Parameters.AddWithValue("@email", this.Email);
                        cmd.Parameters.AddWithValue("@senha", this.Senha);
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

        // Métodos / função atualiza cliente
        public void AtualizaCliente(int id)
        {
            var sql = "UPDATE tbcliente SET nome_cliente=@nome, telefone_cliente=@telefone, id_tipo_cliente=@idtipo, cnpj_cliente=@cnpj, razao_social_cliente=@rocial, email_cliente=@email, id_contrato_cliente=@idcontrato WHERE id_cliente=" + id;


            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        //adiciona os parâmetros de values da query no MySql
                        cmd.Parameters.AddWithValue("@nome", this.Nome);
                        cmd.Parameters.AddWithValue("@telefone", this.Telefone);
                        cmd.Parameters.AddWithValue("@idtipo", this.IdTipo);
                        cmd.Parameters.AddWithValue("@@idcontrato", this.IdContrato);
                        cmd.Parameters.AddWithValue("@cnpj", this.Cnpj);
                        cmd.Parameters.AddWithValue("@rocial", this.RSocial);
                        cmd.Parameters.AddWithValue("@email", this.Email);
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

        // Métodos / função listar Clientes
        public static DataTable ListaClientes()
        {
            var dt = new DataTable();

            var sql = "SELECT id_cliente AS 'ID:', nome_cliente AS 'NOME:', cpf_cliente AS 'CPF:', cnpj_cliente AS 'CNPJ:', razao_social_cliente AS 'EMPRESA:', id_tipo_cliente AS 'ID-TIPO:', id_contrato_cliente AS 'ID-CONTRATO:', email_cliente AS 'EMAIL:' FROM tecnoodb.tbcliente";

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

        // Métodos / função listar clientes por id
        public void ListaClienteId(int id)
        {
            //Variável de busca no banco de dados
            var sql = "SELECT * FROM tbcliente WHERE id_cliente=" + id;

            try
            {
                //Cria váriável de conexão
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    //Abre conexão com o banco de dados
                    cn.Open();
                    //Cria um comando Mysql
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
                                    this.Id = Convert.ToInt32(dr["id_cliente"]);
                                    this.Nome = dr["nome_cliente"].ToString();
                                    this.Cpf = dr["cpf_cliente"].ToString();
                                    this.Cnpj = dr["cnpj_cliente"].ToString();
                                    this.RSocial= dr["razao_social_cliente"].ToString();
                                    this.IdTipo = Convert.ToInt32(dr["id_tipo_cliente"]);
                                    this.IdContrato = Convert.ToInt32(dr["id_contrato_cliente"]);
                                    this.Email = dr["email_cliente"].ToString();
                                    this.Telefone = dr["telefone_cliente"].ToString();
                                    this.Senha = dr["senha_cliente"].ToString();
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


    }
}
