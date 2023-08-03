create procedure dbo.InsertContact
    @FullName nvarchar(100),
    @TelephoneNumber nvarchar(15),
    @DateOfBirth date
as
begin
    set nocount on;

    insert into dbo.Contacts (FullName, TelephoneNumber, DateOfBirth)
    values (@FullName, @TelephoneNumber, @DateOfBirth);
end