using System;
using PlusClouds.Net.Models;

namespace PlusClouds.Net.Request.Users
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
                //TODO: City = user.City.Id,
                ZipCode = user.Zip_code,
                Phone = user.Phone,
                CellPhone = user.Cellphone,
                Twitter = user.Twitter,
                Facebook = user.Facebook,
                Linkedin = user.Linkedin
            };
        }
    }
}