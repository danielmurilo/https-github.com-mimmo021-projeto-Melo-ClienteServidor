using ProjetoEasyImoveis.classesconexao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfServiceClienteRede.classebasica;
using WcfServiceClienteRede.classeInterface;

namespace WcfServiceClienteRede.classeDados
{
    public class DadosClienteRede : InterfaceClienteRede
    {
        private conexao conn = new conexao();
        //construtor
        public DadosClienteRede()
        {
            this.conn.abrirconexao();
        }


        public void cadastrarClienteRede(ClienteRede cr)
        {
            try
            {
                string sql = "insert into Cli_Rede(nome_Cli_Rede, login_Cli_Rede, senha_Cli_Rede, email_Cli_Rede, telefone_Cli_Rede) values (@nome, @login, @senha, @email, @telefone);";
                SqlCommand cadastrando = new SqlCommand(sql, conn.sqlconn);

                cadastrando.Parameters.AddWithValue("@nome", cr.Nome_cli_rede);
                cadastrando.Parameters.AddWithValue("@login", cr.Login_cli_rede);
                cadastrando.Parameters.AddWithValue("@senha", cr.Senha_cli_rede);
                cadastrando.Parameters.AddWithValue("@email", cr.Email_cli_rede);
                cadastrando.Parameters.AddWithValue("@telefone", cr.Telefone_cli_rede);
                conn.fecharConexao();
                conn.sqlconn.Dispose();
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel cadastrar Usuário no Banco!!");
            }
        }
        public void alterarClienteRede(ClienteRede cr)
        {
            try
            {
                string sql = "update Cli_Rede set nome_Cli_Rede = @nome, login_Cli_Rede = @login, senha_Cli_Rede = @senha, email_Cli_Rede = @email, telefone_Cli_Rede = @telefone);";
                SqlCommand update = new SqlCommand(sql, conn.sqlconn);
                update.Parameters.AddWithValue("@nome", cr.Nome_cli_rede);
                update.Parameters.AddWithValue("@login", cr.Login_cli_rede);
                update.Parameters.AddWithValue("@senha", cr.Senha_cli_rede);
                update.Parameters.AddWithValue("@email", cr.Email_cli_rede);
                update.Parameters.AddWithValue("@telefone", cr.Telefone_cli_rede);
                conn.fecharConexao();
                conn.sqlconn.Dispose();
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel atualizar registro do Usuário!!");
            }
        }
        public void deletarClienteRede(ClienteRede cr)
        {
            try
            {
                string sql = "delete from Cli_Rede where Id_Cli = @Id_Cli_Rede";
                SqlCommand deletar = new SqlCommand(sql, conn.sqlconn);
                deletar.Parameters.AddWithValue("@Id_Cli_Rede", cr.Id_cli_rede);

                conn.sqlconn.Dispose();
                conn.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw new Exception("Não foi possivel deletar usuário!!");
            }
        }
        public List<ClienteRede> listarClienteRede()
        {
            List<ClienteRede> lista = new List<ClienteRede>();
            try
            {
                string sql = "select * from Cli_Rede";
                SqlCommand cmd = new SqlCommand(sql, conn.sqlconn);
                SqlDataReader listar = cmd.ExecuteReader();

                while (listar.Read())
                {
                    ClienteRede cr = new ClienteRede(listar.GetInt16(listar.GetOrdinal("Id_cli_rede")),
                    listar.GetString(listar.GetOrdinal("nome_Cli_Rede")),
                    listar.GetString(listar.GetOrdinal("login_Cli_Rede")),
                    listar.GetString(listar.GetOrdinal("senha_Cli_Rede")),
                    listar.GetString(listar.GetOrdinal("email_Cli_Rede")),
                    listar.GetString(listar.GetOrdinal("telefone_Cli_Rede")));
                    lista.Add(cr);
                }
                cmd.Dispose();
                conn.fecharConexao();


            }
            catch (Exception)
            {
                throw new Exception("Não foi possivel listar os usuários cadastrados!");
            }
            return lista;
        }
    }

}