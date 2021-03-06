USE [master]
GO
/****** Object:  Database [STOK]    Script Date: 29.03.2022 17:03:49 ******/
CREATE DATABASE [STOK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'STOK', FILENAME = N'C:\ProgramData\SOLIDWORKS Electrical\MSSQL12.TEW_SQLEXPRESS\MSSQL\DATA\STOK.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'STOK_log', FILENAME = N'C:\ProgramData\SOLIDWORKS Electrical\MSSQL12.TEW_SQLEXPRESS\MSSQL\DATA\STOK_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [STOK] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [STOK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [STOK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [STOK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [STOK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [STOK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [STOK] SET ARITHABORT OFF 
GO
ALTER DATABASE [STOK] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [STOK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [STOK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [STOK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [STOK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [STOK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [STOK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [STOK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [STOK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [STOK] SET  ENABLE_BROKER 
GO
ALTER DATABASE [STOK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [STOK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [STOK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [STOK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [STOK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [STOK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [STOK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [STOK] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [STOK] SET  MULTI_USER 
GO
ALTER DATABASE [STOK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [STOK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [STOK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [STOK] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [STOK] SET DELAYED_DURABILITY = DISABLED 
GO
USE [STOK]
GO
/****** Object:  Table [dbo].[AltGrup]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AltGrup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AltGrup] [nvarchar](50) NULL,
	[Açıklama] [nvarchar](200) NULL,
 CONSTRAINT [PK_AltGrup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grup]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Grup] [nvarchar](50) NULL,
	[Açıklama] [nvarchar](200) NULL,
 CONSTRAINT [PK_GrupAdı1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanıcılar]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcılar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[adSoyad] [nvarchar](50) NULL,
	[kullanıcıAdı] [nvarchar](50) NULL,
	[sifre] [nvarchar](20) NULL,
	[birim] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanıcılar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[malzemeCikis]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[malzemeCikis](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[projeNO] [nvarchar](10) NULL,
	[parcaStokAdi] [nvarchar](50) NULL,
	[miktar] [int] NULL,
	[tur] [nvarchar](15) NULL,
	[tesimAlan] [nvarchar](50) NULL,
	[birim] [nvarchar](50) NULL,
	[tarih] [date] NULL,
	[acıklama] [nvarchar](200) NULL,
	[eskisiİstenicek] [nvarchar](50) NULL,
	[İstenmeyecek] [nvarchar](50) NULL,
	[marka] [nvarchar](50) NULL,
	[seriNo] [int] NULL,
 CONSTRAINT [PK_malzemeCikis] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MalzemeCinsi]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MalzemeCinsi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeCinsi] [nvarchar](50) NULL,
	[Açıklama] [nvarchar](200) NULL,
 CONSTRAINT [PK_MalzemeCinsi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProsesGrubu]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProsesGrubu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProsesGrubu] [nvarchar](50) NULL,
	[Açıklama] [nvarchar](200) NULL,
 CONSTRAINT [PK_ProsesGrubu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokTalebi]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokTalebi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[stokAdi] [nvarchar](100) NULL,
	[projeAdi] [nvarchar](50) NULL,
	[ihtiyac] [int] NULL,
	[talepEden] [nvarchar](50) NULL,
	[durumu] [nvarchar](15) NULL,
	[birim] [nvarchar](10) NULL,
	[tarih] [date] NULL,
	[acıklama] [nvarchar](200) NULL,
	[marka] [nvarchar](50) NULL,
 CONSTRAINT [PK_StokTalebi_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_stokKarti]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_stokKarti](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[prosesGrubu] [nvarchar](100) NULL,
	[grupAdi] [nvarchar](100) NULL,
	[altGrupAdi] [nvarchar](100) NULL,
	[parcaStokAdi] [nvarchar](100) NULL,
	[malzemeCinsi] [nvarchar](100) NULL,
	[uzunluk] [nvarchar](50) NULL,
	[miktar] [int] NULL,
	[ihtiyac] [int] NULL,
	[tedarikci] [nvarchar](100) NULL,
	[tarih] [date] NULL,
	[birim] [nvarchar](10) NULL,
	[marka] [nvarchar](50) NULL,
	[seriNo] [int] NULL,
 CONSTRAINT [PK_tbl_stokKarti] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tedarikciBilgileri]    Script Date: 29.03.2022 17:03:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tedarikciBilgileri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[firmaAdi] [nvarchar](50) NULL,
	[sektor] [nvarchar](30) NULL,
	[firmaYetkilisi] [nvarchar](30) NULL,
	[telefonNumarası] [nvarchar](15) NULL,
	[adresi] [nvarchar](150) NULL,
 CONSTRAINT [PK_tedarikciBilgileri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AltGrup] ON 

INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (21, N'AKUATÖR', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (22, N'AYAK', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (23, N'PİSTON AKSESUARI', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (24, N'KAYIŞ', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (25, N'KASNAK', N'121212')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (26, N'KARE PROFİL TAPASI', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (27, N'MANGA GÖZÜ', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (28, N'BAĞLANTI', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (29, N'CLAMP', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (30, N'SOMUN', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (31, N'CIVATA', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (32, N'BİLEZİK', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (33, N'DUBEL', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (34, N'EMNİYET SİSTEMLERİ', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (35, N'KONSOL', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (36, N'KÖRÜK', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (37, N'KLAVUZ', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (38, N'MOTOR', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (39, N'ORİNG', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (40, N'FENS', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (41, N'ETİKET', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (42, N'BANTLAMA KASETİ', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (43, N'CIVATALI KELEBEK', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (44, N'BRAKET', N'A')
INSERT [dbo].[AltGrup] ([ID], [AltGrup], [Açıklama]) VALUES (45, N'BURC', N'A')
SET IDENTITY_INSERT [dbo].[AltGrup] OFF
GO
SET IDENTITY_INSERT [dbo].[Grup] ON 

INSERT [dbo].[Grup] ([ID], [Grup], [Açıklama]) VALUES (16, N'MEKANİK', N'MEKANİK')
INSERT [dbo].[Grup] ([ID], [Grup], [Açıklama]) VALUES (17, N'HİDROLİK', N'a')
INSERT [dbo].[Grup] ([ID], [Grup], [Açıklama]) VALUES (18, N'KIRTASİYE', N'A')
INSERT [dbo].[Grup] ([ID], [Grup], [Açıklama]) VALUES (19, N'MEKANİK', N'A')
INSERT [dbo].[Grup] ([ID], [Grup], [Açıklama]) VALUES (20, N'PNOMATİK', N'A')
INSERT [dbo].[Grup] ([ID], [Grup], [Açıklama]) VALUES (21, N'ROBOT', N'A')
INSERT [dbo].[Grup] ([ID], [Grup], [Açıklama]) VALUES (22, N'HIRDAVAT', N'A')
SET IDENTITY_INSERT [dbo].[Grup] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanıcılar] ON 

INSERT [dbo].[Kullanıcılar] ([ID], [adSoyad], [kullanıcıAdı], [sifre], [birim]) VALUES (18, N'yasinağabacak', N'admin', N'admin', N'ADMİN')
INSERT [dbo].[Kullanıcılar] ([ID], [adSoyad], [kullanıcıAdı], [sifre], [birim]) VALUES (19, N'YASİN', N'tasarım', N'tasarım', N'TASARIM')
INSERT [dbo].[Kullanıcılar] ([ID], [adSoyad], [kullanıcıAdı], [sifre], [birim]) VALUES (20, N'yasin', N'depo', N'depo', N'DEPO')
SET IDENTITY_INSERT [dbo].[Kullanıcılar] OFF
GO
SET IDENTITY_INSERT [dbo].[malzemeCikis] ON 

INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (1, N'111', N'asdsad', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'rtu57789900**07', N'Üretime yanlış malzeme verildi', N'', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (2, N'111', N'asdsad', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'Üretim esnasında kırıldı - bozuldu', N'Sarf malzemeleri', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (6, N'123456', N'asdsad', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'Servis için istendi', N'Üretime eksik verildi', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (7, N'123456', N'asdsad', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'Üretim esnasında kırıldı - bozuldu', N'Üretime eksik verildi', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (9, N'123456', N'asdsad', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'', N'Üretime eksik verildi', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (10, N'123456', N'asdsad', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'Üretimde iş görmedi', N'', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (12, N'1550', N'yasin', 15, N'LİTRE', N'mehmet', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'qwewq', N'Üretimde iş görmedi', N'', N'qwewqe', 15)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (14, N'1541', N'ceylan', 15, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'aldı', N'', N'', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (15, N'1541', N'ceylan', 15, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'aldı', N'', N'Sarf malzemeleri', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (16, N'1541', N'ceylan', 15, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'aldı', N'', N'Üretime eksik verildi', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (17, N'123456', N'asdsad', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'', N'', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (18, N'123456', N'asdsad', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'Üretime yanlış malzeme verildi', N'', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (19, N'123456', N'ahmet', 11, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'Üretime yanlış malzeme verildi', N'', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (20, N'12123', N'EPT_01_PLASTIK_TUTAMAC_LEVEL', 0, N'ADET', N'asdasd', N'ÖN İMALAT', CAST(N'2022-03-28' AS Date), N'asdasd', N'Servis için istendi', N'Üretime eksik verildi', NULL, NULL)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (21, N'123456', N'asdsad', 10, N'METRE', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'', N'Üretime eksik verildi', N'aaa', 1111)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (22, N'1541', N'ceylan', 10, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'aldı', N'', N'Sarf malzemeleri', N'asdsa', 12312)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (23, N'19191919', N'ES7_B_MAKINE_AYAGI', 10, N'ADET', N'yasin ağaçbacak', N'İMALAT', CAST(N'2022-03-28' AS Date), N'aa', N'Servis için istendi', N'Üretime eksik verildi', N'TÜRK TELEKOM', 2565)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (24, N'15515', N'qqqqqqqqq', 15, N'ADET', N'asdasd', N'TASARIM', CAST(N'2022-03-28' AS Date), N'asdsa', N'Üretimde iş görmedi', N'', N'asdsa', 2663)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (25, N'1541', N'ceylan', 10, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'aldı', N'', N'', N'hp', 1432)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (26, N'1541', N'ceylan', 15, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'aldı', N'', N'Üretime eksik verildi', N'türkcell', 123)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (27, N'1541', N'ceylan', 12, N'ADET', N'YASİN', N'ÖN İMALAT', CAST(N'2022-03-29' AS Date), N'aldı', N'', N'', N'HP', 1432)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (28, N'1541', N'POS_6_L_ERKEK_MANDA_GOZU', 60, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-29' AS Date), N'aldı', N'', N'', N'aa', 1212)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (29, N'12', N'POS_6_L_ERKEK_MANDA_GOZU', 10, N'ADET', N'aa', N'TASARIM', CAST(N'2022-03-29' AS Date), N'aa', N'Üretime yanlış malzeme verildi', N'', N'aa', 11)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (30, N'1212', N'Denge Ayağı EC 2015', 20, N'ADET', N'asdasd', N'ÖN İMALAT', CAST(N'2022-03-29' AS Date), N'asda', N'Üretime yanlış malzeme verildi', N'', N'qww', 1212)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (31, N'1541', N'VIRAJ_AYNASI_500MM', 10, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'aldı', N'', N'Sarf malzemeleri', N'tt', 121212)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (32, N'1541', N'VIRAJ_AYNASI_500MM', 10, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-29' AS Date), N'aldı', N'', N'Sarf malzemeleri', N'tt', 121212)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (33, N'11111111', N'aaaaaaaaa', 1111111, N'ADET', N'ww', N'TASARIM', CAST(N'2022-03-29' AS Date), N'ww', N'', N'', N'aaaaaaaaa', 11111111)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (34, N'1111', N'aaaaaaaaa', 1111111, N'ADET', N'asdsa', N'TASARIM', CAST(N'2022-03-29' AS Date), N'assdasd', N'', N'', N'aaaaaaaaa', 11111111)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (35, N'19191919', N'POS_6_L_ERKEK_MANDA_GOZU', 5, N'ADET', N'yasin ağaçbacak', N'İMALAT', CAST(N'2022-03-31' AS Date), N'aa', N'Servis için istendi', N'Üretime eksik verildi', N'aa', 1212)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (36, N'19191919', N'POS_6_L_ERKEK_MANDA_GOZU', 5, N'ADET', N'yasin ağaçbacak', N'İMALAT', CAST(N'2022-03-31' AS Date), N'aa', N'Servis için istendi', N'Üretime eksik verildi', N'aa', 1212)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (37, N'1541', N'POS_6_L_ERKEK_MANDA_GOZU', 2, N'ADET', N'yasin', N'ÖN İMALAT', CAST(N'2022-03-23' AS Date), N'aldı', N'', N'', N'aa', 1212)
INSERT [dbo].[malzemeCikis] ([ID], [projeNO], [parcaStokAdi], [miktar], [tur], [tesimAlan], [birim], [tarih], [acıklama], [eskisiİstenicek], [İstenmeyecek], [marka], [seriNo]) VALUES (38, N'123456', N'POS_6_L_ERKEK_MANDA_GOZU', 1, N'ADET', N'asdas', N'TASARIM', CAST(N'2022-03-23' AS Date), N'asdsd', N'Üretimde iş görmedi', N'', N'aa', 1212)
SET IDENTITY_INSERT [dbo].[malzemeCikis] OFF
GO
SET IDENTITY_INSERT [dbo].[MalzemeCinsi] ON 

INSERT [dbo].[MalzemeCinsi] ([ID], [MalzemeCinsi], [Açıklama]) VALUES (9, N'ST37', N'A')
INSERT [dbo].[MalzemeCinsi] ([ID], [MalzemeCinsi], [Açıklama]) VALUES (10, N'AL47', N'A')
INSERT [dbo].[MalzemeCinsi] ([ID], [MalzemeCinsi], [Açıklama]) VALUES (11, N'PASLANMAZ', N'A')
INSERT [dbo].[MalzemeCinsi] ([ID], [MalzemeCinsi], [Açıklama]) VALUES (12, N'ÇELİK', N'A')
INSERT [dbo].[MalzemeCinsi] ([ID], [MalzemeCinsi], [Açıklama]) VALUES (13, N'BAKIR', N'A')
SET IDENTITY_INSERT [dbo].[MalzemeCinsi] OFF
GO
SET IDENTITY_INSERT [dbo].[ProsesGrubu] ON 

INSERT [dbo].[ProsesGrubu] ([ID], [ProsesGrubu], [Açıklama]) VALUES (14, N'OEM', N'OEM')
INSERT [dbo].[ProsesGrubu] ([ID], [ProsesGrubu], [Açıklama]) VALUES (15, N'İMALAT', N'İMALAT')
INSERT [dbo].[ProsesGrubu] ([ID], [ProsesGrubu], [Açıklama]) VALUES (17, N'MEKANİK', N'A')
INSERT [dbo].[ProsesGrubu] ([ID], [ProsesGrubu], [Açıklama]) VALUES (18, N'T-MEKANİK', N'A')
SET IDENTITY_INSERT [dbo].[ProsesGrubu] OFF
GO
SET IDENTITY_INSERT [dbo].[StokTalebi] ON 

INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (7, N'xxxx', N'kelem', 15, NULL, N'RED', N'ADET', CAST(N'2022-03-21' AS Date), N'Elimizdekilerin hepsi bize lazım', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (9, N'1111111111111111', N'AAAAAA', 15, NULL, N'RED', N'', CAST(N'2022-03-21' AS Date), N'QQ', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (11, N'dasda', N'elit', 12, NULL, N'RED', N'KİLO', CAST(N'2022-03-22' AS Date), N'elimde cok az sayıda olduğu için malesef size bu üründen ayrılamam stoklar tazelendiğinde tekrar talepte bulursanız sevinirim', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (12, N'11', N'kalem', 10, NULL, N'KABUL', N'', CAST(N'2022-03-22' AS Date), N'kabul edilmiştir', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (15, N'QWEQW', N'wwwww', 5, NULL, N'BEKLEMEDE', N'', CAST(N'2022-03-22' AS Date), N'99adet var zaten veremem', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (19, N'xxxx', N'kardeşler kundurua', 25, N'ademkarayatak', N'KABUL', N'ADET', CAST(N'2022-05-05' AS Date), N'05.05.2022 tarihine kadar size rezerve edilmiştir', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (20, N'QWEQW', N'optimak', 45, N'ademkarayatak', N'RED', N'', CAST(N'2022-03-19' AS Date), N'bize lazım kanka', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (21, N'QWEQW', N'optimak', 25, N'admin', N'KABUL', N'', CAST(N'2022-03-23' AS Date), N'size rezerve ettim', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (22, N'PHS_12_L_DISI_MANDA_GOZU', N'opel', 25, N'admin', N'KABUL', N'ADET', CAST(N'2022-09-01' AS Date), N'SİZE AYIRIDIM
', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (25, N'211_2_BAGLANI_ELEMANI_KUKAMET', N'qqq', 11111, N'admin', N'KABUL', N'ADET', CAST(N'2022-03-24' AS Date), N'ww', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (26, N'VIRAJ_AYNASI_500MM', N'cc', 22, N'admin', N'RED', N'ADET', CAST(N'2022-03-24' AS Date), N'www', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (28, N'211_2_BAGLANI_ELEMANI_KUKAMET', N'mahmut', 10, N'tasarım', N'KABUL', N'ADET', CAST(N'2022-03-24' AS Date), N'sende kanka o', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (29, N'PHS_12_L_DISI_MANDA_GOZU', N'sds', 20, N'tasarım', N'RED', N'ADET', CAST(N'2022-03-24' AS Date), N'başkasına rezecerafdf', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (30, N'qqqqqqqqq', N'hakan', 10000000, N'tasarım', N'KABUL', N'ADET', CAST(N'2022-03-25' AS Date), N'size rezever ettiö', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (31, N'EPT_01_PLASTIK_TUTAMAC_LEVEL', N'optimak', 10, N'tasarım', N'KABUL', N'ADET', CAST(N'2022-03-28' AS Date), N'kabul', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (32, N'aaaaaaaaa', N'aaaaa', 500, N'admin', N'TALEPTE', N'ADET', CAST(N'2022-03-29' AS Date), N'aaaaaaa', NULL)
INSERT [dbo].[StokTalebi] ([ID], [stokAdi], [projeAdi], [ihtiyac], [talepEden], [durumu], [birim], [tarih], [acıklama], [marka]) VALUES (33, N'EPT_01_PLASTIK_TUTAMAC_LEVEL', N'asds', 121, N'admin', N'BEKLEMEDE      ', N'ADET', CAST(N'2022-03-29' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[StokTalebi] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_stokKarti] ON 

INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (91, N'OEM', N'MEKANİK', N'AKUATÖR', N'VIRAJ_AYNASI_500MM', N'ST37', N'500', 5, 90, N'yasin', CAST(N'2022-03-23' AS Date), N'ADET', N'CASPER', 9987)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (92, N'OEM', N'MEKANİK', N'KAYIŞ', N'211_2_BAGLANI_ELEMANI_KUKAMET', N'ST37', N'21', 15, 0, N'yasin', CAST(N'2022-03-23' AS Date), N'ADET', N'YILMAZ', 2234)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (93, N'OEM', N'MEKANİK', N'KAYIŞ', N'ES7_B_MAKINE_AYAGI', N'ST37', N'21', 5, 16, N'yasin', CAST(N'2022-03-23' AS Date), N'METRE', N'ıphone', 1555)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (94, N'İMALAT', N'MEKANİK', N'KASNAK', N'PHS_12_L_DISI_MANDA_GOZU', N'PASLANMAZ', N'500', 25, 25, N'yasin', CAST(N'2022-03-23' AS Date), N'ADET', N'YILMAZ', 5689)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (95, N'İMALAT', N'MEKANİK', N'KASNAK', N'POS_6_L_ERKEK_MANDA_GOZU', N'PASLANMAZ', N'500', 15, 35, N'yasin', CAST(N'2022-03-23' AS Date), N'ADET', N'SOKUROĞLU', 88434)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (96, N'T-MEKANİK', N'HİDROLİK', N'EMNİYET SİSTEMLERİ', N'1748_90DERECE_DIS_CERCEVELI_KOSE_BAGLANTI', N'ST37', N'0', 15, 0, N'yasin', CAST(N'2022-03-23' AS Date), N'ADET', N'SOKUROĞLU', 95043)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (97, N'OEM', N'MEKANİK', N'SOMUN', N'M22_FIBERLI_SOMUN', N'ST37', N'15', 25000, 45000, N'yasin', CAST(N'2022-03-23' AS Date), N'ADET', N'KARDAĞ', 95678)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (98, N'MEKANİK', N'MEKANİK', N'AYAK', N'EPT_01_PLASTIK_TUTAMAC_LEVEL', N'ST37', N'1', 2, 1, N'uzay', CAST(N'2022-04-02' AS Date), N'ADET', N'ASDAS', 2321)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (99, N'MEKANİK', N'MEKANİK', N'AYAK', N'EPT_01_PLASTIK_TUTAMAC_LEVEL', N'ST37', N'1', 0, 0, N'yasin', CAST(N'2022-04-02' AS Date), N'ADET', N'OPTİMAK', 95700)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (100, N'İMALAT', N'HIRDAVAT', N'AYAK', N'EPT_01_PLASTIK_TUTAMAC_LEVEL', N'ST37', N'1234', 11, 11, N'yasin', CAST(N'2022-04-02' AS Date), N'ADET', N'OPTİMAK', 15)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (101, N'İMALAT', N'HIRDAVAT', N'AYAK', N'EPT_01_PLASTIK_TUTAMAC_LEVEL', N'ST37', N'1234', 0, 122, N'yasin', CAST(N'2022-04-02' AS Date), N'ADET', N'qwqq', 1221)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (104, N'MEKANİK', N'ROBOT', N'PİSTON AKSESUARI', N'asdad', N'AL47', N'12', 121, 12, N'yasin', CAST(N'2022-03-24' AS Date), N'ADET', N'asdsa', 212)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (105, N'MEKANİK', N'MEKANİK', N'AYAK', N'EV63_0_55KW_37DD_M3_P1_B_REDUKTORLU_MOTOR', N'ST37', N'1', 0, 0, N'yasin', CAST(N'2022-04-02' AS Date), N'ADET', N'OPTİMAK', 98370)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (107, N'OEM', N'MEKANİK', N'SOMUN', N'M22_FIBERLI_SOMUN', N'ST37', N'15', 25000, 45000, N'uzay', CAST(N'2022-03-23' AS Date), N'ADET', N'dasdas', 121)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (108, N'İMALAT', N'HİDROLİK', N'AYAK', N'qqqqqqqqq', N'AL47', N'12', 0, 0, N'yasin', CAST(N'2022-03-24' AS Date), N'ADET', N'nike', 13212)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (110, N'MEKANİK', N'ROBOT', N'PİSTON AKSESUARI', N'asdad', N'AL47', N'12', 121, 12, N'yasin', CAST(N'2022-03-24' AS Date), N'ADET', N'asdsa', 212)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (111, N'OEM', N'MEKANİK', N'KASNAK', N'POS_6_L_ERKEK_MANDA_GOZU', N'PASLANMAZ', N'500', 0, 65, N'yasin', CAST(N'2022-03-23' AS Date), N'ADET', N'aa', 1212)
INSERT [dbo].[tbl_stokKarti] ([id], [prosesGrubu], [grupAdi], [altGrupAdi], [parcaStokAdi], [malzemeCinsi], [uzunluk], [miktar], [ihtiyac], [tedarikci], [tarih], [birim], [marka], [seriNo]) VALUES (113, N'OEM', N'MEKANİK', N'AYAK', N'Denge Ayağı EC 2015', N'ST37', N'0', 15, 0, N'yasin', CAST(N'2022-03-23' AS Date), N'ADET', N'OPTİMAK', 99246)
SET IDENTITY_INSERT [dbo].[tbl_stokKarti] OFF
GO
SET IDENTITY_INSERT [dbo].[tedarikciBilgileri] ON 

INSERT [dbo].[tedarikciBilgileri] ([ID], [firmaAdi], [sektor], [firmaYetkilisi], [telefonNumarası], [adresi]) VALUES (6, N'AĞAÇBACAK HOLDİNG', N'İHA MOTOR UYGULAMALARI', N'YASİN AĞAÇBACAK', N'(053) 502-2845', N'SAKARYA')
INSERT [dbo].[tedarikciBilgileri] ([ID], [firmaAdi], [sektor], [firmaYetkilisi], [telefonNumarası], [adresi]) VALUES (7, N'uzay', N'mutfak', N'mehmet', N'5350228451', N'istanbul')
INSERT [dbo].[tedarikciBilgileri] ([ID], [firmaAdi], [sektor], [firmaYetkilisi], [telefonNumarası], [adresi]) VALUES (8, N'KARACA', N'MUTFAK', N'REYHAN FİDAYE', N'(535) 022-8451', N'İSTANBUL')
INSERT [dbo].[tedarikciBilgileri] ([ID], [firmaAdi], [sektor], [firmaYetkilisi], [telefonNumarası], [adresi]) VALUES (9, N'ARMSAN', N'silah sanayisi', N'yasin ağaçbacak', N'(535) 022-8', N'sakarya/serdivan')
INSERT [dbo].[tedarikciBilgileri] ([ID], [firmaAdi], [sektor], [firmaYetkilisi], [telefonNumarası], [adresi]) VALUES (10, N'FABER CASTER', N'Kırtasiye ürünleri', N'Emre yanık', N'05350228451', N'istanbul/ünalan')
INSERT [dbo].[tedarikciBilgileri] ([ID], [firmaAdi], [sektor], [firmaYetkilisi], [telefonNumarası], [adresi]) VALUES (11, N'HAKAN KARAKAŞ', N'SİLAH SANAYİSİ', N'YASİN', N'(053) 502-2845', N'sakarya/serdivann')
INSERT [dbo].[tedarikciBilgileri] ([ID], [firmaAdi], [sektor], [firmaYetkilisi], [telefonNumarası], [adresi]) VALUES (12, N'MAK MAKİNA', N'İMALAT', N'HÜSEYİN BEY', N'(535) 000-0000', N'İSTANBUL/İMES')
INSERT [dbo].[tedarikciBilgileri] ([ID], [firmaAdi], [sektor], [firmaYetkilisi], [telefonNumarası], [adresi]) VALUES (14, N'CASPER', N'ROBOTİK KODLAMA', N'YASİN AĞAÇBACAK', N'(555) 555-5555', N'SAKARYA/ERENLER')
SET IDENTITY_INSERT [dbo].[tedarikciBilgileri] OFF
GO
USE [master]
GO
ALTER DATABASE [STOK] SET  READ_WRITE 
GO
