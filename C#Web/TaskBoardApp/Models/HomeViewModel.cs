namespace TaskBoardApp.Models
{
    public class HomeViewModel
    {
        public int AllTaskCount { get; init; }
        public List<HomeBoardModel> BoardsWithTasksCount { get; init; } = null!;
        public int UserTaskCount { get; set; }
    }
}
