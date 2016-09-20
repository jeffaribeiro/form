using System;
using SQLite.Net.Attributes;

namespace Form435.Model
{
    public class OfVwFuncionarioFolha
    {

        public OfVwFuncionarioFolha()
        {

        }
        [PrimaryKey]
        public decimal FUNCIONARIO { get; set; }
        public decimal ID_PESSOA { get; set; }
        public string NOME_COMPLETO { get; set; }
        public string APELIDO { get; set; }
        public System.DateTime DATA_NASCIMENTO { get; set; }
        public string SEXO { get; set; }
        public string DESCRICAO_GRAU_INSTRUCAO { get; set; }
        public string DESCRICAO_ESTADO_CIVIL { get; set; }
        public string CPF { get; set; }
        public string RG_RNE { get; set; }
        public string CENTRO_CUSTO_FUNCIONARIO { get; set; }
        public System.DateTime DATA_ADMISSAO { get; set; }
        public string DESCRICAO_TIPO_ADMISSAO { get; set; }
        public string CATEGORIA { get; set; }
        public string NOME_EMPRESA { get; set; }
        public int MATRICULA_FUNCIONARIO { get; set; }
        public string COD_EMPRESA { get; set; }
        public string COD_DEPARTAMENTO { get; set; }
        public string NOME_DEPARTAMENTO { get; set; }
        public string COD_SECAO { get; set; }
        public string NOME_SECAO { get; set; }
        public string SITUACAO_FUNCIONARIO { get; set; }
        public string NOME_PAI { get; set; }
        public string NOME_MAE { get; set; }
        public Nullable<decimal> PROFILE { get; set; }
        public string GRAT_DESVIO { get; set; }
    }
}
