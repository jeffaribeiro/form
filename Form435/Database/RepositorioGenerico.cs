using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Form435.Database
{
    public abstract class RepositorioGenerico<T> : IDisposable, IRespositorio<T> where T : class
    {
        protected SQLiteConnection conexao = null;
        
        public RepositorioGenerico()
        {
            conexao = BancoSQLite.conexao;
        }

        public void Alterar(object registro)
        {
            conexao.Update(registro);            
        }

        public void Apagar(object registro)
        {
            conexao.Delete(registro);
        }

        public void SalvarOuAtualizar(object registro)
        {
            conexao.InsertOrReplace(registro);
        }

        public void Inserir(object registro)
        {
            conexao.Insert(registro);
        }

        //public object ObterPorId(int id)
        //{
        //    return conexao.Table<T>().FirstOrDefault(c => c. == id);
        //}

        public List<T> ObterTodos()
        {
            return conexao.Table<T>().ToList();
        }
        
        public void Dispose()
        {
            this.Dispose();
        }
    }
}
