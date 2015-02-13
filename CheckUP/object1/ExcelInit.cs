﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.object1
{
    public class ExcelInit:Persistent
    {
        public String Id = "", DepartmentName="";
        public String SfRow = "", SfStatusName = "", SfANo = "", SfAPrefix = "", SfAFirstName = "", SfALastName = "", SfAAge = "", SfBNo = "", SfBPrefix = "", SfBFullName = "", SfBAge = "";
        public String SfCNo = "", SfCFullName = "", SfCAge = "", Active="";
        
        public String PERow = "", PENo="", PEAge="", PEWeight="", PEHeight="", PEBMI="", PEVitalSign="", PEPulse="", PEResult="", PESummary="", PEBloodGroup="", PESheetname="";

        public String XrayRow = "", XrayNo = "", Xray = "", XraySummary = "", XraySheetname = "";

        public String CBCRow = "", CBCNo = "", CBCWBC = "", CBCRBC = "", CBCHb = "", CBCHct = "", CBCNeu = "", CBCLy = "", CBCMono = "", CBCEos = "", CBCBact = "", CBCPltC = "", CBCPltS = "", CBCRBCmono = "", CBCSummary = "", cbcPmn = "", CBCSheetname = "";

        public String FBSRow = "", FBSNo = "", FBS = "", FBSResult = "", FBSSummary = "", FBSSheetname = "";

        public String UARow = "", UANo = "", UAColor = "", UAAppe = "", UASugar = "", UASpgr = "", UApH = "", UAProtein = "", UAWBC = "", UARBC = "", UAEpi = "", UABact = "", UAResult = "", UASummary = "", UAGlu = "", UAKetone = "", UABlood = "", UASheetname = "";

        public String TriRow = "", TriNo = "", Triglyceride = "", TriResult = "", TriSummary = "", TriSheetname = "";

        public String ChoRow = "", ChoNo = "", Cholesteral = "", ChoResult = "", Chosummary = "", ChoLDL = "", ChoHDL = "", ChoSheetname = "";

        public String SgotRow = "", SgotNo = "", Sgot = "", Sgpt = "", SgotResult = "", SgptSummary = "", SgotALP = "", SgotSheetname = "", SgotAlkaline = "";

        public String BunRow = "", BunNo = "", Bun = "", BunCreatinine = "", BunResult = "", BunSummary = "", BunSheetname = "";

        public String UricRow = "", UricNo = "", UricAcid = "", UricResult = "", UricSummary = "", UricSheetname = "";

        public String Other1Row = "", Other1No = "", Other1HBsAg = "", Other1HBsAb = "", Other1AntiHIV = "", Other1VDRL = "", Other1Calcium = "", Other1Amphetamine = "", Other1Sheetname = "", Other1AntiHav = "", Other1Hbtyping="";
        public String CAAFP = "", CACEA = "", CAPSA = "", CAHCG = "", CA153 = "", CA125 = "", CA199 = "";

        public String LungRow = "", LungNo = "", LungFvcPredic = "", LungFvcMeas = "", LungFvcPer = "", LungFev1Predic = "", LungFev1Meas = "", LungFev1Per = "", LungPerFev1 = "", LungSummary = "", LungSheetname = "";

        public String AudiogramRow = "", AudiogramNo = "", AudiogramSheetname = "";
        public String Audiogram500L = "", Audiogram1000L = "", Audiogram2000L = "", Audiogram3000L = "", Audiogram4000L="",Audiogram6000L="", Audiogram8000L="", AudiogramSummaryL="";
        public String Audiogram500R = "", Audiogram1000R = "", Audiogram2000R = "", Audiogram3000R="", Audiogram4000R="", Audiogram6000R="", Audiogram8000R="", AudiogramSummaryR="", AudiogramExam="";

        public String EyeRow = "", EyeNo = "", EyeShortLongLeft = "", EyeShortLongRight = "", EyeSquintLeft = "", EyeSquintRight = "", EyeDegreeLeft = "", EyeDegreeRight = "", EyeOldLeft = "", EyeOldRight = "", EyeBlindness = "", EyeResult = "", EyeSummary = "", EyeExam = "", EyeSheetname = "";

        public String StoolExamRow = "", StoolExamNo = "", StoolExamColor = "", StoolExamAppearance = "", StoolExamWbc = "", StoolExamRbc = "", StoolExamParasite = "", StoolExamSummary = "", StoolExamCulture = "", StoolExamTyphoidO = "", StoolExamTyphoidH = "", StoolExamSheetname = "";

        public String ToxiRow = "", ToxiNo = "", ToxiLead = "", ToxiAluminium = "", ToxiCadmium = "", ToxiMercury = "", ToxiTin = "", ToxiCopper = "", ToxiManganese = "", ToxiZinc = "", ToxiAmmonia = "";
        public String ToxiHippuric = "", ToxiMethyl = "", ToxiAcetone = "", ToxiNickel = "", ToxiChromium = "", ToxiPhenol = "", ToxiKetone = "", ToxiBenzene = "", ToxiMandelic = "", ToxiMethanol = "";
        public String ToxiEthanol = "", ToxiIPA = "", ToxiArsenic = "", ToxiHexane = "", ToxiFomaldehyde = "", ToxiTrichloroethylene = "", ToxiAntimony = "", ToxiFluoride = "", ToxiSheetname = "";
        //public String xrayChestSummary="";

    }
}
