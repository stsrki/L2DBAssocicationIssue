#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using L2DBAssocicationIssue.Data.Models.Common;
using LinqToDB.Mapping;
#endregion

namespace L2DBAssocicationIssue.Data.Models.Financial
{
    [Table( Name = "Invoice", Schema = "Financial" )]
    public class Invoice
    {
        #region Members

        [Column( "InvoiceId" ), Identity, PrimaryKey]
        public int Id { get; set; }

        [Column( "OrderId" ), NotNull]
        public int OrderId { get; set; }

        [Column( "InvoiceDate" ), NotNull]
        public DateTimeOffset InvoiceDate { get; set; }

        [Column( "InvoiceNumber" ), NotNull]
        public int InvoiceNumber { get; set; }

        [Column( "InvoiceNumberFull" ), NotNull]
        public string InvoiceNumberFull { get; set; }

        [Column( "CancellationInvoiceId" ), Nullable]
        public int? CancellationInvoiceId { get; set; }

        [Column( "CancellationDate" ), Nullable]
        public DateTimeOffset? CancellationDate { get; set; }

        [Column( "OfficeSpaceNumber" ), NotNull]
        public string OfficeSpaceNumber { get; set; }

        [Column( "PaymentDeviceNumber" ), NotNull]
        public string PaymentDeviceNumber { get; set; }

        [Column( "PaymentType" ), NotNull]
        public string PaymentType { get; set; }

        [Column( "CustomerType" ), NotNull]
        public int CustomerType { get; set; }

        [Column( "CustomerEmail" ), Nullable]
        public string CustomerEmail { get; set; }

        [Column( "CustomerFirstName" ), Nullable]
        public string CustomerFirstName { get; set; }

        [Column( "CustomerLastName" ), Nullable]
        public string CustomerLastName { get; set; }

        [Column( "CustomerCompany" ), Nullable]
        public string CustomerCompany { get; set; }

        [Column( "CustomerAddress" ), Nullable]
        public string CustomerAddress { get; set; }

        [Column( "CustomerAddress2" ), Nullable]
        public string CustomerAddress2 { get; set; }

        [Column( "CustomerCity" ), Nullable]
        public string CustomerCity { get; set; }

        [Column( "CustomerZip" ), Nullable]
        public string CustomerZip { get; set; }

        [Column( "CustomerCountry" ), Nullable]
        public string CustomerCountry { get; set; }

        [Column( "CustomerVat" ), Nullable]
        public string CustomerVat { get; set; }

        [Column( "CustomerOib" ), Nullable]
        public string CustomerOib { get; set; }

        [Column( "CustomerReverseCharge" ), NotNull]
        public bool CustomerReverseCharge { get; set; }

        [Column( "SellerName" ), Nullable]
        public string SellerName { get; set; }

        [Column( "SellerAddress" ), Nullable]
        public string SellerAddress { get; set; }

        [Column( "SellerAddress2" ), Nullable]
        public string SellerAddress2 { get; set; }

        [Column( "SellerCity" ), Nullable]
        public string SellerCity { get; set; }

        [Column( "SellerZip" ), Nullable]
        public string SellerZip { get; set; }

        [Column( "SellerCountry" ), Nullable]
        public string SellerCountry { get; set; }

        [Column( "SellerWeb" ), Nullable]
        public string SellerWeb { get; set; }

        [Column( "SellerVat" ), Nullable]
        public string SellerVat { get; set; }


        [Column( "DiscountType" ), Nullable]
        public int? DiscountType { get; set; }

        [Column( "DiscountValue" ), Nullable]
        public decimal? DiscountValue { get; set; }

        [Column( "DiscountReferenceType" ), Nullable]
        public int? DiscountReferenceType { get; set; }

        [Column( "DiscountCurrencyId" ), Nullable]
        public int? DiscountCurrencyId { get; set; }


        [Column( "MarketCurrencyId" ), NotNull]
        public int MarketCurrencyId { get; set; }

