using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAccessCore.Models
{
    [Table("User")]
    class UserRto
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required] public string PhoneNumberPrefix { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required, MinLenght(7)]public string Password { get; set; }
        public string ImageName { get; set; }
    }
}
