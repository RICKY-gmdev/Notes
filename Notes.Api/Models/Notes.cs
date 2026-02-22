using System.ComponentModel.DataAnnotations;

namespace Notes.Api.Models
{
    public class Note
    {
        [Key]
        public Guid Id {get; set;}
        [Required]
        public String Title {get; set;} = String.Empty;

        public String Content {get; set;} = String.Empty;

        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;

        public DateTime? UpdatedAt {get; set;}
    }
}
