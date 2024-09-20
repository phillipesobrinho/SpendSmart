using System.ComponentModel.DataAnnotations;

namespace SpendSmart.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public decimal Value { get; set; }

        [Required]//  faz com que tenha q existir um valor em value
        public string Description { get; set; }
    }
}
