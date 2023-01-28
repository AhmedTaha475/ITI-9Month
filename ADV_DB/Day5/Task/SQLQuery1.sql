use SD
--q1
declare c1 cursor
for select empno,salary from emp1
for update
declare @id int ,@sal int
open c1 
fetch c1 into @id,@sal
while @@FETCH_STATUS=0
begin
	if(@sal>=3000)
		update emp1 set Salary=@sal*1.1
		where current of c1
	else if (@sal<3000)
		update emp1 set Salary=@sal*1.2
		where current of c1
	fetch c1 into @id,@sal
end
close c1 
deallocate c1
select * from emp1

--q2
use iti

declare c2 cursor
for select d.Dept_Name,i.Ins_Name from Department d inner join Instructor i
	on d.Dept_Manager=i.Ins_Id
for read only
declare @dep_name nvarchar(50),@ins_name nvarchar(50)
open c2
fetch c2 into @dep_name,@ins_name
while @@FETCH_STATUS=0
	begin
		select @dep_name,@ins_name
		fetch c2 into @dep_name , @ins_name
	end
close c2
deallocate c2

--q3
declare c3 cursor 
for select st_fname from student
for read only
open c3
declare @fname nvarchar(20),@string nvarchar(max)=''
fetch c3 into @fname
while @@FETCH_STATUS=0
	begin
	set @string=concat(@string,@fname,',')
	fetch c3 into @fname
	end
	select @string
close c3
deallocate c3

--q4
Create SEQUENCE s1
START WITH 1
INCREMENT BY 1
MinValue 1
MaxValue 10


create TABLE testobject1
(id int,
name nvarchar(50) );

create TABLE testobject2
(id int,
name nvarchar(50) );
 
 insert into testobject1 values(next value for s1,'ahmed'),(next value for s1,'ahmed'),(next value for s1,'mohaned'),(next value for s1,'ahmed')
 select * from testobject1
 insert into testobject2 values (next value for s1,'ashrf')
 select * from testobject2
