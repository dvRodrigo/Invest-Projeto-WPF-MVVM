--CREATE DATABASE ProjetoWPF

USE ProjetoWPF



CREATE TABLE Corretoras(
PK_Corretora INT PRIMARY KEY IDENTITY(1,1),
Nome VARCHAR(300),
CNPJ VARCHAR(300),
)

CREATE TABLE Investidores(
PK_Investidor INT PRIMARY KEY IDENTITY(140,2),
NomeCompleto VARCHAR (300),
Email VARCHAR(60),
Contato VARCHAR(30),
FK_Corretora INT NULL,
CONSTRAINT FK_Corretora FOREIGN KEY (FK_Corretora) REFERENCES Corretoras (PK_Corretora)
)

CREATE TABLE Usuarios (
PK_Usuario INT PRIMARY KEY IDENTITY(1,1),
Login VARCHAR(30) NOT NULL,
Senha VARCHAR(30) NOT NULL,
FK_Investidor INT NULL,
CONSTRAINT FK_Investidor FOREIGN KEY (FK_Investidor) REFERENCES Investidores (PK_Investidor) 
)

CREATE TABLE OperacoesRealizadas(
PK_Operacao INT PRIMARY KEY IDENTITY(1,1),
CodigoAcao VARCHAR (6) NOT NULL,
Operacao VARCHAR (1) NOT NULL,
Quantidade SMALLINT NOT NULL,
ValorDeFechamento DECIMAL NOT NULL,
PrecoMedio DECIMAL NOT NULL,
ValorTotal DECIMAL NOT NULL,
DataOperacao DATETIME NOT NULL,
FK_Corretora INT NOT NULL,
FK_Investidor INT NOT NULL,
CONSTRAINT FK_CorretoraOperacao FOREIGN KEY (FK_Corretora) REFERENCES Corretoras (PK_Corretora),
CONSTRAINT FK_Investidorx FOREIGN KEY (FK_Investidor) REFERENCES Investidores (PK_Investidor) 
)

