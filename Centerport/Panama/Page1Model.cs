using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Panama
{
    public class Page1Model
    {

        public string Fullname { get; set; }
        public string HomeAddress { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string Birthdate { get; set; }
        public string PassportSeamanBookNo { get; set; }
        public string RhTyping { get; set; }
        public string LookOutDuties { get; set; }
        public string EmergencyDuties { get; set; }
        public string TypeOfShip { get; set; }
        public string TradeArea { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string HighBloodPressure { get; set; }
        public string EyeProblem { get; set; }
        public string EarNoseThroat { get; set; }
        public string HeartSurgery { get; set; }
        public string VaricoseVeins { get; set; }
        public string AsthmaBronchitis { get; set; }
        public string BloodDisorder { get; set; }
        public string Diabetes { get; set; }
        public string ThyroidProblem { get; set; }
        public string DigestiveDisorders { get; set; }
        public string KidneyDisorders { get; set; }
        public string SkinProblem { get; set; }
        public string Allergies { get; set; }


        public string DoyouSmoke { get; set; }
        public string Surgeries { get; set; }
        public string Infectious { get; set; }
        public string DizzinessFainting { get; set; }
        public string Lossofconsciousness { get; set; }
        public string PsychiatricProblem { get; set; }
        public string Depression { get; set; }
        public string Attemptedsuicide { get; set; }
        public string Lossofmemory { get; set; }
        public string BalanceProblems { get; set; }
        public string SevereHeadAches { get; set; }
        public string Vasculardisease { get; set; }
        public string RestrictedMobility { get; set; }
        public string BackJointProblem { get; set; }



        public Page1Model(
       string fullName,
       string homeAddress,
       string department,
       string position,
       string gender,
       string birthdate,
       string passportSeamanBookNo,
       string rhTyping,
       string lookOutDuties,
       string emergencyDuties,
       string typeOfShip,
       string tradeArea,
       string day,
       string month,
       string year,
       string highBloodPressure,
       string eyeProblem,
       string earNoseThroat,
       string heartSurgery,
       string varicoseVeins,
       string asthmaBronchitis,
       string bloodDisorder,
       string diabetes,
       string thyroidProblem,
       string digestiveDisorders,
       string kidneyDisorders,
       string skinProblem,
       string allergies)
        {
            Fullname = fullName;
            HomeAddress = homeAddress;
            Department = department;
            Position = position;
            Gender = gender;
            Birthdate = birthdate;
            PassportSeamanBookNo = passportSeamanBookNo;
            RhTyping = rhTyping;
            LookOutDuties = lookOutDuties;
            EmergencyDuties = emergencyDuties;
            TypeOfShip = typeOfShip;
            TradeArea = tradeArea;
            Day = day;
            Month = month;
            Year = year;
            HighBloodPressure = highBloodPressure;
            EyeProblem = eyeProblem;
            EarNoseThroat = earNoseThroat;
            HeartSurgery = heartSurgery;
            VaricoseVeins = varicoseVeins;
            AsthmaBronchitis = asthmaBronchitis;
            BloodDisorder = bloodDisorder;
            Diabetes = diabetes;
            ThyroidProblem = thyroidProblem;
            DigestiveDisorders = digestiveDisorders;
            KidneyDisorders = kidneyDisorders;
            SkinProblem = skinProblem;
            Allergies = allergies;
            DoyouSmoke = DoyouSmoke;
            Surgeries = Surgeries;
            Infectious = Infectious;
            DizzinessFainting = DizzinessFainting;
            Lossofconsciousness = Lossofconsciousness;
            PsychiatricProblem = PsychiatricProblem;
            Depression = Depression;
            Attemptedsuicide = Attemptedsuicide;
            Lossofmemory = Lossofmemory;
            BalanceProblems = BalanceProblems;
            SevereHeadAches = SevereHeadAches;
            Vasculardisease = Vasculardisease;
            RestrictedMobility = RestrictedMobility;


        }

        public Page1Model()
        {

        }
    }


}


