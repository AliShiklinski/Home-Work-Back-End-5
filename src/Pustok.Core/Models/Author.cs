﻿namespace Pustok.Core.Models;

public class Author : BaseEntity
{
    public string FullName { get; set; }

    public List<Book> Books { get; set; }
}
