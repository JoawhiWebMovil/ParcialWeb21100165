using System;
using System.Collections.Generic;

namespace ParcialWeb21100165.Data;

public partial class Competency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Level { get; set; }
}
