using System;
using System.Collections.Generic;

namespace Website.Models;

public partial class Invoice
{
    public int InvoicesId { get; set; }

    public int? SaleId { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Sale? Sale { get; set; }
}
