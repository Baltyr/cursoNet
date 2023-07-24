using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cursodotnet.Models
{
    [Table("api", Schema = "ApiGateway")]
    public class EntityApi
    {
        [Key]
        public int api_id { get; set; }
        public string name { get; set; } = null!;
    }
}