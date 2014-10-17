using ProjetoEasyImoveis.classesbasicas;
using ProjetoEasyImoveis.classesdados;
using ProjetoEasyImoveis.classesinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesnegocio
{
    public class ImovelNegocios
    {
        private InterfaceImovel id = new DadosImovel();
        //crud Imovel
        public void cadastrarImovel(Imovel i)
        {
            
            id.cadastrarImovel(i);
        }
        public void alterarImovel(Imovel i)
        {
           
            id.alterarImovel(i);
        }
        public void deletarImovel(Imovel i)
        {
           
            id.deletarImovel(i);
        }
        public List<Imovel> listarImovel()
        {
            
            return id.listarImovel();
        }

    }
}