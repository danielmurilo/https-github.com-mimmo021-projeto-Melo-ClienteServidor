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
    public class DadosCliente : InterfaceCliente
    {
        private conexao conn = new conexao();
        //construtor
        public DadosCliente()
        {
            this.conn.abrirconexao();
        }


        public void cadastrarCliente(Cliente c)
        {
            try
            {
                string sql = "insert into Cliente(tipo, nome_Cli, nome_fantasia, razao_social, email_Cli, telefone_Cli, data_Cadastro_Cli, rua, bairro, cidade,complemento, uf, cpf, rg, cnpj) values(@tipo, @nome_Cli, @nome_fantasia, @razao_social, @email_Cli, @telefone_Cli, @data_Cadastro_Cli, @rua, @bairro, @cidade,@complemento, @uf, @cpf, @rg, @cnpj);";
                SqlCommand cadastrando = new SqlCommand(sql, conn.sqlconn);

                cadastrando.Parameters.AddWithValue("@tipo", c.Tipo);
                cadastrando.Parameters.AddWithValue("@nome_Cli", c.Nome);
                cadastrando.Parameters.AddWithValue("@nome_fantasia", c.NomeFantasia);
                cadastrando.Parameters.AddWithValue("@razao_social", c.RazaoSocial);
                cadastrando.Parameters.AddWithValue("@email_Cli", c.Email);
                cadastrando.Parameters.AddWithValue("@telefone_Cli", c.Telefone);
                cadastrando.Parameters.AddWithValue("@data_Cadastro_Cli", c.DataCadastro);
                cadastrando.Parameters.AddWithValue("@rua", c.Endereco.Rua);
                cadastrando.Parameters.AddWithValue("@bairro", c.Endereco.Bairro);
                cadastrando.Parameters.AddWithValue("@cidade", c.Endereco.Cidade);
                cadastrando.Parameters.AddWithValue("@complemeto", c.Endereco.Complemento);
                cadastrando.Parameters.AddWithValue("@uf", c.Endereco.Uf);
                cadastrando.Parameters.AddWithValue("@cpf", c.Cpf);
                cadastrando.Parameters.AddWithValue("@rg", c.Rg);
                cadastrando.Parameters.AddWithValue("@cnpj", c.Cnpj);


                conn.fecharConexao();
                conn.sqlconn.Dispose();
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel cadastrar Cliente no Banco!!");
            }
        }
        public void alterarCliente(Cliente c)
        {
            try
            {
                string sql = "update Cliente set tipo = @tipo, nome_Cli = @nome_Cli, nome_fantasia = @nome_fantasia, razao_social = @razao_social, email_Cli = @email_Cli, telefone_Cli = @telefone_Cli, data_Cadastro_Cli = @data_Cadastro_Cli, rua = @rua, bairro = @bairro, cidade = @cidade, uf = @uf, cpf = @cpf, rg = @rg, cnpj = @cnpj where Id_Cli =@Id_Cli;";

                SqlCommand update = new SqlCommand(sql, conn.sqlconn);
                update.Parameters.AddWithValue("@Id_Cli", c.Id_Cliente);
                update.Parameters.AddWithValue("@tipo",c.Tipo);
                update.Parameters.AddWithValue("@nome_Cli",c.Nome );
                update.Parameters.AddWithValue("@nome_fantasia",c.NomeFantasia );
                update.Parameters.AddWithValue("@razao_social",c.RazaoSocial);
                update.Parameters.AddWithValue("@email_Cli",c.Email);
                update.Parameters.AddWithValue("@telefone_Cli",c.Telefone);
                update.Parameters.AddWithValue("@data_Cadastro_Cli",c.DataCadastro);
                update.Parameters.AddWithValue("@rua", c.Endereco.Rua );
                update.Parameters.AddWithValue("@bairro", c.Endereco.Bairro );
                update.Parameters.AddWithValue("@cidade", c.Endereco.Cidade );
                update.Parameters.AddWithValue("@uf", c.Endereco.Uf);
                update.Parameters.AddWithValue("@cpf",c.Cpf );
                update.Parameters.AddWithValue("@rg",c.Rg );
                update.Parameters.AddWithValue("@cnpj", c.Cnpj);
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
        public void deletarCliente(Cliente c)
        {
            try
            {
                string sql = "delete from Cliente where Id_Cli = @Id_Cli";
                SqlCommand deletar = new SqlCommand(sql, conn.sqlconn);
                deletar.Parameters.AddWithValue("@Id_Cli", c.Id_Cliente);

                conn.sqlconn.Dispose();
                conn.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw new Exception("Não foi possivel deletar!!");
            }
        }
        public List<Cliente> listarCliente()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                string sql = "select * from Cliente ";
                SqlCommand cmd = new SqlCommand(sql, conn.sqlconn);
                SqlDataReader listar = cmd.ExecuteReader();

                while (listar.Read())
                {
            
                    Cliente c = new Cliente(listar.GetInt16(listar.GetOrdinal("Id_Cli")),
                    listar.GetString(listar.GetOrdinal("tipo")),
                    listar.GetString(listar.GetOrdinal("nome_Cli")),
                    listar.GetString(listar.GetOrdinal("nome_fantasia")),
                    listar.GetString(listar.GetOrdinal("razao_social")),
                    listar.GetString(listar.GetOrdinal("email_Cli")),
                    listar.GetString(listar.GetOrdinal("telefone_Cli")),
                    listar.GetDateTime(listar.GetOrdinal("data_Cadastro_Cli")),
                    listar.GetString(listar.GetOrdinal("rua")),
                    listar.GetString(listar.GetOrdinal("bairro")),
                    listar.GetString(listar.GetOrdinal("cidade")),
                    listar.GetString(listar.GetOrdinal("Uf")),
                    listar.GetString(listar.GetOrdinal("complemento")),
                    listar.GetString(listar.GetOrdinal("cpf")),
                    listar.GetString(listar.GetOrdinal("rg")),
                    listar.GetString(listar.GetOrdinal("cnpj")));
                    
                    lista.Add(c);

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
