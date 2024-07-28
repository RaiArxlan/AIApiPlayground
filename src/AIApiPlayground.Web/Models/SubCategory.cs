using System.Text.Json.Serialization;

namespace AIApiPlayground.Web.Models
{
    public class SubCategory
    {
        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonPropertyName("categoryName")]
        public string CategoryName { get; set; } = string.Empty;
    }
}
