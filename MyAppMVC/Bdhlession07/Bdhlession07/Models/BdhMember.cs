using System.ComponentModel.DataAnnotations;

namespace Bdhlession07.Models
{
    public class BdhMember
    {
        public int bdhId { get; set; }

        public string bdhName { get; set; }
        public string bdhUserName { get; set; }

        public string bdhPassword { get; set; }

        public string bdhEmail { get; set; }

        public bool bdhStatus { get; set; }
    }
}
