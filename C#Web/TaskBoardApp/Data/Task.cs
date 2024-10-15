using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskBoardApp.Data
{
    [Comment("Board Tasks")]
    public class Task
    {
        [Key]
        [Comment("Task identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.Task.TitleMaxLength)]
        [Comment("Task title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength (DataConstants.Task.DescriptionMaxLength)]
        [Comment("Task description")]
        public string Description { get; set; } = string.Empty;

        [Comment("Date of creation")]
        public DateTime? CreatedOn { get; set; }
        
        [Comment("Board identifier")]
        public int? BoardId { get; set; }

        [ForeignKey(nameof(BoardId))]
        public Board? Board { get; set; }

        [Required]
        public string OwnerId { get; set; } = string.Empty;

        [ForeignKey(nameof(OwnerId))]
        [Comment("Aplication user identifier")]
        public IdentityUser Owner { get; set; } = null!;
    }
}
