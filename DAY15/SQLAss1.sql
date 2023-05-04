------ 1 - 3 ----



CREATE TABLE REGIONS(REGION_ID INTEGER PRIMARY KEY,REGION_NAME VARCHAR(25));

CREATE TABLE COUNTRIES(COUNTRY_ID INTEGER PRIMARY KEY,COUNTRY_NAME VARCHAR(25), REGION_ID INTEGER,

	FOREIGN KEY(REGION_ID) REFERENCES REGIONS(REGION_ID));

CREATE TABLE JOBS(JOB_ID INTEGER PRIMARY KEY, JOB_TITLE VARCHAR(25),

	MIN_SALARY MONEY ,MAX_SALARY MONEY);

CREATE TABLE LOCATIONS (LOCATION_ID INTEGER PRIMARY KEY, STREET_ADDRESS VARCHAR(35),

	POSTAL_CODE INT, CITY VARCHAR(25), STATE_PROVINCE VARCHAR(20), COUNTRY_ID INTEGER,

	FOREIGN KEY(COUNTRY_ID) REFERENCES COUNTRIES(COUNTRY_ID));

CREATE TABLE DEPARTMENTS(DEPARTMENT_ID INTEGER PRIMARY KEY, DEPARTMENT_NAME VARCHAR(25),

	MANAGER_ID INTEGER, LOCATION_ID INTEGER, FOREIGN KEY(LOCATION_ID) REFERENCES LOCATIONS(LOCATION_ID));

CREATE TABLE EMPLOYEES(EMPLOYEE_ID INTEGER PRIMARY KEY, FIRST_NAME VARCHAR(25),

	LAST_NAME VARCHAR(25), EMAIL VARCHAR(25), PHONE_NUMBER NUMERIC, HIRE_DATE DATE,

	SALARY MONEY, COMMISSION_PCT MONEY, MANAGER_ID INTEGER,

	JOB_ID INTEGER, DEPARTMENT_ID INTEGER,

	FOREIGN KEY(JOB_ID) REFERENCES JOBS(JOB_ID),

	FOREIGN KEY(DEPARTMENT_ID) REFERENCES DEPARTMENTS(DEPARTMENT_ID));

CREATE TABLE JOB_HISTORY(EMPLOYEE_ID INTEGER, START_DATE DATE, END_DATE DATE, JOB_ID INTEGER,

 DEPARTMENT_ID INTEGER, FOREIGN KEY(JOB_ID) REFERENCES JOBS(JOB_ID),

	FOREIGN KEY(EMPLOYEE_ID) REFERENCES EMPLOYEES(EMPLOYEE_ID),

	FOREIGN KEY(DEPARTMENT_ID) REFERENCES DEPARTMENTS(DEPARTMENT_ID));

INSERT INTO REGIONS VALUES (1001,'Asia');

--select * from regions;

INSERT INTO COUNTRIES VALUES(2001,'India',1001);

--select * from countries;

INSERT INTO LOCATIONS VALUES(3001,'Elamakkara',682026,'Ernakulam','Kerala',2001);

--select * from locations;

INSERT INTO JOBS VALUES(4001,'Jr Manager',40000,55000);

--select * from JOBS;

INSERT INTO DEPARTMENTS VALUES(6001,'HR',5001,3001);

INSERT INTO DEPARTMENTS VALUES(900,'Accounts',5001,3001);

----select * from DEPARTMENTS;

INSERT INTO EMPLOYEES VALUES(7001,'Luious','Pious','luious@gmail.com',954467,'2023-05-02',30000,5000,5001,4001,6001);

INSERT INTO EMPLOYEES VALUES(7002,'Rahul','Madhav','rahul@gmail.com',987634,'2021-07-11',45000,5000,5001,4001,900);

----select * from employees;

INSERT INTO JOB_HISTORY VALUES(7001,'2023-05-02','2043-05-02',4001,6001);

----------------------

---- 4 ----

select first_name,salary,12*(salary+100) from Employees;

----- 5 -----

 update Employees set phone_number='2'+REPLICATE('0',7-len('2'+phone_number))+phone_number

 where len(phone_number)=5;

--select * from employees;

---- 6 ----

--DELETE employee_id, salary, job_id FROM employees WHERE dept_id = 900;

 delete from Employees where department_id=900;

---- 7 -----

select distinct(department_id) from Employees where last_name='Smith';

---- 8 -----

-- SELECT empname,hire_date HIREDATE, salary FROM EMPLOYEES ORDER BY hire_date;

 select first_name,last_name,hire_date,salary from Employees order by hire_date asc;

---- 9 -----

CREATE TABLE STUDENT_GRADES(STUDENT_ID NUMERIC(12) PRIMARY KEY,SEMESTER_END DATE, GPA NUMERIC(4,3));

INSERT INTO STUDENT_GRADES VALUES(11,'03-05-2023',8.6);

INSERT INTO STUDENT_GRADES VALUES(12,'03-05-2022',9.07);

SELECT * FROM STUDENT_GRADES;

 select student_id,semester_end,gpa from student_grades order by semester_end,gpa desc;

 ---- 10 -----

 select first_name from Employees where department_id not in(select department_id from departments);

----- 11 -----

CREATE TABLE CUSTOMERS(CUSTOMER_ID NUMERIC(4) PRIMARY KEY, CUSTOMER_NAME VARCHAR(100) NOT NULL,

 CUSTOMER_ADDRESS VARCHAR(150), CUSTOMER_PHONE VARCHAR(20));

INSERT INTO CUSTOMERS VALUES(124,'Alan','Elamakkara','9633266139');

select * from CUSTOMERS;

select concat('Dear Customer ',customer_name,' .') from customers;

---- 12 ----

 CREATE TABLE EMP(ID INTEGER PRIMARY KEY, NAME VARCHAR(20),SAL DECIMAL(10,2), COMM_PCT DECIMAL(5,2),

 PF DECIMAL(10,2), HRA DECIMAL(10,2), TEARN DECIMAL(10,2), TDED DECIMAL(10,2), NET DECIMAL(10,2));

 insert into Emp(id,name,sal,comm_pct) values

 (111,'Hanna',55000,0.77),

 (221,'ryan',70000,0.36),

 (331,'Boston',85000,0.44);

 update Emp set hra=0.12*sal, tearn=sal+hra, tded=0.04*sal;

 UPDATE EMP SET net=(tearn-tded);

 update EMP set PF=0.10*SAL;

 select * from EMP;































































