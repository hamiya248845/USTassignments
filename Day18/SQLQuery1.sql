create trigger emp_trigger on Persons
after insert 
as
select 'Row Created';