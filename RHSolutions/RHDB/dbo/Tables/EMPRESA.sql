CREATE TABLE [dbo].[EMPRESA] (
    [Cpf]             VARCHAR (15)  NOT NULL,
    [NomeEmpresa]     VARCHAR (MAX) NOT NULL,
    [CnpjEmpresa]     VARCHAR (20)  NOT NULL,
    [EnderEmpresa]    VARCHAR (150) NOT NULL,
    [TelefoneEmpresa] VARCHAR (11)  NOT NULL,
    FOREIGN KEY ([Cpf]) REFERENCES [dbo].[FUNCIONARIO] ([Cpf])
);

