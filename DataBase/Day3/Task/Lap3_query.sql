use Company_SD
--Q1
select D.Dnum,Dname,E.SSN,E.Fname
from Departments D inner join Employee E
on D.MGRSSN=E.SSN

select * from Departments
select * from Employee where SSN in(223344,968574,512463)

--Q2
select D.Dname,P.Pname
from Departments D inner join Project P
on D.Dnum=P.Dnum

select * from Departments
select * from Project

--Q3
select E.Fname [Emp Name],D.*
from Employee E inner join Dependent D
on E.SSN=D.ESSN

select * from Employee
select * from Dependent

--Q4
select p.Pnumber,p.Pname,p.Plocation
from Project P
where p.City in ('alex','cairo')
select * from Project

--Q5
select * from Project
where Pname like 'a%'
select * from Project

--Q6
select * from Employee 
where Dno=30 and Salary between 1000 and 2000

select * from Employee


--Q7
select E.Fname 
from Employee E inner join Works_for W
on E.SSN=W.ESSn inner join Project p
on W.Pno=p.Pnumber
where E.Dno=10 and W.Hours>=10 and p.Pname='AL Rabwah'

select * from Employee where Dno=10
select * from Works_for where Hours>=10
select * from Project where Pname='AL Rabwah'



--Q8
select Emp.Fname
from Employee Emp inner join Employee Super 
on Emp.Superssn=Super.SSN
where Super.Fname='Kamel'

select * from Employee


--Q9
select E.Fname ,P.Pname
from Employee E inner join Works_for W
on E.SSN=W.ESSn inner join Project p
on W.Pno=p.Pnumber
order by p.Pname

select fname ,pname from Employee e , Project p ,Departments d
where e.Dno=d.Dnum and p.Dnum=d.Dnum 
order by Pname


--Q10
select p.Pnumber,d.Dname,e.Lname,e.Address,e.Bdate
from Employee E inner join Departments D
on E.SSN=D.MGRSSN inner join Project P
on p.Dnum=D.Dnum
where P.City='cairo'

select * from Project where City='cairo'
select * from Departments
select * from Employee

--Q11
select E.*
from Employee E inner join Departments D
on E.SSN=D.MGRSSN

select * from Departments
select * from Employee

--Q12
select *
from Employee E left outer join Dependent D
on E.SSN = D.ESSN

--Q13
insert into Employee values('Ahmed','Taha',102672,'10/8/1995','15 cairo egypt','m',3000,112233,30)
select * from Employee


--Q14
insert into Employee values('ashrf','medhat',102660,'10/8/1995','15 cairo egypt','m',NULL,Null,30)
select * from Employee

--Q15
update Employee set Salary+=0.2*Salary
where SSN=102672
select * from Employee