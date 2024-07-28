using System.Text.Json.Serialization;

namespace AIApiPlayground.Web.Models
{
    public class Category
    {
        [JsonPropertyName("categoryName")]
        public string CategoryName { get; set; } = string.Empty;

        [JsonPropertyName("subCategories")]
        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}
