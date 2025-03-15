namespace SpoonNScroll.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public List<string> Steps { get; set; } = new List<string>();
        public string Description { get; set; } = string.Empty;
        public string Servings { get; set; } = string.Empty;
        public List<string> Ingredients { get; set; } = new List<string>();
    }
}
