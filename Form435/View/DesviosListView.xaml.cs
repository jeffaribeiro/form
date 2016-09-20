using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Form435.View
{
    public partial class DesviosListView : ContentPage
    {
        private List<Model.Form435> _listaDesvios = new List<Model.Form435>();

        public List<Model.Form435> listaDesvios
        {
            get { return _listaDesvios; }
            set
            {
                if (_listaDesvios == value)
                    return;
                _listaDesvios = value;
                OnPropertyChanged();
            }
        }

        public DesviosListView()
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
                listaDesvios = new Controller.Form435().ObterTodos();
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
                var itemSelecionado = (Model.Form435)e.SelectedItem;
                var detalheItem = new DesviosCadastro(itemSelecionado);
                Navigation.PushAsync(detalheItem, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
