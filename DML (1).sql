use FICS_DBPROJECT

--insert into institute values
--(1,'NUST'),
--(2,'FAST'),
--(3,'AIR'),
--(4,'GIKI'),
--(5,'LUMS'),
--(6,'IBA'),
--(7,'COMSATS'),
--(8,'IST'),
--(9,'CUST'),
--(10,'QAU'),
--(11,'AKU'),
--(12,'SZABIST')

--insert into major values
--(1,'Computer Engineering'),
--(2,'Mechatronics Engineering'),
--(3,'Electrical Engineering'),
--(4,'Mechanical Engineering')

delete from person_classifier
insert into person_classifier values
('S', 'scholar'),
('T', 'Trainer'),
('M', 'Mentor'),
('C', 'Counsellor')

delete from domain
insert into domain values
('Artificial Intelligence and Big Data'),
('Internet of Things'),
('Embedded Devices'),
('Digital Systems'),
('Cloud Infrastructure and Security'),
('Augmented and Virtual Reality'),
('Blockchain and Cryptocurrency'),
('Software Solutions'),
('Front-End Development'),
('Back-End Development'),
('Game Development')

delete from course_difficulity
insert into course_difficulity values
(1, 'Beginner'),
(2, 'Intermediate'),
(3, 'Expert'),
(4, 'Master')

delete from website
insert into website values
('Coursera', 'https://www.coursera.org/'),
('Pluralsight', 'https://www.pluralsight.com/'),
('Udemy', 'https://www.udemy.com/'),
('Alison', 'https://alison.com/'),
('edX', 'https://www.edx.org/'),
('Skillshare', 'https://www.skillshare.com/')

--update website
--set website.url = CONCAT('<a href="', website.url, '">Link</a>');

--insert into course values
--('Calculus','MATH-101')

delete from person
insert into person values 
('Rafay', 'Abdurrafay Bin Khurram', 'razz2k01@gmail.com', 'howdyyo5679', 'S'),
('Usama', 'Usama Siddiqui', 'usiddiqui99@outlook.com', 'password123', 'T'),
('Sharjeel', 'Sharjeel Ali', 'greatestopportunity@gmail.com', 'shadyxv', 'M'),
('Izza', 'Izza Gul Awan', 'izzgulawan@gmail.com', 'Alhamdulillah', 'C')

--delete from scholar
--insert into scholar values
--((select p.id from person p where p.name = 'Rafay'),8,6)

delete from course
insert into course values
(
	(select d.id from domain d where d.name='Game Development'),
	(select cd.id from course_difficulity cd where cd.rating = 4),
	(select w.id from website w where w.name='Skillshare')
),
(
	(select d.id from domain d where d.name='Blockchain and Cryptocurrency'),
	(select cd.id from course_difficulity cd where cd.rating = 2),
	(select w.id from website w where w.name='edX')
),
(
	(select d.id from domain d where d.name='Artificial Intelligence and Big Data'),
	(select cd.id from course_difficulity cd where cd.rating = 1),
	(select w.id from website w where w.name='Coursera')
),
(
	(select d.id from domain d where d.name='Augmented and Virtual Reality'),
	(select cd.id from course_difficulity cd where cd.rating = 3),
	(select w.id from website w where w.name='Pluralsight')
)


delete from scholar_courses
insert into scholar_courses (scholar_id, course_id) values
(
	(select p.id from person p where p.name='Rafay'),
	(select c.id from course c join domain d on c.domain_id = d.id where d.name='Game Development')
)
insert into scholar_courses (scholar_id, course_id, date_completion) values
(
	(select p.id from person p where p.name='Rafay'),
	(select c.id from course c join domain d on c.domain_id = d.id where d.name='Blockchain and Cryptocurrency'),
	dateadd(week, 8, getdate())
),
(
	(select p.id from person p where p.name='Rafay'),
	(select c.id from course c join domain d on c.domain_id = d.id where d.name='Artificial Intelligence and Big Data'),
	dateadd(week, -4, getdate())
),
(
	(select p.id from person p where p.name='Rafay'),
	(select c.id from course c join domain d on c.domain_id = d.id where d.name='Augmented and Virtual Reality'),
	dateadd(month, 2, getdate())
)


delete from mentor_session
insert into mentor_session (mentor_id, scholar_id, date_and_time, meeting_link) values
(
	(select p.id from person p where p.name='Sharjeel'),
	(select p.id from person p where p.name='Rafay'),
	dateadd(day, 3, getdate()),
	'https://us04web.zoom.us/j/78454860141?pwd=K_P7dmfTwkaVIeVpAhE7ww0Lr5chly.1'
)
insert into mentor_session values
(
	(select p.id from person p where p.name='Sharjeel'),
	(select p.id from person p where p.name='Rafay'),
	dateadd(day, -1, getdate()),
	'https://us04web.zoom.us/j/21647987347?pwd=K_P7dmfTwkaVIeVpAhE7ww0Lr5chly.1',
	'Question: How to raycasting only one target Unity C#? Answer: You can temporarily change the layer of the target to a special one, for example, "hittest" and make sure no other gameobjects belong to this layer now, then make the raycast on that layer only. Remember to restore the layer of the target to the original one after the test was finished. I am posting from a mobile phone so I cannot write code at present but I can provide some sample code later if u need future assitant.'
)

delete from counsellor_session
insert into counsellor_session (counsellor_id, scholar_id, date_and_time, meeting_link) values
(
	(select p.id from person p where p.name='Izza'),
	(select p.id from person p where p.name='Rafay'),
	dateadd(day, 3, getdate()),
	'https://us04web.zoom.us/j/78454860141?pwd=K_P7dmfTwkaVIeVpAhE7ww0Lr5chly.1'
)
insert into counsellor_session values
(
	(select p.id from person p where p.name='Izza'),
	(select p.id from person p where p.name='Rafay'),
	dateadd(day, -1, getdate()),
	'https://us04web.zoom.us/j/21647987347?pwd=K_P7dmfTwkaVIeVpAhE7ww0Lr5chly.1',
	'Clear, concise, and accurate therapy progress notes are beneficial to practitioners and their clients. They’re instrumental in monitoring a patient’s progress, the efficacy of their treatment, and helping professionals understand their patient’s personal experiences.'
)

--insert into scholar_request (scholar_id, trainer_id, request) values