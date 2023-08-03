create procedure dbo.GetAllContacts
as
begin
    select ID, FullName, TelephoneNumber, DateOfBirth 
    from dbo.Contacts;
end;