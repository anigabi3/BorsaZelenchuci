using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace BorsaZaZelenchutsiSvejest.Data
{
    public class Client:IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime DateModified { get; set; } = DateTime.Now;
        public ICollection<Order> Orders { get; set; }

    }
}
