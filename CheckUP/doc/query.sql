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