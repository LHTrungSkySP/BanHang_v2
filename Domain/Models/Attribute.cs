using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Attribute
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public int? SortOrder { get; set; }

    public string? BackendType { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<AttributeOption> AttributeOptions { get; set; } = new List<AttributeOption>();

    public virtual ICollection<AttributeValueDateTime> AttributeValueDateTimes { get; set; } = new List<AttributeValueDateTime>();

    public virtual ICollection<AttributeValueDecimal> AttributeValueDecimals { get; set; } = new List<AttributeValueDecimal>();

    public virtual ICollection<AttributeValueInt> AttributeValueInts { get; set; } = new List<AttributeValueInt>();

    public virtual ICollection<AttributeValueText> AttributeValueTexts { get; set; } = new List<AttributeValueText>();

    public virtual ICollection<AttributeValueVarchar> AttributeValueVarchars { get; set; } = new List<AttributeValueVarchar>();
}
