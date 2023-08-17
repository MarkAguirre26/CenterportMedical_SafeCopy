﻿using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Model
{
    class PanamaExamineeModel
    {


        public void Save(string Papin,
                         string ResultMainUID,
                         string HighBloodPressure,
                         string Eyeproblem,
                         string EarNoseThroat,
                         string HeartSurgery,
                         string Varicoseveins,
                         string AsthmaBronchitis,
                         string BloodDisorder,
                         string Diabetes,
                         string ThyroidProblem,
                         string DigestiveDisorders,
                         string KidneyDisorders,
                         string SkinProblem,
                         string Allergies,
                         string Epilipsy,
                         string SickleCell,
                         string Herinas,
                         string GenitalDisorders,
                         string Pregnancy,
                         string Sleepproblem,
                         string DoyouSmoke,
                         string Surgeries,
                         string Infectious,
                         string DizzinessFainting,
                         string Lossofconsciousness,
                         string PsychiatricProblem,
                         string Depression,
                         string Attemptedsuicide,
                         string Lossofmemory,
                         string BalanceProblems,
                         string SevereHeadAches,
                         string Vasculardisease,
                         string RestrictedMobility,
                         string BackJointProblem,
                         string Amputation,
                         string FracturesDislocation,
                         string Covid19,
                         string Repatriated,
                         string Hospitalized,
                         string SeaDuty,
                         string Revoke,
                         string ConsiderDisease,
                         string FitToPerformDuries,
                         string AllergicToAnyMedication,
                         string AlternativeSupliment,
                         string AlternativeSuplimentComment1,
                         string TakenMedications,
                         string TakenMedicationsComment1,
                         string Comment1,
                        string Comment2,
                        string Comment3,
                        string Comment4,
                        string Comment5,
            string AlternativeSuplimentComment2,
            string AlternativeSuplimentComment3,
            string AlternativeSuplimentComment4,
            string AlternativeSuplimentComment5,
            string TakenMedicationsComment2,
            string TakenMedicationsComment3,
            string TakenMedicationsComment4,
            string TakenMedicationsComment5,
            string AlternativeSuplimentComment6
                         )
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Database.connectionString);
            db.PanamaExamineeSave(Papin,
                ResultMainUID,
                HighBloodPressure,
                Eyeproblem,
                EarNoseThroat,
                HeartSurgery,
                Varicoseveins,
                AsthmaBronchitis,
                BloodDisorder,
                Diabetes,
                ThyroidProblem,
                DigestiveDisorders,
                KidneyDisorders,
                SkinProblem,
                Allergies,
                Epilipsy,
                SickleCell,
                Herinas,
                GenitalDisorders,
                Pregnancy,
                Sleepproblem,
                DoyouSmoke,
                Surgeries,
                Infectious,
                DizzinessFainting,
                Lossofconsciousness,
                PsychiatricProblem,
                Depression,
                Attemptedsuicide,
                Lossofmemory,
                BalanceProblems,
                SevereHeadAches,
                Vasculardisease,
                RestrictedMobility,
                BackJointProblem,
                Amputation,
                FracturesDislocation,
                Covid19, Repatriated,
                Hospitalized,
                SeaDuty,
                Revoke,
                ConsiderDisease,
                FitToPerformDuries,
                AllergicToAnyMedication,
                AlternativeSupliment,
                AlternativeSuplimentComment1,
                TakenMedications,
                TakenMedicationsComment1,
                Comment1,
                Comment2,
                Comment3,
                Comment4,
                Comment5,
                AlternativeSuplimentComment2,
                AlternativeSuplimentComment3,
                AlternativeSuplimentComment4,
                AlternativeSuplimentComment5,
                TakenMedicationsComment2,
                TakenMedicationsComment3,
                TakenMedicationsComment4,
                TakenMedicationsComment5,
                AlternativeSuplimentComment6);
        }


    }
}