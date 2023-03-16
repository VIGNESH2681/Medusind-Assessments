Create Table Movie12(
 Mid int Primary Key NOT NULL,
 Moviename Varchar(50) NOT NULL,
 DateofRelease Date NOT NULL
);

INSERT INTO Movie12 Values (1, 'The Matrix', '1999-03-31');
INSERT INTO Movie12 Values (2, 'Need For Speed', '2015-09-03');
INSERT INTO Movie12 Values (3, 'Martian', '2015-10-2');
INSERT INTO Movie12 Values (4, 'The Pursuit of Happyness', '2006-12-15');
INSERT INTO Movie12 Values (5, 'Avatar', '2009-12-18');



SELECT * FROM Movie12;