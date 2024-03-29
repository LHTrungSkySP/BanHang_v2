using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? SeoAlias { get; set; }

    public string? SeoTitle { get; set; }

    public string? SeoKeyword { get; set; }

    public string? SeoDescription { get; set; }

    public int? ParentId { get; set; }

    public int SortOrder { get; set; }

    public Guid? ObjectId { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
