using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Model
{
    public class Restaurant_Table
    {
        [Key]
        public int Id { get; set; }

        public required string Table_Name { get; set; }

        [AllowNull]
        public string Table_Description { get; set; }

        public required int No_Of_Seats { get; set; }

        public string Status { get; set; }


        public List<Reservation> Reservations { get; set; }
        public DateTime Created { get; set; }
    }
}
