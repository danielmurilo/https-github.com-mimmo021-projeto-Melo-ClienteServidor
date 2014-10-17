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
    public class DadosProprietario: InterfaceProprietario
    {
         private conexao conn = new conexao();

        public void cadastrarProprietario(Proprietario p)
        {
            try
            {
            string sql = "insert into Proprietario(nome_p,email_p, telefone_p, data_Cadastro_p, rua, complemento,bairro, cidade, uf) values(@nome_p,@email_p, @telefone_p, @data_Cadastro_p, @rua, @complemento,@bairro, @cidade, @uf);";
                SqlCommand cadastrando = new SqlCommand(sql, conn.sqlconn);

                cadastrando.Parameters.AddWithValue("@nome_p", p.Nome );
                cadastrando.Parameters.AddWithValue("@email_p",p.Email );
                cadastrando.Parameters.AddWithValue("@telefone_p",p.Telefone );
                cadastrando.Parameters.AddWithValue("@data_Cadastro_p",p.DataCadastro );
                cadastrando.Parameters.AddWithValue("@rua",p.Endereco.Rua ); 
                cadastrando.Parameters.AddWithValue("@complemeto", p.Endereco.Complemento);
                cadastrando.Parameters.AddWithValue("@bairro", p.Endereco.Bairro);
                cadastrando.Parameters.AddWithValue("@cidade", p.Endereco.Cidade);
                cadastrando.Parameters.AddWithValue("@uf", p.Endereco.Uf);
               


                conn.fecharConexao();
                conn.sqlconn.Dispose();
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel cadastrar Cliente no Banco!!");
            }
}
        public void alterarProprietario(Proprietario p)
        {
            throw new NotImplementedException();
        }

        public void deletarProprietario(Proprietario p)
        {
            throw new NotImplementedException();
        }

        public List<Proprietario> listarProprietario()
        {
            throw new NotImplementedException();
        }
    }
}