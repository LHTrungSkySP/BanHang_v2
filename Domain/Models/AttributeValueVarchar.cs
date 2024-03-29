using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AttributeValueVarchar
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public int? AttributeId { get; set; }

    public int? ProductId { get; set; }

    public string? LanguageId { get; set; }

    public virtual Attribute? Attribute { get; set; }

    public virtual Product? Product { get; set; }
}
