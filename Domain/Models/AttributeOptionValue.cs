using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AttributeOptionValue
{
    public int Id { get; set; }

    public int? OptionId { get; set; }

    public string? Value { get; set; }

    public virtual AttributeOption? Option { get; set; }
}
