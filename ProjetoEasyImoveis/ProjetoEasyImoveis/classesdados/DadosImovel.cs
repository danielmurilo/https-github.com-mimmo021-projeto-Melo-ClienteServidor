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
    public class DadosImovel: InterfaceImovel
    {
        private conexao conn = new conexao();

        public void cadastrarImovel(Imovel i)
        {
            throw new NotImplementedException();
        }

        public void alterarImovel(Imovel i)
        {
            throw new NotImplementedException();
        }

        public void deletarImovel(Imovel i)
        {
            throw new NotImplementedException();
        }

        public List<Imovel> listarImovel()
        {
            throw new NotImplementedException();
        }

      
        

    }
}