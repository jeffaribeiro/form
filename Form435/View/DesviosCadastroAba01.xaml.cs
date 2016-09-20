using Form435.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Form435.View
{
    public partial class DesviosCadastroAba01 : ContentPage
    {

        public Model.Form435 desvioCorrente
        {
            get { return (Model.Form435)BindingContext; }
            set
            {
                BindingContext = value;
                OnPropertyChanged();
            }
        }

        public DesviosCadastroAba01(Model.Form435 _desvio)
        {
            try
            {
                InitializeComponent();
                desvioCorrente = _desvio;
                //BindingContext = this;
                if (desvioCorrente.FORM_ID == 0)
                    Title = "Novo Desvio";
                else
                    Title = String.Format("Desvio de ID {0}", desvioCorrente.FORM_ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
    }

}
