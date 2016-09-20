using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form435
{
    public class ViewModelResposta
    {
        private List<Model.Form435Categoria> listaCategorias = new List<Model.Form435Categoria>();

        public ObservableCollection<Resposta> Respostas
        {
            get;
            set;
        }

        public ViewModelResposta()
        {
            listaCategorias = new Controller.Form435Categoria().ObterTodos();
            Respostas = new ObservableCollection<Resposta>();
            foreach (var categoria in listaCategorias)
            {
                Resposta resposta = new Resposta();

                resposta.FORM_ID = 0;
                resposta.CATEGORIA_ID = categoria.CATEGORIA_ID;
                resposta.CODIGO_CATEGORIA = categoria.CODIGO_CATEGORIA;
                resposta.DESCRICAO_CATEGORIA = categoria.DESCRICAO_CATEGORIA;

                resposta.QUANTIDADE = 0;

                if (categoria.CATEGORIA_ID_PAI > 0)
                {
                    Model.Form435Categoria categoriaPai = new Controller.Form435Categoria().ObterPorId(categoria.CATEGORIA_ID_PAI.Value);
                    resposta.CATEGORIA_ID_PAI = categoriaPai.CATEGORIA_ID;
                    resposta.CODIGO_CATEGORIA_PAI = categoria.CODIGO_CATEGORIA;
                    resposta.DESCRICAO_CATEGORIA_PAI = categoria.DESCRICAO_CATEGORIA;
                }
                else
                {
                    resposta.CATEGORIA_ID_PAI = null;
                    resposta.CODIGO_CATEGORIA_PAI = null;
                    resposta.DESCRICAO_CATEGORIA_PAI = null;
                }

                Respostas.Add(resposta);
            }
        }

        public class Resposta  : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private int _FORM435_RESPOSTAS_ID;
            private Nullable<int> _FORM_ID;
            private Nullable<int> _CATEGORIA_ID;
            private string _CODIGO_CATEGORIA;
            private string _DESCRICAO_CATEGORIA;
            private Nullable<int> _CATEGORIA_ID_PAI;
            private string _CODIGO_CATEGORIA_PAI;            
            private Nullable<int> _QUANTIDADE;


            public int FORM435_RESPOSTAS_ID
            {
                get
                {
                    return _FORM435_RESPOSTAS_ID;
                }
                set
                {
                    _FORM435_RESPOSTAS_ID = value;
                    this.Notify("FORM435_RESPOSTAS_ID");
                }
            }

            public Nullable<int> FORM_ID
            {
                get
                {
                    return _FORM_ID;
                }
                set
                {
                    _FORM_ID = value;
                    this.Notify("FORM_ID");
                }
            }

            public Nullable<int> CATEGORIA_ID
            {
                get
                {
                    return _CATEGORIA_ID;
                }
                set
                {
                    _CATEGORIA_ID = value;
                    this.Notify("CATEGORIA_ID");
                }
            }

            public string CODIGO_CATEGORIA
            {
                get
                {
                    return _CODIGO_CATEGORIA;
                }
                set
                {
                    _CODIGO_CATEGORIA = value;
                    this.Notify("CODIGO_CATEGORIA");
                }
            }

            public string DESCRICAO_CATEGORIA
            {
                get
                {
                    return _DESCRICAO_CATEGORIA;
                }
                set
                {
                    _DESCRICAO_CATEGORIA = value;
                    this.Notify("DESCRICAO_CATEGORIA");
                }
            }

            public string DETALHE_CATEGORIA
            {
                get
                {
                    if (DESCRICAO_CATEGORIA != null)
                        return CODIGO_CATEGORIA + " - " + DESCRICAO_CATEGORIA;
                    else
                        return null;
                }
            }

            public Nullable<int> CATEGORIA_ID_PAI
            {
                get
                {
                    return _CATEGORIA_ID_PAI;
                }
                set
                {
                    _CATEGORIA_ID_PAI = value;
                    this.Notify("CATEGORIA_ID_PAI");
                }
            }


            public string CODIGO_CATEGORIA_PAI
            {
                get
                {
                    return _CODIGO_CATEGORIA_PAI;
                }
                set
                {
                    _CODIGO_CATEGORIA_PAI = value;
                    this.Notify("CODIGO_CATEGORIA_PAI");
                }
            }

            public string DESCRICAO_CATEGORIA_PAI { get; set; }

            public string DETALHE_CATEGORIA_PAI
            {
                get
                {
                    if (DESCRICAO_CATEGORIA_PAI != null)
                        return CODIGO_CATEGORIA_PAI + " - " + DESCRICAO_CATEGORIA_PAI;
                    else
                        return null;
                }
            }

            public Nullable<int> QUANTIDADE
            {
                get
                {
                    return _QUANTIDADE;
                }
                set
                {
                    _QUANTIDADE = value;
                    this.Notify("QUANTIDADE");
                }
            }

            public bool EH_CATEGORIA_FILHA
            {
                get
                {
                    if (CATEGORIA_ID_PAI == null)
                        return false;
                    else
                        return true;
                }
            }

            public bool EH_CATEGORIA_PAI
            {
                get
                {
                    if (CATEGORIA_ID_PAI == null)
                        return true;
                    else
                        return false;
                }
            }

            private void Notify(string propertyName)
            {
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        
    }
}
