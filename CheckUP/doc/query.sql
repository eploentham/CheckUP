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