﻿using System;
using System.Collections.Generic;

namespace Entities;

public partial class Teacher
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Phone { get; set; }

    public string? MailAddress { get; set; }
}
