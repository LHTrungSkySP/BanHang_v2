using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Language
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDefault { get; set; }

    public int? SortOrder { get; set; }

    public virtual ICollection<ProductTranslation> ProductTranslations { get; set; } = new List<ProductTranslation>();
}
