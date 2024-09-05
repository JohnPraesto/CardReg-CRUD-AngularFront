using System.ComponentModel.DataAnnotations;

namespace CardReg_CRUD_AngularFront.Models
{
    public class Card
    {
        [Key]
        public Guid Id { get; set; }
        public string HolderName { get; set; }
        public string CardNumber { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public int CVC { get; set; }
    }
}
