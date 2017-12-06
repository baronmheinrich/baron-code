--Replace the stars with the name of your database and remove the comment right next to the use
--use ***;
go

create database employee;
go

create schema myCompany;
go


create table myCompany.employee
(
	employeeID int not null primary key identity(1,1)
	,firstname nvarchar(100) not null
	,lastname nvarchar(200) not null
	,socialSecurity nvarchar(11) unique not null
	,deptID int not null
);


create table myCompany.department
(
	departmentID int not null primary key identity(1,1)
	,departmentName nvarchar(100) not null
	,departmentLocation nvarchar(200) not null
);

create table myCompany.empDetails
(
	empID int not null primary key identity(1,1)
	,employeeID int not null
	,empSalary int not null
	,empAddress1 nvarchar(200) not null
	,empAddress2 nvarchar(200) 
	,empCity nvarchar(200) not null
	,empState nvarchar(200) not null
	,empCountry nvarchar(200) not null

);

go

alter table myCompany.employee
	add constraint FK_employee_department foreign key (deptID) references myCompany.department(departmentID);

alter table myCompany.employee
	add constraint CK_socialSecurity check(socialSecurity like'[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]');


alter table myCompany.EmpDetials
	add constraint FK_emp_employee foreign key (employeeID) references myCompany.employee(employeeID) on update cascade;

go

 insert into myCompany.employee(firstname,lastname,socialSecurity,deptID)
 values ('Lana', 'Bedae', '111-11-1111', '1');

 insert into myCompany.employee(firstname,lastname,socialSecurity,deptID)
 values ('Emma', 'Jay', '222-22-2222', '1');

 insert into myCompany.employee(firstname,lastname,socialSecurity,deptID)
 values ('Liz', 'Craft', '333-33-3333', '1');

 go

insert into myCompany.department(departmentName,departmentLocation)
values ('Human Resource', 'Los Angeles');

insert into myCompany.department(departmentName,departmentLocation)
values ('Development Team', 'Austin');

insert into myCompany.department(departmentName,departmentLocation)
values ('Corporate Headquarters', 'Palo Alto');

go

 insert into myCompany.empDetails(employeeID,empSalary,empAddress1,empAddress2,empCity,empState,empCountry)
 values ((select employeeID from myCompany.employee where firstname='Lana' and lastname='bedae') , 90000, '804 Hilltop Avenue', null, 'Austin', 'Texas', 'USA');

 insert into myCompany.empDetails(employeeID,empSalary,empAddress1,empAddress2,empCity,empState,empCountry)
 values ((select employeeID from myCompany.employee where firstname='Emma' and lastname='Jay') , 80000, '3001 Sunshine St', 'Apt 204', 'Juneau', 'Alaska', 'USA');

 insert into myCompany.empDetails(employeeID,empSalary,empAddress1,empAddress2,empCity,empState,empCountry)
 values ((select employeeID from myCompany.employee where firstname='Liz' and lastname='Craft') , 75000, '3001 Sunshine St', 'Apt 204', 'Juneau', 'Alaska', 'USA');


go

insert into myCompany.employee(firstname,lastname,socialSecurity,deptID)
 values ('Tina', 'Smith', '444-33-3333', '2');

insert into myCompany.department(departmentName,departmentLocation)
values('Marketing', 'New York');

select * from myCompany.employee as empl
inner join myCompany.department as dept on dept.departmentID = empl.deptID
where dept.departmentName='Marketing';

select SUM(empSalary) from myCompany.empDetails as empDet
inner join myCompany.employee as emp on emp.employeeID = empDet.employeeID
inner join myCompany.department as dept on dept.departmentID=emp.deptID
where dept.departmentName='Marketing';


select * from myCompany.employee as empl
inner join myCompany.department as dept on dept.departmentID = empl.deptID
order by dept.departmentName;

update myCompany.empDetails 
set empSalary = 90000;