CREATE TABLE [dbo].[Table] (
    [contactsId]   INT           IDENTITY (1, 1) NOT NULL,
    [First Name]    NCHAR (20)    NOT NULL,
    [Last Name]     NCHAR (20)    NOT NULL,
    [Middle Inital] NCHAR (1)     NULL,
    [Email]       TEXT          NULL,
    [Phone Number]    NVARCHAR (15) NOT NULL,
    [Company]      NCHAR (40)    NULL,
    [DOB] DATE          NULL,
    [Job Title]     NCHAR (50)    NULL,
    [Personal]     BIT           NULL,
    [LastContact]  DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([contactsId] ASC)
);

