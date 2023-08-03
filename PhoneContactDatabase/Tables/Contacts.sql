create table dbo.Contacts (
	ID int identity(1,1),
	FullName varchar(100) not null,
	TelephoneNumber varchar(15) not null,
	DateOfBirth date not null,
	constraint PK_Contacts primary key(ID)
);