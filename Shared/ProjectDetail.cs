namespace Portfolio.Shared
{
    public class ProjectDetail
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ViewPath { get; set; }

        public ProjectDetail(string title, string description, string? viewPath = null)
        {
            Title = title;
            Description = description;
            ViewPath = viewPath;
        }
    }
}
