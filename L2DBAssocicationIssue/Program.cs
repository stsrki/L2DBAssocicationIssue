using System;
using System.Collections.Generic;
using L2DBAssocicationIssue.Data.Models.Financial;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider;
using LinqToDB.Mapping;
using System.Linq;
using System.Linq.Expressions;

namespace L2DBAssocicationIssue
{
    class Program
    {
        static void Main( string[] args )
        {
            LinqToDB.Common.Configuration.Linq.AllowMultipleQuery = true;

            var context = new DatabaseContext
            {
                Provider = "SqlServer",
                ConnectionString = "",
            };

            using ( var db = new Database( context ) )
            {
                var query = db.GetTable<Invoice>()
                    .Where( x => x.Id == 37 );

                query = query
                    .LoadWith( x => x.MarketCurrency )
                    .LoadWith( x => x.ChargedCurrency )
                    .LoadWith( x => x.InvoiceCurrency )
                    .LoadWith( x => x.DiscountCurrency )
                    .LoadWith( x => x.InvoiceItems )
                        .ThenLoad( x => x.MarketCurrency )
                    .LoadWith( x => x.InvoiceItems )
                        .ThenLoad( x => x.ChargedCurrency )
                    .LoadWith( x => x.InvoiceItems )
                        .ThenLoad( x => x.InvoiceCurrency );

                var invoice = query.FirstOrDefault();
            }

            Console.WriteLine( "Hello World!" );
        }
    }

    public class DatabaseContext
    {
        public string ConnectionString { get; set; }

        public string Provider { get; set; }
    }

    public class Database : DataConnection
    {
        public Database( DatabaseContext context )
            : base( GetProvider( context ), context.ConnectionString )
        {
        }

        public static IDataProvider GetProvider( DatabaseContext context )
        {
            if ( context.Provider == "SqlServer" )
                return new LinqToDB.DataProvider.SqlServer.SqlServerDataProvider( "L2DBAssocicationIssue", LinqToDB.DataProvider.SqlServer.SqlServerVersion.v2012 );

            throw new NotSupportedException( $"Provider {context.Provider} is not supported." );
        }
    }
}
