using System;
using System.Collections.Generic;

namespace Website.Models;

public partial class Payment
{
    public int PaymentsId { get; set; }

    public int? InvoiceId { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
