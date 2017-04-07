create table company(
id int primary key identity(1, 1),
name varchar(250),
fantasy_name varchar(250),
register varchar(50)
)

create table cost_type(
id int primary key identity(1, 1),
name varchar(150)
)

create table cost(
id int primary key identity(1, 1),
company_id int foreign key references company(id),
amount decimal,
typeId int foreign key references cost_type(id),
insertion_date DateTime,
[description] varchar(250)
)

create table income_type(
id int primary key identity(1, 1),
name varchar(150)
)

create table income(
id int primary key identity(1, 1),
company_id int foreign key references company(id),
amount decimal,
typeId int foreign key references income_type(id),
insertion_date DateTime,
[description] varchar(250)
)

create table project_status(
id int primary key identity(1, 1),
name varchar(150)
)

create table project(
id int primary key identity(1, 1),
company_id int foreign key references company(id),
due_date datetime,
description varchar(500),
paid bit,
price decimal,
status_id int foreign key references project_status(id)
)

select * from company