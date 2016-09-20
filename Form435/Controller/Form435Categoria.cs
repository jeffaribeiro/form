using Form435.Database;
using System.Linq;

namespace Form435.Controller
{
    public class Form435Categoria : RepositorioGenerico<Model.Form435Categoria>
    {

        public Model.Form435Categoria ObterPorId(int id)
        {
            return conexao.Table<Model.Form435Categoria>().
                FirstOrDefault(item => item.CATEGORIA_ID == id);
        }

    }
}
