using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Form435.View
{
    public partial class CategoriasListView : ContentPage
    {
        private List<Model.Form435Categoria> _listaCategorias = new List<Model.Form435Categoria>();

        public List<Model.Form435Categoria> listaCategorias
        {
            get { return _listaCategorias; }
            set
            {
                if (_listaCategorias == value)
                    return;
                _listaCategorias = value;
                OnPropertyChanged();
            }
        }

        public CategoriasListView()
        {
            try
            {
                InitializeComponent();
                NavigationPage.SetHasNavigationBar(this, true);
                BindingContext = this;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                listaCategorias = new Controller.Form435Categoria().ObterTodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void OnAdd(object sender, EventArgs e)
        {
            try
            {
                var novoItem = new Model.Form435Categoria();
                var insereItem = new CategoriasDetalhe(novoItem);
                Navigation.PushAsync(insereItem, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public void OnSelect(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var itemSelecionado = (Model.Form435Categoria)e.SelectedItem;
                var detalheItem = new CategoriasDetalhe(itemSelecionado);
                Navigation.PushAsync(detalheItem, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
