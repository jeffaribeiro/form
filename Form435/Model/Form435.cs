using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;

namespace Form435.Model
{
    [Table("Form435")]
    public class Form435
    {
        public Form435()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int FORM_ID { get; set; }
        public string FLAG_TIPO { get; set; }
        public Nullable<System.DateTime> DAT_INICIO { get; set; }
        public Nullable<System.DateTime> DAT_TERMINO { get; set; }
        public Nullable<int> NUM_PESSOAS_OBSERVADAS { get; set; }
        public string TIPO_OBSERVACAO { get; set; }
        public string DSC_DESVIOS { get; set; }
        public string ACAO_RECOMENDACAO { get; set; }
        public string TIPO_ACAO_RECOMENDACAO { get; set; }
        public string RECONHECIMENTO_TRAB_SEGURO { get; set; }
        public string OBSERVACOES { get; set; }
        public string IDENTIFICACAO { get; set; }
        public string NOM_AUDITOR { get; set; }
        public string SETOR_FUNCAO { get; set; }
        public Nullable<int> EMB_ID { get; set; }
        public string LOCALIDADE { get; set; }
        public Nullable<System.DateTime> DAT_CADASTRO { get; set; }
        public Nullable<System.DateTime> DAT_SINCRONISMO { get; set; }
        public Nullable<int> NUM_REVISAO { get; set; }
    }
}
