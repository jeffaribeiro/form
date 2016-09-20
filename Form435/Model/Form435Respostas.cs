using System;
using SQLite.Net.Attributes;

namespace Form435.Model
{
    [Table("Form435Respostas")]
    public class Form435Respostas
    {
        public Form435Respostas()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int FORM435_RESPOSTAS_ID { get; set; }
        public Nullable<int> CATEGORIA_ID { get; set; }
        public Nullable<int> QUANTIDADE { get; set; }
        public Nullable<int> FORM_ID { get; set; }

        public int FORM435 { get; set; }
        public int FORM435_CATEGORIA { get; set; }
    }
}
