using System.ComponentModel.DataAnnotations;

namespace RacersGroup.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string StateName { get; set; }
        public String StateCode { get; set; }
    }
}
