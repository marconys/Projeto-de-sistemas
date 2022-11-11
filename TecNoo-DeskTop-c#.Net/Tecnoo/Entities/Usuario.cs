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
    internal class Usuario
    {
        //Atributos
        private int _id;
        private string _nome;
        private string _email;
        private int _idNivel;
        private string _login;
        private string _senha;   
        private string _foto;

        //Propriedades
        public int Id { get { return _id; } set { _id = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public int IdNivel { get { return _idNivel; } set { _idNivel = value; } }
        public string Login { get { return _login; } set { _login = value; } }
        public string Senha { get { return _senha; } set { _senha = value; } } 
        public string Foto { get { return _foto; } set { _foto = value; } }

        //Métodos Construtores
        public Usuario()
        {

        }

        public Usuario(int id)
        {
            Id = id;
        }

        public Usuario(string nome, string email, int idNivel, string login, string senha)
        {
            Nome = nome;
            Email = email;
            IdNivel = idNivel;
            Login = login;
            Senha = senha;
        }

        public Usuario(int id, string nome, string email, int idNivel, string login, string senha) : this(id)
        {
            Nome = nome;
            Email = email;
            IdNivel = idNivel;
            Login = login;
            Senha = senha;
        }

        public Usuario(int id, string nome, string email, int idNivel, string login, string senha, string foto) : this(id)
        {
            Nome = nome;
            Email = email;
            IdNivel = idNivel;
            Login = login;
            Senha = senha;
            Foto = foto;
        }

        //Métodos da classe / Funções

        // Métodos / função insere e atualiza usuarios
        public void InserirUsuario()
        {
            
             var   sql = "INSERT INTO tbusuarios (nome_usuario, email_usuario, id_nivel_usuario, login_usuario, senha_usuario) VALUES (@nome, @email, @idUser, @login, @senha) ";
            
            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        //adiciona os parâmetros de values da query no MySql
                        cmd.Parameters.AddWithValue("@nome", this.Nome);
                        cmd.Parameters.AddWithValue("@email", this.Email);
                        cmd.Parameters.AddWithValue("@idUser", this.IdNivel);
                        cmd.Parameters.AddWithValue("@login", this.Login);
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

        // Métodos / função atualiza usuarios
        public void AtualizaUsuario(int id)
        {
            var sql = "UPDATE tbusuarios SET nome_usuario=@nome, email_usuario=@email, id_nivel_usuario=@idUser, login_usuario=@login WHERE id_usuario=" + id;
            

            try
            {
                using (var cn = new MySqlConnection(Banco.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        //adiciona os parâmetros de values da query no MySql
                        cmd.Parameters.AddWithValue("@nome", this.Nome);
                        cmd.Parameters.AddWithValue("@email", this.Email);
                        cmd.Parameters.AddWithValue("@idUser", this.IdNivel);
                        cmd.Parameters.AddWithValue("@login", this.Login);
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

        // Métodos / função listar usuarios
        public static DataTable ListaUsuarios()
        {
            var dt = new DataTable();

            var sql = "SELECT id_usuario AS 'ID:', nome_usuario AS 'NOME:', id_nivel_usuario AS 'NIVEL:', login_usuario AS 'LOGIN:', email_usuario AS 'E-MAIL', senha_usuario AS 'SENHA:' FROM tecnoodb.tbusuarios";

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

        // Métodos / função listar usuarios por id
        public void ListaUsuarioId(int id)
        {
            //Variável de busca no banco de dados
            var sql = "SELECT * FROM tbusuarios WHERE id_usuario=" + id;

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
                                    this.Id = Convert.ToInt32(dr["id_usuario"]);
                                    this.Nome = dr["nome_usuario"].ToString();
                                    this.Email = dr["email_usuario"].ToString();
                                    this.IdNivel = Convert.ToInt32(dr["id_nivel_usuario"]);
                                    this.Login = dr["login_usuario"].ToString();
                                    this.Senha = dr["senha_usuario"].ToString();
                                }
                            }
                        }
                    }

                    cn.Close();
                }
            }
            catch(Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        // Métodos / função logar
        public static Usuario login(string login)
        {
            Usuario usuario = new Usuario();

            var sql = "SELECT * FROM tbusuarios WHERE login_usuario= '" + login + "'";

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
                                    usuario.Id = Convert.ToInt32(dr["id_usuario"]);
                                    usuario.Nome = dr["nome_usuario"].ToString();
                                    usuario.Email = dr["email_usuario"].ToString();
                                    usuario.IdNivel = Convert.ToInt32(dr["id_nivel_usuario"]);
                                    usuario.Login = dr["login_usuario"].ToString();
                                    usuario.Senha = dr["senha_usuario"].ToString();
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

            return usuario;
        }

    }
}
