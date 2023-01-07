-- create rule for the new data type (loc) and add default value of NY to it  and attach rule dept_loc to it as well
create rule Dept_Loc as @loc in('NY','DS','KW')
create default def_loc as 'NY'
sp_addtype loc,'nchar(2)'

sp_bindefault def_loc ,loc
sp_bindrule Dept_Loc,loc



--Create the Department table now 
create table Department (
	
	DeptNo nchar(15) primary key  not null,
	DeptName nvarchar(50) not null,
	location loc ,
)

insert into Department(deptno,deptname) values('d1','Resarch')
insert into Department values('d2','Accounting','DS'),('d3','Marketing','KW')

create table Employee(

EmpNo int primary key ,
Fname nchar(50) not null,
lname nchar(50) not null,
DeptNo  nchar(15)  FOREIGN KEY REFERENCES department(DeptNo),
Salary int unique ,

)
create table Employee2(

EmpNo int ,
Fname nchar(50) ,
lname nchar(50) ,
DeptNo  nchar(15)  ,
Salary int  ,
constraint c1 primary key(EmpNo),
constraint c2 check(Fname is not null),
constraint c3 check(lname is not null),
constraint c4 foreign key (DeptNo) references Company.Department (deptno),
constraint c5 unique(salary)

)
create rule sal as @mySal < 6000
sp_bindrule sal,'Employee.Salary'

insert into Employee values(25348,'Mathew','Smith','d3',2500),
							(10102,'Ann','Jones','d3',3000),
							(18316,'John','Barrimore','d1',2400),
							(29346,'James','James','d2',2800),
							(9031,'Lisa','Bertoni','d2',3600),
							(28559,'Sybl','Moser','d1',2900)


insert into Works_on (EmpNo,ProjectNo) values(11111,'p2')

update Works_on set EmpNo=11111 where EmpNo=10102

update Employee set EmpNo=22222 where EmpNo=10102

delete from Employee where EmpNo=10102

---all test gave an error due to constraints on columns



alter table employee add TelephoneNumber nvarchar(14) 

alter table employee drop column telephonenumber


create schema Company

alter schema company transfer department

create schema HumanResource transfer employee
alter schema humanresource transfer employee

sp_helpconstraint 'HumanResource.employee'

create synonym Emp for HumanResource.employee

--a invalid object name because employee is not the dbo schema anymore
select * from Employee

--b it displays the value of employee because we transfered the employee table to the humanresource schenma
select * from HumanResource.employee

--c it returns the same data as  select * from HumanResource.employee
select * from emp

--d	 it generates an error because the emp synonym isn't assigned to schema humanresource
select * from HumanResource.emp

alter schema company transfer emp
select * from company.emp


select * from Company.Project

--5-
update Company.Project set Budget=Budget+0.1*Budget
from
Company.Project P inner join Works_on W
on p.ProjectNo=w.ProjectNo inner join HumanResource.Employee E
on e.EmpNo=w.EmpNo
where w.EmpNo=10102


select * from Works_on
select * from Company.Project

--6-
update Company.Department set DeptName='sales'
from 
Company.Department d inner join HumanResource.Employee E
on e.DeptNo=d.DeptNo
where e.Fname='james'

select * from Company.Department
select * from HumanResource.Employee

--7

update Works_on set Enter_Date='12.12.2007'
from 
Company.Project p inner join Works_on w 
on p.ProjectNo=w.ProjectNo inner join HumanResource.Employee e
on e.EmpNo=w.EmpNo inner join Company.Department d
on e.DeptNo=d.DeptNo
where 
d.DeptName='sales' and w.ProjectNo='p1'

select * from Company.Project
select * from Works_on
select * from HumanResource.Employee

select * from Company.Department

--8
delete from Works_on 
from 
Works_on w inner join HumanResource.Employee e
on w.EmpNo=e.EmpNo inner join Company.Department d
on e.DeptNo=d.DeptNo
where d.location='KW'

--9

use ITI
