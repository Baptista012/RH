CREATE TABLE [dbo].[PONTO] (
    [PrimeiraBatida]   DATETIME     NOT NULL,
    [SegundaBatida]    DATETIME     NOT NULL,
    [TerceiraBatida]   DATETIME     NULL,
    [QuartaBatida]     DATETIME     NULL,
    [HorasTrabalhadas] TIME (7)     NOT NULL,
    [Cpf]              VARCHAR (15) NOT NULL,
    [Dia]              DATE         NOT NULL,
    FOREIGN KEY ([Cpf]) REFERENCES [dbo].[FUNCIONARIO] ([Cpf])
);

