USE [EasyBuyDev]
GO
/****** Object:  Table [dbo].[YD1S]    Script Date: 03/04/2014 00:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[YD1S](
	[YD1SIID] [int] IDENTITY(1,1) NOT NULL,
	[YD1S1CID] [int] NOT NULL,
	[YD1SNM] [char](50) NOT NULL,
	[YD1SCNLN] [char](50) NOT NULL,
	[YD1SCNFN] [char](50) NOT NULL,
	[YD1SCNMN] [char](50) NOT NULL,
	[YD1SCNNN] [char](50) NOT NULL,
	[YD1SSHA1] [char](30) NOT NULL,
	[YD1SSHA2] [char](30) NOT NULL,
	[YD1SSHA3] [char](30) NOT NULL,
	[YD1SSHPC] [char](10) NOT NULL,
	[YD1SSHCY] [char](50) NOT NULL,
	[YD1STL] [char](20) NOT NULL,
	[YD1SEM] [char](50) NOT NULL,
	[YD1SM1] [char](100) NOT NULL,
	[YD1SPRPT] [numeric](8, 0) NOT NULL,
	[YD1SCRDT] [numeric](8, 0) NOT NULL,
	[YD1SCRTM] [numeric](6, 0) NOT NULL,
	[YD1SCRUS] [char](10) NOT NULL,
	[YD1SCRJB] [char](10) NOT NULL,
	[YD1SCRJN] [char](6) NOT NULL,
	[YD1SLCDT] [numeric](8, 0) NOT NULL,
	[YD1SLCTM] [numeric](6, 0) NOT NULL,
	[YD1SLCUS] [char](10) NOT NULL,
	[YD1SLCJB] [char](10) NOT NULL,
	[YD1SLCJN] [char](6) NOT NULL,
 CONSTRAINT [PK_YD1S] PRIMARY KEY CLUSTERED 
(
	[YD1SIID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SIID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customer Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1S1CID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SNM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact Last Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCNLN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact First Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCNFN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact Middle Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCNMN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact Nick Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCNNN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Address 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SSHA1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Address 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SSHA2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Address 3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SSHA3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Postal Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SSHPC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Country' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SSHCY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Telephone' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1STL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SEM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Memo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SM1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Purchase Points' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SPRPT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCRDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCRTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCRUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCRJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SCRJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SLCDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SLCTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SLCUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SLCJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S', @level2type=N'COLUMN',@level2name=N'YD1SLCJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Shipping Address' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1S'
GO
/****** Object:  Table [dbo].[YD1P]    Script Date: 03/04/2014 00:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[YD1P](
	[YD1PIID] [int] IDENTITY(1,1) NOT NULL,
	[YD1PCD] [char](25) NOT NULL,
	[YD1PNM] [char](50) NOT NULL,
	[YD1PDS] [char](256) NOT NULL,
	[YD1PCT] [char](50) NOT NULL,
	[YD1PSTCS] [money] NOT NULL,
	[YD1PLSPR] [money] NOT NULL,
	[YD1PROLV] [numeric](4, 0) NOT NULL,
	[YD1PTGLV] [numeric](4, 0) NOT NULL,
	[YD1PMRQT] [numeric](4, 0) NOT NULL,
	[YD1PDC] [char](1) NOT NULL,
	[YD1PM1] [char](100) NOT NULL,
	[YD1PIMPT] [char](256) NOT NULL,
	[YD1PCRDT] [numeric](8, 0) NOT NULL,
	[YD1PCRTM] [numeric](6, 0) NOT NULL,
	[YD1PCRUS] [char](10) NOT NULL,
	[YD1PCRJB] [char](10) NOT NULL,
	[YD1PCRJN] [char](6) NOT NULL,
	[YD1PLCDT] [numeric](8, 0) NOT NULL,
	[YD1PLCTM] [numeric](6, 0) NOT NULL,
	[YD1PLCUS] [char](10) NOT NULL,
	[YD1PLCJB] [char](10) NOT NULL,
	[YD1PLCJN] [char](6) NOT NULL,
 CONSTRAINT [PK_YD1P] PRIMARY KEY CLUSTERED 
(
	[YD1PIID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PIID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PCD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PNM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PDS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Category' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PCT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Standard Cost' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PSTCS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List Price' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PLSPR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Reorder Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PROLV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Target Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PTGLV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Minimum Reorder Quantity' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PMRQT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Discontinued' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PDC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Memo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PM1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Image Path' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PIMPT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PCRDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PCRTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PCRUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PCRJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PCRJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PLCDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PLCTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PLCUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PLCJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P', @level2type=N'COLUMN',@level2name=N'YD1PLCJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Product' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1P'
GO
/****** Object:  Table [dbo].[YD1O]    Script Date: 03/04/2014 00:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[YD1O](
	[YD1OIID] [int] IDENTITY(1,1) NOT NULL,
	[YD1O1CID] [int] NULL,
	[YD1OPONO] [char](50) NOT NULL,
	[YD1O1WID] [numeric](8, 0) NOT NULL,
	[YD1O1WNM] [char](50) NOT NULL,
	[YD1ODLM1] [char](100) NOT NULL,
	[YD1O1SID] [int] NULL,
	[YD1OM1] [char](100) NOT NULL,
	[YD1OST] [char](10) NOT NULL,
	[YD1O1AID] [numeric](8, 0) NOT NULL,
	[YD1O1ANM] [char](50) NOT NULL,
	[YD1CPRPT] [numeric](8, 0) NOT NULL,
	[YD1OCRDT] [numeric](8, 0) NOT NULL,
	[YD1OCRTM] [numeric](6, 0) NOT NULL,
	[YD1OCRUS] [char](10) NOT NULL,
	[YD1OCRJB] [char](10) NOT NULL,
	[YD1OCRJN] [char](6) NOT NULL,
	[YD1OLCDT] [numeric](8, 0) NOT NULL,
	[YD1OLCTM] [numeric](6, 0) NOT NULL,
	[YD1OLCUS] [char](10) NOT NULL,
	[YD1OLCJB] [char](10) NOT NULL,
	[YD1OLCJN] [char](6) NOT NULL,
	[YD1ODT] [date] NULL,
	[YD1OTM] [time](7) NULL,
 CONSTRAINT [PK_YD1O] PRIMARY KEY CLUSTERED 
(
	[YD1OIID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OIID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customer Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1O1CID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Purchase Order Number/ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OPONO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Warehouse Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1O1WID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Warehouse Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1O1WNM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Delivery Memo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1ODLM1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Shipping Address Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1O1SID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Order Memo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OM1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OST'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sales Person Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1O1AID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sales Person Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1O1ANM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Purchase Points' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1CPRPT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OCRDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OCRTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OCRUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OCRJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OCRJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OLCDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OLCTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OLCUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OLCJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OLCJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Order Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1ODT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Order Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O', @level2type=N'COLUMN',@level2name=N'YD1OTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Order' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1O'
GO
/****** Object:  Table [dbo].[YD1I]    Script Date: 03/04/2014 00:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[YD1I](
	[YD1IIID] [int] IDENTITY(1,1) NOT NULL,
	[YD1I1OID] [int] NULL,
	[YD1I1PID] [int] NULL,
	[YD1IQT] [int] NOT NULL,
	[YD1IPRUN] [money] NOT NULL,
	[YD1IDSPC] [numeric](4, 0) NOT NULL,
	[YD1IM1] [char](100) NOT NULL,
	[YD1ICRDT] [numeric](8, 0) NOT NULL,
	[YD1ICRTM] [numeric](6, 0) NOT NULL,
	[YD1ICRUS] [char](10) NOT NULL,
	[YD1ICRJB] [char](10) NOT NULL,
	[YD1ICRJN] [char](6) NOT NULL,
	[YD1ILCDT] [numeric](8, 0) NOT NULL,
	[YD1ILCTM] [numeric](6, 0) NOT NULL,
	[YD1ILCUS] [char](10) NOT NULL,
	[YD1ILCJB] [char](10) NOT NULL,
	[YD1ILCJN] [char](6) NOT NULL,
 CONSTRAINT [PK_YD1I] PRIMARY KEY CLUSTERED 
(
	[YD1IIID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1IIID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Order Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1I1OID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Product Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1I1PID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Quantity' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1IQT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unit Price' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1IPRUN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Discount (Percent)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1IDSPC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Memo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1IM1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ICRDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ICRTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ICRUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ICRJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ICRJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ILCDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ILCTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ILCUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ILCJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I', @level2type=N'COLUMN',@level2name=N'YD1ILCJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Order Item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1I'
GO
/****** Object:  Table [dbo].[YD1C]    Script Date: 03/04/2014 00:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[YD1C](
	[YD1CIID] [int] IDENTITY(1,1) NOT NULL,
	[YD1CPTID] [int] NULL,
	[YD1CPTRL] [char](20) NOT NULL,
	[YD1CNM] [char](50) NOT NULL,
	[YD1CNMLG] [char](50) NOT NULL,
	[YD1CCNLN] [char](50) NOT NULL,
	[YD1CCNFN] [char](50) NOT NULL,
	[YD1CCNMN] [char](50) NOT NULL,
	[YD1CCNNN] [char](50) NOT NULL,
	[YD1CBLA1] [char](30) NOT NULL,
	[YD1CBLA2] [char](30) NOT NULL,
	[YD1CBLA3] [char](30) NOT NULL,
	[YD1CBLPC] [char](10) NOT NULL,
	[YD1CBLCY] [char](50) NOT NULL,
	[YD1CTL] [char](20) NOT NULL,
	[YD1CEM] [char](50) NOT NULL,
	[YD1CM1] [char](100) NOT NULL,
	[YD1CPRPT] [numeric](8, 0) NOT NULL,
	[YD1CCRDT] [numeric](8, 0) NOT NULL,
	[YD1CCRTM] [numeric](6, 0) NOT NULL,
	[YD1CCRUS] [char](10) NOT NULL,
	[YD1CCRJB] [char](10) NOT NULL,
	[YD1CCRJN] [char](6) NOT NULL,
	[YD1CLCDT] [numeric](8, 0) NOT NULL,
	[YD1CLCTM] [numeric](6, 0) NOT NULL,
	[YD1CLCUS] [char](10) NOT NULL,
	[YD1CLCJB] [char](10) NOT NULL,
	[YD1CLCJN] [char](6) NOT NULL,
 CONSTRAINT [PK_YD1C] PRIMARY KEY CLUSTERED 
(
	[YD1CIID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CIID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Parent Internal ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CPTID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Parent Relationship' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CPTRL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CNM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legal Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CNMLG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact Last Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCNLN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact First Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCNFN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact Middle Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCNMN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact Nick Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCNNN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Billing Address 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CBLA1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Billing Address 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CBLA2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Billing Address 3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CBLA3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Billing Postal Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CBLPC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Billing Country' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CBLCY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Telephone' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CTL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CEM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Memo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CM1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Purchase Points' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CPRPT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCRDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCRTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCRUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCRJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Create Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CCRJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CLCDT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CLCTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CLCUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CLCJB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last Change Job Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C', @level2type=N'COLUMN',@level2name=N'YD1CLCJN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customer' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'YD1C'
GO
/****** Object:  Default [DF__YD1C__YD1CPTRL__07020F21]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CPTRL__07020F21]  DEFAULT ('') FOR [YD1CPTRL]
GO
/****** Object:  Default [DF__YD1C__YD1CNM__07F6335A]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CNM__07F6335A]  DEFAULT ('') FOR [YD1CNM]
GO
/****** Object:  Default [DF__YD1C__YD1CNMLG__08EA5793]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CNMLG__08EA5793]  DEFAULT ('') FOR [YD1CNMLG]
GO
/****** Object:  Default [DF__YD1C__YD1CCNLN__09DE7BCC]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCNLN__09DE7BCC]  DEFAULT ('') FOR [YD1CCNLN]
GO
/****** Object:  Default [DF__YD1C__YD1CCNFN__0AD2A005]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCNFN__0AD2A005]  DEFAULT ('') FOR [YD1CCNFN]
GO
/****** Object:  Default [DF__YD1C__YD1CCNMN__0BC6C43E]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCNMN__0BC6C43E]  DEFAULT ('') FOR [YD1CCNMN]
GO
/****** Object:  Default [DF__YD1C__YD1CCNNN__0CBAE877]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCNNN__0CBAE877]  DEFAULT ('') FOR [YD1CCNNN]
GO
/****** Object:  Default [DF__YD1C__YD1CBLA1__0DAF0CB0]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CBLA1__0DAF0CB0]  DEFAULT ('') FOR [YD1CBLA1]
GO
/****** Object:  Default [DF__YD1C__YD1CBLA2__0EA330E9]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CBLA2__0EA330E9]  DEFAULT ('') FOR [YD1CBLA2]
GO
/****** Object:  Default [DF__YD1C__YD1CBLA3__0F975522]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CBLA3__0F975522]  DEFAULT ('') FOR [YD1CBLA3]
GO
/****** Object:  Default [DF__YD1C__YD1CBLPC__108B795B]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CBLPC__108B795B]  DEFAULT ('') FOR [YD1CBLPC]
GO
/****** Object:  Default [DF__YD1C__YD1CBLCY__117F9D94]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CBLCY__117F9D94]  DEFAULT ('') FOR [YD1CBLCY]
GO
/****** Object:  Default [DF__YD1C__YD1CTL__1273C1CD]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CTL__1273C1CD]  DEFAULT ('') FOR [YD1CTL]
GO
/****** Object:  Default [DF__YD1C__YD1CEM__1367E606]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CEM__1367E606]  DEFAULT ('') FOR [YD1CEM]
GO
/****** Object:  Default [DF__YD1C__YD1CM1__145C0A3F]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CM1__145C0A3F]  DEFAULT ('') FOR [YD1CM1]
GO
/****** Object:  Default [DF__YD1C__YD1CPRPT__15502E78]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CPRPT__15502E78]  DEFAULT ((0)) FOR [YD1CPRPT]
GO
/****** Object:  Default [DF__YD1C__YD1CCRDT__164452B1]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCRDT__164452B1]  DEFAULT ((0)) FOR [YD1CCRDT]
GO
/****** Object:  Default [DF__YD1C__YD1CCRTM__173876EA]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCRTM__173876EA]  DEFAULT ((0)) FOR [YD1CCRTM]
GO
/****** Object:  Default [DF__YD1C__YD1CCRUS__182C9B23]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCRUS__182C9B23]  DEFAULT ('') FOR [YD1CCRUS]
GO
/****** Object:  Default [DF__YD1C__YD1CCRJB__1920BF5C]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCRJB__1920BF5C]  DEFAULT ('') FOR [YD1CCRJB]
GO
/****** Object:  Default [DF__YD1C__YD1CCRJN__1A14E395]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CCRJN__1A14E395]  DEFAULT ('') FOR [YD1CCRJN]
GO
/****** Object:  Default [DF__YD1C__YD1CLCDT__1B0907CE]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CLCDT__1B0907CE]  DEFAULT ((0)) FOR [YD1CLCDT]
GO
/****** Object:  Default [DF__YD1C__YD1CLCTM__1BFD2C07]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CLCTM__1BFD2C07]  DEFAULT ((0)) FOR [YD1CLCTM]
GO
/****** Object:  Default [DF__YD1C__YD1CLCUS__1CF15040]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CLCUS__1CF15040]  DEFAULT ('') FOR [YD1CLCUS]
GO
/****** Object:  Default [DF__YD1C__YD1CLCJB__1DE57479]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CLCJB__1DE57479]  DEFAULT ('') FOR [YD1CLCJB]
GO
/****** Object:  Default [DF__YD1C__YD1CLCJN__1ED998B2]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1C] ADD  CONSTRAINT [DF__YD1C__YD1CLCJN__1ED998B2]  DEFAULT ('') FOR [YD1CLCJN]
GO
/****** Object:  Default [DF_YD1IQT]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF_YD1IQT]  DEFAULT ((0)) FOR [YD1IQT]
GO
/****** Object:  Default [DF__YD1I__YD1IDSPC__20C1E124]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1IDSPC__20C1E124]  DEFAULT ((0)) FOR [YD1IDSPC]
GO
/****** Object:  Default [DF__YD1I__YD1IM1__21B6055D]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1IM1__21B6055D]  DEFAULT ('') FOR [YD1IM1]
GO
/****** Object:  Default [DF__YD1I__YD1ICRDT__22AA2996]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ICRDT__22AA2996]  DEFAULT ((0)) FOR [YD1ICRDT]
GO
/****** Object:  Default [DF__YD1I__YD1ICRTM__239E4DCF]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ICRTM__239E4DCF]  DEFAULT ((0)) FOR [YD1ICRTM]
GO
/****** Object:  Default [DF__YD1I__YD1ICRUS__24927208]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ICRUS__24927208]  DEFAULT ('') FOR [YD1ICRUS]
GO
/****** Object:  Default [DF__YD1I__YD1ICRJB__25869641]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ICRJB__25869641]  DEFAULT ('') FOR [YD1ICRJB]
GO
/****** Object:  Default [DF__YD1I__YD1ICRJN__267ABA7A]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ICRJN__267ABA7A]  DEFAULT ('') FOR [YD1ICRJN]
GO
/****** Object:  Default [DF__YD1I__YD1ILCDT__276EDEB3]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ILCDT__276EDEB3]  DEFAULT ((0)) FOR [YD1ILCDT]
GO
/****** Object:  Default [DF__YD1I__YD1ILCTM__286302EC]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ILCTM__286302EC]  DEFAULT ((0)) FOR [YD1ILCTM]
GO
/****** Object:  Default [DF__YD1I__YD1ILCUS__29572725]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ILCUS__29572725]  DEFAULT ('') FOR [YD1ILCUS]
GO
/****** Object:  Default [DF__YD1I__YD1ILCJB__2A4B4B5E]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ILCJB__2A4B4B5E]  DEFAULT ('') FOR [YD1ILCJB]
GO
/****** Object:  Default [DF__YD1I__YD1ILCJN__2B3F6F97]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1I] ADD  CONSTRAINT [DF__YD1I__YD1ILCJN__2B3F6F97]  DEFAULT ('') FOR [YD1ILCJN]
GO
/****** Object:  Default [DF__YD1O__YD1OPONO__2E1BDC42]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OPONO__2E1BDC42]  DEFAULT ('') FOR [YD1OPONO]
GO
/****** Object:  Default [DF__YD1O__YD1O1WID__2F10007B]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1O1WID__2F10007B]  DEFAULT ((0)) FOR [YD1O1WID]
GO
/****** Object:  Default [DF__YD1O__YD1O1WNM__300424B4]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1O1WNM__300424B4]  DEFAULT ('') FOR [YD1O1WNM]
GO
/****** Object:  Default [DF__YD1O__YD1ODLM1__30F848ED]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1ODLM1__30F848ED]  DEFAULT ('') FOR [YD1ODLM1]
GO
/****** Object:  Default [DF__YD1O__YD1OM1__31EC6D26]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OM1__31EC6D26]  DEFAULT ('') FOR [YD1OM1]
GO
/****** Object:  Default [DF__YD1O__YD1OST__32E0915F]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OST__32E0915F]  DEFAULT ('') FOR [YD1OST]
GO
/****** Object:  Default [DF__YD1O__YD1O1AID__33D4B598]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1O1AID__33D4B598]  DEFAULT ((0)) FOR [YD1O1AID]
GO
/****** Object:  Default [DF__YD1O__YD1O1ANM__34C8D9D1]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1O1ANM__34C8D9D1]  DEFAULT ('') FOR [YD1O1ANM]
GO
/****** Object:  Default [DF__YD1O__YD1CPRPT__35BCFE0A]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1CPRPT__35BCFE0A]  DEFAULT ((0)) FOR [YD1CPRPT]
GO
/****** Object:  Default [DF__YD1O__YD1OCRDT__36B12243]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OCRDT__36B12243]  DEFAULT ((0)) FOR [YD1OCRDT]
GO
/****** Object:  Default [DF__YD1O__YD1OCRTM__37A5467C]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OCRTM__37A5467C]  DEFAULT ((0)) FOR [YD1OCRTM]
GO
/****** Object:  Default [DF__YD1O__YD1OCRUS__38996AB5]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OCRUS__38996AB5]  DEFAULT ('') FOR [YD1OCRUS]
GO
/****** Object:  Default [DF__YD1O__YD1OCRJB__398D8EEE]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OCRJB__398D8EEE]  DEFAULT ('') FOR [YD1OCRJB]
GO
/****** Object:  Default [DF__YD1O__YD1OCRJN__3A81B327]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OCRJN__3A81B327]  DEFAULT ('') FOR [YD1OCRJN]
GO
/****** Object:  Default [DF__YD1O__YD1OLCDT__3B75D760]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OLCDT__3B75D760]  DEFAULT ((0)) FOR [YD1OLCDT]
GO
/****** Object:  Default [DF__YD1O__YD1OLCTM__3C69FB99]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OLCTM__3C69FB99]  DEFAULT ((0)) FOR [YD1OLCTM]
GO
/****** Object:  Default [DF__YD1O__YD1OLCUS__3D5E1FD2]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OLCUS__3D5E1FD2]  DEFAULT ('') FOR [YD1OLCUS]
GO
/****** Object:  Default [DF__YD1O__YD1OLCJB__3E52440B]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OLCJB__3E52440B]  DEFAULT ('') FOR [YD1OLCJB]
GO
/****** Object:  Default [DF__YD1O__YD1OLCJN__3F466844]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OLCJN__3F466844]  DEFAULT ('') FOR [YD1OLCJN]
GO
/****** Object:  Default [DF__YD1O__YD1ODT__2C3393D0]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1ODT__2C3393D0]  DEFAULT ('00-00-0000') FOR [YD1ODT]
GO
/****** Object:  Default [DF__YD1O__YD1OTM__2D27B809]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1O] ADD  CONSTRAINT [DF__YD1O__YD1OTM__2D27B809]  DEFAULT ('00:00:00') FOR [YD1OTM]
GO
/****** Object:  Default [DF__YD1P__YD1PCD__403A8C7D]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PCD__403A8C7D]  DEFAULT ('') FOR [YD1PCD]
GO
/****** Object:  Default [DF__YD1P__YD1PNM__412EB0B6]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PNM__412EB0B6]  DEFAULT ('') FOR [YD1PNM]
GO
/****** Object:  Default [DF__YD1P__YD1PDS__4222D4EF]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PDS__4222D4EF]  DEFAULT ('') FOR [YD1PDS]
GO
/****** Object:  Default [DF__YD1P__YD1PCT__4316F928]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PCT__4316F928]  DEFAULT ('') FOR [YD1PCT]
GO
/****** Object:  Default [DF__YD1P__YD1PROLV__440B1D61]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PROLV__440B1D61]  DEFAULT ((0)) FOR [YD1PROLV]
GO
/****** Object:  Default [DF__YD1P__YD1PTGLV__44FF419A]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PTGLV__44FF419A]  DEFAULT ((0)) FOR [YD1PTGLV]
GO
/****** Object:  Default [DF__YD1P__YD1PMRQT__45F365D3]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PMRQT__45F365D3]  DEFAULT ((0)) FOR [YD1PMRQT]
GO
/****** Object:  Default [DF__YD1P__YD1PDC__46E78A0C]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PDC__46E78A0C]  DEFAULT ('') FOR [YD1PDC]
GO
/****** Object:  Default [DF__YD1P__YD1PM1__47DBAE45]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PM1__47DBAE45]  DEFAULT ('') FOR [YD1PM1]
GO
/****** Object:  Default [DF__YD1P__YD1PIMPT__48CFD27E]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PIMPT__48CFD27E]  DEFAULT ('') FOR [YD1PIMPT]
GO
/****** Object:  Default [DF__YD1P__YD1PCRDT__49C3F6B7]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PCRDT__49C3F6B7]  DEFAULT ((0)) FOR [YD1PCRDT]
GO
/****** Object:  Default [DF__YD1P__YD1PCRTM__4AB81AF0]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PCRTM__4AB81AF0]  DEFAULT ((0)) FOR [YD1PCRTM]
GO
/****** Object:  Default [DF__YD1P__YD1PCRUS__4BAC3F29]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PCRUS__4BAC3F29]  DEFAULT ('') FOR [YD1PCRUS]
GO
/****** Object:  Default [DF__YD1P__YD1PCRJB__4CA06362]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PCRJB__4CA06362]  DEFAULT ('') FOR [YD1PCRJB]
GO
/****** Object:  Default [DF__YD1P__YD1PCRJN__4D94879B]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PCRJN__4D94879B]  DEFAULT ('') FOR [YD1PCRJN]
GO
/****** Object:  Default [DF__YD1P__YD1PLCDT__4E88ABD4]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PLCDT__4E88ABD4]  DEFAULT ((0)) FOR [YD1PLCDT]
GO
/****** Object:  Default [DF__YD1P__YD1PLCTM__4F7CD00D]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PLCTM__4F7CD00D]  DEFAULT ((0)) FOR [YD1PLCTM]
GO
/****** Object:  Default [DF__YD1P__YD1PLCUS__5070F446]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PLCUS__5070F446]  DEFAULT ('') FOR [YD1PLCUS]
GO
/****** Object:  Default [DF__YD1P__YD1PLCJB__5165187F]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PLCJB__5165187F]  DEFAULT ('') FOR [YD1PLCJB]
GO
/****** Object:  Default [DF__YD1P__YD1PLCJN__52593CB8]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1P] ADD  CONSTRAINT [DF__YD1P__YD1PLCJN__52593CB8]  DEFAULT ('') FOR [YD1PLCJN]
GO
/****** Object:  Default [DF__YD1S__YD1SNM__534D60F1]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SNM__534D60F1]  DEFAULT ('') FOR [YD1SNM]
GO
/****** Object:  Default [DF__YD1S__YD1SCNLN__5441852A]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCNLN__5441852A]  DEFAULT ('') FOR [YD1SCNLN]
GO
/****** Object:  Default [DF__YD1S__YD1SCNFN__5535A963]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCNFN__5535A963]  DEFAULT ('') FOR [YD1SCNFN]
GO
/****** Object:  Default [DF__YD1S__YD1SCNMN__5629CD9C]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCNMN__5629CD9C]  DEFAULT ('') FOR [YD1SCNMN]
GO
/****** Object:  Default [DF__YD1S__YD1SCNNN__571DF1D5]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCNNN__571DF1D5]  DEFAULT ('') FOR [YD1SCNNN]
GO
/****** Object:  Default [DF__YD1S__YD1SSHA1__5812160E]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SSHA1__5812160E]  DEFAULT ('') FOR [YD1SSHA1]
GO
/****** Object:  Default [DF__YD1S__YD1SSHA2__59063A47]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SSHA2__59063A47]  DEFAULT ('') FOR [YD1SSHA2]
GO
/****** Object:  Default [DF__YD1S__YD1SSHA3__59FA5E80]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SSHA3__59FA5E80]  DEFAULT ('') FOR [YD1SSHA3]
GO
/****** Object:  Default [DF__YD1S__YD1SSHPC__5AEE82B9]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SSHPC__5AEE82B9]  DEFAULT ('') FOR [YD1SSHPC]
GO
/****** Object:  Default [DF__YD1S__YD1SSHCY__5BE2A6F2]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SSHCY__5BE2A6F2]  DEFAULT ('') FOR [YD1SSHCY]
GO
/****** Object:  Default [DF__YD1S__YD1STL__5CD6CB2B]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1STL__5CD6CB2B]  DEFAULT ('') FOR [YD1STL]
GO
/****** Object:  Default [DF__YD1S__YD1SEM__5DCAEF64]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SEM__5DCAEF64]  DEFAULT ('') FOR [YD1SEM]
GO
/****** Object:  Default [DF__YD1S__YD1SM1__5EBF139D]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SM1__5EBF139D]  DEFAULT ('') FOR [YD1SM1]
GO
/****** Object:  Default [DF__YD1S__YD1SPRPT__5FB337D6]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SPRPT__5FB337D6]  DEFAULT ((0)) FOR [YD1SPRPT]
GO
/****** Object:  Default [DF__YD1S__YD1SCRDT__60A75C0F]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCRDT__60A75C0F]  DEFAULT ((0)) FOR [YD1SCRDT]
GO
/****** Object:  Default [DF__YD1S__YD1SCRTM__619B8048]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCRTM__619B8048]  DEFAULT ((0)) FOR [YD1SCRTM]
GO
/****** Object:  Default [DF__YD1S__YD1SCRUS__628FA481]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCRUS__628FA481]  DEFAULT ('') FOR [YD1SCRUS]
GO
/****** Object:  Default [DF__YD1S__YD1SCRJB__6383C8BA]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCRJB__6383C8BA]  DEFAULT ('') FOR [YD1SCRJB]
GO
/****** Object:  Default [DF__YD1S__YD1SCRJN__6477ECF3]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SCRJN__6477ECF3]  DEFAULT ('') FOR [YD1SCRJN]
GO
/****** Object:  Default [DF__YD1S__YD1SLCDT__656C112C]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SLCDT__656C112C]  DEFAULT ((0)) FOR [YD1SLCDT]
GO
/****** Object:  Default [DF__YD1S__YD1SLCTM__66603565]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SLCTM__66603565]  DEFAULT ((0)) FOR [YD1SLCTM]
GO
/****** Object:  Default [DF__YD1S__YD1SLCUS__6754599E]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SLCUS__6754599E]  DEFAULT ('') FOR [YD1SLCUS]
GO
/****** Object:  Default [DF__YD1S__YD1SLCJB__68487DD7]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SLCJB__68487DD7]  DEFAULT ('') FOR [YD1SLCJB]
GO
/****** Object:  Default [DF__YD1S__YD1SLCJN__693CA210]    Script Date: 03/04/2014 00:40:16 ******/
ALTER TABLE [dbo].[YD1S] ADD  CONSTRAINT [DF__YD1S__YD1SLCJN__693CA210]  DEFAULT ('') FOR [YD1SLCJN]
GO
