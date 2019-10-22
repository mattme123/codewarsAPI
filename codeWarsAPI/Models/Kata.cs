using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace codeWarsAPI.Models
{
    public class Kata
    {
        [Key]
        public int KataId { get; set; }
        [Required]
        public string KataName { get; set; }
        [Required]
        public string KataLink { get; set; }
        [DefaultValue(false)]
        public bool IsCompleted { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        public DateTime ProposedDate { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}