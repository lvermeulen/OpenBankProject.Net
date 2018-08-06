using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Customer
{
    public class Customer
    {
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }
        [JsonProperty("customer_number")]
        public string CustomerNumber { get; set; }
        [JsonProperty("legal_name")]
        public string LegalName { get; set; }
        [JsonProperty("mobile_phone_number")]
        public string MobilePhoneNumber { get; set; }
        public string Email { get; set; }
        [JsonProperty("face_image")]
        public ImageInformation FaceImage { get; set; }
        [JsonProperty("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }
        [JsonProperty("relationship_status")]
        public string RelationshipStatus { get; set; }
        public int Dependants { get; set; }
        [JsonProperty("dob_of_dependants")]
        public List<DateTime> DobOfDependants { get; set; }
        [JsonProperty("credit_rating")]
        public CreditRating CreditRating { get; set; }
        [JsonProperty("credit_limit")]
        public CurrencyAmount CreditLimit { get; set; }
        [JsonProperty("highest_education_attained")]
        public string HighestEducationAttained { get; set; }
        [JsonProperty("employment_status")]
        public string EmploymentStatus { get; set; }
        [JsonProperty("kyc_status")]
        public bool KycStatus { get; set; }
        [JsonProperty("last_ok_date")]
        public DateTime? LastOkDate { get; set; }
    }
}
