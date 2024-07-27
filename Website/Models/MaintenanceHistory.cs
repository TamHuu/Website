using System;
using System.Collections.Generic;

namespace Website.Models;

public partial class MaintenanceHistory
{
    public int MaintenanceId { get; set; }

    public int? CarId { get; set; }

    public int? ServiceId { get; set; }

    public DateOnly? MaintenanceDate { get; set; }

    public string? Details { get; set; }

    public virtual Car? Car { get; set; }
}
