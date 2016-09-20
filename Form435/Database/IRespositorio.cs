using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form435.Database
{
    interface IRespositorio<T> where T : class
    {
        void Inserir(object registro);
        void Alterar(object registro);
        void SalvarOuAtualizar(object registro);
        void Apagar(object registro);
        //object ObterPorId(int id);
        List<T> ObterTodos();        
    }
}