        [Column( "MarketExchangeDate" ), NotNull]
        public DateTime MarketExchangeDate { get; set; }

        [Column( "MarketExchangeRate" ), NotNull]
        public decimal MarketExchangeRate { get; set; }

        [Column( "MarketSubtotal" ), NotNull]
        public decimal MarketSubtotal { get; set; }

        [Column( "MarketDiscount" ), Nullable]
        public decimal? MarketDiscount { get; set; }

        [Column( "MarketTax" ), NotNull]
        public decimal MarketTax { get; set; }

        [Column( "MarketTotal" ), NotNull]
        public decimal MarketTotal { get; set; }


        [Column( "ChargedCurrencyId" ), NotNull]
        public int ChargedCurrencyId { get; set; }

        [Column( "ChargedExchangeDate" ), NotNull]
        public DateTime ChargedExchangeDate { get; set; }

        [Column( "ChargedExchangeRate" ), NotNull]
        public decimal ChargedExchangeRate { get; set; }

        [Column( "ChargedSubtotal" ), NotNull]
        public decimal ChargedSubtotal { get; set; }

        [Column( "ChargedDiscount" ), Nullable]
        public decimal? ChargedDiscount { get; set; }

        [Column( "ChargedTax" ), NotNull]
        public decimal ChargedTax { get; set; }

        [Column( "ChargedTotal" ), NotNull]
        public decimal ChargedTotal { get; set; }


        [Column( "InvoiceCurrencyId" ), NotNull]
        public int InvoiceCurrencyId { get; set; }

        [Column( "InvoiceExchangeDate" ), NotNull]
        public DateTime InvoiceExchangeDate { get; set; }

        [Column( "InvoiceExchangeRate" ), NotNull]
        public decimal InvoiceExchangeRate { get; set; }

        [Column( "InvoiceSubtotal" ), NotNull]
        public decimal InvoiceSubtotal { get; set; }

        [Column( "InvoiceDiscount" ), Nullable]
        public decimal? InvoiceDiscount { get; set; }

        [Column( "InvoiceTax" ), NotNull]
        public decimal InvoiceTax { get; set; }

        [Column( "InvoiceTotal" ), NotNull]
        public decimal InvoiceTotal { get; set; }

        [Column( "ExchangeRateDifference" ), NotNull]
        public decimal ExchangeRateDifference { get; set; }

        [Column( "FiscalizationId" ), Nullable]
        public int? FiscalizationId { get; set; }

        [Column( "Zki" ), Nullable]
        public string Zki { get; set; }

        [Column( "Jir" ), Nullable]
        public string Jir { get; set; }

        [Column( "IssuerName" ), Nullable]
        public string IssuerName { get; set; }

        [Column( "IssuerOib" ), Nullable]
        public string IssuerOib { get; set; }

        #endregion

        #region Associations

        [Association( ThisKey = nameof( MarketCurrencyId ), OtherKey = nameof( Common.Currency.Id ), CanBeNull = false )]
        public Currency MarketCurrency { get; set; }

        [Association( ThisKey = nameof( ChargedCurrencyId ), OtherKey = nameof( Common.Currency.Id ), CanBeNull = false )]
        public Currency ChargedCurrency { get; set; }

        [Association( ThisKey = nameof( InvoiceCurrencyId ), OtherKey = nameof( Common.Currency.Id ), CanBeNull = false )]
        public Currency InvoiceCurrency { get; set; }

        [Association( ThisKey = nameof( DiscountCurrencyId ), OtherKey = nameof( Common.Currency.Id ), CanBeNull = true )]
        public Currency DiscountCurrency { get; set; }

        [Association( ThisKey = nameof( Id ), OtherKey = nameof( Financial.Invoice.Id ), CanBeNull = true, Relationship = Relationship.OneToMany )]
        public List<InvoiceItem> InvoiceItems { get; set; }

        #endregion
    }
}
