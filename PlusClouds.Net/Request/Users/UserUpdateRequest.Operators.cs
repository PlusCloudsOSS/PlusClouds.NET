using System;
using PlusCloudsNet.Models;

namespace PlusCloudsNet.Request.Users
{
    public partial class UserUpdateRequest
    {
        public static implicit operator UserUpdateRequest(UserDefinition user)
        {
            DateTime birthDate;

            return new UserUpdateRequest
            {
                Name = user.Name,
                Surname = user.Surname,
                BirthDate = DateTime.TryParse(user.Birthdate, out birthDate) ? (DateTime?) birthDate : null,
                Gender = user.Gender,
                Address = user.Address,
                Address2 = user.Address2,
                Country = user.Country.Id,
                City = user.City,
                ZipCode = user.ZipCode,
                Phone = user.Phone,
                CellPhone = user.Cellphone,
                Twitter = user.Twitter,
                Facebook = user.Facebook,
                Linkedin = user.Linkedin
            };
        }
    }
}