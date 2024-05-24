using SchullerCo.Collab.Dash.Models.CustomIcons;

namespace SchullerCo.Collab.Dash.Models
{
    public class PaperItem
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public string? PageUrl { get; set; }
        public string? BackgroundColor { get; set; }
        public string? HoverColor { get; set; } 
        public List<PaperSvg>? PaperSvgs { get; set; }
    }
}