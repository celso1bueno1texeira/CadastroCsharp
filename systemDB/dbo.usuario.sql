CREATE TABLE [dbo].[usuario] (
    [Id]    INT        NOT NULL IDENTITY,
    [login] NCHAR (20) NOT NULL,
    [senha] NCHAR (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

