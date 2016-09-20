using SQLite.Net;
using SQLite.Net.Interop;

namespace Form435.Database
{
    public interface IConfig
    {
        string DiretorioSQLite { get; }
        ISQLitePlatform Plataforma { get; }
        string ArquivoBd { get; }
        bool ExisteBanco { get; }

    }
}
