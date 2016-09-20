using Form435.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Form435.View
{

    public partial class RegistrarUsuario : ContentPage
    {
        private string site = "http://localhost/";

        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private async Task<String> buscarPorCpf()
        {
            try
            {

                //string url = site + "api/OF_VW_FUNCIONARIO_FOLHA/?cpf=13905893746";

                string url = site + "api/OF_VW_FUNCIONARIO_FOLHA/";

                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected async void RegistraUsuario(object sender, EventArgs e)
        {
            try
            {
                //string url = site + "api/OF_VW_FUNCIONARIO_FOLHA/?cpf=13905893746";

                //string json = @"{ 'FUNCIONARIO':33609.0,'ID_PESSOA':127730.0,'NOME_COMPLETO':'Jefferson Augusto Ribeiro','APELIDO':null,'DATA_NASCIMENTO':'1991-08-28T00:00:00','SEXO':'M','DESCRICAO_GRAU_INSTRUCAO':'Superior Incompleto','DESCRICAO_ESTADO_CIVIL':'Solteiro','CPF':'13905893746','RG_RNE':'242015956','CENTRO_CUSTO_FUNCIONARIO':'3300170024','DATA_ADMISSAO':'2015-01-12T00:00:00','DESCRICAO_TIPO_ADMISSAO':'Empregado com emprego anterior','CATEGORIA':'Administrativo','NOME_EMPRESA':'WILSON SONS OFFSHORE SA','MATRICULA_FUNCIONARIO':200,'COD_EMPRESA':'103','COD_DEPARTAMENTO':'720','NOME_DEPARTAMENTO':'OFFSHORE','COD_SECAO':'210','NOME_SECAO':'TI MATRIZ','SITUACAO_FUNCIONARIO':'Normal','NOME_PAI':'Aldeir Jose Ribeiro                                          ','NOME_MAE':'Sandra Regina Augusto Ribeiro                                ','PROFILE':12.0,'GRAT_DESVIO':'1,00'}";
                OfVwFuncionarioFolha funcionario = JsonConvert.DeserializeObject<OfVwFuncionarioFolha>(buscarPorCpf().Result);
                await Navigation.PushAsync(new Principal());
            }
            catch (Exception ex)
            {
                var erro = DisplayAlert("Erro", "Erro ao recuperar CPF: " + ex.Message.ToString(), "OK");
                //throw ex;
            }
        }
    }
}
