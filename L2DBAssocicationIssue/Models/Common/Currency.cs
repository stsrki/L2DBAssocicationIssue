#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using LinqToDB.Mapping;
#endregion

namespace L2DBAssocicationIssue.Data.Models.Common
{
    [Table( Name = "Currency", Schema = "Common" )]
    public class Currency
    {
        #region Members

        [Column( "CurrencyId" ), Identity, PrimaryKey]
        public int Id { get; set; }

        [Column( "Iso3" ), NotNull]
        public string Iso3 { get; set; }

        [Column( "Name" ), NotNull]
        public string Name { get; set; }

        [Column( "Symbol" ), NotNull]
        public string Symbol { get; set; }

        [Column( "Unit" ), NotNull]
        public decimal Unit { get; set; }

        #endregion
    }
}
