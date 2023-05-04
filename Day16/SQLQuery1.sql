--create OR ALTER PROCEDURE sp_PrintDate AS 
--BEGIN 
--SELECT getdate();
--END;



--EXEC sp_PrintDate;

--create or alter procedure SHOWaccno(@accno int)
--as
--begin
--select * from BankTB where ACCNO=@accno;
--end;

--exec SHOWAccNo 101

create or alter procedure SHOWODDOREVEN(@num int)
as 
begin
if @num%2 = 0
   print 'even'
else
   print 'odd'
end;

exec SHOWODDOREVEN 10;
