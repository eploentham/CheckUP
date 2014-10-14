using CheckUP.objdb;
using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUP.objdb
{
    public class CustCheckUpPatientDB
    {
        ConnectDB conn;
        public CustCheckUpPatient ccp;
        public CustCheckUpPatientDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            ccp = new CustCheckUpPatient();
            ccp.Id="patient_id";
            ccp.CustCheckupId="cust_checkup_id";    
            ccp.ChecklistId="t_checklist_id";    
            ccp.visitHn="visit_hn";    
            ccp.patientFullname="";    
            ccp.patientAge="";    
            ccp.departmentName="";    
            ccp.pid="";    
            ccp.patientNumber="";    
            ccp.sectionName="";    
            ccp.vitalsign="";    
            ccp.patientHeight="";    
            ccp.patientPulse="";    
            ccp.patientWeight="";    
            ccp.opticalExamLeft="";    
            ccp.opticalExamRight="";    
            ccp.fSexId="";    
            ccp.summaryPhysicalExam="";    
            ccp.stoolExamColor="";
            ccp.stoolExamAppearance="";
            ccp.stoolExamWbc="";
            ccp.stoolExamRbc="";
            ccp.stoolExamParasite="";
            ccp.toxicologyLead="";
            ccp.toxicologyMercury="";
            ccp.toxicologyBenzene="";
            ccp.toxicologyXylene="";
            ccp.audiogram500Left="";
            ccp.audiogram1000Left="";
            ccp.audiogram2000Left="";
            ccp.audiogram3000Left="";
            ccp.audiogram4000Left="";
            ccp.audiogram6000Left="";
            ccp.audiogram8000Left="";
            ccp.audiogramSummaryLeft="";
            ccp.audiogram500Right="";
            ccp.audiogram1000Right="";
            ccp.audiogram2000Right="";
            ccp.audiogram3000Right="";
            ccp.audiogram4000Rightt="";
            ccp.audiogram6000Right="";
            ccp.audiogram8000Right="";
            ccp.audiogramSummaryRight="";
            ccp.audiogramExam="";
            ccp.xrayChestExam="";
            ccp.xrayChestSummary="";
            ccp.eyesExam="";
            ccp.ekgExam="";
            ccp.caAfp="";
            ccp.caCea="";
            ccp.caPsa="";
            ccp.caHcg="";
            ccp.ca153="";
            ccp.ca125="";
            ccp.ca199="";
            ccp.thyroidT3="";
            ccp.thyroidT4="";
            ccp.thyroidTsh="";
            ccp.fPatientBloodGroupId="";
            ccp.vdrl="";
            ccp.antiHiv="";
            ccp.hbsag="";
            ccp.hbsab="";
            ccp.amphetamine="";
            ccp.disscusExam="";
            ccp.suggestExam="";
            ccp.sugar="";
            ccp.sugarDiagnosis="";
            ccp.sugarSummary="";
            ccp.sugarSuggess="";
            ccp.kidneyBun="";
            ccp.kidneyCreatinine="";
            ccp.liverSgot="";
            ccp.liverSgpt="";
            ccp.liverAlp="";
            ccp.uricAcid="";
            ccp.cholesterol="";
            ccp.triglyceride="";
            ccp.hdl="";
            ccp.ldl="";
            ccp.calcium="";
            ccp.cbcHb="";
            ccp.cbcHct="";
            ccp.cbcWbc="";
            ccp.cbcNeutrophil="";
            ccp.cbcLymphocyte="";
            ccp.cbcEosinophil="";
            ccp.cbcMonocyte="";
            ccp.cbcBasophil="";
            ccp.cbcPlateletCount="";
            ccp.cbcRbcMorpholog="";
            ccp.cbcSummary="";
            ccp.urineColor="";
            ccp.urineAppearance="";
            ccp.urinePh="";
            ccp.urineSpGr="";
            ccp.urineSugar="";
            ccp.urineProtein="";
            ccp.urineBlood="";
            ccp.urineKetone="";
            ccp.urineBacteria="";
            ccp.urineWbc="";
            ccp.urineRbc="";
            ccp.urineEpithelium="";
            ccp.urineSummary="";
            ccp.lungFvcPredic="";
            ccp.lungFvcMeas="";
            ccp.lungFvcPer="";
            ccp.lungFev1Predic="";
            ccp.lungFev1Meas="";
            ccp.lungFev1Per="";
            ccp.lungPerFev1="";
            ccp.lungSummary="";
            ccp.lungSuggess="";
            ccp.statusName="";
            ccp.rowNumber="row_number";
            ccp.cbcMcv="";
            ccp.toxicologyToluene="";
            ccp.thyroidRubellaLgg="";
            ccp.billirubin="";
            ccp.toxicologyThinner="";
            ccp.toxicologyAlcohol="";
            ccp.stickerQty="";
            ccp.statusCbc="";
            ccp.statusUa="";
            ccp.statusFbs="";
            ccp.statusPe="";
            ccp.statusXray="";
            ccp.statusStool="";
            ccp.stoolExamSummary="";
            ccp.cholesterolSummary="";
            ccp.cholesterolSuggess="";
            ccp.statusCholes="";
            ccp.StatusHbsag="";
            ccp.hbsagSuggess="";
            ccp.hbsagSummary="";
            ccp.cbcRbc="";
            ccp.cbcMch="";
            ccp.cbcMchc="";
            ccp.Active="";
            ccp.eyeBio="";
            ccp.amphetamineSummary="";
            ccp.amphetamineSuggess="";
            ccp.statusAmphetamine="";
            ccp.antiHivSummary="";
            ccp.antiHivSuggess="";
            ccp.statusAntiHiv="";
            ccp.statusUricAcid="";
            ccp.uricAcidSuggess="";
            ccp.uricAcidSummary="";
            ccp.statusVisit="";
            ccp.visitComment="";
            ccp.bmi="";
            ccp.caFt3="";
            ccp.hbtyping="";
            ccp.toxicologyHexane="";
            ccp.toxicologyMethanol="";
            ccp.toxicologyMek="";
            ccp.toxicologyAcetone="";
            ccp.antiHbc="";
            ccp.eyeLeft = "";
            ccp.eyeRight = "";
            ccp.opticalLeftAngle="";
            ccp.opticalRightAngle="";
            ccp.cbcMcvOld="";
            ccp.cbcHbOld="";
            ccp.cbcHctOld="";
            ccp.cbcWbcOld="";
            ccp.cbcNeutrophilOld="";
            ccp.cbcLymphocyteOld="";
            ccp.cbcEosinophilOld="";
            ccp.cbcMonocyteOld="";
            ccp.cbcBasophilOld="";
            ccp.cbcPlateletCountOld="";
            ccp.cbcRbcMorphologOld="";
            ccp.cbcSummaryOld="";
            ccp.cbcRbcOld="";
            ccp.cbcMchcOld="";
            ccp.cbcMchOld="";
            ccp.sugarOld="";
            ccp.kidneyBunOld="";
            ccp.kidneyCreatinineOld="";
            ccp.liverSgotOld="";
            ccp.liverSgptOld="";
            ccp.liverAlpOld="";
            ccp.uricAcidOld="";
            ccp.cholesterolOld="";
            ccp.triglycerideOld="";
            ccp.hdlOld="";
            ccp.ldlOld="";
            ccp.toxicologyLeadOld="";
            ccp.toxicologyMercuryOld="";
            ccp.toxicologyBenzeneOld="";
            ccp.toxicologyXyleneOld="";
            ccp.toxicologyThinnerOld="";
            ccp.toxicologyAlcoholOld="";
            ccp.toxicologyHexaneOld="";
            ccp.toxicologyMethanolOld="";
            ccp.toxicologyMekOld="";
            ccp.toxicologyAcetoneOld="";
            ccp.toxicologyTolueneOld="";
            ccp.urineLeu="";
            ccp.urineOther="";
            ccp.cultureStool="";
            ccp.cultureUrine="";
            ccp.cultureBacteria="";
            ccp.cultureSputum="";
            ccp.marketingCheckupPatientOldId="";
            ccp.thyroidFt3="";
            ccp.thyroidFt4="";
            ccp.amylase="";
            ccp.totalProtein="";
            ccp.albumin="";
            ccp.globulin="";
            ccp.albuminGlobulin="";
            ccp.directBillirubin="";
            ccp.colorBlindness="";
        }
        public String selectByPk1(String cuId)
        {
            //CustCheckUpPatient item = new CustCheckUpPatient();
            String sql = "", chk="";
            DataTable dt = new DataTable();
            sql = "Select " + ccp .Id+ " From " + ccp.table + " Where " + ccp.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                chk = dt.Rows[0][ccp.Id].ToString();
            }
            return chk;
        }
        private String insert(CustCheckUpPatient p) {
        String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "cc" + p.getGenID();
            }
            try {
    //            Connection conn = config1.getConnectionBangna;
    //            Statement st = conn.createStatement;
                //ccp = getMarketingTCheckupPatientByPK(st,"", p.getMarketingCheckupPatientId,"");
                p.departmentName=p.departmentName.Replace("'", "''");
                p.patientFullname = p.patientFullname.Replace("'", "''");
                p.sectionName = p.sectionName.Replace("'", "''");
                p.summaryPhysicalExam = p.summaryPhysicalExam.Replace("'", "''");
                p.xrayChestExam = p.xrayChestExam.Replace("'", "''");
                //p.xrayChestExam = p.xrayChestExam.Replace("'", "''"));
                //p.xrayChestExam = p.xrayChestExam.Replace("'", "''"));

                    //max = getMaxRowMarketingTCheckupPatient(st);
            sql = "Insert Into " + ccp.table+ "(" 
                + ccp.Id + ", " + ccp.amphetamine + ", "
                + ccp.antiHiv + "," + ccp.audiogramExam + ","
                + ccp.audiogram1000Left + "," + ccp.audiogram1000Right + ","
                + ccp.audiogram2000Left + "," + ccp.audiogram2000Right + ","
                + ccp.audiogram3000Left + "," + ccp.audiogram3000Right + ","

                + ccp.audiogram4000Left + "," + ccp.audiogram4000Rightt + ","
                + ccp.audiogram6000Left + "," + ccp.audiogram6000Right + ","
                + ccp.audiogram8000Left + "," + ccp.audiogram8000Right + ","
                + ccp.audiogram500Left + "," + ccp.audiogram500Right + ","
                + ccp.audiogramSummaryLeft + "," + ccp.audiogramSummaryRight + ","

                + ccp.ca125 + "," + ccp.ca125 + ","
                + ccp.ca199 + "," + ccp.caAfp + ","
                + ccp.caCea + "," + ccp.caHcg + ","
                + ccp.calcium + "," + ccp.caPsa + ","
                + ccp.cbcBasophil + "," + ccp.cbcEosinophil + ","

                + ccp.cbcHb + "," + ccp.cbcHct + ","
                + ccp.cbcLymphocyte + "," + ccp.cbcMonocyte + ","
                + ccp.cbcNeutrophil + "," + ccp.cbcPlateletCount + ","
                + ccp.cbcRbcMorpholog + "," + ccp.cbcWbc + ","
                + ccp.cholesterol + "," + ccp.departmentName + ","

                + ccp.disscusExam + "," + ccp.ekgExam + ","
                + ccp.urineEpithelium + "," + ccp.eyesExam + ","
                + ccp.fPatientBloodGroupId + "," + ccp.fSexId + ","
                + ccp.hbsab + "," + ccp.hbsag + ","
                + ccp.hdl + "," + ccp.kidneyBun + ","

                + ccp.kidneyCreatinine + "," + ccp.ldl + ","
                + ccp.liverAlp + "," + ccp.liverSgot + ","
                + ccp.liverSgpt + "," + ccp.CustCheckupId + ","
                + ccp.xrayChestExam + "," + ccp.opticalExamLeft + ","
                + ccp.opticalExamRight + "," + ccp.patientAge + ","

                + ccp.patientFullname + "," + ccp.xrayChestSummary+","
                + ccp.patientHeight + "," + ccp.patientNumber + ","
                + ccp.patientPulse + "," + ccp.patientWeight + ","
                + ccp.pid + "," + ccp.sectionName + ","
                + ccp.stoolExamAppearance + "," + ccp.ChecklistId + ","

                + ccp.stoolExamColor + "," + ccp.stoolExamParasite + ","
                + ccp.stoolExamRbc + "," + ccp.stoolExamWbc + ","
                + ccp.sugar + "," + ccp.suggestExam + ","
                + ccp.sugarDiagnosis + "," + ccp.sugarSuggess + ","
                + ccp.sugarSummary + ","//+ccp.CbcSummary+","

                + ccp.thyroidT3+ "," + ccp.thyroidT4 + ","
                + ccp.thyroidTsh + "," + ccp.toxicologyBenzene + ","
                + ccp.toxicologyLead + "," + ccp.toxicologyMercury + ","
                + ccp.toxicologyXylene + "," + ccp.triglyceride + ","
                + ccp.uricAcid + "," + ccp.urineAppearance + ","

                + ccp.urineBacteria + "," + ccp.urineBlood + ","
                + ccp.urineKetone + "," + ccp.urineColor + ","
                + ccp.urinePh + "," + ccp.urineProtein + ","
                + ccp.urineRbc + "," + ccp.urineSpGr + ","
                + ccp.urineSugar + "," + ccp.urineWbc + ","

                + ccp.lungFev1Meas + "," + ccp.lungFev1Per + ","
                + ccp.lungFev1Predic + "," + ccp.lungFvcMeas + ","
                + ccp.lungFvcPer + "," + ccp.lungFvcPredic + ","
                + ccp.lungPerFev1 + "," + ccp.lungSuggess + ","
                + ccp.lungSummary + "," +ccp.urineSummary+","

                + ccp.cbcSummary + "," +ccp.summaryPhysicalExam+","
                + ccp.vdrl + "," + ccp.visitHn + ","
                + ccp.rowNumber+","+ccp.cbcMcv+","
                    + ccp.stickerQty+","+ccp.statusCbc+","
                    + ccp.statusFbs+","+ccp.statusUa+","
                    + ccp.statusPe+","+ccp.statusXray+","
                    + ccp.statusStool+","+ccp.stoolExamSummary+","
                    + ccp.cholesterolSuggess+","+ccp.cholesterolSummary+","
                    + ccp.cbcMch+","+ccp.cbcMchc+","
                    + ccp.hbsagSuggess+","+ccp.hbsagSummary+","
                    + ccp.statusCholes+","+ccp.StatusHbsag+","
                    + ccp.cbcRbc+","+ccp.Active+","
                    + ccp.eyeBio+","+ccp.amphetamineSuggess+","
                    + ccp.amphetamineSummary+","+ccp.antiHivSuggess+","
                    + ccp.antiHivSummary+","+ccp.statusAmphetamine+","
                    + ccp.statusAntiHiv+","+ccp.statusVisit+") "
                + "Values('" + p.Id + "','" + p.amphetamine + "','"
                + p.antiHiv + "','" + p.audiogramExam + "','"
                + p.audiogram1000Left + "','" + p.audiogram1000Right + "','"
                + p.audiogram2000Left + "','" + p.audiogram2000Right + "','"
                + p.audiogram3000Left + "','" + p.audiogram3000Right + "','"

                + p.audiogram4000Left + "','" + p.audiogram4000Rightt + "','"
                + p.audiogram6000Left + "','" + p.audiogram6000Right + "','"
                + p.audiogram8000Left + "','" + p.audiogram8000Right + "','"
                + p.audiogram500Left + "','" + p.audiogram500Right + "','"
                + p.audiogramSummaryLeft + "','" + p.audiogramSummaryRight + "','"

                + p.ca125 + "','" + p.ca125 + "','"
                + p.ca199 + "','" + p.caAfp + "','"
                + p.caCea + "','" + p.caHcg + "','"
                + p.calcium + "','" + p.caPsa + "','"
                + p.cbcBasophil + "','" + p.cbcEosinophil + "','"

                + p.cbcHb + "','" + p.cbcHct + "','"
                + p.cbcLymphocyte + "','" + p.cbcMonocyte + "','"
                + p.cbcNeutrophil + "','" + p.cbcPlateletCount + "','"
                + p.cbcRbcMorpholog + "','" + p.cbcWbc + "','"
                + p.cholesterol + "','" + p.departmentName + "','"

                + p.disscusExam + "','" + p.ekgExam + "','"
                + p.urineEpithelium + "','" + p.eyesExam + "','"
                + p.fPatientBloodGroupId + "','" + p.fSexId + "','"
                + p.hbsab + "','" + p.hbsag + "','"
                + p.hdl + "','" + p.kidneyBun + "','"

                + p.kidneyCreatinine + "','" + p.ldl + "','"
                + p.liverAlp + "','" + p.liverSgot + "','"
                + p.liverSgpt + "','" + p.CustCheckupId + "','"
                + p.xrayChestExam + "','" + p.opticalExamLeft + "','"
                + p.opticalExamRight + "','" + p.patientAge + "','"

                + p.patientFullname + "','" + p.xrayChestSummary + "','"
                + p.patientHeight + "','" + p.patientNumber + "','"
                + p.patientPulse + "','" + p.patientWeight + "','"
                + p.pid + "','" + p.sectionName + "','"
                + p.stoolExamAppearance + "','" + p.ChecklistId + "','"

                + p.stoolExamColor + "','" + p.stoolExamParasite + "','"
                + p.stoolExamRbc + "','" + p.stoolExamWbc + "','"
                + p.sugar + "','" + p.suggestExam + "','"
                + p.sugarDiagnosis + "','" + p.sugarSuggess + "','"
                + p.sugarSummary + "','"//+p.getCbcSummary+"','"

                + p.thyroidT3 + "','" + p.thyroidT4 + "','"
                + p.thyroidTsh + "','" + p.toxicologyBenzene + "','"
                + p.toxicologyLead + "','" + p.toxicologyMercury + "','"
                + p.toxicologyXylene + "','" + p.triglyceride + "','"
                + p.uricAcid + "','" + p.urineAppearance + "','"

                + p.urineBacteria + "','" + p.urineBlood + "','"
                + p.urineKetone + "','" + p.urineColor + "','"
                + p.urinePh + "','" + p.urineProtein + "','"
                + p.urineRbc + "','" + p.urineSpGr + "','"
                + p.urineSugar + "','" + p.urineWbc + "','"

                + p.lungFev1Meas + "','" + p.lungFev1Per + "','"
                + p.lungFev1Predic + "','" + p.lungFvcMeas + "','"
                + p.lungFvcPer + "','" + p.lungFvcPredic + "','"
                + p.lungPerFev1 + "','" + p.lungSuggess + "','"
                + p.lungSummary + "','" + p.urineSummary + "','"

                + p.cbcSummary + "','" + p.summaryPhysicalExam + "','"
                + p.vdrl + "','" + p.visitHn + "',"
                + p.rowNumber + ",'" + p.cbcMcv + "','"
                    + p.stickerQty + "','" + p.statusCbc + "','"
                    + p.statusFbs + "','" + p.statusUa + "','"
                    + p.statusPe + "','" + p.statusXray + "','"
                    + p.statusStool + "','" + p.stoolExamSummary + "','"
                    + p.cholesterolSuggess + "','" + p.cholesterolSummary + "','"
                    + p.cbcMch + "','" + p.cbcMchc + "','"
                    + p.hbsagSuggess + "','" + p.hbsagSummary + "','"
                    + p.statusCholes + "','" + p.StatusHbsag + "','"
                    + p.cbcRbc + "','" + p.Active + "','"
                    + p.eyeBio + "','" + p.amphetamineSuggess + "','"
                    + p.amphetamineSummary + "','" + p.antiHivSuggess + "','"
                    + p.antiHivSummary + "','" + p.statusAmphetamine + "','"
                    + p.statusAntiHiv + "','" + p.statusVisit + "') ";
            chk = conn.ExecuteNonQuery(sql);
    //            conn.close;
            } catch (Exception ex) {
                //Logger.getLogger(MarketingTCheckupDB.class.getName).log(Level.SEVERE, null, ex);
                //max = ex.getMessage;
            }
            return p.Id;
        }
        private String update(CustCheckUpPatient p)
        {
            String chk = "";
            return chk;
        }
        //ccp.InsertCustCheckUpPatient()
        //{

        //}
        ccp.InsertCustCheckUpPatient(CustCheckUpPatient p)
        {
            //CustCheckUpPatient item = new CustCheckUpPatient();
            String chk = "", id="";
            id = selectByPk1(p.Id);
            if (id == "")
            {
                p.Active = "1";
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
    }
}
