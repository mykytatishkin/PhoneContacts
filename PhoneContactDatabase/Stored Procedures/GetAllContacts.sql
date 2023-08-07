create procedure dbo.GetAllContacts
as
begin
    set nocount on;
    select ID, FullName, TelephoneNumber, DateOfBirth 
    from dbo.Contacts;
end;