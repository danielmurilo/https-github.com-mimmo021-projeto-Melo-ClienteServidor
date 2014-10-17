using ProjetoEasyImoveis.classesbasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEasyImoveis.classesinterface
{
    interface InterfaceVenda
    {
        //crud Venda
        void cadastrarVenda(Venda v);
        void alterarVenda(Venda v);
        void deletarVenda(Venda v);
        List<Venda> listarVenda();
        
    }
}
