using schoolDAL.Models;
using System.Xml.Serialization;

namespace schoolDAL1
{

    public class schoolDAL
    {
        public static List<TeacherXml> readXML()
        {
            TeachersRoot tr1 = new TeachersRoot();
            string path = "assignment.xml";
            XmlSerializer x = new XmlSerializer(typeof(TeachersRoot));
            StreamReader reader = new StreamReader(path);
            tr1 = (TeachersRoot)x.Deserialize(reader);
            return tr1.Teachers;

        }
    }
}
