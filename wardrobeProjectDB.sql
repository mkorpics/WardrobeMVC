USE [master]
GO
/****** Object:  Database [WardrobeMVC]    Script Date: 5/16/2017 7:42:16 AM ******/
CREATE DATABASE [WardrobeMVC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WardrobeMVC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\WardrobeMVC.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WardrobeMVC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\WardrobeMVC_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WardrobeMVC] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WardrobeMVC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WardrobeMVC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ARITHABORT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WardrobeMVC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WardrobeMVC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WardrobeMVC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WardrobeMVC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WardrobeMVC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WardrobeMVC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WardrobeMVC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WardrobeMVC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WardrobeMVC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WardrobeMVC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WardrobeMVC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WardrobeMVC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WardrobeMVC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WardrobeMVC] SET  MULTI_USER 
GO
ALTER DATABASE [WardrobeMVC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WardrobeMVC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WardrobeMVC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WardrobeMVC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WardrobeMVC] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WardrobeMVC]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 5/16/2017 7:42:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Articles](
	[ArticleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Photo] [nvarchar](100) NULL,
	[ArticleTypeID] [int] NOT NULL,
	[ColorID] [int] NOT NULL,
	[SeasonID] [int] NOT NULL,
	[OccasionID] [int] NOT NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ArticleTypes]    Script Date: 5/16/2017 7:42:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArticleTypes](
	[ArticleTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ArticleType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ArticleTypes] PRIMARY KEY CLUSTERED 
(
	[ArticleTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 5/16/2017 7:42:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Colors](
	[ColorID] [int] IDENTITY(1,1) NOT NULL,
	[Color] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Occasions]    Script Date: 5/16/2017 7:42:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Occasions](
	[OccasionID] [int] IDENTITY(1,1) NOT NULL,
	[Occasion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Occasions] PRIMARY KEY CLUSTERED 
(
	[OccasionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Outfits]    Script Date: 5/16/2017 7:42:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Outfits](
	[OutfitID] [int] IDENTITY(1,1) NOT NULL,
	[ArticleID1] [int] NOT NULL,
	[ArticleID2] [int] NULL,
	[ArticleID3] [int] NULL,
	[ArticleID4] [int] NULL,
	[ArticleID5] [int] NULL,
	[ArticleID6] [int] NULL,
	[ArticleID7] [int] NULL,
	[ArticleID8] [int] NULL,
	[ArticleID9] [int] NULL,
	[ArticleID10] [int] NULL,
	[ArticleID11] [int] NULL,
	[ArticleID12] [int] NULL,
 CONSTRAINT [PK_Outfits] PRIMARY KEY CLUSTERED 
(
	[OutfitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Seasons]    Script Date: 5/16/2017 7:42:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seasons](
	[SeasonID] [int] IDENTITY(1,1) NOT NULL,
	[Season] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Seasons] PRIMARY KEY CLUSTERED 
(
	[SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Articles] ON 

INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (1, N'Super Speedy Super Fast Shoes', N'~\Content\images\IMG_HermesBoots.JPG', 3, 2, 1, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (2, N'Just for Style', NULL, 1, 3, 1, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (3, N'Completely Useless But Totally Cool', N'~/Content\images\IMG_BlackCape.JPG', 1, 11, 1, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (4, N'Super-intellectual Glasses', N'~/Content/images/No-Photo-Available-240x300.jpg', 4, 12, 3, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (5, N'Particularly Fascinating Utility Belt', N'~/Content/images/IMG_2978.JPG', 4, 6, 6, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (6, N'Ubiquitous Protagonist-Armor Suit', N'~\Content\images\IMG_SuitGold.JPG', 2, 11, 1, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (8, N'Seedy X-Ray Vision Goggles', N'~\Content\images\IMG_2974.JPG', 4, 9, 2, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (9, N'Authentic Hero''s Mask', N'~/Content\images\IMG_2975.JPG', 4, 4, 3, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (10, N'Because I''m That Cool Glasses', N'~\Content\images\IMG_2976.JPG', 4, 2, 6, 5)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (11, N'Gorgeous Gloves', N'~\Content\images\IMG_2977.JPG', 4, 2, 6, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (12, N'Super-communication Earpiece', N'~\Content\images\IMG_2979.JPG', 4, 2, 3, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (15, N'Required Set of Invisible Accessories', N'~\Content\images\Man.gif', 4, 16, 3, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (16, N'(Surprisingly Practical) Warm Cape', N'~\Content\images\IMG_RedCape.JPG', 1, 7, 1, 3)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (17, N'Superaerodynamic', N'~/Content\images\IMG_BlueCape.JPG', 1, 9, 2, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (18, N'Invisible Cape Just Because', N'~\Content\images\dancers-1825660_1920.jpg', 1, 16, 3, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (19, N'Trying Too Hard Gecko Boots', N'~\Content\images\IMG_OrangeGreenBoots.JPG', 3, 5, 6, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (20, N'Impractical and Nonfunctional But Stylish', N'~\Content\images\IMG_BlackGreenBoots.JPG', 3, 10, 1, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (21, N'Who Wants Water Waterproof Boots', N'~\Content\images\IMG_PurpleBoots.JPG', 3, 15, 3, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (22, N'Completely Necessary Invisible Boots', N'~\Content\images\Blank.jpg', 3, 16, 3, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (23, N'The Incredible Invisible Suit', N'~\Content\images\dancers-1825659_1920.jpg', 2, 16, 3, 1)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (24, N'Ultra-Flex Spandex Stretch Suit', N'~\Content\images\IMG_SuitPurple.JPG', 2, 15, 3, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (25, N'Environment Proof Suit', N'~\Content\images\IMG_SuitSilver.JPG', 2, 12, 2, 2)
INSERT [dbo].[Articles] ([ArticleID], [Name], [Photo], [ArticleTypeID], [ColorID], [SeasonID], [OccasionID]) VALUES (26, N'Too Hot For Your Own Good Temperature-Regulated', N'~\Content\images\IMG_SuitScarlet.JPG', 2, 8, 1, 2)
SET IDENTITY_INSERT [dbo].[Articles] OFF
SET IDENTITY_INSERT [dbo].[ArticleTypes] ON 

INSERT [dbo].[ArticleTypes] ([ArticleTypeID], [ArticleType]) VALUES (1, N'Cape')
INSERT [dbo].[ArticleTypes] ([ArticleTypeID], [ArticleType]) VALUES (2, N'Suit')
INSERT [dbo].[ArticleTypes] ([ArticleTypeID], [ArticleType]) VALUES (3, N'Shoes')
INSERT [dbo].[ArticleTypes] ([ArticleTypeID], [ArticleType]) VALUES (4, N'Accessories')
SET IDENTITY_INSERT [dbo].[ArticleTypes] OFF
SET IDENTITY_INSERT [dbo].[Colors] ON 

INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (2, N'Midnight Black')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (3, N'Optimistic White')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (4, N'Visionary Violet')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (5, N'Eco-friendly Green')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (6, N'Unconventional Mauve')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (7, N'Traditional Red')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (8, N'Savage Scarlet')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (9, N'Marvelous Blue')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (10, N'Suave Silver')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (11, N'Golden-witted Gold')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (12, N'Wise-man Gray')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (13, N'Complex Yellow')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (14, N'Noble Brown')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (15, N'Poisonous Purple')
INSERT [dbo].[Colors] ([ColorID], [Color]) VALUES (16, N'Versatile Chameleon')
SET IDENTITY_INSERT [dbo].[Colors] OFF
SET IDENTITY_INSERT [dbo].[Occasions] ON 

INSERT [dbo].[Occasions] ([OccasionID], [Occasion]) VALUES (1, N'Saving the Day in Stealth Mode')
INSERT [dbo].[Occasions] ([OccasionID], [Occasion]) VALUES (2, N'Saving the Day in a Blaze of Glory')
INSERT [dbo].[Occasions] ([OccasionID], [Occasion]) VALUES (3, N'Meet the Mayor')
INSERT [dbo].[Occasions] ([OccasionID], [Occasion]) VALUES (5, N'Alter Ego')
SET IDENTITY_INSERT [dbo].[Occasions] OFF
SET IDENTITY_INSERT [dbo].[Outfits] ON 

INSERT [dbo].[Outfits] ([OutfitID], [ArticleID1], [ArticleID2], [ArticleID3], [ArticleID4], [ArticleID5], [ArticleID6], [ArticleID7], [ArticleID8], [ArticleID9], [ArticleID10], [ArticleID11], [ArticleID12]) VALUES (1, 26, 1, 17, 10, 5, 12, 11, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Outfits] ([OutfitID], [ArticleID1], [ArticleID2], [ArticleID3], [ArticleID4], [ArticleID5], [ArticleID6], [ArticleID7], [ArticleID8], [ArticleID9], [ArticleID10], [ArticleID11], [ArticleID12]) VALUES (2, 6, 20, 2, 9, 5, 11, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Outfits] ([OutfitID], [ArticleID1], [ArticleID2], [ArticleID3], [ArticleID4], [ArticleID5], [ArticleID6], [ArticleID7], [ArticleID8], [ArticleID9], [ArticleID10], [ArticleID11], [ArticleID12]) VALUES (6, 23, 22, 18, 15, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Outfits] ([OutfitID], [ArticleID1], [ArticleID2], [ArticleID3], [ArticleID4], [ArticleID5], [ArticleID6], [ArticleID7], [ArticleID8], [ArticleID9], [ArticleID10], [ArticleID11], [ArticleID12]) VALUES (7, 25, 21, 17, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Outfits] OFF
SET IDENTITY_INSERT [dbo].[Seasons] ON 

INSERT [dbo].[Seasons] ([SeasonID], [Season]) VALUES (1, N'Glory days')
INSERT [dbo].[Seasons] ([SeasonID], [Season]) VALUES (2, N'Hero They Deserve')
INSERT [dbo].[Seasons] ([SeasonID], [Season]) VALUES (3, N'Hero They Need')
INSERT [dbo].[Seasons] ([SeasonID], [Season]) VALUES (4, N'Became the villain')
INSERT [dbo].[Seasons] ([SeasonID], [Season]) VALUES (6, N'Multi-Season')
INSERT [dbo].[Seasons] ([SeasonID], [Season]) VALUES (7, N'TItular Alcoholic')
SET IDENTITY_INSERT [dbo].[Seasons] OFF
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_Articles_ArticleTypes] FOREIGN KEY([ArticleTypeID])
REFERENCES [dbo].[ArticleTypes] ([ArticleTypeID])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_Articles_ArticleTypes]
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_Articles_Colors] FOREIGN KEY([ColorID])
REFERENCES [dbo].[Colors] ([ColorID])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_Articles_Colors]
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_Articles_Occasions] FOREIGN KEY([OccasionID])
REFERENCES [dbo].[Occasions] ([OccasionID])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_Articles_Occasions]
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_Articles_Seasons] FOREIGN KEY([SeasonID])
REFERENCES [dbo].[Seasons] ([SeasonID])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_Articles_Seasons]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles] FOREIGN KEY([ArticleID1])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles1] FOREIGN KEY([ArticleID2])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles1]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles10] FOREIGN KEY([ArticleID11])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles10]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles11] FOREIGN KEY([ArticleID12])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles11]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles2] FOREIGN KEY([ArticleID3])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles2]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles3] FOREIGN KEY([ArticleID4])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles3]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles4] FOREIGN KEY([ArticleID5])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles4]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles5] FOREIGN KEY([ArticleID6])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles5]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles6] FOREIGN KEY([ArticleID7])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles6]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles7] FOREIGN KEY([ArticleID8])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles7]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles8] FOREIGN KEY([ArticleID9])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles8]
GO
ALTER TABLE [dbo].[Outfits]  WITH CHECK ADD  CONSTRAINT [FK_Outfits_Articles9] FOREIGN KEY([ArticleID10])
REFERENCES [dbo].[Articles] ([ArticleID])
GO
ALTER TABLE [dbo].[Outfits] CHECK CONSTRAINT [FK_Outfits_Articles9]
GO
USE [master]
GO
ALTER DATABASE [WardrobeMVC] SET  READ_WRITE 
GO
