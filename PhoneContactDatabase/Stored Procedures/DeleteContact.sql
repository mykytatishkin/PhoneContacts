create procedure dbo.DeleteContact
    @ID int
as
begin
    set nocount on;

    delete from dbo.Contacts
    where ID = @ID;
end
