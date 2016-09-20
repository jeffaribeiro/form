using System;
using SQLite.Net;
using System.IO;
using Xamarin.Forms;


namespace Form435.Database
{
    public static class BancoSQLite
    {

        public static SQLiteConnection conexao = ConectaBd();

        public static SQLiteConnection ConectaBd()
        {
            try
            {
                var config = DependencyService.Get<IConfig>();
                if (config.ExisteBanco) // caso exista o arquivo .db3 criado, efetua-se a conexão com o BD
                {
                    SQLiteConnection con = new SQLiteConnection(config.Plataforma, config.ArquivoBd);
                    return con;
                }                    
                else // caso não exista o arquivo .db3 criado, cria-se o arquivo, efetua-se a conexão com o BD, cria-se as tabelas e insere-se os registros básicos
                {
                    SQLiteConnection con = new SQLiteConnection(config.Plataforma, config.ArquivoBd);
                    CriarTabelas(con);                    
                    return con;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar banco de dados do aplicativo! Mensagem de erro: " + ex.Message.ToString());
            }

        }

        private static void CriarTabelas(SQLiteConnection con)
        {
            con.CreateTable<Model.Form435>();
            con.CreateTable<Model.Form435Categoria>();
            con.CreateTable<Model.Form435Respostas>();
            con.CreateTable<Model.OfVwFuncionarioFolha>();
            CarregarDados(con);
        }


        private static void CarregarDados(SQLiteConnection con)
        {
            try
            {
                //Controller.Form435Categoria categoria = new Controller.Form435Categoria();
                Model.Form435Categoria A = new Model.Form435Categoria(1, "A", "Reação das Pessoas", "S", null, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria A01 = new Model.Form435Categoria(2, "A01", "Mudando de posição", "S", 1, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria A02 = new Model.Form435Categoria(3, "A02", "Parando o serviço", "S", 1, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria A03 = new Model.Form435Categoria(4, "A03", "Ajustando o EPI", "S", 1, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria A04 = new Model.Form435Categoria(5, "A04", "Adequando o serviço", "S", 1, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B = new Model.Form435Categoria(6, "B", "Posição das Pessoas", "S", null, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B01 = new Model.Form435Categoria(7, "B01", "Risco de Bater contra/ser atingido por", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B02 = new Model.Form435Categoria(8, "B02", "Risco de Ficar preso", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B03 = new Model.Form435Categoria(9, "B03", "Risco de queda", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B04 = new Model.Form435Categoria(10, "B04", "Risco de queimadura", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B05 = new Model.Form435Categoria(11, "B05", "Risco de choque elétrico", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B06 = new Model.Form435Categoria(12, "B06", "Risco de inalar contaminantes (ex.: respirar gases tóxicos, fumos, etc))", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B07 = new Model.Form435Categoria(13, "B07", "Risco de absorver contaminantes (ex.: contato com ácido na pele, etc.)", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B08 = new Model.Form435Categoria(14, "B08", "Risco de Ingerir contaminantes", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B09 = new Model.Form435Categoria(15, "B09", "Postura inadequada", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria B10 = new Model.Form435Categoria(16, "B10", "Esforço inadequado", "S", 6, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria C = new Model.Form435Categoria(17, "C", "EPIs", "S", null, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria C01 = new Model.Form435Categoria(18, "C01", "Cabeça", "S", 16, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria C02 = new Model.Form435Categoria(19, "C02", "Sistema respiratório", "S", 16, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria C03 = new Model.Form435Categoria(20, "C03", "Olhos e rosto", "S", 16, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria C04 = new Model.Form435Categoria(21, "C04", "Ouvidos", "S", 16, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria C05 = new Model.Form435Categoria(22, "C05", "Mãos e braços", "S", 16, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria C06 = new Model.Form435Categoria(23, "C06", "Tronco", "S", 16, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria C07 = new Model.Form435Categoria(24, "C07", "Pés e pernas", "S", 16, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria D = new Model.Form435Categoria(25, "D", "Ferramentas e Equipamentos", "S", null, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria D01 = new Model.Form435Categoria(26, "D01", "Impróprias para o serviço", "S", 25, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria D02 = new Model.Form435Categoria(27, "D02", "Usados incorretamente", "S", 25, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria D03 = new Model.Form435Categoria(28, "D03", "Condições inseguras", "S", 25, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria E = new Model.Form435Categoria(29, "E", "Procedimentos", "S", null, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria E01 = new Model.Form435Categoria(30, "E01", "Inadequados", "S", 29, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria E02 = new Model.Form435Categoria(31, "E02", "Não existem procedimentos escritos", "S", 29, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria E03 = new Model.Form435Categoria(32, "E03", "Adequados e não seguidos", "S", 29, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria F = new Model.Form435Categoria(33, "F", "Ordem, Limpeza e Arrumação", "S", null, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria F01 = new Model.Form435Categoria(34, "F01", "Local sujo", "S", 33, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria F02 = new Model.Form435Categoria(35, "F02", "Local desorganizado", "S", 33, DateTime.Now, "JEAR", null, null, 3);
                Model.Form435Categoria F03 = new Model.Form435Categoria(36, "F03", "Local com vazamentos e poluição Ambiental", "S", 33, DateTime.Now, "JEAR", null, null, 3);

                con.Insert(A);
                con.Insert(A01);
                con.Insert(A02);
                con.Insert(A03);
                con.Insert(A04);
                con.Insert(B);
                con.Insert(B01);
                con.Insert(B02);
                con.Insert(B03);
                con.Insert(B04);
                con.Insert(B05);
                con.Insert(B06);
                con.Insert(B07);
                con.Insert(B08);
                con.Insert(B09);
                con.Insert(B10);
                con.Insert(C);
                con.Insert(C01);
                con.Insert(C02);
                con.Insert(C03);
                con.Insert(C04);
                con.Insert(C05);
                con.Insert(C06);
                con.Insert(C07);
                con.Insert(D);
                con.Insert(D01);
                con.Insert(D02);
                con.Insert(D03);
                con.Insert(E);
                con.Insert(E01);
                con.Insert(E02);
                con.Insert(E03);
                con.Insert(F);
                con.Insert(F01);
                con.Insert(F02);
                con.Insert(F03);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
