CREATE PROCEDURE AddUser
    @Nume NVARCHAR(50),
    @Prenume NVARCHAR(50),
    @Username NVARCHAR(50),
    @Email NVARCHAR(100),
    @Parola NVARCHAR(50),
    @TipCont NVARCHAR(20)
AS
BEGIN
    INSERT INTO Utilizatori (Nume, Prenume, Username, Email, Parola, TipCont, DataInregistrare)
    VALUES (@Nume, @Prenume, @Username, @Email, @Parola, @TipCont, GETDATE());
END;

CREATE PROCEDURE DeleteUser
    @ID_Utilizator INT
AS
BEGIN
    DELETE FROM Utilizatori
    WHERE ID_Utilizator = @ID_Utilizator;
END;

