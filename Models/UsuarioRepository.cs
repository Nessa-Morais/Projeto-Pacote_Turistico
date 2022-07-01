using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atividade_2.Models
{
    public class UsuarioRepository
    {
         private const string DadosConexao = "Database=Turismo;Data Source=localhost;User Id=root;"; // obs de id maiusculo pode ser necessario alterar

        public void TestarConexao()
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados conectado com sucesso!!!");
            Conexao.Close();
        }

      
        public Usuario ValidarLogin(Usuario usuario)
        {

          
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

          
            Usuario UsuarioEncontrado = null;

           
            String Query = "SELECT * FROM Usuario WHERE Login=@Login and Senha=@Senha";

            
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Login", usuario.Login);
            Comando.Parameters.AddWithValue("@Senha", usuario.Senha);

            MySqlDataReader Reader = Comando.ExecuteReader();

            // Percurso de registros
            if (Reader.Read())
            {

                UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            Conexao.Close();

            return UsuarioEncontrado;


        }

        public void Remover(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id", user.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public List<Usuario> Listar(int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            List<Usuario> ListaDeUsuarios = new List<Usuario>();


            
            String Query = " SELECT * FROM Usuario";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);


            MySqlDataReader Reader = Comando.ExecuteReader();


            while (Reader.Read())
            {

                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");

                ListaDeUsuarios.Add(UsuarioEncontrado);
            }

            Conexao.Close();

            return ListaDeUsuarios;

        }

        public Usuario BuscarPorId(int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            Usuario UsuarioEncontrado = new Usuario();

            String Query = "SELECT * FROM Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            if (Reader.Read())
            {

                UsuarioEncontrado.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            Conexao.Close();

            return UsuarioEncontrado;
        }

        public void Inserir(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "INSERT INTO Usuario(Nome,Login,Senha,DataNascimento) VALUES(@Nome,@Login,@Senha,@DataNascimento)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }


        public void Atualizar(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "UPDATE Usuario SET Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);
            Comando.Parameters.AddWithValue("@Id", user.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }
    }
}