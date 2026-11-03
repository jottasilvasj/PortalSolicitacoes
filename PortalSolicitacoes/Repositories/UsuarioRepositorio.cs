using MySql.Data.MySqlClient;
using PortalSolicitacoes.Models;

namespace PortalSolicitacoes.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly string _conexaoMySQL;

        public UsuarioRepositorio(IConfiguration configuration)
        {
            _conexaoMySQL = configuration.GetConnectionString("ConexaoMySQL")
                ?? throw new InvalidOperationException("String de conexão não encontrada.");
        }

        public UsuarioModel? BuscarPorLogin(string email)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                string sql = "SELECT id, Nome, Email, SenhaHash, DataCriacao FROM usuarios WHERE Email = @Email";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UsuarioModel
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("Nome"),
                                Email = reader.GetString("Email"),
                                SenhaHash = reader.GetString("SenhaHash"),
                                DataCriacao = reader.GetDateTime("DataCriacao")
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void Cadastrar(UsuarioModel usuario)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                string sql = @"
                    INSERT INTO usuarios (Nome, Email, SenhaHash, DataCriacao)
                    VALUES (@Nome, @Email, @SenhaHash, @DataCriacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
                    cmd.Parameters.AddWithValue("@DataCriacao", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}