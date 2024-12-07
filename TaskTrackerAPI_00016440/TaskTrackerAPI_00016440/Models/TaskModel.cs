namespace TaskTrackerAPI_00016440.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public int UserId { get; set; }

        public UserModel User { get; set; }

    }
}
