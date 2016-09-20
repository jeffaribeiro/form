using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form435.ViewModel
{
    public class ViewModelForm435
    {

        private Model.Form435 _form435 = new Model.Form435();

        private List<Model.Form435Respostas> _form435Respostas = new List<Model.Form435Respostas>();

        public class Resposta
        {

            public int FORM435_RESPOSTAS_ID { get; set; }

            public Nullable<int> FORM_ID { get; set; }

            public Nullable<int> CATEGORIA_ID { get; set; }

            public string CODIGO_CATEGORIA { get; set; }

            public string DESCRICAO_CATEGORIA { get; set; }

            public string DETALHE_CATEGORIA
            {
                get
                {
                    return CODIGO_CATEGORIA + " - " + DESCRICAO_CATEGORIA;
                }
            }

            public Nullable<int> CATEGORIA_ID_PAI { get; set; }


            public string CODIGO_CATEGORIA_PAI { get; set; }

            public string DESCRICAO_CATEGORIA_PAI { get; set; }

            public string DETALHE_CATEGORIA_PAI
            {
                get
                {
                    return CODIGO_CATEGORIA_PAI + " - " + DESCRICAO_CATEGORIA_PAI;
                }
            }

            public Nullable<int> QUANTIDADE { get; set; }

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


            public Resposta()
            {

            }
        }


        public Model.Form435 form435
        {
            get
            {
                return _form435;
            }
            set
            {
                form435 = value;                
            }
        }

        //public List<Model.Form435Respostas> form435Respostas
        //{
        //    get
        //    {
        //        return _form435Respostas;
        //    }
        //    set
        //    {
        //        _form435Respostas = value;
        //    }
        //}


        //public List<Resposta> respostas = new List<Resposta>();



    }
}
