CREATE DATABASE EducatieStiinteNaturale;
GO

USE EducatieStiinteNaturale;
GO

CREATE TABLE Utilizatori 
(
    ID_Utilizator INT PRIMARY KEY IDENTITY(1,1), 
    Nume NVARCHAR(100) NOT NULL,
    Prenume NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL, 
    Email NVARCHAR(150) UNIQUE NOT NULL,
    Parola NVARCHAR(255) NOT NULL, 
    TipCont NVARCHAR(50) CHECK (TipCont IN ('Student', 'Profesor', 'Administrator')) NOT NULL,
    DataInregistrare DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE Materii
(
    ID_Materie INT PRIMARY KEY IDENTITY(1,1),
    NumeMaterie NVARCHAR(100) NOT NULL,
    Descriere NVARCHAR(MAX) NULL
);
GO

CREATE TABLE Teste 
(
    ID_Test INT PRIMARY KEY IDENTITY(1,1),
    NumeTest NVARCHAR(200) NOT NULL,
    ID_Materie INT FOREIGN KEY REFERENCES Materii(ID_Materie),
    Autor INT FOREIGN KEY REFERENCES Utilizatori(ID_Utilizator),
    DataCreare DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE Intrebari 
(
    ID_Intrebare INT PRIMARY KEY IDENTITY(1,1),
	ID_Test INT FOREIGN KEY REFERENCES Teste(ID_Test),
    TextIntrebare NVARCHAR(MAX) NOT NULL,
    Punctaj FLOAT DEFAULT 1.0
);
GO

CREATE TABLE Raspunsuri 
(
    ID_Raspuns INT PRIMARY KEY IDENTITY(1,1),
    ID_Intrebare INT FOREIGN KEY REFERENCES Intrebari(ID_Intrebare),
    TextRaspuns NVARCHAR(MAX) NOT NULL,
    EsteCorect BIT NOT NULL 
);
GO

CREATE TABLE Lectii (
    ID_Lectie INT AUTO_INCREMENT PRIMARY KEY,
    ID_Materie INT NOT NULL,
    TitluLectie VARCHAR(255) NOT NULL,
    ContinutLectie TEXT,
    FOREIGN KEY (ID_Materie) REFERENCES Materii(ID_Materie)
);
GO

/*


CREATE TABLE Lectii 
(
    ID_Lectie INT PRIMARY KEY IDENTITY(1,1),
    Titlu NVARCHAR(200) NOT NULL,
    Continut NVARCHAR(MAX) NOT NULL, 
    ID_Categorie INT FOREIGN KEY REFERENCES CategoriiLectii(ID_Categorie),
    CreatDe INT FOREIGN KEY REFERENCES Utilizatori(ID_Utilizator),
    DataCreare DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE RezultateTeste (
    ID_Rezultat INT PRIMARY KEY IDENTITY(1,1),
    ID_Test INT FOREIGN KEY REFERENCES Teste(ID_Test),
    ID_Student INT FOREIGN KEY REFERENCES Utilizatori(ID_Utilizator),
    ScorObtinut FLOAT NOT NULL,
    DataFinalizare DATETIME DEFAULT GETDATE()
);
GO
*/


