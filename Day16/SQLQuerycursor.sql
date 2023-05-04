--declare @empid int;
--declare emp_cursor CURSOR
--for
--select PersonlId from Persons order by PersonlId;
--open emp_cursor;
--fetch next from emp_cursor into @empid;
--close emp_cursor;
--deallocate emp_cursor;

DECLARE @empid int;
declare @sal money;
declare @grandSalary money;
SET @grandSalary=0;
declare emp_cursor cursor
for
select PersonlId from Persons order by PersonlId;
open emp_cursor;
fetch next from emp_cursor into @empid;
while @@FETCH_STATUS=0
begin
execute @sal @empid,1,
@sal output;
set @grandSalary=@grandSalary+@sal;
FETCH NEXT FROM emp_cursor
INTO @empid; END
DEALLOCATE emp_cursor;
SELECT @grandSalary AS GrantSalary;










