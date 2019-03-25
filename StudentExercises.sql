
DROP TABLE IF EXISTS StudentExercise;
DROP TABLE IF EXISTS Exercise;
DROP TABLE IF EXISTS Student;
DROP TABLE IF EXISTS Instructor;
DROP TABLE IF EXISTS Cohort;

--Creating Tables

Create Table Cohort (
Id integer not null Primary Key Identity,
[Name] varchar (50) not null 
);


Create Table Student (
Id integer not null Primary Key Identity,
FirstName varchar (50) not null,
LastName varchar (50) not null,
SlackHandle varchar (50) not null,
Constraint FK_StudentCohort Foreign Key (CohortId) References Cohort(Id) 
);


Create Table Instructor (
Id integer not null Primary Key Identity ,
FirstName varChar (50) not null,
LastName varChar (50) not null,
SlackHandle varChar (50) not null,
CONSTRAINT FK_InstuctorCohort Foreign Key (CohortId) References Cohort(Id) 
);


Create Table Exercise (
Id integer not null Primary Key Identity ,
[Name] varchar (50) not null,
[Language] varchar (50) not null
);


Create Table StudentExercise(
Id integer not null Primary Key Identity,
StudentId integer not null,
ExerciseId integer not null,
CONSTRAINT FK_StuExerStu FOREIGN KEY (StudentId)
REFERENCES Student(Id), 
CONSTRAINT FK_StuExerExer FOREIGN KEY (ExerciseId)
REFERENCES Exercise(Id) 
);



--Setting Values 4 Cohorts, 8 Students, 4 Instructors, 3 Exercises

--Cohorts

Insert into Cohort ([Name])
Values ( '28' );

Insert into Cohort ([Name])
Values ( '29' );

Insert into Cohort ([Name])
Values ( '30' );

Insert into Cohort ([Name])
Values ( '31' );

--Students

Insert into Student (FirstName, LastName, SlackHandle, CohortId)
Values ('Johnny', 'Neumonic', 'johnny5@slack', 1 );

Insert into Student (FirstName, LastName, SlackHandle, CohortId)
Values ('Jill', 'Valentine', 'umbrella@slack', 2 );

Insert into Student (FirstName, LastName, SlackHandle, CohortId)
Values ('Kara', 'Thrace', 'starbuck@slack', 3 );

Insert into Student (FirstName, LastName, SlackHandle, CohortId)
Values ('Gaius', 'Balter', '6lover@slack', 4 );

Insert into Student (FirstName, LastName, SlackHandle, CohortId)
Values ('Khal', 'Drago', 'horsey@slack', 1 );

Insert into Student (FirstName, LastName, SlackHandle, CohortId)
Values ('Daenerys', 'Targaryen', 'umbrella@slack', 2 );

Insert into Student (FirstName, LastName, SlackHandle, CohortId)
Values ('Micheal', 'Scott', 'dundies@slack', 3 );

Insert into Student (FirstName, LastName, SlackHandle, CohortId)
Values ('Tony', 'Stark', 'ironman@slack', 4 );

--Instructors

Insert into Instructor (FirstName, LastName, SlackHandle, CohortId)
Values ( 'Mister' , 'Miyagi', 'okinawaSensei@slack', 1 );

Insert into Instructor (FirstName, LastName, SlackHandle, CohortId)
Values ( 'Splinter' , 'Rat', 'tmntTeacher@slack', 2 );

Insert into Instructor (FirstName, LastName, SlackHandle, CohortId)
Values ( 'Master' , 'Roshi', 'justSayin@slack', 3 );

Insert into Instructor (FirstName, LastName, SlackHandle, CohortId)
Values ( 'Morpheus', 'Fishburne', 'redPill@slack', 4 );

-- Exercises

Insert into Exercise ([Name], [Language])
Values ( 'ChickenMonkey' , 'Javascript' );

Insert into Exercise ([Name], [Language])
Values ( 'Planets' , 'C#' );

Insert into Exercise ([Name], [Language])
Values ( 'RandomNumbers' , 'C#' );

--Student Exercises
Insert into StudentExercise (StudentId, ExerciseId)
Values (1,1);

Insert into StudentExercise (StudentId, ExerciseId)
Values (2,2);

Insert into StudentExercise (StudentId, ExerciseId)
Values (3,3);

Insert into StudentExercise (StudentId, ExerciseId)
Values (4,1);

Insert into StudentExercise (StudentId, ExerciseId)
Values (5,2);

Insert into StudentExercise (StudentId, ExerciseId)
Values (6,3);

Insert into StudentExercise (StudentId, ExerciseId)
Values (7,1);

Insert into StudentExercise (StudentId, ExerciseId)
Values (8,2);

select * from Exercise;
select * from Student;
select * from Instructor;
select * from StudentExercise;
select * from Cohort;