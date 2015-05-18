using System;
using PlusClouds.Net.Attributes;

namespace PlusClouds.Net.Request.Users
{
    public partial class UserUpdateRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        [Name("birthdate")]
        public DateTime? BirthDate { get; set; }

        public string Gender { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Country { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
    }
}