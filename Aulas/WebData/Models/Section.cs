using System;
using System.Collections.Generic;

namespace WebData.Models;

public partial class Section
{
    public int SectionId { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int BookId { get; set; }

    public virtual Book Book { get; set; } = null!;
}
