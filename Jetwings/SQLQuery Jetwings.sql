create database jetwings;
use jetwings;

create table CustomerTable
(Cust_ID int IDENTITY(1,1) ,
Cust_FName varchar(20) not null,
Cust_LName varchar(20) not null,
Cust_Email varchar(50) not null PRIMARY KEY,
Cust_Address varchar(100)not null,
Cust_Gender varchar(30)not null,
Cust_Password varchar(50) not null,
Cust_ConformPassword varchar(50) not null,
Cust_SecurityQuestion varchar (50),
Cust_QuestionAnswer varchar (50));

drop table CustomerTable;

select * from CustomerTable;


create table AdminTable
(Adm_Username varchar(20) not null,
Adm_Password varchar (20) not null);

insert into AdminTable values 
('Amandi', '123456789*');


select * from AdminTable;

create table BookingDetails
(Book_Id int IDENTITY(1,1)primary key,
Book_Branch varchar (200),
Book_Packages varchar (20),
Book_TotalPerson varchar (20),
Book_DateIn varchar (15),
Book_DateOut varchar (15),
Cust_Email varchar(50) -- This will be the foreign key
FOREIGN KEY (Cust_Email) REFERENCES CustomerTable(Cust_Email));



select * from BookingDetails;
