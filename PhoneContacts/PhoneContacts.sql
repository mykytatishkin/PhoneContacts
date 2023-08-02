--create database PhoneContacts;
--use PhoneContacts;

--create table Contacts (
--	ID int identity(1,1) primary key,
--	FullName varchar(100) not null,
--	TelephoneNumber varchar(15) not null,
--	DateOfBirth date not null
--);

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('John Smith', '+123456789', '1985-05-10');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('Jane Doe', '+987654321', '1990-12-25');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('Michael Johnson', '+111222333', '1978-08-15');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('Emily Williams', '+444555666', '1995-03-01');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('Robert Brown', '+777888999', '1982-11-20');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('Sophia Miller', '+666777888', '1998-09-05');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('William Davis', '+222333444', '1972-06-12');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('Olivia Wilson', '+888999000', '1989-04-03');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('James Lee', '+999000111', '1993-10-08');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('James Lee', '+999000111', '1993-10-08');

--INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--VALUES ('Emma Anderson', '+333444555', '1980-07-18');

--create procedure GetAllContacts
--as
--begin
--    select *
--    from Contacts;
--end;

--create procedure DeleteContact
--    @ID int
--as
--begin
--    set nocount on;

--    delete from Contacts
--    where ID = @ID;
--end

--CREATE PROCEDURE InsertContact
--    @FullName NVARCHAR(100),
--    @TelephoneNumber NVARCHAR(15),
--    @DateOfBirth DATE
--AS
--BEGIN
--    SET NOCOUNT ON;

--    INSERT INTO Contacts (FullName, TelephoneNumber, DateOfBirth)
--    VALUES (@FullName, @TelephoneNumber, @DateOfBirth);
--END

--CREATE PROCEDURE UpdateContact
--    @OldPhoneNumber NVARCHAR(20),
--    @NewFullName NVARCHAR(100),
--    @NewPhoneNumber NVARCHAR(20),
--    @NewDateOfBirth DATE
--AS
--BEGIN
--    SET NOCOUNT ON;

--     --Обновляем запись с заданным номером телефона (@OldPhoneNumber)
--     --на новые значения (@NewFullName, @NewPhoneNumber, @NewDateOfBirth)

--    UPDATE Contacts
--    SET FullName = @NewFullName,
--        TelephoneNumber = @NewPhoneNumber,
--        DateOfBirth = @NewDateOfBirth
--    WHERE TelephoneNumber = @OldPhoneNumber;
--END


--exec GetAllContacts
--exec DeleteContact @ID = 11
--exec GetAllContacts