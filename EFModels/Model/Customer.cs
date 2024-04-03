using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public required string Customer_Name { get; set; }

        public required string Customer_Mobile_Phone { get; set; }

        public List<Reservation> Reservations { get; set; }

        public DateTime Created { get; set; }
    }
}
