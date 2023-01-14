use iti

select month(GETDATE()) from  Student

--q1--
create function MonthName(@date date)
returns nvarchar(20)
begin
	declare @name nvarchar(20)
	declare @monthNo int
	set @monthNo=month(@date)
	if @monthNo=1
		set @name='january'
	else if @monthNo=2
		set @name='february'
	else if @monthNo=3
		set @name='march'
	else if @monthNo=4
		set @name='april'
	else if @monthNo=5
		set @name='may'
	else if @monthNo=6
		set @name='june'
	else if @monthNo=7
		set @name='july'
	else if @monthNo=8
		set @name='august'
	else if @monthNo=9
		set @name='septamper'
	else if @monthNo=10
		set @name='october'
	else if @monthNo=11
		set @name='novamber'
	else if @monthNo=12
		set @name='december'
return @name
end

select dbo.monthname('5/1/2007')
select dbo.monthname('1/1/2007')
select dbo.monthname('2/1/2007')
select dbo.monthname('3/1/2007')
select dbo.monthname('4/1/2007')
select dbo.monthname('9/1/2007')


create function getMonth2(@x datetime)
returns nvarchar(20)
begin
return  FORMAT(@x,'MMMM')
end
select dbo.getMonth2('5/1/2007')
select dbo.getMonth2('1/1/2007')
select dbo.getMonth2('2/1/2007')
select dbo.getMonth2('3/1/2007')
select dbo.getMonth2('4/1/2007')
select dbo.getMonth2('9/1/2007')



--q2
create function integerArray(@par1 int,@par2 int)
returns @t table (numbers int)
as
begin 
set @par1+=1
	while @par1 < @par2
	begin
		insert into @t select @par1
		set @par1+=1
	end

return
end

select * from integerArray(-1,9)

--q3
create function stdName(@stdNo int)
returns table
as
	return (
		select (s.St_Fname+' '+s.St_Lname)[Full Name],d.Dept_Name Department from Student s inner join Department d
		on s.Dept_Id=d.Dept_Id
		where s.St_Id=@stdNo
	)
	
	select * from stdName(10)
	select * from stdName(12)


--q4
create function stdMessage(@stdNo int)
returns nvarchar(100)
begin

declare @mess nvarchar(100)
if ( ((select s.St_Fname  from Student s where s.St_Id=@stdNo) is null) and ((select s.St_Lname  from Student s where s.St_Id=@stdNo) is null))
		select @mess='First name & last name are null'
	else if (((select s.St_Fname  from Student s where s.St_Id=@stdNo) is null))
		select @mess= 'first name is null'
	else if (((select s.St_Lname  from Student s where s.St_Id=@stdNo) is null))
		select @mess= 'last name is null'
	else 
	 	select @mess='first name & last name are not null'
	
	return @mess
end
	select * from Student
	select dbo.stdmessage(1)
	select dbo.stdmessage(13)
	select dbo.stdmessage(14)
	select dbo.stdmessage(30)


	--q5
	create function data(@x int)
	returns table 
	as
	return(
		select d.Dept_Name,i.Ins_Name,d.Manager_hiredate  from Department d inner join Instructor i
		on d.Dept_Manager=i.Ins_Id where i.Ins_Id=@x
		
	)


	select * from data(1)
	select * from data(3)
	select * from data(5)
	select * from Department
	select * from Instructor

	--q6
	create function returnName(@name nvarchar(20))
	returns @t table (stdName nvarchar(30) )
	as 
	begin
		if(@name='first name')
			insert into @t select isnull(s.St_Fname,'') from Student s
		else if (@name='last name')
			insert into @t select isnull(s.St_Lname,'') from Student s
		else if (@name='full name')
			insert into @t select concat(ISNULL(s.St_Fname,''),' ',isnull(s.St_Lname,''))fullName from Student s

		return
	end 

	select * from returnname('first name')
	select * from returnname('last name')
	select * from returnname('full name')





	--q7
	select s.St_Id,SUBSTRING(s.St_Fname,1,LEN(s.St_Fname)-1)  from Student s
	select St_Fname from Student


	--q8

	delete  Stud_Course
	from Student s inner join Department d
	on s.Dept_Id=d.Dept_Id inner join Stud_Course sc
	on sc.St_Id=s.St_Id
	where d.Dept_Name='SD'

	--Bonus 1











	--bonus 2
	declare @x int
	set @x=3000
	while @x<6000
	begin
	insert into Student (St_Id,St_Fname,St_Lname) values(@x,'Jane','Smith')
	set @x+=1
	end
	select * from Student

	--bonus 1
	use SD
	create table tree(
	
	Node hierarchyid not null,
	Name nvarchar(30)	not null,
	type nvarchar(30) not null
		
	)

	-- inserting node of the tree
	insert into tree values('/','Earth','planet')

	select Node,node.ToString() [Node text],Node.GetLevel() [Node Level],Name,type from tree

	--inserting the first level 
	insert into tree values ('/1/','Asia','Continent')
							,('/2/','Africa','Continent')
							,('/3/','Oceania','Continent')

		
	
	--inserting Second level
	insert into tree values ('/1/1/','China','Country')
,('/1/2/','Japan','Country')
,('/1/3/','South Korea','Country')
,('/2/1/','South Africa','Country')
,('/2/2/','Egypt','Country')
,('/3/1/','Australia','Country')






	--inserting third level
	insert into tree values
							('/1/2/1/','Tokyo','City')
,('/1/3/1/','Seoul','City')
,('/2/1/1/','Pretoria','City')
,('/2/2/1/','Cairo','City')
,('/3/1/1/','Canberra','City')



select Node,node.ToString() [Node text],Node.GetLevel() [Node Level],Name,type from tree	order by [Node text]