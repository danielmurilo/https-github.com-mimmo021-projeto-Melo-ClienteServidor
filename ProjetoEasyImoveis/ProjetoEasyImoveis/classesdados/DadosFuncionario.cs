using ProjetoEasyImoveis.classesbasicas;
using ProjetoEasyImoveis.classesconexao;
using ProjetoEasyImoveis.classesinterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesdados
{
    public class DadosFuncionario: InterfaceFuncionario
    {
         private conexao conn = new conexao();

        public void cadastrarFuncionario(Funcionario f)
        {
            try{
                string sql = "insert into Funcionario(nome_f, login_f, senha_f, email_f,data_Cadastro_Fun, telefone_f ) values(@nome_f, @login_f, @senha_f, @email_f, @data_Cadastro_Fun,@telefone_f );";
                SqlCommand cadastrando = new SqlCommand(sql, conn.sqlconn);

                cadastrando.Parameters.AddWithValue("@nome_f", f.Nome );
                cadastrando.Parameters.AddWithValue("@login_f", f.Login);
                cadastrando.Parameters.AddWithValue("@senha_f", f.Senha );
                cadastrando.Parameters.AddWithValue("@email_f", f.Email);
                cadastrando.Parameters.AddWithValue("@data_Cadastro_Fun",f.DataCadastro );
                cadastrando.Parameters.AddWithValue("@telefone_f", f.Telefone);
               


                conn.fecharConexao();
                conn.sqlconn.Dispose();
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel cadastrar Cliente no Banco!!");
            }
        }

        public void alterarFuncionario(Funcionario f)
        {
            try
            {
                string sql = "update Funcionario set nome_f = @nome_f, login_f = @login_f, senha_f = @senha_f, email_f = @email_f, data_Cadastro_Fun = @data_Cadastro_Fun, telefone_f = @telefone_f where Id_Funcionario =@Id_Funcionario;";

                SqlCommand update = new SqlCommand(sql, conn.sqlconn);
                update.Parameters.AddWithValue("@Id_Funcionario", f.Id_Funcionario);
                update.Parameters.AddWithValue("@nome_f", f.Nome);
                update.Parameters.AddWithValue("@login_f", f.Login);
                update.Parameters.AddWithValue("@senha_f", f.Senha);
                update.Parameters.AddWithValue("@email_f", f.Email);
                update.Parameters.AddWithValue("@data_Cadastro_Fun", f.DataCadastro);
                
                update.ExecuteNonQuery();

                conn.sqlconn.Dispose();
                conn.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw new Exception("Não foi possivel mostrar o Banco!!");
                throw new Exception("Não foi possivel Alterar!!");
            }
        }

        public void deletarFuncionario(Funcionario f)
        {
            try
            {
                string sql = "delete from Funcionario where Id_Funcionario = @Id_Funcionario";
                SqlCommand deletar = new SqlCommand(sql, conn.sqlconn);
                deletar.Parameters.AddWithValue("@Id_Funcionario", f.Id_Funcionario);

                conn.sqlconn.Dispose();
                conn.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw new Exception("Não foi possivel deletar!!");
            }
        }

        public List<Funcionario> listarFuncionario()
        {
            List<Funcionario> lista = new List<Funcionario>();

            try
            {
                string sql = "select * from Funcionario ";
                SqlCommand cmd = new SqlCommand(sql, conn.sqlconn);
                SqlDataReader listar = cmd.ExecuteReader();

                while (listar.Read())
                {

                    Funcionario f = new Funcionario(listar.GetInt16(listar.GetOrdinal("Id_Funcionario")),
                    listar.GetString(listar.GetOrdinal("nome_f")),
                    listar.GetString(listar.GetOrdinal("login_f")),
                    listar.GetString(listar.GetOrdinal("senha_f")),
                    listar.GetString(listar.GetOrdinal("email_f")),
                    listar.GetDateTime(listar.GetOrdinal("data_Cadastro_Fun")),
                    listar.GetString(listar.GetOrdinal("telefone_f")));


                    lista.Add(f);

                }
                cmd.Dispose();
                conn.fecharConexao();


            }
            catch (Exception)
            {
                throw new Exception("Não foi possivel listar o Banco!!");
            }
            return lista;
        }
    }
}