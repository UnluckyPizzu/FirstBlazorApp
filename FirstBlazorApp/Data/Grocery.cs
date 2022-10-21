using System.ComponentModel.DataAnnotations;
namespace FirstBlazorApp.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be under 15 characters"]
        public string Name { get; set; }
        [Range(1,10000, ErrorMessage ="Less than 10000")]
        public float Price { get; set; }
    }
}
