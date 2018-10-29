CREATE DATABASE testDB
use testDB
go
CREATE TABLE Contacts (
    ID int PRIMARY KEY identity(1,1),
    FirstName varchar(255),
    LastName varchar(255),
	Gender nvarchar(10),
	PhoneNumber varchar(50),
    EmailAddress varchar(255),
    City varchar(255) 
);

insert into Contacts values('Godknows','Sithole','Male','0605180895','sitholeknows@gmail.com','Midrand')
insert into Contacts values('Thembi','Nkosi','Female','0714567824','thembankosi@gmail.com','Tembisa')
insert into Contacts values('Lisa','Johns','Female','0824567382','mike@gmail.com','Jozi')
insert into Contacts values('Chris','Sambo','Male','0783456821','Sambo@gmail.com','Tshwane')

Create procedure spGetAllContacts
as
Begin
 Select Id, FirstName,LastName, Gender,PhoneNumber,EmailAddress, City 
 from Contacts
End

Create procedure spAddContact
@fstname nvarchar(2555),  
@lstname nvarchar(255),  
@Gender nvarchar (10),
@PhoneNumber varchar(50),
@EmailAddress varchar(255),
@City varchar(255)
as  
Begin  
 Insert into contacts (firstname,lastname,gender,phonenumber,emailaddress,city)  
 Values (@fstname,@lstname, @Gender,@phonenumber,@EmailAddress, @City)  
End


Create procedure spAditContact 
@ID int,
@fstname nvarchar(255),  
@lstname nvarchar(255),  
@Gender nvarchar (10),
@PhoneNumber varchar(50),
@EmailAddress varchar(255),
@City varchar(255)
as  
Begin  
 update Contacts set FirstName= @fstname,LastName=@lstname,Gender=@Gender,
 PhoneNumber=@phonenumber,EmailAddress=@EmailAddress,City=@City 
 where id=@ID 
End

create procedure spDeleteContact
@ID int
as
begin
delete from contacts where id=@ID
End 

select * from Contacts

--{firstName:"Sam",lastName:"Gomo",Gender:"Male",phoneNumber:"0793456271",emailAddress:"sam@ggmail.com",City:"PTA"}
--{firstName:"Sam",lastName:"Gomoz",Gender:"Female",phoneNumber:"0793456271",emailAddress:"sam@ggmail.com",City:"PTA"}