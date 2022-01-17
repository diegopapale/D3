# Estrutura

WebApplication - Projeto Front
ExemploAPI - Projeto API com o CRUD para banco de dados

# Scripts Tabela PessoaDados

CREATE TABLE [dbo].[PessoaDados](
	[IdDados] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[DataNascimento] [date] NOT NULL,
 CONSTRAINT [PK_PessoaDados] PRIMARY KEY CLUSTERED 
(
	[IdDados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

# Scripts Tabela PessoaTelefone

CREATE TABLE [dbo].[PessoaTelefone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TelefonePessoal] [int] NOT NULL,
	[TelefoneResidencial] [int] NOT NULL,
	[TelefoneRecado] [int] NOT NULL,
	[IdPessoa] [int] NOT NULL,
 CONSTRAINT [PK_PessoaTelefone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
, CONSTRAINT FK_Pessoa FOREIGN KEY (IdPessoa)
        REFERENCES PessoaDados (IdDados)
        ON DELETE CASCADE
        ON UPDATE CASCADE)