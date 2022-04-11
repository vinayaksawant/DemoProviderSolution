using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEntityAndDTO
{
    public class PatientProviderClaim
    {
        [JsonProperty("BeneID")]
        public string BeneID { get; set; }

        [JsonProperty("ClaimID")]
        public string ClaimID { get; set; }

        [JsonProperty("ClaimStartDt")]
        public string ClaimStartDt { get; set; }

        [JsonProperty("ClaimEndDt")]
        public string ClaimEndDt { get; set; }

        [JsonProperty("Provider")]
        public string Provider { get; set; }

        [JsonProperty("InscClaimAmtReimbursed")]
        public string InscClaimAmtReimbursed { get; set; }
        
        [JsonProperty("AttendingPhysician")]
        public string AttendingPhysician { get; set; }
        
        [JsonProperty("OperatingPhysician")]
        public string OperatingPhysician { get; set; }

        [JsonProperty("OtherPhysician")]
        public string OtherPhysician { get; set; }

        [JsonProperty("AdmissionDt")]
        public string AdmissionDt { get; set; }

        [JsonProperty("ClmAdmitDiagnosisCode")]
        public string ClmAdmitDiagnosisCode { get; set; }

        [JsonProperty("DeductibleAmtPaid")]
        public string DeductibleAmtPaid { get; set; }

        [JsonProperty("DiagnosisGroupCode")]
        public string DiagnosisGroupCode { get; set; }

        [JsonProperty("ClmDiagnosisCode_1")]
        public string ClmDiagnosisCode_1 { get; set; }

        [JsonProperty("ClmDiagnosisCode_2")]
        public string ClmDiagnosisCode_2 { get; set; }

        [JsonProperty("ClmDiagnosisCode_3")]
        public string ClmDiagnosisCode_3 { get; set; }

        [JsonProperty("ClmDiagnosisCode_4")]
        public string ClmDiagnosisCode_4 { get; set; }

        [JsonProperty("ClmDiagnosisCode_5")]
        public string ClmDiagnosisCode_5 { get; set; }

        [JsonProperty("ClmDiagnosisCode_6")]
        public string ClmDiagnosisCode_6 { get; set; }

        [JsonProperty("ClmDiagnosisCode_7")]
        public string ClmDiagnosisCode_7 { get; set; }

        [JsonProperty("ClmDiagnosisCode_8")]
        public string ClmDiagnosisCode_8 { get; set; }

        [JsonProperty("ClmDiagnosisCode_9")]
        public string ClmDiagnosisCode_9 { get; set; }

        [JsonProperty("ClmDiagnosisCode_10")]
        public string ClmDiagnosisCode_10 { get; set; }

        [JsonProperty("ClmProcedureCode_1")]
        public string ClmProcedureCode_1 { get; set; }

        [JsonProperty("ClmProcedureCode_2")]
        public string ClmProcedureCode_2 { get; set; }

        [JsonProperty("ClmProcedureCode_3")]
        public string ClmProcedureCode_3 { get; set; }

        [JsonProperty("ClmProcedureCode_4")]
        public string ClmProcedureCode_4 { get; set; }

        [JsonProperty("ClmProcedureCode_5")]
        public string ClmProcedureCode_5 { get; set; }

        [JsonProperty("ClmProcedureCode_6")]
        public string ClmProcedureCode_6 { get; set; }


    }
}


