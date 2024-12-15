using Microsoft.EntityFrameworkCore;

namespace Angular_Crud.Models
{
    public class PeymantDetailContext:DbContext
    {
        public PeymantDetailContext(DbContextOptions optionss):base(optionss)
        {
            
        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<Department> Departments{ get; set; }
    }
}
