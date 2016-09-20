using Form435.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Form435.View
{
    public partial class DesviosCadastro : TabbedPage
    {

        public Model.Form435 desvio
        {
            get
            {                
                return (Model.Form435)BindingContext;
            }
            set
            {
                BindingContext = value;
                OnPropertyChanged();
            }
        }

        public DesviosCadastro()
        {
            try
            {
                InitializeComponent();
                BindingContext = new Model.Form435();
                DesenhaToolbar();
                DesenhaTabs();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DesviosCadastro(Model.Form435 _desvio)
        {
            InitializeComponent();
            DesenhaToolbar();
            DesenhaTabs();
            desvio = _desvio;
        }

        private void DesenhaToolbar()
        {
            ToolbarItem tbiSalvar = new ToolbarItem();
            tbiSalvar.Text = "Salvar";
            //tbiSalvar.Icon = "plus.png";
            tbiSalvar.Clicked += salvarClick;
            this.ToolbarItems.Add(tbiSalvar);

            ToolbarItem tbiExcluir = new ToolbarItem();
            tbiExcluir.Text = "Excluir";
            //tbiExcluir.Icon = "plus.png";
            tbiExcluir.Clicked += excluirClick;
            this.ToolbarItems.Add(tbiExcluir);
        }

        private void DesenhaTabs()
        {
            this.Children.Add(new DesviosCadastroAba01(desvio));
            this.Children.Add(new DesviosCadastroAba02(desvio));
            this.Children.Add(new DesviosCadastroAba03(desvio));
        }

        private void SalvarRespostas()
        {
            var abaRespostas = (DesviosCadastroAba02)this.Children[1].BindingContext;
            var listaRespostas = abaRespostas.viewModelRespostas.Respostas.ToList();
            foreach (var item in listaRespostas)
            {
                Model.Form435Respostas resposta = new Model.Form435Respostas();

                resposta.CATEGORIA_ID = item.CATEGORIA_ID;
                resposta.FORM435_CATEGORIA = item.CATEGORIA_ID.Value;
                resposta.FORM_ID = item.FORM_ID;
                resposta.QUANTIDADE = item.QUANTIDADE;

                if (item.FORM_ID > 0)
                    new Controller.Form435Respostas().Alterar(resposta);
                else
                {
                    resposta.FORM_ID = desvio.FORM_ID;
                    new Controller.Form435Respostas().Inserir(resposta);
                }
            }
        }

        void salvarClick(object sender, EventArgs e)
        {
            try
            {
                if (desvio.FORM_ID > 0)
                    new Controller.Form435().Alterar(desvio);                    
                else
                    new Controller.Form435().Inserir(desvio);

                SalvarRespostas();
                var confirmacao = DisplayAlert("Salvo com sucesso", "Registro de desvio salvo com sucesso!", "OK");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async void excluirClick(object sender, EventArgs e)
        {
            try
            {
                var excluir = await DisplayAlert("Confirmação de exclusão", "Deseja realmente excluir?", "Sim", "Não");
                if (excluir)
                {
                    if (desvio.FORM_ID > 0)
                    {
                        new Controller.Form435().Apagar(desvio);
                        var confirmacao = DisplayAlert("Excluído com sucesso", "Registro de desvio excluído com sucesso!", "OK");
                        await Navigation.PopAsync();
                    }
                    else
                    {
                        var confirmacao = DisplayAlert("Erro na exclusão", "Não há um registro salvo para ser excluído!", "OK");
                    }
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
