using System;
using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Users
{
    public partial class UserUpdateRequest : AccessTokenizedRequest, IUserSessionRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [Name("birthdate")]
        public DateTime? BirthDate { get; set; }

        public string Gender { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public long Country { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }

        [Name("sid")]
        public string SessionId { get; set; }
    }
}