CREATE TABLE [dbo].[Messages] (
    [MessageID]    INT          IDENTITY (1, 1) NOT NULL,
    [Message]      VARCHAR (50) NULL,
    [EmptyMessage] VARCHAR (50) NULL,
    [MessageDate]  DATETIME     NOT NULL,
    CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED ([MessageID] ASC)
);

