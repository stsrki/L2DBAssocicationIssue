# Create tables

```
GO
/****** Object:  Schema [Common]    Script Date: 11.11.2020. 9:45:37 ******/
CREATE SCHEMA [Common]
GO
/****** Object:  Schema [Financial]    Script Date: 11.11.2020. 9:45:37 ******/
CREATE SCHEMA [Financial]
GO
/****** Object:  Table [Common].[Currency]    Script Date: 11.11.2020. 9:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[Currency](
	[CurrencyId] [int] IDENTITY(1,1) NOT NULL,
	[Iso3] [nvarchar](3) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Symbol] [nvarchar](8) NOT NULL,
	[Unit] [decimal](19, 5) NOT NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Financial].[Invoice]    Script Date: 11.11.2020. 9:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Financial].[Invoice](
	[InvoiceId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[InvoiceDate] [datetimeoffset](7) NOT NULL,
	[InvoiceNumber] [int] NOT NULL,
	[InvoiceNumberFull] [nvarchar](32) NOT NULL,
	[CancellationInvoiceId] [int] NULL,
	[CancellationDate] [datetimeoffset](7) NULL,
	[OfficeSpaceNumber] [nvarchar](32) NOT NULL,
	[PaymentDeviceNumber] [nvarchar](32) NOT NULL,
	[PaymentType] [varchar](1) NOT NULL,
	[CustomerEmail] [nvarchar](256) NULL,
	[CustomerFirstName] [nvarchar](128) NULL,
	[CustomerLastName] [nvarchar](128) NULL,
	[CustomerCompany] [nvarchar](256) NULL,
	[CustomerAddress] [nvarchar](256) NULL,
	[CustomerAddress2] [nvarchar](256) NULL,
	[CustomerCity] [nvarchar](256) NULL,
	[CustomerZip] [nvarchar](64) NULL,
	[CustomerCountry] [nvarchar](256) NULL,
	[CustomerVat] [nvarchar](32) NULL,
	[SellerName] [nvarchar](256) NULL,
	[SellerAddress] [nvarchar](256) NULL,
	[SellerAddress2] [nvarchar](256) NULL,
	[SellerCity] [nvarchar](256) NULL,
	[SellerZip] [nvarchar](64) NULL,
	[SellerCountry] [nvarchar](256) NULL,
	[SellerWeb] [nvarchar](256) NULL,
	[SellerVat] [nvarchar](32) NULL,
	[DiscountType] [int] NULL,
	[DiscountValue] [decimal](18, 4) NULL,
	[DiscountReferenceType] [int] NULL,
	[DiscountCurrencyId] [int] NULL,
	[MarketCurrencyId] [int] NULL,
	[MarketExchangeDate] [date] NOT NULL,
	[MarketExchangeRate] [decimal](18, 6) NOT NULL,
	[MarketSubtotal] [decimal](18, 4) NOT NULL,
	[MarketDiscount] [decimal](18, 4) NULL,
	[MarketTax] [decimal](18, 4) NOT NULL,
	[MarketTotal] [decimal](18, 4) NOT NULL,
	[ChargedCurrencyId] [int] NULL,
	[ChargedExchangeDate] [date] NOT NULL,
	[ChargedExchangeRate] [decimal](18, 6) NOT NULL,
	[ChargedSubtotal] [decimal](18, 4) NOT NULL,
	[ChargedDiscount] [decimal](18, 4) NULL,
	[ChargedTax] [decimal](18, 4) NOT NULL,
	[ChargedTotal] [decimal](18, 4) NOT NULL,
	[InvoiceCurrencyId] [int] NULL,
	[InvoiceExchangeDate] [date] NOT NULL,
	[InvoiceExchangeRate] [decimal](18, 6) NOT NULL,
	[InvoiceSubtotal] [decimal](18, 4) NOT NULL,
	[InvoiceDiscount] [decimal](18, 4) NULL,
	[InvoiceTax] [decimal](18, 4) NOT NULL,
	[InvoiceTotal] [decimal](18, 4) NOT NULL,
	[ExchangeRateDifference] [decimal](18, 4) NOT NULL,
	[FiscalizationId] [int] NULL,
	[Zki] [varchar](32) NULL,
	[Jir] [varchar](36) NULL,
	[CustomerType] [int] NOT NULL,
	[CustomerReverseCharge] [bit] NOT NULL,
	[IssuerName] [nvarchar](50) NULL,
	[IssuerOib] [nvarchar](50) NULL,
	[CustomerOib] [nvarchar](50) NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Financial].[InvoiceItem]    Script Date: 11.11.2020. 9:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Financial].[InvoiceItem](
	[InvoiceItemId] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [int] NOT NULL,
	[ProductName] [nvarchar](256) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
	[LicenseName] [nvarchar](256) NOT NULL,
	[Quantity] [int] NOT NULL,
	[TaxRate] [decimal](18, 4) NULL,
	[MarketCurrencyId] [int] NULL,
	[MarketPrice] [decimal](18, 4) NOT NULL,
	[MarketDiscount] [decimal](18, 4) NULL,
	[MarketSubtotal] [decimal](18, 4) NOT NULL,
	[MarketTax] [decimal](18, 4) NOT NULL,
	[MarketTotal] [decimal](18, 4) NOT NULL,
	[ChargedCurrencyId] [int] NULL,
	[ChargedPrice] [decimal](18, 4) NOT NULL,
	[ChargedDiscount] [decimal](18, 4) NULL,
	[ChargedSubtotal] [decimal](18, 4) NOT NULL,
	[ChargedTax] [decimal](18, 4) NOT NULL,
	[ChargedTotal] [decimal](18, 4) NOT NULL,
	[InvoiceCurrencyId] [int] NULL,
	[InvoicePrice] [decimal](18, 4) NOT NULL,
	[InvoiceDiscount] [decimal](18, 4) NULL,
	[InvoiceSubtotal] [decimal](18, 4) NOT NULL,
	[InvoiceTax] [decimal](18, 4) NOT NULL,
	[InvoiceTotal] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_InvoiceItem] PRIMARY KEY CLUSTERED 
(
	[InvoiceItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Financial].[Invoice] ADD  CONSTRAINT [DF_Invoice_CustomerType]  DEFAULT ((0)) FOR [CustomerType]
GO
ALTER TABLE [Financial].[Invoice] ADD  CONSTRAINT [DF_Invoice_CustomerReverseCharge]  DEFAULT ((1)) FOR [CustomerReverseCharge]
GO
ALTER TABLE [Financial].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_ChargedCurrency] FOREIGN KEY([ChargedCurrencyId])
REFERENCES [Common].[Currency] ([CurrencyId])
GO
ALTER TABLE [Financial].[Invoice] CHECK CONSTRAINT [FK_Invoice_ChargedCurrency]
GO
ALTER TABLE [Financial].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_DiscountCurrency] FOREIGN KEY([DiscountCurrencyId])
REFERENCES [Common].[Currency] ([CurrencyId])
GO
ALTER TABLE [Financial].[Invoice] CHECK CONSTRAINT [FK_Invoice_DiscountCurrency]
GO
ALTER TABLE [Financial].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Fiscalization] FOREIGN KEY([FiscalizationId])
REFERENCES [Logs].[Fiscalization] ([FiscalizationId])
GO
ALTER TABLE [Financial].[Invoice] CHECK CONSTRAINT [FK_Invoice_Fiscalization]
GO
ALTER TABLE [Financial].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_InvoiceCurrency] FOREIGN KEY([InvoiceCurrencyId])
REFERENCES [Common].[Currency] ([CurrencyId])
GO
ALTER TABLE [Financial].[Invoice] CHECK CONSTRAINT [FK_Invoice_InvoiceCurrency]
GO
ALTER TABLE [Financial].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_MarketCurrency] FOREIGN KEY([MarketCurrencyId])
REFERENCES [Common].[Currency] ([CurrencyId])
GO
ALTER TABLE [Financial].[Invoice] CHECK CONSTRAINT [FK_Invoice_MarketCurrency]
GO
ALTER TABLE [Financial].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Order] FOREIGN KEY([OrderId])
REFERENCES [Sales].[Order] ([OrderId])
GO
ALTER TABLE [Financial].[Invoice] CHECK CONSTRAINT [FK_Invoice_Order]
GO
ALTER TABLE [Financial].[InvoiceItem]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceItem_ChargedCurrency] FOREIGN KEY([ChargedCurrencyId])
REFERENCES [Common].[Currency] ([CurrencyId])
GO
ALTER TABLE [Financial].[InvoiceItem] CHECK CONSTRAINT [FK_InvoiceItem_ChargedCurrency]
GO
ALTER TABLE [Financial].[InvoiceItem]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceItem_Invoice] FOREIGN KEY([InvoiceId])
REFERENCES [Financial].[Invoice] ([InvoiceId])
GO
ALTER TABLE [Financial].[InvoiceItem] CHECK CONSTRAINT [FK_InvoiceItem_Invoice]
GO
ALTER TABLE [Financial].[InvoiceItem]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceItem_InvoiceCurrency] FOREIGN KEY([InvoiceCurrencyId])
REFERENCES [Common].[Currency] ([CurrencyId])
GO
ALTER TABLE [Financial].[InvoiceItem] CHECK CONSTRAINT [FK_InvoiceItem_InvoiceCurrency]
GO
ALTER TABLE [Financial].[InvoiceItem]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceItem_MarketCurrency] FOREIGN KEY([MarketCurrencyId])
REFERENCES [Common].[Currency] ([CurrencyId])
GO
ALTER TABLE [Financial].[InvoiceItem] CHECK CONSTRAINT [FK_InvoiceItem_MarketCurrency]
GO
```