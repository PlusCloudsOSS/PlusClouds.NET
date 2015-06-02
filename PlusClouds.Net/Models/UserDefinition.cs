namespace PlusClouds.Net.Models
{
    public class UserDefinition
    {
        public string Id { get; set; }
        public bool SysUser { get; set; }
        public string AccountType { get; set; }
        public bool IsEntrepreneur { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsSuspended { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public string Gender { get; set; }
        public Balance Balance { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Invitation_count { get; set; }
        public string CreateTime { get; set; }
        public object Website { get; set; }
        public object AffiliationCode { get; set; }
        public Country Country { get; set; }
        public Company Company { get; set; }
        public bool IsMissingContactInfo { get; set; }
        public object Avatar { get; set; }
        public string DefaultLocale { get; set; }
    }
}