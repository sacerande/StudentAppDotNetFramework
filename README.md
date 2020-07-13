###Setup SQL Server Database 'dbStudent'
1. create new db "dbStudent"

2. add following 2 tables in it
create table student(id int primary key, firstname nvarchar(50), lastname nvarchar(50))
create table subjects(
id int primary key, 
studid int foreign key references student(id),
subName nvarchar(100)
)

3. add some data
insert into student values(1000,'Sachin','Erande');
insert into student values(1001,'Sachin1','Erande1');
insert into student values(1002,'Sachin2','Erande2');
insert into subjects values(2000, 1000, 'History');
insert into subjects values(2001, 1000, 'Maths');
insert into subjects values(2002, 1001, 'Geography');
insert into subjects values(2003,1002, 'English');

4. modify connection string in app.config file as per your sql server database.
<add name="dbStudent" connectionString="data source=.\SQLExpress;initial catalog=dbStudent;user id=sa;password=xxxxxx;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />

5. Run/Debug the application.
Observed - EF6 can fetch data from database and no "key already exists" error that ef core throws occurs.

https://github.com/dotnet/efcore/issues/21592