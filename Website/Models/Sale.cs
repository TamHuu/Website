using System;
using System.Collections.Generic;

namespace Website.Models;

public partial class Sale
{
    public int SalesId { get; set; }

    public int? CarId { get; set; }

    public DateOnly? SaleDate { get; set; }

    public decimal? SalePrice { get; set; }

    public virtual Car? Car { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
