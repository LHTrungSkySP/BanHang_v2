using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public double Price { get; set; }

    public double? DiscountPrice { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? ImageList { get; set; }

    public int? ViewCount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public bool IsActive { get; set; }

    public int? RateTotal { get; set; }

    public int? RateCount { get; set; }

    public Guid? ObjectId { get; set; }

    public virtual ICollection<AttributeValueDateTime> AttributeValueDateTimes { get; set; } = new List<AttributeValueDateTime>();

    public virtual ICollection<AttributeValueDecimal> AttributeValueDecimals { get; set; } = new List<AttributeValueDecimal>();

    public virtual ICollection<AttributeValueInt> AttributeValueInts { get; set; } = new List<AttributeValueInt>();

    public virtual ICollection<AttributeValueText> AttributeValueTexts { get; set; } = new List<AttributeValueText>();

    public virtual ICollection<AttributeValueVarchar> AttributeValueVarchars { get; set; } = new List<AttributeValueVarchar>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ProductTranslation> ProductTranslations { get; set; } = new List<ProductTranslation>();

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
