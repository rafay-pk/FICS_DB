use FICS_DBPROJECT

EXEC sp_MSforeachtable @command1 = "DROP TABLE ?"

if object_id('person', 'U') is not null drop table person
if object_id('person_classifier', 'U') is not null drop table person_classifier
if object_id('institute', 'U') is not null drop table institute
if object_id('major', 'U') is not null drop table major
if object_id('domain', 'U') is not null drop table domain
if object_id('scholar', 'U') is not null drop table scholar
if object_id('trainer', 'U') is not null drop table trainer
if object_id('mentor', 'U') is not null drop table mentor
if object_id('counsellor', 'U') is not null drop table counsellor
if object_id('course', 'U') is not null drop table course
if object_id('course_difficulity', 'U') is not null drop table course_difficulity
if object_id('website', 'U') is not null drop table website
if object_id('scholar_courses', 'U') is not null drop table scholar_courses
if object_id('mentor_session', 'U') is not null drop table mentor_session
if object_id('counsellor_session', 'U') is not null drop table counsellor_session
if object_id('scholar_request', 'U') is not null drop table scholar_request



create table person (
    id int not null identity(1,1) primary key,
    name varchar(31) not null default null,
	fullname varchar(255),
	mail varchar(255) not null unique,
	password varchar(255) not null default null,
	persontype char(1) not null default null
);

create table person_classifier (
	id char(1) not null primary key,
	name varchar(63) unique not null
);

create table institute (
	id int primary key,
	name varchar (255) not null unique
);

--create table major (
--	id int primary key,
--	name varchar (255) not null unique
--);

create table domain (
	id int not null identity(1,1) primary key,
	name varchar (255) not null unique
);

--create table scholar (
--	id int primary key references person(id),
--	--inst_id int not null default null constraint fk_scholar_inst foreign key (inst_id) references institute(id),
--	semester_degree int not null default null check(semester_degree in (2,4,6,8,10)),
--	semester_current int not null default null,
--	check(semester_current <= semester_degree)
--);

--create table trainer ( 
--	trainer_id int not null default null check(exists(select 1 from person p where p.id = trainer_id and p.persontype = 'T')),
--	scholar_id int not null default null check((select persontype from person where id = scholar_id)='S'),
--	constraint pk_trainer primary key (trainer_id, scholar_id),
--	constraint fk_idtrainer foreign key (trainer_id) references person (id),
--	constraint fk_idscholar foreign key (scholar_id) references person (id)
--);

--create table mentor (
--	id int primary key references person(id),
--);

--create table counsellor (
--	id int primary key references person(id),
--);

create table course_difficulity (
	id int not null identity(1,1) primary key,
	rating int not null default null,
	title varchar(31) not null default null
);

create table website (
	id int not null identity(1,1) primary key,
	name varchar(63) not null default null,
	url varchar(255) not null default null
);

create table course (
	id int not null identity(1,1) primary key,
	domain_id int not null default null,
	difficulity_id int not null default null,
	website_id int not null default null
	constraint fk_course_domain foreign key (domain_id) references domain (id),
	constraint fk_course_difficulity foreign key (difficulity_id) references course_difficulity (id),
	constraint fk_course_website foreign key (website_id) references website (id)
	--title varchar(255) not null default null,
	--code varchar(15) not null default null
	--check(left(code,charindex('-',code)-1) not like '%[^a-zA-Z]%' and 
	--	  0 < cast(right(code,len(code)-charindex('-',code)) as int) and 
	--	  cast(right(code,len(code)-charindex('-',code)) as int) < 9999)
	-- domains
);

create table scholar_courses (
	scholar_id int not null default null,
	course_id int not null default null,
	date_enrolled date not null default getdate(),
	date_completion date not null default dateadd(week, 6, getdate()),
	constraint pk_scholar_course primary key (scholar_id, course_id),
	constraint fk_sc_scholar foreign key (scholar_id) references person (id),
	constraint fk_sc_course foreign key (course_id) references course (id)
);

create table mentor_session (
	mentor_id int not null default null,
	scholar_id int not null default null,
	date_and_time datetime not null default null,
	meeting_link varchar(255) not null default null,
	notes varchar(8000) default null,
	constraint pk_mentor_session primary key (mentor_id, scholar_id, date_and_time),
	constraint fk_ms_mentor foreign key (mentor_id) references person (id),
	constraint fk_ms_scholar foreign key (scholar_id) references person (id),
);

create table counsellor_session (
	counsellor_id int not null default null,
	scholar_id int not null default null,
	date_and_time datetime not null default null,
	meeting_link varchar(255) not null default null,
	advice varchar(8000) default null,
	constraint pk_counsellor_session primary key (counsellor_id, scholar_id, date_and_time),
	constraint fk_cs_mentor foreign key (counsellor_id) references person (id),
	constraint fk_cs_scholar foreign key (scholar_id) references person (id),
);

create table scholar_request (
	scholar_id int not null default null,
	trainer_id int not null default null,
	date_and_time datetime default getdate(),
	request varchar(8000) default null,
	constraint pk_scholar_request primary key (scholar_id, trainer_id, date_and_time),
	constraint fk_sr_scholar foreign key (scholar_id) references person (id),
	constraint fk_sr_trainer foreign key (trainer_id) references person (id)
);