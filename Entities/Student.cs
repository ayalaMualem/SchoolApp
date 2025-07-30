using System;
using System.Collections.Generic;

namespace Entities;

public partial class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? HomePhone { get; set; }

    public int? BirthdayYear { get; set; }

    public string? Class { get; set; }

    public string? Address { get; set; }
}
