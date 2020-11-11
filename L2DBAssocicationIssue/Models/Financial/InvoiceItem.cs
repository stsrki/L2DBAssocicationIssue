#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using L2DBAssocicationIssue.Data.Models.Common;
using LinqToDB.Mapping;
#endregion

namespace L2DBAssocicationIssue.Data.Models.Financial
{
    [Table( Name = "InvoiceItem", Schema = "Financial" )]
    public class InvoiceItem
    {
        #region Members

        [Column( "InvoiceItemId" ), Identity, PrimaryKey]
        public int Id { get; set; }

        [Column( "InvoiceId" ), NotNull]
        public int InvoiceId { get; set; }

        [Column( "ProductName" ), NotNull]
        public string ProductName { get; set; }

        [Column( "ProductVersion" ), NotNull]
        public string ProductVersion { get; set; }

        [Column( "LicenseName" ), NotNull]
        public string LicenseName { get; set; }

        [Column( "Quantity" ), NotNull]
        public int Quantity { get; set; }

        [Column( "TaxRate" ), Nullable]
        public decimal? TaxRate { get; set; }

        // market prices(customer selects this currency on the web and pays with this currency)
        [Column( "MarketCurrencyId" ), NotNull]
        public int MarketCurrencyId { get; set; }

        [Column( "MarketPrice" ), NotNull]
        public decimal MarketPrice { get; set; }

        [Column( "MarketDiscount" ), Nullable]
        public decimal? MarketDiscount { get; set; }

        [Column( "MarketSubtotal" ), NotNull]
        public decimal MarketSubtotal { get; set; }

        [Column( "MarketTax" ), NotNull]
        public decimal MarketTax { get; set; }

        [Column( "MarketTotal" ), NotNull]
        public decimal MarketTotal { get; set; }


        // selling prices(this is the base company currency)
        [Column( "ChargedCurrencyId" ), NotNull]
        public int ChargedCurrencyId { get; set; }

        [Column( "ChargedPrice" ), NotNull]
        public decimal ChargedPrice { get; set; }

        [Column( "ChargedDiscount" ), Nullable]
        public decimal? ChargedDiscount { get; set; }

        [Column( "ChargedSubtotal" ), NotNull]
        public decimal ChargedSubtotal { get; set; }

        [Column( "ChargedTax" ), NotNull]
        public decimal ChargedTax { get; set; }

        [Column( "ChargedTotal" ), NotNull]
        public decimal ChargedTotal { get; set; }


        // invoice prices, calculated based on the real currency rates made by central bank
        [Column( "InvoiceCurrencyId" ), NotNull]
        public int InvoiceCurrencyId { get; set; }

        [Column( "InvoicePrice" ), NotNull]
        public decimal InvoicePrice { get; set; }

        [Column( "InvoiceDiscount" ), Nullable]
        public decimal? InvoiceDiscount { get; set; }

        [Column( "InvoiceSubtotal" ), NotNull]
        public decimal InvoiceSubtotal { get; set; }

        [Column( "InvoiceTax" ), NotNull]
        public decimal InvoiceTax { get; set; }

        [Column( "InvoiceTotal" ), NotNull]
        public decimal InvoiceTotal { get; set; }

        #endregion

        #region Associations

        [Association( ThisKey = nameof( InvoiceId ), OtherKey = nameof( Financial.Invoice.Id ), CanBeNull = false )]
        public Invoice Invoice { get; set; }

        [Association( ThisKey = nameof( MarketCurrencyId ), OtherKey = nameof( Common.Currency.Id ), CanBeNull = false )]
        public Currency MarketCurrency { get; set; }

        [Association( ThisKey = nameof( ChargedCurrencyId ), OtherKey = nameof( Common.Currency.Id ), CanBeNull = false )]
        public Currency ChargedCurrency { get; set; }

        [Association( ThisKey = nameof( InvoiceCurrencyId ), OtherKey = nameof( Common.Currency.Id ), CanBeNull = false )]
        public Currency InvoiceCurrency { get; set; }

        #endregion
    }
}
