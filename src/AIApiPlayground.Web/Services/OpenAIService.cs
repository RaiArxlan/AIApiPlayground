using AIApiPlayground.Web.Contracts;
using AIApiPlayground.Web.Models;
using System.Text.Json.Nodes;

namespace AIApiPlayground.Web.Services
{
    public class OpenAIService : IAttributeService
    {
        public Task<IEnumerable<Attribute>> GetAttributesAsync(string categoryName)
        {
            
        }
    }
}
