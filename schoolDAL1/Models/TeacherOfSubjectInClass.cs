using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace schoolDAL.Models;

public partial class TeacherOfSubjectInClass
{
    [Key]
    public int Id { get; set; }
    public int? IdTeacher { get; set; }

    public int? IdSubject { get; set; }

    public string? Class { get; set; }
}
