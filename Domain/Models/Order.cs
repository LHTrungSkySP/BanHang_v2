using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerAddress { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string CustomerPhone { get; set; } = null!;

    public string CustomerNote { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ObjectId { get; set; }

    public Guid? UpdatedBy { get; set; }

    public int Status { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
