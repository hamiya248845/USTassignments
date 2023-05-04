--create table BankTB(ACCNO INTEGER PRIMARY KEY, Accountholdername Varchar(25),BALANCE FLOAT, RefAccno INTEGER);



--insert into BankTB values(101,'Hamiya',5000,102);

--insert into BankTB values(102,'Briyala',5500,101);

--select * from BankTB;

--drop table BankTB;

select a.ACCNO as [ACCNO],a.Accountholdername as [Account Holder Name], a.BALANCE as 'Balance',
	a.RefAccno as [Reference Account NO],r.Accountholdername [Name of Referer] from BankTB
	a join BankTB r on a.RefAccno = r.ACCNO;
