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