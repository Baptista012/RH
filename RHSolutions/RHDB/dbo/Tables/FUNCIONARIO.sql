CREATE TABLE [dbo].[FUNCIONARIO] (
    [Cpf]                 VARCHAR (15)  NOT NULL,
    [Nome]                VARCHAR (150) NOT NULL,
    [TelefoneFunc]        VARCHAR (11)  NOT NULL,
    [CargoFunc]           VARCHAR (MAX) NOT NULL,
    [SalarioFunc]         FLOAT (53)    NOT NULL,
    [Funcional]           VARCHAR (10)  NOT NULL,
    [VAuxilioAlimentacao] FLOAT (53)    NULL,
    [VAuxilioRefeicao]    FLOAT (53)    NULL,
    [Senha]               VARCHAR (8)   NOT NULL,
    [Email]               VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Cpf] ASC)
);

