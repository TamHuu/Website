using System;
using System.Collections.Generic;

namespace Website.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int? CarId { get; set; }

    public int? Quantity { get; set; }

    public string? Location { get; set; }

    public virtual Car? Car { get; set; }
}
