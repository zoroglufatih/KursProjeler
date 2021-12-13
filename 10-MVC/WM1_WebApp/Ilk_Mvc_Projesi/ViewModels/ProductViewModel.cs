using System.ComponentModel.DataAnnotations;

namespace Ilk_Mvc_Projesi.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Ürün Adı alanı gereklidir.")]
        [StringLength(40, ErrorMessage = "Ürün Adı alanı en fazla 40 karakter olabilir.")]
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }
        [Display(Name ="Kategori Numarası")]
        public int CategoryID { get; set; }
        [Display(Name = "Fiyat")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage ="Bu alan zorunludur")]
        [Display(Name = "Satışta mı?")]
        public bool Discontinued { get; set; }
    }
}
