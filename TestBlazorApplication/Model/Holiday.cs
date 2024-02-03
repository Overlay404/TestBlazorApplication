using System.Collections;

namespace TestBlazorApplication.Model
{
    public class Holiday
    {
        public string? Name { get; set; }
        public string? CountryCode { get; set; }
        public string? LocalName { get; set;}
        public DateTime Date { get; set;}
        public bool Fixed {  get; set;}
        public bool Global { get; set;}
        public string? LaunchYear { get; set;}
        public List<string>? Types { get; set;}
    }
}
