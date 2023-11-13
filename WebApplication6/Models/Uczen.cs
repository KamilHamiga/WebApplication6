using Microsoft.AspNetCore.Identity;

namespace WebApplication6.Models
{
    public class Uczen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Ulica { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }

        public string UczenUserId { get; set; }

        public IdentityUser? UczenUser { get; set; }
    }
}
