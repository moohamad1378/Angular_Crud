using System.ComponentModel.DataAnnotations;

namespace Angular_Crud.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PaymentDetail> PaymentDetails { get; set; }
        public int PaymentDetailsId { get; set; }
    }
}
