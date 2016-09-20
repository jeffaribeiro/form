using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Form435.View
{
    public partial class CategoriasDetalhe : ContentPage
    {

        public Model.Form435Categoria Categoria
        {
            get { return (Model.Form435Categoria)BindingContext; }
            set
            {
                BindingContext = value;
                OnPropertyChanged();
            }
        }

        public CategoriasDetalhe(Model.Form435Categoria categoria)
        {

            InitializeComponent();

            Categoria = categoria;

            NavigationPage.SetHasNavigationBar(this, true);

            if (Categoria.CATEGORIA_ID == 0)
                Title = "Nova Categoria";
            else
                Title = String.Format("Categoria de ID {0}", Categoria.CATEGORIA_ID);

        }


        public bool Validar()
        {
            return true;
        }

        public void Salvar()
        {
            if (!Validar())
                return;
            new Controller.Form435Categoria().SalvarOuAtualizar(Categoria);
        }

    }
}
