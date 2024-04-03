using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Model
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public int Customer_Id { get; set; }


        public DateTime Reservation_Date_Time { get; set; }

        public DateTime Request_Date_Time { get; set; }

        public int No_Of_Adults { get; set; }

        public int No_Of_Toddlers { get; set; }

        public string Status { get; set; }

        public List<Restaurant_Table> Restaurant_Tables { get; set; }

        public DateTime Created { get; set; }
    }
}
