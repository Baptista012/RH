CREATE TABLE [dbo].[PONTO] (
    [PrimeiraBatida]   TIME (7)     NULL,
    [SegundaBatida]    TIME (7)     NULL,
    [TerceiraBatida]   TIME (7)     NULL,
    [QuartaBatida]     TIME (7)     NULL,
    [HorasTrabalhadas] TIME (7)     NULL,
    [Cpf]              VARCHAR (15) NOT NULL,
    [Dia]              DATE         NOT NULL,
    FOREIGN KEY ([Cpf]) REFERENCES [dbo].[FUNCIONARIO] ([Cpf])
);

