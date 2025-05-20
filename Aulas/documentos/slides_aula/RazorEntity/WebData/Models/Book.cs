using System;
using System.Collections.Generic;

namespace WebData.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public int AuthorId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
}
