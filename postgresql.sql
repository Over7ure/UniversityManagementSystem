/*
PostgreSQL
Database: wangcwmis12
*/

DROP TABLE IF EXISTS "wangcwmis12"."wangcw_adminusers12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_classes12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_colleges12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_courses12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_majors12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_scores12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_students12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_studentusers12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_teach12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_teachers12";
DROP TABLE IF EXISTS "wangcwmis12"."wangcw_teacherusers12";
DROP VIEW IF EXISTS "wangcwmis12"."wangcw_claview12";
DROP VIEW IF EXISTS "wangcwmis12"."wangcw_scoreview12";
DROP VIEW IF EXISTS "wangcwmis12"."wangcw_avgscoreview12";
DROP VIEW IF EXISTS "wangcwmis12"."wangcw_clacouview12";
DROP FUNCTION IF EXISTS "wangcwmis12"."delete_func()";
DROP FUNCTION IF EXISTS "wangcwmis12"."insert_func()";
DROP FUNCTION IF EXISTS "wangcwmis12"."update_func()";
DROP FUNCTION IF EXISTS "wangcwmis12"."wangcw_avgofscore12()";
DROP FUNCTION IF EXISTS "wangcwmis12"."wangcw_numberofregion12()";
DROP FUNCTION IF EXISTS "wangcwmis12"."wangcw_updatecredit_fun()";
CREATE TABLE "wangcw_adminusers12" (
  "wcw_ausername12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_apassword12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_afunction12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_adminusers12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_classes12" (
  "wcw_clano12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_mno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_colno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_classes12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_colleges12" (
  "wcw_colno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_colname12" varchar(50) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_colleges12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_courses12" (
  "wcw_couno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_couname12" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_counature12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_couhours12" float8 NOT NULL,
  "wcw_coumode12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_coucredits12" float8 NOT NULL
)
;
ALTER TABLE "wangcw_courses12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_majors12" (
  "wcw_mno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_mname12" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_colno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_majors12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_scores12" (
  "wcw_sno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_couno12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tsemester12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tyear12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_sscore12" float8 NOT NULL
)
;
ALTER TABLE "wangcw_scores12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_students12" (
  "wcw_sno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_sname12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_sgender12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_sage12" int4 NOT NULL,
  "wcw_ssource12" varchar(40) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_sgrade12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_scredits12" float8 NOT NULL,
  "wcw_sgpa12" float8 NOT NULL,
  "wcw_clano12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_sregion12" varchar(100) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_students12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_studentusers12" (
  "wcw_susername12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_spassword12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_sno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_studentusers12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_teach12" (
  "wcw_couno12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tsemester12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tyear12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_teach12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_teachers12" (
  "wcw_tno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tname12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tgender12" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tage12" int4 NOT NULL,
  "wcw_ttitle12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_ttel12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_teachers12" OWNER TO "wangcw12";
CREATE TABLE "wangcw_teacherusers12" (
  "wcw_tusername12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tpassword12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "wcw_tno12" varchar(20) COLLATE "pg_catalog"."default" NOT NULL
)
;
ALTER TABLE "wangcw_teacherusers12" OWNER TO "wangcw12";
CREATE VIEW "wangcw_claview12" AS  SELECT DISTINCT wangcw_classes12.wcw_clano12 AS "班级编号", 
    wangcw_classes12.wcw_colno12 AS "学院编号", 
    wangcw_colleges12.wcw_colname12 AS "学院名称", 
    wangcw_classes12.wcw_mno12 AS "专业编号", 
    wangcw_majors12.wcw_mname12 AS "专业名称"
   FROM wangcw_classes12
   JOIN wangcw_majors12 ON wangcw_classes12.wcw_mno12::text = wangcw_majors12.wcw_mno12::text
   JOIN wangcw_colleges12 ON wangcw_classes12.wcw_colno12::text = wangcw_colleges12.wcw_colno12::text AND wangcw_majors12.wcw_colno12::text = wangcw_colleges12.wcw_colno12::text
  ORDER BY wangcw_classes12.wcw_mno12;
ALTER TABLE "wangcw_claview12" OWNER TO "wangcw12";
CREATE VIEW "wangcw_scoreview12" AS  SELECT wangcw_scores12.wcw_sno12 AS "学生编号", 
    wangcw_students12.wcw_sname12 AS "学生姓名", 
    wangcw_scores12.wcw_couno12 AS "课程编号", 
    wangcw_courses12.wcw_couname12 AS "课程名称", 
    wangcw_scores12.wcw_tsemester12 AS "学期", 
    wangcw_scores12.wcw_tyear12 AS "学年", 
    wangcw_scores12.wcw_tno12 AS "教师编号", 
    wangcw_teachers12.wcw_tname12 AS "教师姓名", 
    wangcw_scores12.wcw_sscore12 AS "成绩"
   FROM wangcw_scores12
   JOIN wangcw_students12 ON wangcw_scores12.wcw_sno12::text = wangcw_students12.wcw_sno12::text
   JOIN wangcw_teachers12 ON wangcw_scores12.wcw_tno12::text = wangcw_teachers12.wcw_tno12::text
   JOIN wangcw_courses12 ON wangcw_scores12.wcw_couno12::text = wangcw_courses12.wcw_couno12::text
  ORDER BY wangcw_scores12.wcw_sno12, wangcw_scores12.wcw_tsemester12, wangcw_scores12.wcw_tyear12, wangcw_scores12.wcw_sscore12 DESC;
ALTER TABLE "wangcw_scoreview12" OWNER TO "wangcw12";
CREATE VIEW "wangcw_avgscoreview12" AS  SELECT wangcw_scores12.wcw_couno12 AS "课程编号", 
    wangcw_courses12.wcw_couname12 AS "课程名称", 
    wangcw_scores12.wcw_tsemester12 AS "学期", 
    wangcw_scores12.wcw_tyear12 AS "学年", 
    wangcw_scores12.wcw_tno12 AS "任课教师编号", 
    wangcw_teachers12.wcw_tname12 AS "教师姓名", 
    avg(wangcw_scores12.wcw_sscore12) AS "平均成绩"
   FROM wangcw_scores12
   JOIN wangcw_courses12 ON wangcw_scores12.wcw_couno12::text = wangcw_courses12.wcw_couno12::text
   JOIN wangcw_teachers12 ON wangcw_scores12.wcw_tno12::text = wangcw_teachers12.wcw_tno12::text
  GROUP BY wangcw_scores12.wcw_couno12, wangcw_scores12.wcw_tsemester12, wangcw_scores12.wcw_tyear12, wangcw_courses12.wcw_couname12, wangcw_scores12.wcw_tno12, wangcw_teachers12.wcw_tname12
  ORDER BY wangcw_scores12.wcw_couno12;
ALTER TABLE "wangcw_avgscoreview12" OWNER TO "wangcw12";
CREATE VIEW "wangcw_clacouview12" AS  SELECT DISTINCT wangcw_students12.wcw_clano12 AS "班级编号", 
    wangcw_scores12.wcw_couno12 AS "课程编号", 
    wangcw_courses12.wcw_couname12 AS "课程名称", 
    wangcw_courses12.wcw_counature12 AS "课程性质", 
    wangcw_courses12.wcw_couhours12 AS "课程学时", 
    wangcw_courses12.wcw_coumode12 AS "考察模式", 
    wangcw_courses12.wcw_coucredits12 AS "课程学分", 
    wangcw_scores12.wcw_tsemester12 AS "学期", 
    wangcw_scores12.wcw_tyear12 AS "学年"
   FROM wangcw_scores12
   JOIN wangcw_courses12 ON wangcw_scores12.wcw_couno12::text = wangcw_courses12.wcw_couno12::text
   JOIN wangcw_students12 ON wangcw_scores12.wcw_sno12::text = wangcw_students12.wcw_sno12::text
  ORDER BY wangcw_scores12.wcw_tsemester12, wangcw_scores12.wcw_tyear12, wangcw_students12.wcw_clano12 DESC;
ALTER TABLE "wangcw_clacouview12" OWNER TO "wangcw12";
CREATE OR REPLACE FUNCTION "delete_func"()
  RETURNS "pg_catalog"."trigger" AS $BODY$
BEGIN
UPDATE wangcw_students12
 SET wcw_scredits12=(SELECT SUM(wcw_coucredits12) FROM wangcw_courses12 WHERE wcw_couno12 IN(
 SELECT wcw_couno12 FROM wangcw_scores12 WHERE wangcw_scores12.wcw_sscore12>=60 AND wangcw_scores12.wcw_sno12 = old.wcw_sno12)) WHERE wangcw_students12.wcw_sno12 =old.wcw_sno12;
 RETURN OLD;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION "delete_func"() OWNER TO "wangcw12";
CREATE OR REPLACE FUNCTION "insert_func"()
  RETURNS "pg_catalog"."trigger" AS $BODY$
BEGIN
INSERT INTO wangcw_scores12
VALUES(new.wcw_sno12,wcw_couno12,wcw_tsemester12,new.wcw_tyear12,new.wcw_tno12,new.wcw_sscore12);
RETURN NEW;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION "insert_func"() OWNER TO "wangcw12";
CREATE OR REPLACE FUNCTION "update_func"()
  RETURNS "pg_catalog"."trigger" AS $BODY$
BEGIN
UPDATE wangcw_students12
SET wcw_sgpa12=(select round(cast(wcw_scredits12 as numeric )/cast(5.3 as numeric),2) from wangcw_students12 where wcw_sno12=new.wcw_sno12) where wcw_sno12=new.wcw_sno12;
return NEW;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION "update_func"() OWNER TO "wangcw12";
CREATE OR REPLACE FUNCTION "wangcw_avgofscore12"()
  RETURNS TABLE("课程编号" varchar, "平均成绩" float8) AS $BODY$
BEGIN
   RETURN QUERY
select
wcw_couno12 as 课程编号,
AVG(wcw_sscore12) as 平均成绩
from wangcw_scores12
group by wcw_couno12;
END
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100
  ROWS 1000;
ALTER FUNCTION "wangcw_avgofscore12"() OWNER TO "wangcw12";
CREATE OR REPLACE FUNCTION "wangcw_numberofregion12"()
  RETURNS TABLE("地区" varchar, "人数" int8) AS $BODY$
BEGIN
   RETURN QUERY
select
wcw_sregion12 as 地区,
COUNT(wcw_sno12) as 人数
from wangcw_students12
group by wcw_sregion12;
END
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100
  ROWS 1000;
ALTER FUNCTION "wangcw_numberofregion12"() OWNER TO "wangcw12";
CREATE OR REPLACE FUNCTION "wangcw_updatecredit_fun"()
  RETURNS "pg_catalog"."trigger" AS $BODY$
begin
 UPDATE wangcw_students12
 SET wcw_scredits12=(SELECT SUM(wcw_coucredits12) FROM wangcw_courses12 WHERE wcw_couno12 IN(
 SELECT wcw_couno12 FROM wangcw_scores12 WHERE wangcw_scores12.wcw_sscore12>=60 AND wangcw_scores12.wcw_sno12 = new.wcw_sno12)) WHERE wangcw_students12.wcw_sno12 =new.wcw_sno12;
 RETURN NEW;
end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION "wangcw_updatecredit_fun"() OWNER TO "wangcw12";
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_adminusers12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_adminusers12";
INSERT INTO "wangcwmis12"."wangcw_adminusers12" ("wcw_ausername12","wcw_apassword12","wcw_afunction12") VALUES ('admin002', 'admin', '校级管理员'),('admin003', 'admin', '院级管理员'),('admin001', 'admin', '系统管理员'),('admin004', 'admin', '院级管理员');
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_classes12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_classes12";
INSERT INTO "wangcwmis12"."wangcw_classes12" ("wcw_clano12","wcw_mno12","wcw_colno12") VALUES ('软工01', '001', '001'),('建设01', '002', '002'),('人文01', '003', '003'),('数学01', '004', '004');
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_colleges12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_colleges12";
INSERT INTO "wangcwmis12"."wangcw_colleges12" ("wcw_colno12","wcw_colname12") VALUES ('001', '计算机学院'),('002', '建筑与设计学院'),('003', '人文学院'),('004', '理学院');
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_courses12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_courses12";
INSERT INTO "wangcwmis12"."wangcw_courses12" ("wcw_couno12","wcw_couname12","wcw_counature12","wcw_couhours12","wcw_coumode12","wcw_coucredits12") VALUES ('001', '线性代数', '必修课', 64, '考试', 5),('002', '英语', '必修课', 64, '考试', 5),('003', '人与自然', '选修课', 32, '考查', 2),('004', '建筑设计基础', '必修课', 64, '考试', 5),('005', '现代文学导论', '必修课', 64, '考试', 5),('006', 'C++程序设计', '必修课', 64, '考试', 5),('007', '影视动漫赏析', '选修课', 32, '考查', 5);
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_majors12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_majors12";
INSERT INTO "wangcwmis12"."wangcw_majors12" ("wcw_mno12","wcw_mname12","wcw_colno12") VALUES ('001', '软件工程', '001'),('003', '人文修养', '003'),('002', '建筑设计', '002'),('004', '数学', '004');
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_scores12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_scores12";
INSERT INTO "wangcwmis12"."wangcw_scores12" ("wcw_sno12","wcw_couno12","wcw_tsemester12","wcw_tyear12","wcw_tno12","wcw_sscore12") VALUES ('001', '006', '2', '2021', '001', 83),('001', '007', '1', '2021', '004', 95),('002', '004', '1', '2021', '003', 86),('003', '005', '2', '2021', '002', 88),('003', '007', '1', '2021', '004', 85),('004', '001', '2', '2021', '001', 87),('004', '002', '1', '2021', '002', 84),('004', '006', '2', '2021', '001', 94),('001', '003', '1', '2021', '003', 85),('001', '001', '1', '2021', '002', 80),('002', '001', '2', '2021', '001', 80),('001', '002', '1', '2021', '002', 88),('002', '002', '1', '2021', '002', 93),('003', '002', '1', '2021', '002', 95),('004', '007', '1', '2021', '004', 86);
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_students12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_students12";
INSERT INTO "wangcwmis12"."wangcw_students12" ("wcw_sno12","wcw_sname12","wcw_sgender12","wcw_sage12","wcw_ssource12","wcw_sgrade12","wcw_scredits12","wcw_sgpa12","wcw_clano12","wcw_sregion12") VALUES ('001', '张三', '男', 20, '浙江嘉兴', '2021级', 22, 4.15, '软工01', '浙江'),('002', '李四', '男', 20, '浙江杭州', '2021级', 15, 2.83, '建设01', '浙江'),('003', '王五', '女', 20, '上海', '2021级', 15, 2.83, '人文01', '上海'),('004', '赵六', '男', 20, '北京', '2021级', 20, 3.77, '数学01', '北京');
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_studentusers12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_studentusers12";
INSERT INTO "wangcwmis12"."wangcw_studentusers12" ("wcw_susername12","wcw_spassword12","wcw_sno12") VALUES ('002', 'pwd', '002'),('003', 'pwd', '003'),('001', 'pwd', '001'),('004', 'pwd', '004');
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_teach12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_teach12";
INSERT INTO "wangcwmis12"."wangcw_teach12" ("wcw_couno12","wcw_tno12","wcw_tsemester12","wcw_tyear12") VALUES ('001', '001', '2', '2021'),('002', '002', '1', '2021'),('003', '003', '1', '2021'),('004', '003', '1', '2021'),('001', '002', '1', '2021'),('005', '002', '2', '2021'),('006', '001', '2', '2021'),('007', '004', '1', '2021');
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_teachers12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_teachers12";
INSERT INTO "wangcwmis12"."wangcw_teachers12" ("wcw_tno12","wcw_tname12","wcw_tgender12","wcw_tage12","wcw_ttitle12","wcw_ttel12") VALUES ('001', '王老师', '男', 40, '教授', '13766668888'),('002', '李老师', '女', 35, '副教授', '13844447777'),('003', '周老师', '女', 30, '讲师', '13922225555'),('004', '吴老师', '男', 26, '助教', '13656565656');
COMMIT;
BEGIN;
LOCK TABLE "wangcwmis12"."wangcw_teacherusers12" IN SHARE MODE;
DELETE FROM "wangcwmis12"."wangcw_teacherusers12";
INSERT INTO "wangcwmis12"."wangcw_teacherusers12" ("wcw_tusername12","wcw_tpassword12","wcw_tno12") VALUES ('002', 'pwd', '002'),('003', 'pwd', '003'),('004', 'pwd', '004'),('001', 'pwd', '001');
COMMIT;
ALTER TABLE "wangcw_adminusers12" ADD CONSTRAINT "wangcw_adminusers12_pkey" PRIMARY KEY ("wcw_ausername12");
ALTER TABLE "wangcw_classes12" ADD CONSTRAINT "wangcw_classes12_pkey" PRIMARY KEY ("wcw_clano12");
ALTER TABLE "wangcw_colleges12" ADD CONSTRAINT "wangcw_colleges12_pkey" PRIMARY KEY ("wcw_colno12");
ALTER TABLE "wangcw_courses12" ADD CONSTRAINT "wangcw_courses12_pkey" PRIMARY KEY ("wcw_couno12");
ALTER TABLE "wangcw_majors12" ADD CONSTRAINT "wangcw_majors12_pkey" PRIMARY KEY ("wcw_mno12");
ALTER TABLE "wangcw_scores12" ADD CONSTRAINT "wangcw_scores12_pkey" PRIMARY KEY ("wcw_sno12", "wcw_couno12", "wcw_tsemester12", "wcw_tyear12", "wcw_tno12");
ALTER TABLE "wangcw_students12" ADD CONSTRAINT "wangcw_students12_pkey" PRIMARY KEY ("wcw_sno12");
CREATE UNIQUE INDEX "wangcw_stu_snoindex12" ON "wangcw_students12" USING btree (
  "wcw_sno12" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);
ALTER TABLE "wangcw_studentusers12" ADD CONSTRAINT "wangcw_studentusers12_pkey" PRIMARY KEY ("wcw_susername12");
ALTER TABLE "wangcw_teach12" ADD CONSTRAINT "wangcw_teach12_pkey" PRIMARY KEY ("wcw_couno12", "wcw_tno12", "wcw_tsemester12", "wcw_tyear12");
ALTER TABLE "wangcw_teachers12" ADD CONSTRAINT "wangcw_teachers12_pkey" PRIMARY KEY ("wcw_tno12");
CREATE UNIQUE INDEX "wangcw_tea_tnoindex12" ON "wangcw_teachers12" USING btree (
  "wcw_tno12" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);
ALTER TABLE "wangcw_teacherusers12" ADD CONSTRAINT "wangcw_teacherusers12_pkey" PRIMARY KEY ("wcw_tusername12");
ALTER TABLE "wangcw_adminusers12" ADD CONSTRAINT "wangcw_adminusers12_wcw_afunction12_check" CHECK (((wcw_afunction12)::text = ANY ((ARRAY['系统管理员'::character varying, '校级管理员'::character varying, '院级管理员'::character varying])::text[])));
ALTER TABLE "wangcw_classes12" ADD CONSTRAINT "wangcw_classes12_wcw_colno12_fkey" FOREIGN KEY ("wcw_colno12") REFERENCES "wangcwmis12"."wangcw_colleges12" ("wcw_colno12") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "wangcw_classes12" ADD CONSTRAINT "wangcw_classes12_wcw_mno12_fkey" FOREIGN KEY ("wcw_mno12") REFERENCES "wangcwmis12"."wangcw_majors12" ("wcw_mno12") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "wangcw_courses12" ADD CONSTRAINT "wangcw_courses12_wcw_coucredits12_check" CHECK ((wcw_coucredits12 > (0)::double precision));
ALTER TABLE "wangcw_courses12" ADD CONSTRAINT "wangcw_courses12_wcw_coumode12_check" CHECK (((wcw_coumode12)::text = ANY ((ARRAY['考试'::character varying, '考查'::character varying])::text[])));
ALTER TABLE "wangcw_courses12" ADD CONSTRAINT "wangcw_courses12_wcw_couhours12_check" CHECK ((wcw_couhours12 > (0)::double precision));
ALTER TABLE "wangcw_courses12" ADD CONSTRAINT "wangcw_courses12_wcw_counature12_check" CHECK (((wcw_counature12)::text = ANY ((ARRAY['任选课'::character varying, '体育课'::character varying, '必选课'::character varying, '限选课'::character varying, '选修课'::character varying, '必修课'::character varying])::text[])));
ALTER TABLE "wangcw_majors12" ADD CONSTRAINT "wangcw_majors12_wcw_colno12_fkey" FOREIGN KEY ("wcw_colno12") REFERENCES "wangcwmis12"."wangcw_colleges12" ("wcw_colno12") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "wangcw_scores12" ADD CONSTRAINT "wangcw_scores12_wcw_sscore12_check" CHECK ((wcw_sscore12 > (0)::double precision));
ALTER TABLE "wangcw_scores12" ADD CONSTRAINT "wangcw_scores12_wcw_couno12_fkey" FOREIGN KEY ("wcw_couno12", "wcw_tno12", "wcw_tsemester12", "wcw_tyear12") REFERENCES "wangcwmis12"."wangcw_teach12" ("wcw_couno12", "wcw_tno12", "wcw_tsemester12", "wcw_tyear12") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "wangcw_scores12" ADD CONSTRAINT "wangcw_scores12_wcw_sno12_fkey" FOREIGN KEY ("wcw_sno12") REFERENCES "wangcwmis12"."wangcw_students12" ("wcw_sno12") ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE TRIGGER "delete_trigger" AFTER DELETE ON "wangcw_scores12"
FOR EACH ROW
EXECUTE PROCEDURE "wangcwmis12"."delete_func"();
CREATE TRIGGER "wangcw_updatecredit_trigger12" AFTER INSERT OR UPDATE ON "wangcw_scores12"
FOR EACH ROW
EXECUTE PROCEDURE "wangcwmis12"."wangcw_updatecredit_fun"();
ALTER TABLE "wangcw_students12" ADD CONSTRAINT "wangcw_students12_wcw_sgpa12_check" CHECK (((wcw_sgpa12 >= (0)::double precision) AND (wcw_sgpa12 <= (5)::double precision)));
ALTER TABLE "wangcw_students12" ADD CONSTRAINT "wangcw_students12_wcw_scredits12_check" CHECK ((wcw_scredits12 >= (0)::double precision));
ALTER TABLE "wangcw_students12" ADD CONSTRAINT "wangcw_students12_wcw_sage12_check" CHECK (((wcw_sage12 >= 0) AND (wcw_sage12 <= 120)));
ALTER TABLE "wangcw_students12" ADD CONSTRAINT "wangcw_students12_wcw_sgender12_check" CHECK (((wcw_sgender12)::text = ANY ((ARRAY['男'::character varying, '女'::character varying])::text[])));
ALTER TABLE "wangcw_students12" ADD CONSTRAINT "wangcw_students12_wcw_clano12_fkey" FOREIGN KEY ("wcw_clano12") REFERENCES "wangcwmis12"."wangcw_classes12" ("wcw_clano12") ON DELETE NO ACTION ON UPDATE CASCADE;
CREATE TRIGGER "wangcw_gpaTri12" AFTER UPDATE OF "wcw_scredits12" ON "wangcw_students12"
FOR EACH ROW
EXECUTE PROCEDURE "wangcwmis12"."update_func"();
ALTER TABLE "wangcw_studentusers12" ADD CONSTRAINT "wangcw_studentusers12_wcw_sno12_fkey" FOREIGN KEY ("wcw_sno12") REFERENCES "wangcwmis12"."wangcw_students12" ("wcw_sno12") ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE "wangcw_teach12" ADD CONSTRAINT "wangcw_teach12_wcw_couno12_fkey" FOREIGN KEY ("wcw_couno12") REFERENCES "wangcwmis12"."wangcw_courses12" ("wcw_couno12") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "wangcw_teach12" ADD CONSTRAINT "wangcw_teach12_wcw_tno12_fkey" FOREIGN KEY ("wcw_tno12") REFERENCES "wangcwmis12"."wangcw_teachers12" ("wcw_tno12") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "wangcw_teachers12" ADD CONSTRAINT "wangcw_teachers12_wcw_ttitle12_check" CHECK (((wcw_ttitle12)::text = ANY ((ARRAY['教授'::character varying, '副教授'::character varying, '讲师'::character varying, '助教'::character varying])::text[])));
ALTER TABLE "wangcw_teachers12" ADD CONSTRAINT "wangcw_teachers12_wcw_tage12_check" CHECK (((wcw_tage12 >= 0) AND (wcw_tage12 <= 120)));
ALTER TABLE "wangcw_teachers12" ADD CONSTRAINT "wangcw_teachers12_wcw_tgender12_check" CHECK (((wcw_tgender12)::text = ANY ((ARRAY['男'::character varying, '女'::character varying])::text[])));
ALTER TABLE "wangcw_teacherusers12" ADD CONSTRAINT "wangcw_teacherusers12_wcw_tno12_fkey" FOREIGN KEY ("wcw_tno12") REFERENCES "wangcwmis12"."wangcw_teachers12" ("wcw_tno12") ON DELETE NO ACTION ON UPDATE NO ACTION;
