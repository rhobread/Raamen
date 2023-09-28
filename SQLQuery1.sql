CREATE TABLE [dbo].[Role] (
    [Id]   INT          NOT NULL,
    [name] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[User] (
    [Id]       INT          NOT NULL,
    [Roleid]   INT          NULL,
    [Username] VARCHAR (50) NULL,
    [Email]    VARCHAR (50) NULL,
    [Gender]   VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_Role] FOREIGN KEY ([Roleid]) REFERENCES [dbo].[Role] ([Id])
);

CREATE TABLE [dbo].[Header] (
    [Id]         INT  NOT NULL,
    [Customerid] INT  NULL,
    [Staffid]    INT  NULL,
    [Date]       DATE NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Header_User] FOREIGN KEY ([Customerid]) REFERENCES [dbo].[User] ([Id])
);

CREATE TABLE [dbo].[Meat] (
    [Id]   INT          NOT NULL,
    [name] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Ramen] (
    [Id]     INT          NOT NULL,
    [Meatid] INT          NULL,
    [Name]   VARCHAR (50) NULL,
    [Borth]  VARCHAR (50) NULL,
    [Price]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Ramen_Meat] FOREIGN KEY ([Meatid]) REFERENCES [dbo].[Meat] ([Id])
);

CREATE TABLE [dbo].[Detail] (
    [Headerid] INT NOT NULL,
    [Ramenid]  INT NULL,
    [Quantity] INT NULL,
    PRIMARY KEY CLUSTERED ([Headerid] ASC),
    CONSTRAINT [FK_Detail_Header] FOREIGN KEY ([Headerid]) REFERENCES [dbo].[Header] ([Id]),
    CONSTRAINT [FK_Detail_Ramen] FOREIGN KEY ([Ramenid]) REFERENCES [dbo].[Ramen] ([Id])
);

