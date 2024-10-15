using System.ComponentModel.DataAnnotations;
using TaskBoardApp.Data;
using TaskBoardApp.Views;
using Task = TaskBoardApp.Data.Task;

namespace TaskBoardApp.Models
{
    public class BoardViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.Board.NameMaxLength, MinimumLength = DataConstants.Board.NameMaxLength)]
        public string Name { get; set; }=string.Empty;
        public IEnumerable<TaskViewModel> Tasks { get; set; }=new List<TaskViewModel>();
    }
}
