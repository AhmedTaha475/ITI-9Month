use iti 
--q1
create proc stdNo
as
select d.Dept_Name,COUNT(s.St_Id) '#students'  from Student s inner join Department d
on s.Dept_Id=d.Dept_Id
group by d.Dept_Name

stdNo

--q2
use SD

select  p.ProjectNo,count(w.ProjectNo) from Works_on w inner join proj p 
on w.ProjectNo=p.ProjectNo
where p.ProjectNo='p1'
group by p.ProjectNo


create proc EmpMess
as 
 
if( (select count(w.ProjectNo) from Works_on w inner join proj p 
on w.ProjectNo=p.ProjectNo
where p.ProjectNo='p1'
)>3)
	select 'the number of employees is 3 or more'
else 
	begin
		
	select  concat('The following employee work for the project p1',' ',trim(e.Fname),' ',trim(e.lname)) as Message
	from Works_on w inner join proj p 
	on w.ProjectNo=p.ProjectNo inner join emp1 e
	on e.EmpNo=w.EmpNo
	where p.ProjectNo='p1'
	end

empmess

--q3
--use try and catch
create proc updateWork @oldEmpNo int,@newEmpNo int,@projNo nchar(15)
as
update Works_on set EmpNo=@newEmpNo
where EmpNo=@oldEmpNo and ProjectNo=@projNo

updateWork 18316,9031,'p2'


select * from Works_on


--q4
create table audit
(
projectNo nchar(15),
userName nvarchar(50),
modifiedDate date,
Budget_old int,
Budget_new int
)
create trigger t1 
on [Company].[Project]
after update
as 
	if(update(Budget))
	begin
		insert into audit values((select i.ProjectNo from inserted i),SUSER_NAME(),GETDATE(),(select d.Budget from deleted d),(select i.Budget from inserted i))
	end

	select * from proj
update proj set Budget=5000
where ProjectNo='p1'
select * from audit


--q5
use ITI

create trigger t2
on department
instead of insert
as
select 'You cannot insert a new  record in that table'

select * from Department
		
insert into Department (Dept_Id) values (90)

--q6
use SD
create trigger t3
on [HumanResource].[Employee]
instead of insert
as
	if(FORMAT(GETDATE(),'MMMM')='March')
		begin
			select 'Your are not allowed to insert data during march'
		end
	else 
		begin
			insert into [HumanResource].[Employee]
			select * from inserted
		end


--q7
use iti
create table studentAudit 
(
serverUserName nvarchar(256),
date date,
Note nvarchar(max)
)
drop table studentaudit

alter trigger t4
on student
after insert
as
	declare @userName nvarchar(256)=suser_name()
	declare @stdId int
	select @stdId=i.St_Id from inserted i
	insert into studentAudit values 
	(
	SUSER_NAME(),
	GETDATE(),
	concat(@userName,' ','insert new row with key ',convert(nvarchar(20),@stdId),' ','in table students')
	)

	insert into Student (St_Id,St_Fname,St_Lname) values (7500,'ahmed','taha')
	select * from Student
	select * from studentaudit


--q8
create trigger t6
on student
instead of delete
as
	declare @userName nvarchar(256)=suser_name()
	declare @stdId int
	select @stdId=i.St_Id from deleted i
	insert into studentAudit values 
	(
	SUSER_NAME(),
	GETDATE(),
	concat(@userName,' ','try to delete row with key ',convert(nvarchar(20),@stdId),' ','from table students')
	)

	delete Student where St_Id=7500
	select * from Student where St_Id=7500
	select * from studentaudit

--q9
--a attribute
use AdventureWorks2012
	
select * from [HumanResources].[Employee]
for xml raw

--b elements

select * from [HumanResources].[Employee]
for xml raw,elements


--q10
use ITI
--a auto
select * from Department d inner join Instructor i
on i.Dept_Id=d.Dept_Id
for xml auto
--b path
select 
d.Dept_Id as '@Dept_id',d.Dept_Name as 'dept_name',d.Dept_Desc as 'dept_Desc',d.Dept_Location as 'dept_location',
d.Manager_hiredate as 'm_hireDate',i.Ins_Id as 'instructor/@id',i.Ins_Name as 'instructor/name', i.Ins_Degree as'instructor/degree',i.Salary as 'instructor/salary'
from Department d inner join Instructor i
on i.Dept_Id=d.Dept_Id
for xml path ('Department'),type , root('Departments')


--q11
declare @docs xml ='<customers>
              <customer FirstName="Bob" Zipcode="91126">
                     <order ID="12221">Laptop</order>
              </customer>
              <customer FirstName="Judy" Zipcode="23235">
                     <order ID="12221">Workstation</order>
              </customer>
              <customer FirstName="Howard" Zipcode="20009">
                     <order ID="3331122">Laptop</order>
              </customer>
              <customer FirstName="Mary" Zipcode="12345">
                     <order ID="555555">Server</order>
              </customer>
       </customers>'
declare @hdocs int
Exec sp_xml_preparedocument @hdocs output, @docs
SELECT * 
FROM OPENXML (@hdocs, '//customer')  --levels  XPATH Code
WITH (firstname nvarchar(50) '@FirstName',
	  Zipcode int '@Zipcode',
	  orders nvarchar(50) 'order',
	  ID int 'order/@ID'
	  )

Exec sp_xml_removedocument @hdocs



-- bonus 
--1
	--a monthName
		create proc getMonth @date datetime
		as
		select FORMAT(@date,'MMMM')

		getmonth '12-10-2007'

	--b
create proc integerArrayProc @par1 int,@par2 int 
as 
declare @t table (numbers int)
select @par1+=1
while @par1<@par2
begin
insert into @t select @par1
set @par1+=1
end
select * from @t

integerArrayProc 10,20

--c
create proc stdNameProc(@stdNo int)
as	
select (s.St_Fname+' '+s.St_Lname)[Full Name],d.Dept_Name Department from Student s inner join Department d
on s.Dept_Id=d.Dept_Id
where s.St_Id=@stdNo

stdnameproc 10

--d
create proc stdMessageProc(@stdNo int)
as
declare @mess nvarchar(100)
if ( ((select s.St_Fname  from Student s where s.St_Id=@stdNo) is null) and ((select s.St_Lname  from Student s where s.St_Id=@stdNo) is null))
		select @mess='First name & last name are null'
	else if (((select s.St_Fname  from Student s where s.St_Id=@stdNo) is null))
		select @mess= 'first name is null'
	else if (((select s.St_Lname  from Student s where s.St_Id=@stdNo) is null))
		select @mess= 'last name is null'
	else 
	 	select @mess='first name & last name are not null'
	
	select @mess


stdmessageproc 10



--e
create proc dataproc(@x int)
as
select d.Dept_Name,i.Ins_Name,d.Manager_hiredate  from Department d inner join Instructor i
on d.Dept_Manager=i.Ins_Id where i.Ins_Id=@x

dataproc 5


--f
	create proc returnNameproc(@name nvarchar(20))
	as
	declare @t table (stdName nvarchar(30) )


		if(@name='first name')
			insert into @t select isnull(s.St_Fname,'') from Student s
		else if (@name='last name')
			insert into @t select isnull(s.St_Lname,'') from Student s
		else if (@name='full name')
			insert into @t select concat(ISNULL(s.St_Fname,''),' ',isnull(s.St_Lname,''))fullName from Student s

		select * from @t

		returnnameproc 'first name'
		returnnameproc 'last name'

--2 bonus
 use SD

create trigger t12
on database
for ALTER_TABLE 
as
rollback

alter table audit add test nvarchar(50)