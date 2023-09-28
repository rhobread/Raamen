CREATE TABLE [dbo].[HeaderTool] (
    [Id]         INT  NOT NULL,
    [Customerid] INT  NULL,
    [Date]       DATE NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Header_User_Tool] FOREIGN KEY ([Customerid]) REFERENCES [dbo].[User] ([Id])
);

CREATE TABLE [dbo].[DetailTool] (
    [Headerid] INT NOT NULL,
    [Ramenid]  INT NULL,
    [Quantity] INT NULL,
    PRIMARY KEY CLUSTERED ([Headerid] ASC),
    CONSTRAINT [FK_Detail_Header_Tool] FOREIGN KEY ([Headerid]) REFERENCES [dbo].[HeaderTool] ([Id]),
    CONSTRAINT [FK_Detail_Ramen_Tool] FOREIGN KEY ([Ramenid]) REFERENCES [dbo].[Ramen] ([Id])
);