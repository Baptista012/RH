CREATE TABLE [dbo].[ENDERECOFUNC] (
    [Endereco]    VARCHAR (150) NOT NULL,
    [Numero]      INT           NULL,
    [Complemento] VARCHAR (150) NULL,
    [Cidade]      VARCHAR (MAX) NULL,
    [Cpf]         VARCHAR (15)  NOT NULL,
    [Cep]         VARCHAR (10)  NOT NULL,
    FOREIGN KEY ([Cpf]) REFERENCES [dbo].[FUNCIONARIO] ([Cpf])
);

