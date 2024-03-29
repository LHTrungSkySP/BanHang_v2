using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AttributeOption
{
    public int Id { get; set; }

    public int? AttributeId { get; set; }

    public int? SortOrder { get; set; }

    public virtual Attribute? Attribute { get; set; }

    public virtual ICollection<AttributeOptionValue> AttributeOptionValues { get; set; } = new List<AttributeOptionValue>();
}
