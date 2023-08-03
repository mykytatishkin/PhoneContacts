create procedure dbo.UpdateContact
    @ID int,
    @NewFullName nvarchar(100),
    @NewPhoneNumber nvarchar(20),
    @NewDateOfBirth date
as
begin
    set nocount on;
    update dbo.Contacts
    set FullName = @NewFullName,
        TelephoneNumber = @NewPhoneNumber,
        DateOfBirth = @NewDateOfBirth
    where ID = @ID;
end