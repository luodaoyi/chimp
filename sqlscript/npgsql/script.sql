
-- ----------------------------
-- Table structure for school
-- ----------------------------
DROP TABLE IF EXISTS school;
CREATE TABLE school (
  id UUID NOT NULL,
  name varchar(255) NOT NULL,
  PRIMARY KEY (Id)
);

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS student;
CREATE TABLE student (
  id UUID NOT NULL,
  name varchar(255) DEFAULT NULL,
  schoolid varchar(36) DEFAULT NULL,
  Birthday timestamp DEFAULT NULL,
  PRIMARY KEY (Id) 
);
