using ProjetoEasyImoveis.classesbasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEasyImoveis.classesinterface
{
    interface InterfaceCliente
    {
        //crud cliente
        void cadastrarCliente(Cliente c);
        void alterarCliente(Cliente c);
        void deletarCliente(Cliente c);
        List<Cliente> listarCliente();
        
    }
}
