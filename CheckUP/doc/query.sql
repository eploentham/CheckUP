delete from b_excel_init
insert into b_excel_init(id)
values('10000');

61-08-07
ALTER TABLE dbo.b_company ADD
	report_sum_name_pe nvarchar(255) NULL,
	report_sum_name_fbs nvarchar(255) NULL,
	report_sum_name_cbc nvarchar(255) NULL

UPDATE       b_company
SET                report_sum_name_pe = 'การตรวจ/วัดBMI ดัชนีมวลร่างกาย (วัดความอ้วน) ชีพจร(อัตราการเต้นของหัวใจ) และ ความดันโลหิต ', report_sum_name_fbs = 'การตรวจหาระดับน้ำตาลในเลือด (FBS)', report_sum_name_cbc = 'การตรวจความสมบูรณ์ของเลือด (CBC) '

UPDATE       b_company
SET                
[report_sum_name_bun] = 'การตรวจการทำงานของไต (BUN )'
, [report_sum_name_cho] = 'การตรวจหาระดับไขมันคลอเลสเตอรอลในเลือด ( Cholesterol )'
, [report_sum_name_eye] = 'ผลการตรวจสุขภาพสายตาทั่วไป สายตาสั้น/ ยาว ,สายตาเอียง'
, [report_sum_name_lung] = 'การตรวจสมรรถภาพการทำงานของปอด'
, [report_sum_name_other1] = ' '
, [report_sum_name_sgot] = 'การตรวจการทำงานของตับ (SGPT) , (SGOT) '
, [report_sum_name_stool_exam] = ' '
, [report_sum_name_sum] = ' '
, [report_sum_name_toxi] = ' '
, [report_sum_name_tri] = 'การตรวจหาไขมันไตกลีเซอไรด์ ( Triglyceride) '
, [report_sum_name_ua] = 'การตรวจความสมบูรณ์ของปัสสาวะ (Urine analysis) '
, [report_sum_name_uric] = 'การตรวจหากรดยูลิคในเลือด(Uric acid)'
, [report_sum_name_xray] = ' '


CREATE LOGIN pop WITH PASSWORD = 'Ekartc2c5' ; 

insert into b_company(comp_id) values('2');

insert into b_excel_init(id)values('10000');

insert into b_cust_checkup_patient_value_normal(patient_id) values('1');

update b_company
set comp_code = '100';

delete from b_company;
delete from b_cust_checkup_patient_value_normal;
delete from b_excel_init;


insert into b_company(comp_id) values('2');

insert into b_excel_init(id)values('10000');

insert into b_cust_checkup_patient_value_normal(patient_id) values('1');


INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('1','01','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('2','02','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('3','03','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('4','04','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('5','05','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('6','06','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('7','07','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('8','08','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('9','09','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('10','10','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('11','11','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('12','12','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('13','13','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('14','14','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('15','15','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('16','16','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('17','17','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('18','18','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('19','19','-');
INSERT INTO b_sticker (sticker_id,sticker_code,sticker_name) VALUES('20','20','-');

ALTER TABLE dbo.t_cust_checkup_patient ADD
	test01 nvarchar(255) NULL,
	test02 nvarchar(255) NULL,
	test03 nvarchar(255) NULL,
	test04 nvarchar(255) NULL,
	test05 nvarchar(255) NULL,
	test06 nvarchar(255) NULL,
	test07 nvarchar(255) NULL,
	test08 nvarchar(255) NULL,
	test09 nvarchar(255) NULL,
	test10 nvarchar(255) NULL,
	test11 nvarchar(255) NULL,
	test12 nvarchar(255) NULL,
	test13 nvarchar(255) NULL,
	test14 nvarchar(255) NULL,
	test15 nvarchar(255) NULL,
	test16 nvarchar(255) NULL,
	test17 nvarchar(255) NULL,
	test18 nvarchar(255) NULL,
	test19 nvarchar(255) NULL,
	test20 nvarchar(255) NULL

	update t_cust_checkup_patient
set 
test01 = '0'
, test02 = '0'
, test03 = '0'
, test04 = '0'
, test05 = '0'
, test06 = '0'
, test07 = '0'
, test08 = '0'
, test09 = '0'
, test10 = '0'
, test11 = '0'
, test12 = '0'
, test13 = '0'
, test14 = '0'
, test15 = '0'
, test16 = '0'
, test17 = '0'
, test18 = '0'
, test19 = '0'
, test20 = '0'

select *
into onsite_t_cust_checkup_patient
from t_cust_checkup_patient;

select *
into onsite_t_cust_checkup_patient1
from t_cust_checkup_patient1;

select *
into onsite_t_cust_checkup
from t_cust_checkup;

select * 
into b_excel_init_mini
from b_excel_init;


EXEC sp_addlinkedserver @server='SRV_NAME',
   @srvproduct=N'',
   @provider=N'SQLNCLI',   
   @datasrc=N'aaa.bbb.ccc.ddd';

EXEC sp_addlinkedsrvlogin 'SRV_NAME', 'false', NULL, 'your_remote_db_login_user', 'your_remote_db_login_password'

EXEC sp_addlinkedserver @server='kr_client',
   @srvproduct=N'',
   @provider=N'SQLNCLI',   
   @datasrc=N'mobile';

EXEC sp_addlinkedsrvlogin 'kr_server', 'false', NULL, 'pop', 'Ekartc2c5'

SELECT *
FROM testdetail
WHERE sampleid=125 AND TestTime >#2018-06-07 00:00:00# and testtime <= #2018-06-07 23:59:00#
ORDER BY testdetail.testtime, itemid ;

SELECT testtime, itemid, fullname, testresult, printref 
FROM testdetail 
left join testdefine on testdefine.id = testdetail.itemid
WHERE  TestTime >= #2016-05-01 00:00:00# and testtime <= #2016-05-31 23:59:00# and sampleid =5
ORDER BY testdetail.testtime, itemid; 

61-08-30
ALTER TABLE dbo.b_lab_map ADD
	value_normal nvarchar(255) NULL


SELECT  patientinfo.name, testdetail.sampleid, testdetail.id
                FROM testdetail 
left join patientinfo on testdetail.id = patientinfo.id
                WHERE  TestTime >= #24-08-2018 00:00:00# and testtime <= #24-08-2018 23:59:00# and patientinfo.questdate >= #24-08-2018 00:00:00# and patientinfo.questdate <= #24-08-2018 23:59:00#
                ORDER BY patientinfo.name,sampleid;

SELECT  patientinfo.name, testdetail.sampleid, patientinfo.id
                FROM testdetail 
left join patientinfo on testdetail.id = patientinfo.id
                WHERE  TestTime >= #24-08-2018 00:00:00# and testtime <= #24-08-2018 23:59:00# and patientinfo.questdate >= #24-08-2018 00:00:00# and patientinfo.questdate <= #24-08-2018 23:59:00#
                ORDER BY patientinfo.name,sampleid;


create table t_sticker (
     sticker_id varchar(255) not null,
     cust_checkup_patient_id varchar(255) not null,
     sticker_code varchar(255),
	 sticker_name varchar(255),
     primary key (sticker_id, cust_checkup_patient_id)
);


update t_cust_checkup
set 
	sticker01_name ='',
	sticker02_name ='',
	sticker03_name ='',
	sticker04_name ='',
	sticker05_name ='',
	sticker06_name ='',
	sticker07_name ='',
	sticker08_name ='',
	sticker09_name ='',
	sticker10_name ='',
	sticker11_name ='',
	sticker12_name ='',
	sticker13_name ='',
	sticker14_name ='',
	sticker15_name ='',
	sticker16_name ='',
	sticker17_name ='',
	sticker18_name ='',
	sticker19_name ='',
	sticker20_name =''
	