using ProjetoEasyImoveis.classesbasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEasyImoveis.classesinterface
{
    interface InterfaceImovel
    {
        //crud Imovel
        void cadastrarImovel(Imovel i);
        void alterarImovel(Imovel i);
        void deletarImovel(Imovel i);
        List<Imovel> listarImovel();
        
    }
}
