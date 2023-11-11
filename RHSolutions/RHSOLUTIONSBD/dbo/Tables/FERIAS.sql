CREATE TABLE [dbo].[FERIAS] (
    [QtdDiasPrimeiroPeriodo] INT          NULL,
    [QtdDiasSegundoPeriodo]  INT          NULL,
    [QtdDiasTerceiroPeriodo] INT          NULL,
    [QtdPeriodos]            INT          NULL,
    [Cpf]                    VARCHAR (15) NOT NULL,
    [DataLimiteGozo]         DATE         NOT NULL,
    FOREIGN KEY ([Cpf]) REFERENCES [dbo].[FUNCIONARIO] ([Cpf])
);

