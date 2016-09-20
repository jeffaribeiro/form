using System;
using SQLite.Net.Interop;
using Xamarin.Forms;
using Form435.Database;
using SQLite.Net;
using System.IO;

[assembly: Dependency(typeof(Form435.Droid.Database.Config))]
namespace Form435.Droid.Database
{
    public class Config : IConfig
    {
        private string _diretorioSQLite;
        private ISQLitePlatform _plataforma;
        private string _nomeBancoDeDados;
        private string _arquivoBd;
        
        private string NomeBancoDeDados{
            get
            {
                if (string.IsNullOrEmpty(_arquivoBd))
                {
                    _nomeBancoDeDados = "Form435.db3";
                }
                return _nomeBancoDeDados;
            }
        }

        public string DiretorioSQLite
        {
            get
            {
                if (string.IsNullOrEmpty(_diretorioSQLite))
                {
                    _diretorioSQLite = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                return _diretorioSQLite;
            }
        }
        
        public string ArquivoBd
        {
            get
            {
                if (string.IsNullOrEmpty(_arquivoBd))
                {
                    _arquivoBd = Path.Combine(DiretorioSQLite, NomeBancoDeDados);
                }
                return _arquivoBd;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (_plataforma == null)
                {
                    _plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return _plataforma;
            }
        }

        public bool ExisteBanco
        {
            get
            {
                return File.Exists(ArquivoBd);
            }
        }

    }
}