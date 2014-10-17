using ProjetoEasyImoveis.classesbasicas;
using ProjetoEasyImoveis.classesdados;
using ProjetoEasyImoveis.classesinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesnegocio
{
    public class VendaNegocios
    {

        InterfaceVenda dv = new DadosVenda();
        //crud Venda
        public void cadastrarVenda(Venda v)
        {
            
            dv.cadastrarVenda(v);
        }
        public void alterarVenda(Venda v)
        {
            
            dv.alterarVenda(v);
        }
        public void deletarVenda(Venda v)
        {
           
            dv.deletarVenda(v);
        }
        public List<Venda> listarVenda()
        {
           
            return dv.listarVenda();
        }

    }
}