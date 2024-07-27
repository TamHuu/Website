using System;
using System.Collections.Generic;

namespace Website.Models;

public partial class PurchaseOrder
{
    public int PurchaseOrdersId { get; set; }

    public int? SupplierId { get; set; }

    public int? CarId { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public virtual Supplier? Supplier { get; set; }
}
