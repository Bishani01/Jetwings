create database jetwings;
use jetwings;

create table CustomerTable
(Cust_ID int IDENTITY(1,1) PRIMARY KEY ,
Cust_FName varchar(20) not null,
Cust_LName varchar(20) not null,
Cust_Email varchar(50) not null ,
Cust_Address varchar(100)not null,
Cust_Gender varchar(30)not null,
Cust_Password varchar(50) not null,
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
Book_NumOfRooms int,
Book_TotalPerson varchar (20),
Book_DateIn varchar (15),
Book_DateOut varchar (15),
Amount varchar (20),
Cust_ID int -- This will be the foreign key
FOREIGN KEY (Cust_ID) REFERENCES CustomerTable(Cust_ID));

drop table BookingDetails

select * from BookingDetails;

SELECT Book_Branch, Book_Packages, SUM(DISTINCT Book_NumOfRooms) AS SumDistinctBook_NumOfRooms
FROM BookingDetails
GROUP BY Book_Branch, Book_Packages;

Create table hotels
(Hotel_ID int IDENTITY(1,1)Primary Key,
Hotel_Name varchar (50),
Premium_room_count int,
Standard_room_count int,
Classic_room_count int)

select * from hotels

INSERT INTO hotels VALUES('Jetwing Colombo Seven',5,0,5)
INSERT INTO hotels VALUES('Jetwing Kandy Gallery',5,5,5)
INSERT INTO hotels VALUES('Jetwing Jaffna',5,5,5)
INSERT INTO hotels VALUES('Jetwing Vil Uyana',5,5,5)
INSERT INTO hotels VALUES('Jetwing Blue',5,5,5)
INSERT INTO hotels VALUES('Jetwing Yala',5,5,5)
INSERT INTO hotels VALUES('Jetwing Lake Dambulla',5,5,5)