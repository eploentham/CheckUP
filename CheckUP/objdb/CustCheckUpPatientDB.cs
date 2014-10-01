using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUP.objdb
{
    public class CustCheckUpPatientDB
    {
        public CustCheckUpPatient ccp;
        private String insert(CustCheckUpPatient p) {
        String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "po" + p.getGenID();
            }
            try {
    //            Connection conn = config1.getConnectionBangna();
    //            Statement st = conn.createStatement();
                //mkcup = getMarketingTCheckupPatientByPK(st,"", p.getMarketingCheckupPatientId(),"");
                p.departmentName=p.departmentName.Replace("'", "''");
                p.patientFullname = p.patientFullname.Replace("'", "''");
                p.sectionName = p.sectionName.Replace("'", "''");
                p.summaryPhysicalExam = p.summaryPhysicalExam.Replace("'", "''");
                p.xrayChestExam = p.getXrayChestExam.Replace("'", "''");
                p.XrayChestExam = (config1.StringNull(p.getXrayChestExam()).Replace("'", "''"));
                p.XrayChestExam = (config1.StringNull(p.getXrayChestExam()).Replace("'", "''"));
                if (mkcup.getMarketingCheckupPatientId().equals("")) {
                    max = getMaxRowMarketingTCheckupPatient(st);
                    sql = "Insert Into " + mkcup.getMarketingTCheckupPatient()+ "(" 
                        + mkcup.getFMarketingCheckupPatientId() + ", " + mkcup.getFAmphetamine() + ", "
                        + mkcup.getFAntiHiv() + "," + mkcup.getFAudiogramExam() + ","
                        + mkcup.getFAudiogram1000Left() + "," + mkcup.getFAudiogram1000Right() + ","
                        + mkcup.getFAudiogram2000Left() + "," + mkcup.getFAudiogram2000Right() + ","
                        + mkcup.getFAudiogram3000Left() + "," + mkcup.getFAudiogram3000Right() + ","

                        + mkcup.getFAudiogram4000Left() + "," + mkcup.getFAudiogram4000Right() + ","
                        + mkcup.getFAudiogram6000Left() + "," + mkcup.getFAudiogram6000Right() + ","
                        + mkcup.getFAudiogram8000Left() + "," + mkcup.getFAudiogram8000Right() + ","
                        + mkcup.getFAudiogram500Left() + "," + mkcup.getFAudiogram500Right() + ","
                        + mkcup.getFAudiogramSummaryLeft() + "," + mkcup.getFAudiogramSummaryRight() + ","

                        + mkcup.getFCa125() + "," + mkcup.getFCa153() + ","
                        + mkcup.getFCa199() + "," + mkcup.getFCaAfp() + ","
                        + mkcup.getFCaCea() + "," + mkcup.getFCaHcg() + ","
                        + mkcup.getFCalcium() + "," + mkcup.getFCaPsa() + ","
                        + mkcup.getFCbcBasophil() + "," + mkcup.getFCbcEosinophil() + ","

                        + mkcup.getFCbcHb() + "," + mkcup.getFCbcHct() + ","
                        + mkcup.getFCbcLymphocyte() + "," + mkcup.getFCbcMonocyte() + ","
                        + mkcup.getFCbcNeutrophil() + "," + mkcup.getFCbcPlateletCount() + ","
                        + mkcup.getFCbcRbcMorpholog() + "," + mkcup.getFCbcWbc() + ","
                        + mkcup.getFCholesterol() + "," + mkcup.getFDepartmentName() + ","

                        + mkcup.getFDisscusExam() + "," + mkcup.getFEkgExam() + ","
                        + mkcup.getFUrineEpithelium() + "," + mkcup.getFEyesExam() + ","
                        + mkcup.getFFPatientBloodGroupId() + "," + mkcup.getFFSexId() + ","
                        + mkcup.getFHbsab() + "," + mkcup.getFHbsag() + ","
                        + mkcup.getFHdl() + "," + mkcup.getFKidneyBun() + ","

                        + mkcup.getFKidneyCreatinine() + "," + mkcup.getFLdl() + ","
                        + mkcup.getFLiverAlp() + "," + mkcup.getFLiverSgot() + ","
                        + mkcup.getFLiverSgpt() + "," + mkcup.getFMarketingCheckupId() + ","
                        + mkcup.getFXrayChestExam() + "," + mkcup.getFOpticalExamLeft() + ","
                        + mkcup.getFOpticalExamRight() + "," + mkcup.getFPatientAge() + ","

                        + mkcup.getFPatientFullname() + "," + mkcup.getFXrayChestSummary()+","
                        + mkcup.getFPatientHeight() + "," + mkcup.getFPatientNumber() + ","
                        + mkcup.getFPatientPulse() + "," + mkcup.getFPatientWeight() + ","
                        + mkcup.getFPid() + "," + mkcup.getFSectionName() + ","
                        + mkcup.getFStoolExamAppearance() + ","+ mkcup.getFTChecklistId()+","

                        + mkcup.getFStoolExamColor() + "," + mkcup.getFStoolExamParasite() + ","
                        + mkcup.getFStoolExamRbc() + "," + mkcup.getFStoolExamWbc() + ","
                        + mkcup.getFSugar() + "," + mkcup.getFSuggestExam() + ","
                        + mkcup.getFSugarDiagnosis() + "," + mkcup.getFSugarSuggess() + ","
                        + mkcup.getFSugarSummary() + ","//+mkcup.getFCbcSummary()+","

                        + mkcup.getFThyroidT3()+ "," + mkcup.getFThyroidT4() + ","
                        + mkcup.getFThyroidTsh() + "," + mkcup.getFToxicologyBenzene() + ","
                        + mkcup.getFToxicologyLead() + "," + mkcup.getFToxicologyMercury() + ","
                        + mkcup.getFToxicologyXylene() + "," + mkcup.getFTriglyceride() + ","
                        + mkcup.getFUricAcid() + "," + mkcup.getFUrineAppearance() + ","

                        + mkcup.getFUrineBacteria() + "," + mkcup.getFUrineBlood() + ","
                        + mkcup.getFUrineKetone() + "," + mkcup.getFUrineColor() + ","
                        + mkcup.getFUrinePh() + "," + mkcup.getFUrineProtein() + ","
                        + mkcup.getFUrineRbc() + "," + mkcup.getFUrineSpGr() + ","
                        + mkcup.getFUrineSugar() + "," + mkcup.getFUrineWbc() + ","

                        + mkcup.getFLungFev1Meas() + "," + mkcup.getFLungFev1Per() + ","
                        + mkcup.getFLungFev1Predic() + "," + mkcup.getFLungFvcMeas() + ","
                        + mkcup.getFLungFvcPer() + "," + mkcup.getFLungFvcPredic() + ","
                        + mkcup.getFLungPerFev1() + "," + mkcup.getFLungSuggess() + ","
                        + mkcup.getFLungSummary() + "," +mkcup.getFUrineSummary()+","

                        + mkcup.getFCbcSummary() + "," +mkcup.getFSummaryPhysicalExam()+","
                        + mkcup.getFVdrl() + "," + mkcup.getFVisitHn() + ","
                        + mkcup.getFRowNumber()+","+mkcup.getFCbcMcv()+","
                            + mkcup.getFStickerQty()+","+mkcup.getFStatusCbc()+","
                            + mkcup.getFStatusFbs()+","+mkcup.getFStatusUa()+","
                            + mkcup.getFStatusPe()+","+mkcup.getFStatusXray()+","
                            + mkcup.getFStatusStool()+","+mkcup.getFStoolExamSummary()+","
                            + mkcup.getFCholesterolSuggess()+","+mkcup.getFCholesterolSummary()+","
                            + mkcup.getFCbcMch()+","+mkcup.getFCbcMchc()+","
                            + mkcup.getFHbsAgSuggess()+","+mkcup.getFHbsAgSummary()+","
                            + mkcup.getFStatusCholes()+","+mkcup.getFStatusHbsAg()+","
                            + mkcup.getFCbcRbc()+","+mkcup.getFMkcupActive()+","
                            + mkcup.getFEyeBio()+","+mkcup.getFAmphetamineSuggess()+","
                            + mkcup.getFAmphetamineSummary()+","+mkcup.getFAntiHivSuggess()+","
                            + mkcup.getFAntiHivSummary()+","+mkcup.getFStatusAmphetamine()+","
                            + mkcup.getFStatusAntiHiv()+","+mkcup.getFStatusVisit()+") "
                        + "Values('" + max + "','" + p.getAmphetamine() + "','"
                        + p.getAntiHiv() + "','" + p.getAudiogramExam() + "','"
                        + p.getAudiogram1000Left() + "','" + p.getAudiogram1000Right() + "','"
                        + p.getAudiogram2000Left() + "','" + p.getAudiogram2000Right() + "','"
                        + p.getAudiogram3000Left() + "','" + p.getAudiogram3000Right() + "','"

                        + p.getAudiogram4000Left() + "','" + p.getAudiogram4000Rightt() + "','"
                        + p.getAudiogram6000Left() + "','" + p.getAudiogram6000Right() + "','"
                        + p.getAudiogram8000Left() + "','" + p.getAudiogram8000Right() + "','"
                        + p.getAudiogram500Left() + "','" + p.getAudiogram500Right() + "','"
                        + p.getAudiogramSummaryLeft() + "','" + p.getAudiogramSummaryRight() + "','"

                        + p.getCa125() + "','" + p.getCa153() + "','"
                        + p.getCa199() + "','" + p.getCaAfp() + "','"
                        + p.getCaCea() + "','" + p.getCaHcg() + "','"
                        + p.getCalcium() + "','" + p.getCaPsa() + "','"
                        + p.getCbcBasophil() + "','" + p.getCbcEosinophil() + "','"

                        + p.getCbcHb() + "','" + p.getCbcHct() + "','"
                        + p.getCbcLymphocyte() + "','" + p.getCbcMonocyte() + "','"
                        + p.getCbcNeutrophil() + "','" + p.getCbcPlateletCount() + "','"
                        + p.getCbcRbcMorpholog() + "','" + p.getCbcWbc() + "','"
                        + p.getCholesterol() + "','" + p.getDepartmentName() + "','"

                        + p.getDisscusExam() + "','" + p.getEkgExam() + "','"
                        + p.getUrineEpithelium() + "','" + p.getEyesExam() + "','"
                        + p.getFPatientBloodGroupId() + "','" + p.getFSexId() + "','"
                        + p.getHbsab() + "','" + p.getHbsag() + "','"
                        + p.getHdl() + "','" + p.getKidneyBun() + "','"

                        + p.getKidneyCreatinine() + "','" + p.getLdl() + "','"
                        + p.getLiverAlp() + "','" + p.getLiverSgot() + "','"
                        + p.getLiverSgpt() + "','" + p.getMarketingCheckupId() + "','"
                        + p.getXrayChestExam() + "','" + p.getOpticalExamLeft() + "','"
                        + p.getOpticalExamRight() + "','" + p.getPatientAge() + "','"

                        + p.getPatientFullname() + "','" + p.getXrayChestSummary()+"','"
                        + p.getPatientHeight() + "','" + p.getPatientNumber() + "','"
                        + p.getPatientPulse() + "','" + p.getPatientWeight() + "','"
                        + p.getPid() + "','" + p.getSectionName() + "','"
                        + p.getStoolExamAppearance() + "','"+ p.getTChecklistId()+"','"

                        + p.getStoolExamColor() + "','" + p.getStoolExamParasite() + "','"
                        + p.getStoolExamRbc() + "','" + p.getStoolExamWbc() + "','"
                        + p.getSugar() + "','" + p.getSuggestExam() + "','"
                        + p.getSugarDiagnosis() + "','" + p.getSugarSuggess() + "','"
                        + p.getSugarSummary() + "','"//+p.getCbcSummary()+"','"

                        + p.getThyroidT3()+ "','" + p.getThyroidT4() + "','"
                        + p.getThyroidTsh() + "','" + p.getToxicologyBenzene() + "','"
                        + p.getToxicologyLead() + "','" + p.getToxicologyMercury() + "','"
                        + p.getToxicologyXylene() + "','" + p.getTriglyceride() + "','"
                        + p.getUricAcid() + "','" + p.getUrineAppearance() + "','"

                        + p.getUrineBacteria() + "','" + p.getUrineBlood() + "','"
                        + p.getUrineKetone() + "','" + p.getUrineColor() + "','"
                        + p.getUrinePh() + "','" + p.getUrineProtein() + "','"
                        + p.getUrineRbc() + "','" + p.getUrineSpGr() + "','"
                        + p.getUrineSugar() + "','" + p.getUrineWbc() + "','"

                        + p.getLungFev1Meas() + "','" + p.getLungFev1Per() + "','"
                        + p.getLungFev1Predic() + "','" + p.getLungFvcMeas() + "','"
                        + p.getLungFvcPer() + "','" + p.getLungFvcPredic() + "','"
                        + p.getLungPerFev1() + "','" + p.getLungSuggess() + "','"
                        + p.getLungSummary() + "','" +p.getUrineSummary()+"','"

                        + p.getCbcSummary() + "','" +p.getSummaryPhysicalExam()+"','"
                        + p.getVdrl() + "','" + p.getVisitHn() + "',"
                        + p.getRowNumber()+",'"+p.getCbcMcv()+"','"
                            + p.getStickerQty()+"','"+p.getStatusCbc()+"','"
                            + p.getStatusFbs()+"','"+p.getStatusUa()+"','"
                            + p.getStatusPe()+"','"+p.getStatusXray()+"','"
                            + p.getStatusStool()+"','"+p.getStoolExamSummary()+"','"
                            + p.getCholestorolSuggess()+"','"+p.getCholesterolSummary()+"','"
                            + p.getCbcMch()+"','"+p.getCbcMchc()+"','"
                            + p.getHbsAgSuggess()+"','"+p.getHbsAgSummary()+"','"
                            + p.getStatusCholes()+"','"+p.getStatusHbsAg()+"','"
                            + p.getCbcRbc()+"','"+p.getMkcupActive()+"','"
                            + p.getEyeBio()+"','"+p.getAmphetamineSuggess()+"','"
                            + p.getAmphetamineSummary()+"','"+p.getAntiHivSuggess()+"','"
                            + p.getAntiHivSummary()+"','"+p.getStatusAmphetamine()+"','"
                            + p.getStatusAntiHiv()+"','"+p.getStatusVisit()+"') ";
                }else{
                }
                chk = st.executeUpdate(sql);
    //            conn.close();
            } catch (Exception ex) {
                //Logger.getLogger(MarketingTCheckupDB.class.getName()).log(Level.SEVERE, null, ex);
                //max = ex.getMessage();
            }
            return max;
        }
    }
}
