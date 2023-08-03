if not exists (select * from dbo.Contacts)
    insert into dbo.Contacts (FullName, TelephoneNumber, DateOfBirth) values
    ('John Smith', '+123456789', '1985-05-10'),
    ('Jane Doe', '+987654321', '1990-12-25'),
    ('Michael Johnson', '+111222333', '1978-08-15'),
    ('Emily Williams', '+444555666', '1995-03-01'),
    ('Robert Brown', '+777888999', '1982-11-20'),
    ('Sophia Miller', '+666777888', '1998-09-05'),
    ('William Davis', '+222333444', '1972-06-12'),
    ('Olivia Wilson', '+888999000', '1989-04-03'),
    ('James Lee', '+999000111', '1993-10-08'),
    ('Emma Anderson', '+333444555', '1980-07-18');
