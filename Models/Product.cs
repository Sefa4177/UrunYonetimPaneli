using System.ComponentModel.DataAnnotations;

namespace FormUygulaması.Models
{
    public class Product
    {
        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Display(Name = "Ürün Adı")]
        public string? Name { get; set; }

        [Display(Name = "Ürün fiyatı")]
        public decimal Price { get; set; }

        [Display(Name = "Ürün Resmi")]
        public string? Image { get; set; }

        [Display(Name = "Ürün Stok Bilgisi")]
        public int Stock { get; set; }

        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
    }

}