use FICS_DBPROJECT

select * from person order by person.id

--select * from person_classifier order by person_classifier.id

--select * from domain order by domain.id

--select * from scholar order by scholar.id

--select * from trainer order by trainer.id

--select * from course order by course.id

--select * from course_difficulity order by course_difficulity.rating

--select * from website order by website.id

--select * from scholar_courses order by scholar_courses.scholar_id

--select 
--	d.name as Category,
--	cd.title as Skill_Level, 
--	w.name as Website, 
--	w.url as Website_Link, 
--	sc.date_enrolled as Date_Enrolled, 
--	sc.date_completion as Date_to_Complete
--from 
--	scholar_courses sc 
--	join course c on sc.course_id = c.id 
--	join domain d on c.domain_id = d.id
--	join website w on c.website_id = w.id
--	join course_difficulity cd on c.difficulity_id = cd.id 
--where 
--	sc.scholar_id=1 and sc.date_enrolled < sc.date_completion
--order by
--	sc.date_completion

--select p.persontype from person p where p.id = 1

select 
	p.fullname as Student_Name, 
	ms.date_and_time as Date_and_Time, 
	ms.meeting_link as Meeting_Link, 
	ms.notes as Notes_Given
from mentor_session ms join person p on ms.scholar_id = p.id
where ms.date_and_time < getdate()

select 
	p.fullname as Student_Name, 
	cs.date_and_time as Date_and_Time, 
	cs.meeting_link as Meeting_Link, 
	cs.advice as Advice_Given
from counsellor_session cs join person p on cs.scholar_id = p.id
where cs.date_and_time < getdate()

select
	p.fullname as Mentor_Name,
	ms.date_and_time as Date_and_Time,
	ms.meeting_link as Meeting_Link, 
	ms.notes as Notes
from mentor_session ms join person p on ms.mentor_id = p.id
where ms.date_and_time < getdate()

select
	p.fullname as Counsellor_Name,
	cs.date_and_time as Date_and_Time,
	cs.meeting_link as Meeting_Link, 
	cs.advice as Advice_Received
from counsellor_session cs join person p on cs.counsellor_id = p.id
where cs.date_and_time < getdate()



--select case 
--	when exists(
--		select 1 
--		from person p
--		where p.mail = 'razz2k01@gmail.com' and p.password = 'howdyyo5679') 
--	then cast(1 as bit) 
--	else cast(0 as bit) end

--select p.name from person p where p.id = 15

--select * from institute order by institute.id

--select * from major order by major.id