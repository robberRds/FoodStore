using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Store_Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Порядок відображення для категорії має бути більшим за 0")]
        public int DisplayOrder { get; set; }
    }
}
