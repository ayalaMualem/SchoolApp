using Entities;
using schoolDAL.Models;
using schoolDAL1;
using System.Linq;

namespace schoolBL
{
    public class schoolBL
    {
        SchoolContext schoolContext;
        public List<Teacher> GetTeachers()
        {
            schoolContext = new SchoolContext();
            return schoolContext.Teachers.ToList();
        }
        public List<Student> GetStudents(string filter)
        {
            schoolContext = new SchoolContext();
            if (filter == "All")
                return schoolContext.Students.ToList();
            else
                return schoolContext.Students.Where(s => s.Class == filter).ToList();

        }

        public List<string> GetClasses()
        {
            schoolContext = new SchoolContext();
            return schoolContext.Students.Select(s => s.Class).Distinct().OrderBy(c => c).ToList();
        }

        public void FillTablesFromXml()
        {
            schoolContext = new SchoolContext();

            List<TeacherXml> tr1 = schoolDAL1.schoolDAL.readXML();
            List<TeacherOfSubjectInClass> tb = new List<TeacherOfSubjectInClass>();
            List<Subject> tb2 = new List<Subject>();
            int mone = schoolContext.Subjects
                .Select(s => s.Id)
                .AsEnumerable()
                .DefaultIfEmpty(0)
                .Max() + 1;
            foreach (TeacherXml tr in tr1)
            {
                foreach (ClassXml cls in tr.Classes)
                {
                    foreach (SubjectXml subj in cls.Subjects)
                    {
                        var subject = tb2.FirstOrDefault(s => s.SubjectName == subj.SubjectName);

                        if (subject == null)
                        {
                            subject = new Subject { Id = mone++,SubjectName = subj.SubjectName };
                            tb2.Add(subject);
                        }

                        TeacherOfSubjectInClass row = new TeacherOfSubjectInClass
                        {
                            IdTeacher = tr.Id,
                            Class = cls.ClassName,
                            IdSubject = tb2.FindIndex(x => x.SubjectName == subj.SubjectName)
                        };

                        tb.Add(row);
                    }
                }
            }
                schoolContext.TeacherOfSubjectInClasses.AddRange(tb);
                schoolContext.Subjects.AddRange(tb2);
                schoolContext.SaveChanges();
            
        }
    }

}


