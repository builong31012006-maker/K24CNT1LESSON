using System;
using System.Collections.Generic;

namespace BVLONGLesson10.Models;

public partial class Bvlong
{
    public long Id { get; set; }

    public string BvlongUsername { get; set; } = null!;

    public string BvlongPassword { get; set; } = null!;

    public string? BvlongFullName { get; set; }

    public string? BvlongEmail { get; set; }

    public string? BvlongPhone { get; set; }

    public bool? BvlongStatus { get; set; }
}
