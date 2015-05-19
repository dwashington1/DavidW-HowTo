using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication1.Models
{
    public class HomeIndex
    {
        public int id { get; set; }
        public string TableName { get; set; }
        public int Step { get; set; }
        public string Description { get; set; }
    }
}