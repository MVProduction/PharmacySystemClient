﻿using PharmacySystemDataAccess.Models.Prescription;

namespace PharmacySystemBusinessLogic.Perscription
{
    public class PrescriptionValidationStatus
    {
        public bool IsValid { get; set; }
        public PrescriptionEntity Prescription { get; set; }
    }
}
