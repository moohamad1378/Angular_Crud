using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Angular_Crud.Models
{
    public class PaymentDetail
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public string CardOwnerName { get; set; } = "";
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; } = "";
        [Column(TypeName = "nvarchar(5)")]
        public string ExperiationDate { get; set; } = "";
        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; } = "";
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
    
}
