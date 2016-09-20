using Form435.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Form435.View
{
    public partial class DesviosCadastroAba02 : ContentPage
    {
        //private Model.Form435 desvioCorrente = new Model.Form435();
        //private bool novoRegistro = true;
        //private List<Model.Form435Categoria> listaCategorias = new List<Model.Form435Categoria>();
        //private List<ViewModelResposta> _listaRespostas = new List<ViewModelResposta>();

        public ViewModelResposta viewModelRespostas = new ViewModelResposta();

        //public List<ViewModelResposta> listaRespostas
        //{
        //    get { return _listaRespostas; }
        //    set
        //    {
        //        _listaRespostas = value;
        //        OnPropertyChanged();
        //    }
        //}
        


        //public Model.Form435 desvioCorrente
        //{
        //    get { return desvioCorrente; }
        //    set
        //    {
        //        desvioCorrente = value;
        //        OnPropertyChanged();
        //    }
        //}

        public DesviosCadastroAba02(Model.Form435 _desvio)
        {
            try
            {
                InitializeComponent();
                //desvioCorrente = _desvio;
                //BindingContext = this;
                BindingContext = viewModelRespostas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //protected override void OnAppearing()
        //{
        //    try
        //    {
        //        base.OnAppearing();
        //        if (desvioCorrente.FORM_ID > 0)
        //            novoRegistro = false;
        //        if (listaRespostas.Count < 1)
        //            MontaListaRespostasParaEdicao(novoRegistro);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        ////////private void MontaListaRespostasParaEdicao(bool novoRegistro)
        ////////{

        ////////    if (novoRegistro)
        ////////    {
        ////////        listaCategorias = new Controller.Form435Categoria().ObterTodos();
        ////////        foreach (var categoria in listaCategorias)
        ////////        {
        ////////            ViewModelResposta resposta = new ViewModelResposta();

        ////////            resposta.FORM_ID = 0;
        ////////            resposta.CATEGORIA_ID = categoria.CATEGORIA_ID;
        ////////            resposta.CODIGO_CATEGORIA = categoria.CODIGO_CATEGORIA;
        ////////            resposta.DESCRICAO_CATEGORIA = categoria.DESCRICAO_CATEGORIA;

        ////////            resposta.QUANTIDADE = 0;

        ////////            if (categoria.CATEGORIA_ID_PAI > 0)
        ////////            {
        ////////                Model.Form435Categoria categoriaPai = new Controller.Form435Categoria().ObterPorId(categoria.CATEGORIA_ID);
        ////////                resposta.CATEGORIA_ID_PAI = categoriaPai.CATEGORIA_ID;
        ////////                resposta.CODIGO_CATEGORIA_PAI = categoria.CODIGO_CATEGORIA;
        ////////                resposta.DESCRICAO_CATEGORIA_PAI = categoria.DESCRICAO_CATEGORIA;
        ////////            }
        ////////            else
        ////////            {
        ////////                resposta.CATEGORIA_ID_PAI = null;
        ////////                resposta.CODIGO_CATEGORIA_PAI = null;
        ////////                resposta.DESCRICAO_CATEGORIA_PAI = null;
        ////////            }

        ////////            listaRespostas.Add(resposta);                    
        ////////        }
        ////////    }
        //else
        //{
        //    listaRespostas = new Controller.Form435Respostas().ObterTodos();
        //    foreach (var categoria in listaCategorias)
        //    {
        //        Resposta resposta = new Resposta();

        //        resposta.FORM_ID = 0;
        //        resposta.CATEGORIA_ID = categoria.CATEGORIA_ID;
        //        resposta.CODIGO_CATEGORIA = categoria.CODIGO_CATEGORIA;
        //        resposta.DESCRICAO_CATEGORIA = categoria.DESCRICAO_CATEGORIA;

        //        resposta.QUANTIDADE = null;

        //        if (categoria.CATEGORIA_ID_PAI > 0)
        //        {
        //            Model.Form435Categoria categoriaPai = new Controller.Form435Categoria().ObterPorId(categoria.CATEGORIA_ID);
        //            resposta.CATEGORIA_ID_PAI = categoriaPai.CATEGORIA_ID;
        //            resposta.CODIGO_CATEGORIA_PAI = categoria.CODIGO_CATEGORIA;
        //            resposta.DESCRICAO_CATEGORIA_PAI = categoria.DESCRICAO_CATEGORIA;
        //        }
        //        else
        //        {
        //            resposta.CATEGORIA_ID_PAI = null;
        //            resposta.CODIGO_CATEGORIA_PAI = null;
        //            resposta.DESCRICAO_CATEGORIA_PAI = null;
        //        }

        //        listaRespostasEdicao.Add(resposta);
        //    }
        //}

        //////DesviosObservadosListView.ItemsSource = listaRespostas;

        ///}

        void AlterarQuantidade(object sender, ValueChangedEventArgs e)
        {

            //_stockItem.Quantity = (int)e.NewValue;

            //Debug.WriteLine(e.NewValue);

            //if (PropertyChanged != null)
            //    PropertyChanged(this, new PropertyChangedEventArgs("Quantity"));


            //var confirmacao = DisplayAlert("Valor alterado", e.NewValue.ToString(), "OK");



            ////try
            ////{
            ////    var itemSelecionado = (Model.Form435Categoria)e.SelectedItem;
            ////    var detalheItem = new CategoriasDetalhe(itemSelecionado);
            ////    Navigation.PushAsync(detalheItem, true);
            ////}
            ////catch (Exception ex)
            ////{
            ////    throw ex;
            ////}

        }

    }
}
