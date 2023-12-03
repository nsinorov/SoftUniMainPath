namespace Medicines.DataProcessor
{
    using Medicines.Data;
    using Medicines.DataProcessor.ExportDtos;
    using Medicines.Utilities;
    using Newtonsoft.Json;
    using System.Globalization;

    public class Serializer
    {
        // USING XML HELPER FOR 3RD PROBLEM, ALSO CREATING THE EXPORTDTOS CLASSES
        public static string ExportPatientsWithTheirMedicines(MedicinesContext context, string date)
        {
            XmlHelper xmlHelper = new XmlHelper();

             bool isDateValid= DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateAsDateTime);

            ExportPatientDto[] patients = context.Patients
                .Where(p => p.PatientsMedicines.Any(pm => pm.Medicine.ProductionDate > dateAsDateTime))
                .ToArray()
                .Select(p => new ExportPatientDto()
                {
                    Gender = p.Gender.ToString().ToLower(),
                    FullName = p.FullName,
                    AgeGroup = p.AgeGroup.ToString(),
                    Medicines = p.PatientsMedicines
                        .Where(p => p.Medicine.ProductionDate > dateAsDateTime)
                        .OrderByDescending(p => p.Medicine.ExpiryDate)
                        .ThenBy(p => p.Medicine.Price)
                        .Select(p => new ExportMedicineDto()
                        {
                            Category = p.Medicine.Category.ToString().ToLower(),
                            Name = p.Medicine.Name,
                            Price = p.Medicine.Price.ToString("F2"),
                            Producer = p.Medicine.Producer,
                            ExpiryDate = p.Medicine.ExpiryDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)


                        })
                        .ToArray()
                })
                .OrderByDescending(p => p.Medicines.Length)
                .ThenBy(p => p.FullName)
                .ToArray();

                
            return xmlHelper.Serialize(patients, "Patients");
        }

        public static string ExportMedicinesFromDesiredCategoryInNonStopPharmacies(MedicinesContext context, int medicineCategory)
        {
            var medicines = context.Medicines
                .Where(m => (int)m.Category == medicineCategory &&
                        m.Pharmacy.IsNonStop == true)
                .ToArray()
                .OrderBy(m => m.Price)
                .ThenBy(m => m.Name)
                .Select(m => new
                {
                    Name = m.Name,
                    Price = m.Price.ToString("F2"),
                    Pharmacy = new 
                    {
                        Name = m.Pharmacy.Name,
                        PhoneNumber = m.Pharmacy.PhoneNumber
                    }
                })              
                .ToArray(); 

           return JsonConvert.SerializeObject(medicines, Formatting.Indented);
        }
    }
}
