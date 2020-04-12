using System.Collections.Generic;
using generatorID.Models;

namespace generatorID
{
    public class Database
    {
        
        private Database() {}
        public static Database shared = new Database();

        public List<Student> students
        {
            get
            {
                List<Student> students = new List<Student>();
                students.Add(new Student("Ashanti", "08-12-2000", "CSSE-1704K"));
                students.Add(new Student("Orson", "19-08-1999", "CSSE-1704K"));
                students.Add(new Student("Ernar", "08-12-1974", "CSSE-1701K"));
                students.Add(new Student("Mirzhan", "19-08-1998", "CSSE-1706K"));
                students.Add(new Student("Zhanbolat", "28-05-1999", "CSSE-1703K"));
                students.Add(new Student("Nurzhan", "19-08-1997", "CSSE-1703K"));
                students.Add(new Student("Ablay", "08-12-2000", "CSSE-1703K"));
                students.Add(new Student("Erzat", "19-08-2002", "CSSE-1905K"));
                students.Add(new Student("Erbolat", "08-12-2003", "CSSE-1905K"));
                students.Add(new Student("Sakura", "Konoha1999", "CSSE-1707K"));
                students.Add(new Student("Saske", "Konoha1999", "CSSE-1707K"));
                students.Add(new Student("Naruto", "Konoha1999", "CSSE-1707K"));
                return students;
            }
        }
    }
}