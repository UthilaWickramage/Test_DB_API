using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Model
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        public required string Restaurant_Name { get; set; }

        public TimeOnly Opening_Time { get; set; }
        public TimeOnly ClosingTime { get; set; }


        public List<Customer> Customers { get; set; }
        public List<Restaurant_Table> Restaurant_Tables { get; set; }
        public List<Reservation> Reservations { get; set; }

        public DateTime Created { get; set; }
    }
}
