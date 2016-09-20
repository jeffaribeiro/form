using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;

namespace Form435.Model
{
    [Table("Form435Categoria")]
    public class Form435Categoria
    {
        public Form435Categoria()
        {
        }

        public Form435Categoria(int CATEGORIA_ID, string CODIGO_CATEGORIA, string DESCRICAO_CATEGORIA, string FLAG_ATIVO, Nullable<int> CATEGORIA_ID_PAI, Nullable<System.DateTime> DAT_INCLUSAO, string USUARIO_INCLUSAO, Nullable<System.DateTime> DAT_EXCLUSAO, string USUARIO_EXCLUSAO, Nullable<int> NUM_REVISAO)
        {
            this.CATEGORIA_ID = CATEGORIA_ID;
            this.CODIGO_CATEGORIA = CODIGO_CATEGORIA;
            this.DESCRICAO_CATEGORIA = DESCRICAO_CATEGORIA;
            this.FLAG_ATIVO = FLAG_ATIVO;
            this.CATEGORIA_ID_PAI = CATEGORIA_ID_PAI;
            this.DAT_INCLUSAO = DAT_INCLUSAO;
            this.USUARIO_INCLUSAO = USUARIO_INCLUSAO;
            this.DAT_EXCLUSAO = DAT_EXCLUSAO;
            this.USUARIO_EXCLUSAO = USUARIO_EXCLUSAO;
            this.NUM_REVISAO = NUM_REVISAO;
        }

        [PrimaryKey]
        public int CATEGORIA_ID { get; set; }
        public string CODIGO_CATEGORIA { get; set; }
        public string DESCRICAO_CATEGORIA { get; set; }
        public string FLAG_ATIVO { get; set; }
        public Nullable<int> CATEGORIA_ID_PAI { get; set; }
        public Nullable<System.DateTime> DAT_INCLUSAO { get; set; }
        public string USUARIO_INCLUSAO { get; set; }
        public Nullable<System.DateTime> DAT_EXCLUSAO { get; set; }
        public string USUARIO_EXCLUSAO { get; set; }
        public Nullable<int> NUM_REVISAO { get; set; }
        public string DETALHE_CATEGORIA
        {
            get
            {
                return CODIGO_CATEGORIA + " - " + DESCRICAO_CATEGORIA;
            }
        }

    }
}
