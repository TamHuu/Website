using System;
using System.Collections.Generic;

namespace Website.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int? CarId { get; set; }

    public int? CustomerId { get; set; }

    public int? Rating { get; set; }

    public string? Comment { get; set; }

    public DateOnly? ReviewDate { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Customer? Customer { get; set; }
}
