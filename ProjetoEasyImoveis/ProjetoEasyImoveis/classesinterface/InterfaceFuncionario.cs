using ProjetoEasyImoveis.classesbasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEasyImoveis.classesinterface
{
    interface InterfaceFuncionario
    {
        //crud Funcionario
        void cadastrarFuncionario(Funcionario f);

        void alterarFuncionario(Funcionario f);

        void deletarFuncionario(Funcionario f);

        List<Funcionario> listarFuncionario();
       
    }
}
