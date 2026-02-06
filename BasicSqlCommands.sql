CREATE Database StudentInfo;
USE StudentInfo;
/* DDL Commands Pratice
 1. Create Command 
   Syntax -- CREATE Table Tablename*/
   CREATE Table Students.(
    ID INT PRIMARY KEY,
    NAME VARCHAR(100)
   );
   /* 2.Alter Command
   Syntax -- ALTER TABLE TABLENAME ADD FIELDNAME
   */
   ALTER Table Students ADD Age INT ;
   /* 3. Drop Command
    Syntax --- DROP Table TableName */
    DROP Table Students;
    /* DML Commands Practice
    1. Insert Command
    Syntax -- Insert Into Tablename Values(FieldName)
    */
    INSERT INTO Students(ID,NAME,Age) VALUES (101,'Sambhav',21);
    INSERT INTO Students(ID,NAME,Age) VALUES (102 ,'Aditey', 20);
    INSERT INTO Students(ID, NAME, Age) VALUES (103, 'Shyam', 22);
    INSERT INTO Students(ID, NAME, Age) VALUES (104, 'Satyam', 21);
    INSERT INTO Students(ID, NAME, Age) VALUES (105, 'Samarth', 19);
    INSERT INTO Students(ID, NAME, Age) VALUES (106, 'Anon', 23);

    /* 2. Update Command 
    Syntax --- Update TableName Set Column = value where condition 
     */
     UPDATE Students SET Age = 22 where ID =101;
     /* 3. Delete Command 
     Syntax --- Delete from TableName where condition */
     Delete from Students where ID = 101;
     /* DQL Command Practice
     1. Select Command 
     Syntax -- Select * from TableName 
     Select Field from TableName where condition
     */
      Select * from Students;
      Select NAME,Age from Students where Age>20;
      /* DCL Command Practice
      1. Grant Command
      Syntax -- Grant Select On TableName To FieldName 
       */
       Grant Select on Students To user_name ;
       /* 2. Revoke Command 
        Syntax -- REVOKE SELECT ON TableName  FROM FieldName;*/
       REVOKE SELECT ON Students FROM user_name;
      /* TCL Command Practice 
      1. Commit ,2. Rollback, 3. SavePoint
      */
BEGIN TRANSACTION;
UPDATE Students SET Age = 25 WHERE ID = 101;
SAVE TRANSACTION sp1;
UPDATE Students SET Age = 30 WHERE ID = 102;
ROLLBACK TRANSACTION sp1;
COMMIT TRANSACTION;
/* Joins 
1. Inner Joins 
*/
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    StudentID INT,
    CourseName VARCHAR(100)
);
INSERT INTO Courses VALUES (1, 101, 'C#');
INSERT INTO Courses VALUES (2, 102, 'Java');
INSERT INTO Courses VALUES (3, 104, 'Python');
INSERT INTO Courses VALUES (4, 107, 'SQL');   
INSERT INTO Courses VALUES (5, 108, 'React'); 
SELECT * 
FROM Students s
INNER JOIN Courses c
ON s.ID = c.StudentID;
/* 2. Left Join*/ 
SELECT * 
FROM Students s
LEFT JOIN Courses c
ON s.ID = c.StudentID;
/* 3. Right Join */
SELECT * 
FROM Students s
RIGHT JOIN Courses c
ON s.ID = c.StudentID;
/* 4. Outer Join*/
SELECT * 
FROM Students s
RIGHT JOIN Courses c
ON s.ID = c.StudentID;
/* 5. Cross Join */
SELECT 
    s.ID,
    s.NAME,
    c.CourseName
FROM Students s
CROSS JOIN Courses c;
/* 6. Self Join */
SELECT 
    s1.NAME AS OlderStudent,
    s2.NAME AS YoungerStudent
FROM Students s1
JOIN Students s2
ON s1.Age > s2.Age;



