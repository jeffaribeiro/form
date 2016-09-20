using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Form435.View
{
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        protected async void IrParaCadastro(object sender, EventArgs e)
        {
            //var selecao = await DisplayActionSheet("Selecione o tipo de desvio:", "Cancel", null, "CAC - Cartão de Auditoria Comportamental", "CID - Cartão de Identificação de Desvios", "IPS - Índice de Prática Insegura");
            //var confirmacao = DisplayAlert("Confirmação", "Selecionado " + selecao, "OK");
            await Navigation.PushAsync(new DesviosCadastro());
        }

        protected async void IrParaListagem(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DesviosListView());
        }

        protected async void VerCategorias(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriasListView());
        }
    }
}
