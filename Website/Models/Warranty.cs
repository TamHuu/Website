using System;
using System.Collections.Generic;

namespace Website.Models;

public partial class Warranty
{
    public int WarrantyId { get; set; }

    public int? CarId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? CoverageDetails { get; set; }

    public virtual Car? Car { get; set; }
}
