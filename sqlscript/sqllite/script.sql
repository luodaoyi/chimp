
-- ----------------------------
-- Table structure for school
-- ----------------------------
DROP TABLE IF EXISTS School;
CREATE TABLE School (
    id   CHAR(32)     PRIMARY KEY
                       NOT NULL,
    name VARCHAR (255) 
);

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS Student;
CREATE TABLE Student (
    id       CHAR(32)     NOT NULL
                           PRIMARY KEY,
    name     VARCHAR (255),
    age      INT,
    birthday DATETIME,
    schoolId CHAR (32) 
); 
