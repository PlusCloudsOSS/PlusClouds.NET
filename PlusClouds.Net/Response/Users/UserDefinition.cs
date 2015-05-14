namespace PlusClouds.Net.Response.Users
{
    public class UserDefinition
    {
        public string Id { get; set; }
        public bool Sys_user { get; set; }
        public string Account_type { get; set; }
        public bool Is_entrepreneur { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Full_name { get; set; }
        public string Email { get; set; }
        public bool Is_suspended { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zip_code { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public string Gender { get; set; }
        public Balance Balance { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Invitation_count { get; set; }
        public string Create_time { get; set; }
        public object Website { get; set; }
        public object Affiliation_code { get; set; }
        public Country Country { get; set; }
        public Company Company { get; set; }
        public bool Is_missing_contact_info { get; set; }
        public object Avatar { get; set; }
        public string Default_locale { get; set; }
    }
}