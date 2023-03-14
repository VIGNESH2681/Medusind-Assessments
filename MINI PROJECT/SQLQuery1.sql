USE master;
CREATE DATABASE test03;
GO
USE test03

CREATE TABLE DEPT
       (DEPTNO DECIMAL(2) CONSTRAINT pk_dept PRIMARY KEY,
        DNAME VARCHAR(14),
        LOC VARCHAR(13) );

INSERT INTO DEPT VALUES (10, 'ACCOUNTING', 'NEW YORK');
INSERT INTO DEPT VALUES (20, 'RESEARCH',   'DALLAS');
INSERT INTO DEPT VALUES (30, 'SALES',      'CHICAGO');
INSERT INTO DEPT VALUES (40, 'OPERATIONS', 'BOSTON');

CREATE TABLE EMP
       (EMPNO DECIMAL(4) CONSTRAINT pk_emp PRIMARY KEY,
        ENAME VARCHAR(10),
        JOB VARCHAR(9),
        MGR DECIMAL(4),
        HIREDATE DATE,
        SAL DECIMAL(7, 2),
        COMM DECIMAL(7, 2),
        DEPTNO DECIMAL(2) CONSTRAINT fk_emp_dept REFERENCES dept(deptno));

INSERT INTO EMP VALUES
        (7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20);
INSERT INTO EMP VALUES
        (7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600,  300, 30);
INSERT INTO EMP VALUES
        (7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250,  500, 30);
INSERT INTO EMP VALUES
        (7566, 'JONES', 'MANAGER',  7839, '1981-04-02', 2975, NULL, 20);
INSERT INTO EMP VALUES
        (7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30);
INSERT INTO EMP VALUES
        (7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30);
INSERT INTO EMP VALUES
        (7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10);
INSERT INTO EMP VALUES
        (7788, 'SCOTT', 'ANALYST', 7566, '1982-12-09', 3000, NULL, 20);
INSERT INTO EMP VALUES
        (7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10);
INSERT INTO EMP VALUES
        (7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30);
INSERT INTO EMP VALUES
        (7876, 'ADAMS', 'CLERK', 7788, '1983-01-12', 1100, NULL, 20);
INSERT INTO EMP VALUES
        (7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30);
INSERT INTO EMP VALUES
        (7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20);
INSERT INTO EMP VALUES
        (7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);

CREATE TABLE SALGRADE
        (GRADE INT,
         LOSAL INTEGER,
         HISAL INTEGER);

INSERT INTO SALGRADE VALUES (1,  700, 1200);
INSERT INTO SALGRADE VALUES (2, 1201, 1400);
INSERT INTO SALGRADE VALUES (3, 1401, 2000);
INSERT INTO SALGRADE VALUES (4, 2001, 3000);
INSERT INTO SALGRADE VALUES (5, 3001, 9999);

select * from emp;