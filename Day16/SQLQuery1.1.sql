
create or alter procedure getSalary
@empid int,@sal MONEY OUTPUT
as
begin
select @sal=Salary from Persons where PersonlId=@empid;
end;

--exec getSalary 101;