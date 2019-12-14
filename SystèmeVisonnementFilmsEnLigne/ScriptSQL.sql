GO
GO
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'SystèmeVisonnementFilmsEnLigneDB')
	CREATE DATABASE SystèmeVisonnementFilmsEnLigneDB
GO
Use SystèmeVisonnementFilmsEnLigneDB
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblRemboursement' and xtype='U')
	CREATE TABLE [dbo].[tblRemboursement] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	dateTransaction datetime, 	typeTransaction nvarchar(255), 	prix float, 	montantTaxe float, 
	CONSTRAINT [PK_tblRemboursement] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblApprovisionnement' and xtype='U')
	CREATE TABLE [dbo].[tblApprovisionnement] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	dateTransaction datetime, 	typeTransaction nvarchar(255), 	prix float, 	montantTaxe float, 
	CONSTRAINT [PK_tblApprovisionnement] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblVisionnement' and xtype='U')
	CREATE TABLE [dbo].[tblVisionnement] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	dateTransaction datetime, 	typeTransaction nvarchar(255), 	prix float, 	montantTaxe float, 	IDPaiement  uniqueidentifier NOT NULL, 
	CONSTRAINT [PK_tblVisionnement] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblCatégorie' and xtype='U')
	CREATE TABLE [dbo].[tblCatégorie] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	description nvarchar(255), 
	CONSTRAINT [PK_tblCatégorie] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblClient' and xtype='U')
	CREATE TABLE [dbo].[tblClient] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	nom nvarchar(255), 	prénom nvarchar(255), 	adresse nvarchar(255), 	téléphone nvarchar(255), 	adresseCourriel nvarchar(255), 	aAcceptéRecevoirNuveautés bit, 	nomUsager nvarchar(255), 	motDePasse nvarchar(255), 
	CONSTRAINT [PK_tblClient] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblSession' and xtype='U')
	CREATE TABLE [dbo].[tblSession] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	dateConnexion datetime, 	dateDéconnexion datetime, 	IDVisiteur  uniqueidentifier NOT NULL, 
	CONSTRAINT [PK_tblSession] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblDistributeur' and xtype='U')
	CREATE TABLE [dbo].[tblDistributeur] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	nom nvarchar(255), 	adresse nvarchar(255), 	téléphone nvarchar(255), 	adresseCourriel nvarchar(255), 	adresseSiteWeb nvarchar(255), 
	CONSTRAINT [PK_tblDistributeur] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblPaiementCarteCrédit' and xtype='U')
	CREATE TABLE [dbo].[tblPaiementCarteCrédit] (	[ID] [uniqueidentifier] NOT NULL,	numéroCarteCrédit nvarchar(255), 	titulaire nvarchar(255), 	dateExpiration nvarchar(255), 	numéro nvarchar(255), 	date datetime, 	montant float, 
	CONSTRAINT [PK_tblPaiementCarteCrédit] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblPaiementEnCompte' and xtype='U')
	CREATE TABLE [dbo].[tblPaiementEnCompte] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	date datetime, 	montant float, 	IDCompte  uniqueidentifier NOT NULL, 
	CONSTRAINT [PK_tblPaiementEnCompte] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblBandeAnnonce' and xtype='U')
	CREATE TABLE [dbo].[tblBandeAnnonce] (	[ID] [uniqueidentifier] NOT NULL,	durée int, 	bande nvarchar(255), 	IDFilm  uniqueidentifier NOT NULL, 
	CONSTRAINT [PK_tblBandeAnnonce] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblCompte' and xtype='U')
	CREATE TABLE [dbo].[tblCompte] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	solde float, 	numéroCarteCrédit nvarchar(255), 	titualire nvarchar(255), 	dateExpiration datetime, 	IDMembre  uniqueidentifier NOT NULL, 
	CONSTRAINT [PK_tblCompte] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblTransaction' and xtype='U')
	CREATE TABLE [dbo].[tblTransaction] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	dateTransaction datetime, 	typeTransaction nvarchar(255), 	prix float, 	montantTaxe float, 	IDSession  uniqueidentifier NOT NULL, 
	CONSTRAINT [PK_tblTransaction] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblPaiement' and xtype='U')
	CREATE TABLE [dbo].[tblPaiement] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	date datetime, 	montant float, 
	CONSTRAINT [PK_tblPaiement] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblAdministrateur' and xtype='U')
	CREATE TABLE [dbo].[tblAdministrateur] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	nom nvarchar(255), 	prénom nvarchar(255), 	adresse nvarchar(255), 	téléphone nvarchar(255), 	adresseCourriel nvarchar(255), 	aAcceptéRecevoirNuveautés bit, 	nomUsager nvarchar(255), 	motDePasse nvarchar(255), 
	CONSTRAINT [PK_tblAdministrateur] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblFilm' and xtype='U')
	CREATE TABLE [dbo].[tblFilm] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	titre nvarchar(255), 	durée int, 	coûtVisionnement float, 	coûtAchat float, 	synopsis nvarchar(255), 	motsClès nvarchar(255), 	réalisateurs nvarchar(255), 	producteurs nvarchar(255), 	maisonsProduction nvarchar(255), 	statut nvarchar(255), 	acteurs nvarchar(255), 	estApprouvé bit, 	IDRéalisateur  uniqueidentifier NOT NULL, 
	CONSTRAINT [PK_tblFilm] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblMembre' and xtype='U')
	CREATE TABLE [dbo].[tblMembre] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	nom nvarchar(255), 	prénom nvarchar(255), 	adresse nvarchar(255), 	téléphone nvarchar(255), 	adresseCourriel nvarchar(255), 	aAcceptéRecevoirNuveautés bit, 	nomUsager nvarchar(255), 	motDePasse nvarchar(255), 
	CONSTRAINT [PK_tblMembre] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblVisiteur' and xtype='U')
	CREATE TABLE [dbo].[tblVisiteur] (	[ID] [uniqueidentifier] NOT NULL,
	CONSTRAINT [PK_tblVisiteur] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblRéalisateur' and xtype='U')
	CREATE TABLE [dbo].[tblRéalisateur] (	[ID] [uniqueidentifier] NOT NULL,	numéro nvarchar(255), 	nom nvarchar(255), 	prénom nvarchar(255), 	adresse nvarchar(255), 	téléphone nvarchar(255), 	adresseCourriel nvarchar(255), 	aAcceptéRecevoirNuveautés bit, 	nomUsager nvarchar(255), 	motDePasse nvarchar(255), 
	CONSTRAINT [PK_tblRéalisateur] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	) 
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblSessionCoteFilm' and xtype='U')
	CREATE TABLE [dbo].[tblSessionCoteFilm] (	ID uniqueidentifier NOT NULL,	IDSession [uniqueidentifier] NOT NULL,	IDFilm  uniqueidentifier NOT NULL,	cote int, 	commentaire nvarchar(255), 
	CONSTRAINT [PK_tblSessionCoteFilm] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
	) ON [PRIMARY]

GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tblMembreADesPréférencesCatégorie' and xtype='U')
	CREATE TABLE [dbo].[tblMembreADesPréférencesCatégorie] (	ID uniqueidentifier NOT NULL,	IDMembre [uniqueidentifier] NOT NULL,	IDCatégorie  uniqueidentifier NOT NULL,
	CONSTRAINT [PK_tblMembreADesPréférencesCatégorie] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
	) ON [PRIMARY]

GO
