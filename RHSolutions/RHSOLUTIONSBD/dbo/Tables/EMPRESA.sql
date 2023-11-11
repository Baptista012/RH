CREATE TABLE [dbo].[EMPRESA] (
    [CpfFuncionario]  VARCHAR (15)  NOT NULL,
    [NomeEmpresa]     VARCHAR (MAX) NULL,
    [CnpjEmpresa]     VARCHAR (20)  NULL,
    [EnderEmpresa]    VARCHAR (150) NULL,
    [TelefoneEmpresa] VARCHAR (11)  NULL,
    FOREIGN KEY ([CpfFuncionario]) REFERENCES [dbo].[FUNCIONARIO] ([Cpf])
);

