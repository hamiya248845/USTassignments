
create table Persons(
PersonlId int primary key,
LastName varchar(25),
FirstName varchar(25),
Address varchar(25),
City varchar(25),
Salary money
);



insert into Persons values(101,'James','Hami','hgtdgj','Ernakulam',50000);

insert into Persons values(102,'anand','aaina','gvvhj','wayanad',30000);

insert into Persons values(103,'jolly','antony','valiyavtil','kochi',40000);

insert into Persons values(104,'rani','m','kochuvtil','kochi',50000);

----select * from Persons where fname like 'a%';

----select * from Persons where fname like '_u%';

----select * from Persons order by pid desc;

--select * from Persons;

--select * from Persons where FirstName='rani' and city='kochi';

----select * from Persons where fname='rani' or city='kochi';

----select * from Persons order by city;

----select * from Persons order by city desc;

----select * from Persons order by city desc, fname asc;

----update Persons set lname='P S' where pid=101;

----select * from Persons;

