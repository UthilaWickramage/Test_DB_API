using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Model
{
    public class TRSDBContext :DbContext
    {
        public TRSDBContext(DbContextOptions<TRSDBContext> options):base(options) { }

        public TRSDBContext()
        {
            
        }

        DbSet<Customer> Customers {  get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Restaurant> Restaurants { get; set; }
        DbSet<Restaurant_Table> Restaurants_Table { get; set; }
    }
}
