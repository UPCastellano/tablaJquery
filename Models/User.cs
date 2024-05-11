using System.ComponentModel.DataAnnotations;

namespace tablaJquery.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string Contact { get; set; }

    }
}
