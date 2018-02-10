using System;
using Concepts;
using doLittle.Commands;

namespace Domain
{
    public class AddDataCollector : ICommand
    {
        //TODO: Update these properties to reflect what is needed for event. Remove PhoneNumber
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Guid NationalSociety { get; set; }
        public Language PreferredLanguage { get; set; }
        public Location GpsLocation { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Email { get; set; }
    }
}