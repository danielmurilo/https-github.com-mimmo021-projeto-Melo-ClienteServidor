using ProjetoEasyImoveis.classesbasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEasyImoveis.classesinterface
{
    interface InterfaceProprietario
    {
        //crud Proprietario
        void cadastrarProprietario(Proprietario p);
        void alterarProprietario(Proprietario p);
        void deletarProprietario(Proprietario p);
        List<Proprietario> listarProprietario();
        
    }
}
