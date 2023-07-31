/*
PostgreSQL
Database: database
*/

DROP TABLE IF EXISTS "database"."adminusers";
DROP TABLE IF EXISTS "database"."classes";
DROP TABLE IF EXISTS "database"."colleges";
DROP TABLE IF EXISTS "database"."courses";
DROP TABLE IF EXISTS "database"."majors";
DROP TABLE IF EXISTS "database"."scores";
DROP TABLE IF EXISTS "database"."students";
DROP TABLE IF EXISTS "database"."studentusers";
DROP TABLE IF EXISTS "database"."teach";
DROP TABLE IF EXISTS "database"."teachers";
DROP TABLE IF EXISTS "database"."teacherusers";
DROP VIEW IF EXISTS "database"."claview";
DROP VIEW IF EXISTS "database"."scoreview";
DROP VIEW IF EXISTS "database"."avgscoreview";
DROP VIEW IF EXISTS "database"."clacouview";
DROP FUNCTION IF EXISTS "database"."delete_func()";
DROP FUNCTION IF EXISTS "database"."insert_func()";
DROP FUNCTION IF EXISTS "database"."update_func()";
DROP FUNCTION IF EXISTS "database"."avgofscore()";
DROP FUNCTION IF EXISTS "database"."numberofregion()";
DROP FUNCTION IF EXISTS "database"."updatecredit_fun()";
CREATE TABLE "adminusers" (
  "ausername" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "apassword" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "afunction" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "adminusers" OWNER TO "user";
CREATE TABLE "classes" (
  "clano" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "mno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "colno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "classes" OWNER TO "user";
CREATE TABLE "colleges" (
  "colno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "colname" varchar(50) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "colleges" OWNER TO "user";
CREATE TABLE "courses" (
  "couno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "couname" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "counature" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "couhours" float8 NOT NULL,
  "coumode" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "coucredits" float8 NOT NULL
)
;
ALTER TABLE "courses" OWNER TO "user";
CREATE TABLE "majors" (
  "mno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "mname" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "colno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "majors" OWNER TO "user";
CREATE TABLE "scores" (
  "sno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "couno" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "tsemester" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "tyear" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "tno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "sscore" float8 NOT NULL
)
;
ALTER TABLE "scores" OWNER TO "user";
CREATE TABLE "students" (
  "sno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "sname" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "sgender" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "sage" int4 NOT NULL,
  "ssource" varchar(40) COLLATE "pg_catalog"."default" NOT NULL,
  "sgrade" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "scredits" float8 NOT NULL,
  "sgpa" float8 NOT NULL,
  "clano" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "sregion" varchar(100) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "students" OWNER TO "user";
CREATE TABLE "studentusers" (
  "susername" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "spassword" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "sno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "studentusers" OWNER TO "user";
CREATE TABLE "teach" (
  "couno" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "tno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "tsemester" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "tyear" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "teach" OWNER TO "user";
CREATE TABLE "teachers" (
  "tno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "tname" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "tgender" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "tage" int4 NOT NULL,
  "ttitle" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "ttel" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "teachers" OWNER TO "user";
CREATE TABLE "teacherusers" (
  "tusername" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "tpassword" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "tno" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "teacherusers" OWNER TO "user";
CREATE VIEW "claview" AS  SELECT DISTINCT classes.clano AS "班级编号", 
    classes.colno AS "学院编号", 
    colleges.colname AS "学院名称", 
    classes.mno AS "专业编号", 
    majors.mname AS "专业名称"
   FROM classes
   JOIN majors ON classes.mno::text = majors.mno::text
   JOIN colleges ON classes.colno::text = colleges.colno::text AND majors.colno::text = colleges.colno::text
  ORDER BY classes.mno;
ALTER TABLE "claview" OWNER TO "user";
CREATE VIEW "scoreview" AS  SELECT scores.sno AS "学生编号", 
    students.sname AS "学生姓名", 
    scores.couno AS "课程编号", 
    courses.couname AS "课程名称", 
    scores.tsemester AS "学期", 
    scores.tyear AS "学年", 
    scores.tno AS "教师编号", 
    teachers.tname AS "教师姓名", 
    scores.sscore AS "成绩"
   FROM scores
   JOIN students ON scores.sno::text = students.sno::text
   JOIN teachers ON scores.tno::text = teachers.tno::text
   JOIN courses ON scores.couno::text = courses.couno::text
  ORDER BY scores.sno, scores.tsemester, scores.tyear, scores.sscore DESC;
ALTER TABLE "scoreview" OWNER TO "user";
CREATE VIEW "avgscoreview" AS  SELECT scores.couno AS "课程编号", 
    courses.couname AS "课程名称", 
    scores.tsemester AS "学期", 
    scores.tyear AS "学年", 
    scores.tno AS "任课教师编号", 
    teachers.tname AS "教师姓名", 
    avg(scores.sscore) AS "平均成绩"
   FROM scores
   JOIN courses ON scores.couno::text = courses.couno::text
   JOIN teachers ON scores.tno::text = teachers.tno::text
  GROUP BY scores.couno, scores.tsemester, scores.tyear, courses.couname, scores.tno, teachers.tname
  ORDER BY scores.couno;
ALTER TABLE "avgscoreview" OWNER TO "user";
CREATE VIEW "clacouview" AS  SELECT DISTINCT students.clano AS "班级编号", 
    scores.couno AS "课程编号", 
    courses.couname AS "课程名称", 
    courses.counature AS "课程性质", 
    courses.couhours AS "课程学时", 
    courses.coumode AS "考察模式", 
    courses.coucredits AS "课程学分", 
    scores.tsemester AS "学期", 
    scores.tyear AS "学年"
   FROM scores
   JOIN courses ON scores.couno::text = courses.couno::text
   JOIN students ON scores.sno::text = students.sno::text
  ORDER BY scores.tsemester, scores.tyear, students.clano DESC;
ALTER TABLE "clacouview" OWNER TO "user";
CREATE OR REPLACE FUNCTION "delete_func"()
  RETURNS "pg_catalog"."trigger" AS $BODY$
BEGIN
UPDATE students
 SET scredits=(SELECT SUM(coucredits) FROM courses WHERE couno IN(
 SELECT couno FROM scores WHERE scores.sscore>=60 AND scores.sno = old.sno)) WHERE students.sno =old.sno;
 RETURN OLD;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION "delete_func"() OWNER TO "user";
CREATE OR REPLACE FUNCTION "insert_func"()
  RETURNS "pg_catalog"."trigger" AS $BODY$
BEGIN
INSERT INTO scores
VALUES(new.sno,couno,tsemester,new.tyear,new.tno,new.sscore);
RETURN NEW;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION "insert_func"() OWNER TO "user";
CREATE OR REPLACE FUNCTION "update_func"()
  RETURNS "pg_catalog"."trigger" AS $BODY$
BEGIN
UPDATE students
SET sgpa=(select round(cast(scredits as numeric )/cast(5.3 as numeric),2) from students where sno=new.sno) where sno=new.sno;
return NEW;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION "update_func"() OWNER TO "user";
CREATE OR REPLACE FUNCTION "avgofscore"()
  RETURNS TABLE("课程编号" varchar, "平均成绩" float8) AS $BODY$
BEGIN
   RETURN QUERY
select
couno as 课程编号,
AVG(sscore) as 平均成绩
from scores
group by couno;
END
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100
  ROWS 1000;
ALTER FUNCTION "avgofscore"() OWNER TO "user";
CREATE OR REPLACE FUNCTION "numberofregion"()
  RETURNS TABLE("地区" varchar, "人数" int8) AS $BODY$
BEGIN
   RETURN QUERY
select
sregion as 地区,
COUNT(sno) as 人数
from students
group by sregion;
END
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100
  ROWS 1000;
ALTER FUNCTION "numberofregion"() OWNER TO "user";
CREATE OR REPLACE FUNCTION "updatecredit_fun"()
  RETURNS "pg_catalog"."trigger" AS $BODY$
begin
 UPDATE students
 SET scredits=(SELECT SUM(coucredits) FROM courses WHERE couno IN(
 SELECT couno FROM scores WHERE scores.sscore>=60 AND scores.sno = new.sno)) WHERE students.sno =new.sno;
 RETURN NEW;
end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION "updatecredit_fun"() OWNER TO "user";
BEGIN;
LOCK TABLE "database"."adminusers" IN SHARE MODE;
DELETE FROM "database"."adminusers";
INSERT INTO "database"."adminusers" ("ausername","apassword","afunction") VALUES ('admin002', 'admin', '校级管理员'),('admin003', 'admin', '院级管理员'),('admin001', 'admin', '系统管理员'),('admin004', 'admin', '院级管理员');
COMMIT;
BEGIN;
LOCK TABLE "database"."classes" IN SHARE MODE;
DELETE FROM "database"."classes";
INSERT INTO "database"."classes" ("clano","mno","colno") VALUES ('软工01', '001', '001'),('建设01', '002', '002'),('人文01', '003', '003'),('数学01', '004', '004');
COMMIT;
BEGIN;
LOCK TABLE "database"."colleges" IN SHARE MODE;
DELETE FROM "database"."colleges";
INSERT INTO "database"."colleges" ("colno","colname") VALUES ('001', '计算机学院'),('002', '建筑与设计学院'),('003', '人文学院'),('004', '理学院');
COMMIT;
BEGIN;
LOCK TABLE "database"."courses" IN SHARE MODE;
DELETE FROM "database"."courses";
INSERT INTO "database"."courses" ("couno","couname","counature","couhours","coumode","coucredits") VALUES ('001', '线性代数', '必修课', 64, '考试', 5),('002', '英语', '必修课', 64, '考试', 5),('003', '人与自然', '选修课', 32, '考查', 2),('004', '建筑设计基础', '必修课', 64, '考试', 5),('005', '现代文学导论', '必修课', 64, '考试', 5),('006', 'C++程序设计', '必修课', 64, '考试', 5),('007', '影视动漫赏析', '选修课', 32, '考查', 5);
COMMIT;
BEGIN;
LOCK TABLE "database"."majors" IN SHARE MODE;
DELETE FROM "database"."majors";
INSERT INTO "database"."majors" ("mno","mname","colno") VALUES ('001', '软件工程', '001'),('003', '人文修养', '003'),('002', '建筑设计', '002'),('004', '数学', '004');
COMMIT;
BEGIN;
LOCK TABLE "database"."scores" IN SHARE MODE;
DELETE FROM "database"."scores";
INSERT INTO "database"."scores" ("sno","couno","tsemester","tyear","tno","sscore") VALUES ('001', '006', '2', '2021', '001', 83),('001', '007', '1', '2021', '004', 95),('002', '004', '1', '2021', '003', 86),('003', '005', '2', '2021', '002', 88),('003', '007', '1', '2021', '004', 85),('004', '001', '2', '2021', '001', 87),('004', '002', '1', '2021', '002', 84),('004', '006', '2', '2021', '001', 94),('001', '003', '1', '2021', '003', 85),('001', '001', '1', '2021', '002', 80),('002', '001', '2', '2021', '001', 80),('001', '002', '1', '2021', '002', 88),('002', '002', '1', '2021', '002', 93),('003', '002', '1', '2021', '002', 95),('004', '007', '1', '2021', '004', 86);
COMMIT;
BEGIN;
LOCK TABLE "database"."students" IN SHARE MODE;
DELETE FROM "database"."students";
INSERT INTO "database"."students" ("sno","sname","sgender","sage","ssource","sgrade","scredits","sgpa","clano","sregion") VALUES ('001', '张三', '男', 20, '浙江嘉兴', '2021级', 22, 4.15, '软工01', '浙江'),('002', '李四', '男', 20, '浙江杭州', '2021级', 15, 2.83, '建设01', '浙江'),('003', '王五', '女', 20, '上海', '2021级', 15, 2.83, '人文01', '上海'),('004', '赵六', '男', 20, '北京', '2021级', 20, 3.77, '数学01', '北京');
COMMIT;
BEGIN;
LOCK TABLE "database"."studentusers" IN SHARE MODE;
DELETE FROM "database"."studentusers";
INSERT INTO "database"."studentusers" ("susername","spassword","sno") VALUES ('002', 'pwd', '002'),('003', 'pwd', '003'),('001', 'pwd', '001'),('004', 'pwd', '004');
COMMIT;
BEGIN;
LOCK TABLE "database"."teach" IN SHARE MODE;
DELETE FROM "database"."teach";
INSERT INTO "database"."teach" ("couno","tno","tsemester","tyear") VALUES ('001', '001', '2', '2021'),('002', '002', '1', '2021'),('003', '003', '1', '2021'),('004', '003', '1', '2021'),('001', '002', '1', '2021'),('005', '002', '2', '2021'),('006', '001', '2', '2021'),('007', '004', '1', '2021');
COMMIT;
BEGIN;
LOCK TABLE "database"."teachers" IN SHARE MODE;
DELETE FROM "database"."teachers";
INSERT INTO "database"."teachers" ("tno","tname","tgender","tage","ttitle","ttel") VALUES ('001', '王老师', '男', 40, '教授', '13766668888'),('002', '李老师', '女', 35, '副教授', '13844447777'),('003', '周老师', '女', 30, '讲师', '13922225555'),('004', '吴老师', '男', 26, '助教', '13656565656');
COMMIT;
BEGIN;
LOCK TABLE "database"."teacherusers" IN SHARE MODE;
DELETE FROM "database"."teacherusers";
INSERT INTO "database"."teacherusers" ("tusername","tpassword","tno") VALUES ('002', 'pwd', '002'),('003', 'pwd', '003'),('004', 'pwd', '004'),('001', 'pwd', '001');
COMMIT;
ALTER TABLE "adminusers" ADD CONSTRAINT "adminusers_pkey" PRIMARY KEY ("ausername");
ALTER TABLE "classes" ADD CONSTRAINT "classes_pkey" PRIMARY KEY ("clano");
ALTER TABLE "colleges" ADD CONSTRAINT "colleges_pkey" PRIMARY KEY ("colno");
ALTER TABLE "courses" ADD CONSTRAINT "courses_pkey" PRIMARY KEY ("couno");
ALTER TABLE "majors" ADD CONSTRAINT "majors_pkey" PRIMARY KEY ("mno");
ALTER TABLE "scores" ADD CONSTRAINT "scores_pkey" PRIMARY KEY ("sno", "couno", "tsemester", "tyear", "tno");
ALTER TABLE "students" ADD CONSTRAINT "students_pkey" PRIMARY KEY ("sno");
CREATE UNIQUE INDEX "stu_snoindex" ON "students" USING btree (
  "sno" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);
ALTER TABLE "studentusers" ADD CONSTRAINT "studentusers_pkey" PRIMARY KEY ("susername");
ALTER TABLE "teach" ADD CONSTRAINT "teach_pkey" PRIMARY KEY ("couno", "tno", "tsemester", "tyear");
ALTER TABLE "teachers" ADD CONSTRAINT "teachers_pkey" PRIMARY KEY ("tno");
CREATE UNIQUE INDEX "tea_tnoindex" ON "teachers" USING btree (
  "tno" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);
ALTER TABLE "teacherusers" ADD CONSTRAINT "teacherusers_pkey" PRIMARY KEY ("tusername");
ALTER TABLE "adminusers" ADD CONSTRAINT "adminusers_afunction_check" CHECK (((afunction)::text = ANY ((ARRAY['系统管理员'::character varying, '校级管理员'::character varying, '院级管理员'::character varying])::text[])));
ALTER TABLE "classes" ADD CONSTRAINT "classes_colno_fkey" FOREIGN KEY ("colno") REFERENCES "database"."colleges" ("colno") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "classes" ADD CONSTRAINT "classes_mno_fkey" FOREIGN KEY ("mno") REFERENCES "database"."majors" ("mno") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "courses" ADD CONSTRAINT "courses_coucredits_check" CHECK ((coucredits > (0)::double precision));
ALTER TABLE "courses" ADD CONSTRAINT "courses_coumode_check" CHECK (((coumode)::text = ANY ((ARRAY['考试'::character varying, '考查'::character varying])::text[])));
ALTER TABLE "courses" ADD CONSTRAINT "courses_couhours_check" CHECK ((couhours > (0)::double precision));
ALTER TABLE "courses" ADD CONSTRAINT "courses_counature_check" CHECK (((counature)::text = ANY ((ARRAY['任选课'::character varying, '体育课'::character varying, '必选课'::character varying, '限选课'::character varying, '选修课'::character varying, '必修课'::character varying])::text[])));
ALTER TABLE "majors" ADD CONSTRAINT "majors_colno_fkey" FOREIGN KEY ("colno") REFERENCES "database"."colleges" ("colno") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "scores" ADD CONSTRAINT "scores_sscore_check" CHECK ((sscore > (0)::double precision));
ALTER TABLE "scores" ADD CONSTRAINT "scores_couno_fkey" FOREIGN KEY ("couno", "tno", "tsemester", "tyear") REFERENCES "database"."teach" ("couno", "tno", "tsemester", "tyear") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "scores" ADD CONSTRAINT "scores_sno_fkey" FOREIGN KEY ("sno") REFERENCES "database"."students" ("sno") ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE TRIGGER "delete_trigger" AFTER DELETE ON "scores"
FOR EACH ROW
EXECUTE PROCEDURE "database"."delete_func"();
CREATE TRIGGER "updatecredit_trigger" AFTER INSERT OR UPDATE ON "scores"
FOR EACH ROW
EXECUTE PROCEDURE "database"."updatecredit_fun"();
ALTER TABLE "students" ADD CONSTRAINT "students_sgpa_check" CHECK (((sgpa >= (0)::double precision) AND (sgpa <= (5)::double precision)));
ALTER TABLE "students" ADD CONSTRAINT "students_scredits_check" CHECK ((scredits >= (0)::double precision));
ALTER TABLE "students" ADD CONSTRAINT "students_sage_check" CHECK (((sage >= 0) AND (sage <= 0)));
ALTER TABLE "students" ADD CONSTRAINT "students_sgender_check" CHECK (((sgender)::text = ANY ((ARRAY['男'::character varying, '女'::character varying])::text[])));
ALTER TABLE "students" ADD CONSTRAINT "students_clano_fkey" FOREIGN KEY ("clano") REFERENCES "database"."classes" ("clano") ON DELETE NO ACTION ON UPDATE CASCADE;
CREATE TRIGGER "gpaTri" AFTER UPDATE OF "scredits" ON "students"
FOR EACH ROW
EXECUTE PROCEDURE "database"."update_func"();
ALTER TABLE "studentusers" ADD CONSTRAINT "studentusers_sno_fkey" FOREIGN KEY ("sno") REFERENCES "database"."students" ("sno") ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE "teach" ADD CONSTRAINT "teach_couno_fkey" FOREIGN KEY ("couno") REFERENCES "database"."courses" ("couno") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "teach" ADD CONSTRAINT "teach_tno_fkey" FOREIGN KEY ("tno") REFERENCES "database"."teachers" ("tno") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "teachers" ADD CONSTRAINT "teachers_ttitle_check" CHECK (((ttitle)::text = ANY ((ARRAY['教授'::character varying, '副教授'::character varying, '讲师'::character varying, '助教'::character varying])::text[])));
ALTER TABLE "teachers" ADD CONSTRAINT "teachers_tage_check" CHECK (((tage >= 0) AND (tage <= 0)));
ALTER TABLE "teachers" ADD CONSTRAINT "teachers_tgender_check" CHECK (((tgender)::text = ANY ((ARRAY['男'::character varying, '女'::character varying])::text[])));
ALTER TABLE "teacherusers" ADD CONSTRAINT "teacherusers_tno_fkey" FOREIGN KEY ("tno") REFERENCES "database"."teachers" ("tno") ON DELETE NO ACTION ON UPDATE NO ACTION;
