using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace schoolDAL.Models;

public partial class Subject
{
    [Key]
    public int Id { get; set; }

    public string? SubjectName { get; set; }
}
