using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ProductTranslation
{
    public int ProductId { get; set; }

    public string LanguageId { get; set; } = null!;

    public string? Content { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? SeoDescription { get; set; }

    public string? SeoAlias { get; set; }

    public string? SeoTitle { get; set; }

    public string? SeoKeyword { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
