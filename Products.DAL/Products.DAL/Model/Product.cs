using System.ComponentModel.DataAnnotations;

namespace Products.DAL.Model
{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = " Поле должно быть установлено")]
        public string Name { get; set; }

        public double Quantity { get; set; }

        [Required(ErrorMessage = " Поле должно быть установлено")]
        public double Price { get; set; }

        public string Category { get; set; }
    }
}
