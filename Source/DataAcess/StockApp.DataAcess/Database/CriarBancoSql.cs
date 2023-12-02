using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcess.Database
{
    public static class CriarBancoSql
    {
        public static void Executar()
        {
            var sql = @"
                        IF NOT EXIST(SELECT * FROM sys.databases WHERE name = 'StockApp')
                          BEGIN
                            CREATE DATABSE StockApp
                          END";
        }
    }
}
