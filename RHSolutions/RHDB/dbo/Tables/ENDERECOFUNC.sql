CREATE TABLE [dbo].[ENDERECOFUNC] (
    [Endereco]    VARCHAR (MAX) NOT NULL,
    [Numero]      INT           NOT NULL,
    [Complemento] VARCHAR (150) NULL,
    [Cidade]      VARCHAR (50)  NOT NULL,
    [Cpf]         VARCHAR (15)  NOT NULL,
    [Cep]         VARCHAR (9)   NOT NULL,
    FOREIGN KEY ([Cpf]) REFERENCES [dbo].[FUNCIONARIO] ([Cpf])
);

