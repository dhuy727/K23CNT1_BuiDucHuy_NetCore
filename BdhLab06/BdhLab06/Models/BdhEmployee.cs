using System.ComponentModel.DataAnnotations;

namespace BdhLab06.Models
{
    public class BdhEmployee
    {
        [Key]
        public uint BdhId { get; set; }

        [Required]
        public string BdhName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BdhBirthDay { get; set; }

        [EmailAddress]
        public string BdhEmail { get; set; }

        [Phone]
        public string BdhPhone { get; set; }

        public decimal BdhSalary { get; set; }

        public bool BdhStatus { get; set; }
    }
}
