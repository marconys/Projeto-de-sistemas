using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecnoo.Entities
{
    internal class Endereco : Cliente
    {
        //Atributos
        private int _idEndereco;
        private string _cep;
        private string _rua;
        private string _numero;
        private string _complemento;
        private string _bairro;
        private string _cidade;
        private string _estado;

        //Propriedades
        public int IdEndereco { get { return _idEndereco; } set { _idEndereco = value; } }
        public string Cep { get { return _cep; } set { _cep = value; } }
        public string Rua { get { return _rua; } set { _rua = value; } }
        public string Numero { get { return _numero; } set { _numero = value; } }
        public string Complemento { get { return _complemento; } set { _complemento = value; } }
        public string Bairro { get { return _bairro; } set { _bairro = value; } }
        public string Cidade { get { return _cidade; } set { _cidade = value; } }
        public string Estado { get { return _estado; } set { _estado = value; } }

        //Métodos construtores
        public Endereco()
        {

        }

        public Endereco(int idEndereco)
        {
            IdEndereco = idEndereco;
        }

        public Endereco(int id, int idEndereco, string cep, string rua, string numero, string complemento, string bairro, string cidade, string estado) : base(id)
        {
            IdEndereco = idEndereco;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public Endereco(string cep, string rua, string numero, string complemento, string bairro, string cidade, string estado)
        {
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public void inserirEndereco()
        {
            //
        }

        // Métodos / função listar endereço por Idcliente
        public void ListaEnderecoId(int id)
        {
            var sql = "SELECT * FROM tbendereco WHERE id_cliente_endereco=" + id;

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
                                    this.Cep = dr["cep_endereco"].ToString();
                                    this.Rua = dr["logradouro_endereco"].ToString();
                                    this.Numero = dr["num_endereco"].ToString();
                                    this.Complemento = dr["complemento_endereco"].ToString();
                                    this.Bairro = dr["bairro_endereco"].ToString();
                                    this.Cidade = dr["cidade_endereco"].ToString();
                                    this.Estado = dr["estado_endereco"].ToString();

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

        // Métodos / função atualiza Endereco
        public void AtualizaEndereco(int id)
        {
            var sql = "UPDATE tbendereco SET cep_endereco=@cep, logradouro_endereco=@rua, num_endereco=@numero, " +
                "complemento_endereco=@complemento, bairro_endereco=@bairro, cidade_endereco=@cidade, estado_endereco=@estado " +
                "WHERE id_cliente_endereco=" + id;


            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        //adiciona os parâmetros de values da query no MySql
                        cmd.Parameters.AddWithValue("@cep", this.Cep);
                        cmd.Parameters.AddWithValue("@rua", this.Rua);
                        cmd.Parameters.AddWithValue("@numero", this.Numero);
                        cmd.Parameters.AddWithValue("@complemento", this.Complemento);
                        cmd.Parameters.AddWithValue("@bairro", this.Bairro);
                        cmd.Parameters.AddWithValue("@cidade", this.Cidade);
                        cmd.Parameters.AddWithValue("@estado", this.Estado);
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao tentar atualizar o endereço \n" + erro.Message);
            }

        }






    }
}
