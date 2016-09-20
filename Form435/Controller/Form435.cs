using Form435.Database;
using System.Linq;

namespace Form435.Controller
{
    public class Form435 : RepositorioGenerico<Model.Form435>
    {
        public Model.Form435 ObterPorId(int id)
        {
            return conexao.Table<Model.Form435>().
                FirstOrDefault(item => item.FORM_ID == id);
        }
    }
}
