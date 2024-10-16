using System;
using System.Collections.Generic;

namespace ParcialWeb21100165.Data;

public partial class JobOffer
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Salary { get; set; } = null!;

    public string Location { get; set; } = null!;
}
