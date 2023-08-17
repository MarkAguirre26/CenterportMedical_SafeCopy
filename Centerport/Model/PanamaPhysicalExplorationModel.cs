using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Model
{
    class PanamaPhysicalExplorationModel
    {
        //

        public void Save(string Papin, string ResultMainUID, string Head, string Mouth, string Dental, string Ears, string Tympanic, string Eyes, string Pupils, string OfThalmoscopy, string EyeMovement, string Lungs, string Breast, string Heart, string Skin, string VaricoseVenis, string Vascular, string Abdomen, string Hernias, string Anus, string Gu, string Upper, string Spine, string Neurologic, string Psychiatric, string GeneralAppearance, string PhysicalExplorationComment1, string PhysicalExplorationComment2, string PhysicalExplorationComment3, string PhysicalExplorationComment4)
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Database.connectionString);
            db.PanamaPhysicalExplorationSave(Papin, ResultMainUID, Head, Mouth, Dental, Ears, Tympanic, Eyes, Pupils, OfThalmoscopy, EyeMovement, Lungs, Breast, Heart, Skin, VaricoseVenis, Vascular, Abdomen, Hernias, Anus, Gu, Upper, Spine, Neurologic, Psychiatric, GeneralAppearance, PhysicalExplorationComment1, PhysicalExplorationComment2, PhysicalExplorationComment3, PhysicalExplorationComment4);
          
        }


    }
}
