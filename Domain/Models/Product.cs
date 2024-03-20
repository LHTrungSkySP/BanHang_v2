using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Product : BaseModel
    {
        [Column(TypeName = "nvarchar(255)")]
        public string? Name { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? Description { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? Content { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? Sku { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column(TypeName = "float")]
        public float? DiscountPrice { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? ImageUrl { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? ImageList { get; set; }
        [Column(TypeName = "int")]
        public int? ViewCount { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? SeoAlias { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? SeoTitle { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? SeoKeyword { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? SeoDescription { get; set; }
        [Column(TypeName = "bit")]
        public bool? IsActive { get; set; }
        [Column(TypeName = "int")]
        public int? RateTotal { get; set; }
        [Column(TypeName = "int")]
        public int? RateCount { get; set; }
    }
}
