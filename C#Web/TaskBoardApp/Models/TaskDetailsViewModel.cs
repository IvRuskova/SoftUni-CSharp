using TaskBoardApp.Views;

namespace TaskBoardApp.Models
{
    public class TaskDetailsViewModel : TaskViewModel
    {
        public string CreatedOn { get; set; } = string.Empty;
        public string Board { get; set; } = string.Empty ;
        public object BoardId { get; internal set; }
        public IEnumerable<TaskBoardViewModel> Boards { get; internal set; }
    }
}
