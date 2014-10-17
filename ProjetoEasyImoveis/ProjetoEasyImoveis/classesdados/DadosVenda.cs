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
    public class DadosVenda: InterfaceVenda
    {
        private conexao conn = new conexao();

        public void cadastrarVenda(Venda v)
        {
            throw new NotImplementedException();
        }

        public void alterarVenda(Venda v)
        {
            throw new NotImplementedException();
        }

        public void deletarVenda(Venda v)
        {
            throw new NotImplementedException();
        }

        public List<Venda> listarVenda()
        {
            throw new NotImplementedException();
        }
    }
}