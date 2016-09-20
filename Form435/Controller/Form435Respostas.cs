using Form435.Database;
using System.Collections.Generic;
using System.Linq;

namespace Form435.Controller
{
    public class Form435Respostas : RepositorioGenerico<Model.Form435Respostas>
    {
        public Model.Form435Respostas ObterPorId(int id)
        {
            return conexao.Table<Model.Form435Respostas>().
                FirstOrDefault(item => item.FORM435_RESPOSTAS_ID == id);
        }

        public List<Model.Form435Respostas> ObterPorForm435(int id)
        {
            return conexao.Table<Model.Form435Respostas>().
                Where(itens => itens.FORM_ID == id).ToList();
        }


    }
}
