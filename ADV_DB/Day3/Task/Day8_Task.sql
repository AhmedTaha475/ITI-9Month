use ITI
--q1
create view vDisplay
as
select  (s.St_Fname+' '+s.St_Lname)[Full Name], c.Crs_Name from Student s inner join Stud_Course sc
on s.St_Id=sc.St_Id inner join Course c 
on c.Crs_Id=sc.Crs_Id
where sc.Grade>50

select * from vDisplay

sp_helptext vdisplay
--q2
use ITI
create view vMang
with encryption
as
select distinct i.Ins_Name [Manager Name],t.Top_Name [Topic Name] from Instructor i inner join Department d
on d.Dept_Manager=i.Ins_Id inner join Ins_Course ic
on ic.Ins_Id=i.Ins_Id inner join Course c
on c.Crs_Id=ic.Crs_Id inner join Topic t
on t.Top_Id=c.Top_Id



select * from vMang

sp_helptext vMang
--q3

create view vinstName
as 
select i.Ins_Name [instructor Name] ,d.Dept_Name [department Name] from Instructor i inner join Department d
on d.Dept_Id=i.Dept_Id
where d.Dept_Name in ('sd','java')


select * from vinstName


--q4
create view v1
as 
select s.* from Student s
where s.St_Address in ('alex','cairo')
with check option

select * from v1

update v1 set St_Address='tanta'
where St_Address='alex'

use SD
--q5

create view vsd1
as
select p.ProjectName [Project Name],COUNT(w.EmpNo) [Number of Employees] 
from 
Works_on w inner join Company.Project p 
on p.ProjectNo=w.ProjectNo
group by ProjectName


select * from vsd1

use iti
--q6
--can't create more than one clustered index on the table
create clustered index i2
on department(manager_hiredate)

create nonclustered index i3
on department(manager_hiredate)
drop index i3 on department

--q7
--error becasue there are already duplicated data in student age
create unique index i4
on student(st_age)


--q8

create table lastTranscation 
(
userId int primary key,
transactionAmount int
)

create table DailyTranscation 
(
userId int primary key,
transactionAmount int
)


insert into lastTranscation values (1,1000),(2,2000),(3,1000)
insert into DailyTranscation values (1,4000),(4,2000),(2,10000)
select * from lastTranscation
select * from DailyTranscation

merge into lastTranscation as t
using DailyTranscation as d
on t.userid=d.userid
when matched then 
update set t.transactionAmount=d.transactionAmount
when not matched then 
insert values (d.userid,d.transactionAmount);



create synonym emp1
for [HumanResource].[Employee]
create synonym dep
for [Company].[Department]

create synonym proj
for [Company].[Project]






--Part2
use SD
--1

create view v_clerk
as
select e.*,p.*,w.Enter_Date from emp1 e inner join Works_on w
on w.EmpNo=e.empNO inner join proj p 
on w.ProjectNo=p.projectno
where w.Job='clerk'


select * from v_clerk

select * from emp1
select * from proj
select * from Works_on



--2
create view v_without_budget
as
select projectno,projectname from proj

select * from v_without_budget

--3
create view v_count
as 
select p.projectname,count(w.Job)[Number of jobs] from proj p inner join Works_on w
on w.ProjectNo=p.projectno
group by p.projectname

select * from v_count

--4
create view v_project_p2
as 
select [Number of jobs][number of employee] from v_count v inner join proj p 
on v.projectname=p.projectname
where p.projectno='p2'

select * from v_project_p2


--5
alter view v_without_budget
as
select * from proj
where projectno in ('p1','p2')

select * from v_without_budget

--6
drop view v_clerk
drop view v_count



--7


create view v_display
as
select empno,lname from emp1 
where deptno='d2'

select * from v_display

--8
create view v_contains
as
select lname from v_display
where lname like '%j%'

select * from v_contains


--9
create view v_dept
as 
select deptno,deptname from dep

select * from v_dept

--10
insert into v_dept
values('d4','Development')

select * from v_dept

--11
create view v_2006_check
as
select w.EmpNo,w.ProjectNo,w.Enter_Date from emp1 e inner join Works_on w
on w.EmpNo=e.empno 
where w.Enter_Date between '1.1.2006' and '12.30.2006'

select * from v_2006_check