using schoolDAL.Models;
using System.Runtime;
using System.Xml.Serialization;

[XmlRoot("Teachers")]
public class TeachersRoot
{
    [XmlElement("Teacher")]
    public List<TeacherXml> Teachers { get; set; }
}

public class TeacherXml
{
    [XmlAttribute("Id")]
    public int Id { get; set; }

    [XmlElement("Class")]
    public List<ClassXml> Classes { get; set; }
}

public class ClassXml
{
    [XmlAttribute("Name")]
    public string ClassName { get; set; }

    [XmlElement("Subject")]
    public List<SubjectXml> Subjects { get; set; }
}

public class SubjectXml
{
    [XmlAttribute("Name")]
    public string SubjectName { get; set; }
}


