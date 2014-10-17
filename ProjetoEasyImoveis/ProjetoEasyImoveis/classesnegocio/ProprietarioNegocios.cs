using ProjetoEasyImoveis.classesbasicas;
using ProjetoEasyImoveis.classesdados;
using ProjetoEasyImoveis.classesinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEasyImoveis.classesnegocio
{
    public class ProprietarioNegocios
    {

        InterfaceProprietario dp = new DadosProprietario();
        //crud Proprietario
        public void cadastrarProprietario(Proprietario p)
        {
            
            dp.cadastrarProprietario(p);
        }
        public void alterarProprietario(Proprietario p)
        {
           
            dp.alterarProprietario(p);
        }
        public void deletarProprietario(Proprietario p)
        {
           
            dp.deletarProprietario(p);
        }
        public List<Proprietario> listarProprietario()
        {
            
            return dp.listarProprietario();
        }
    }
}