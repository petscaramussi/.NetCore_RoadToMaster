using ApiCrudUsingGeneric.IService;
using ApiCrudUsingGeneric.Models;

namespace ApiCrudUsingGeneric.Service
{
    public class StudentService : IGenericService<Student>
    {
        List<Student> _students = new List<Student>();

        public StudentService()
        {
            for (int i = 1; i <= 9; i++)
            {
                _students.Add(new Student
                {
                    StudentId = i,
                    Name = "Stu" + i,
                    Roll = "100" + 1,
                });
            }
        }
        public List<Student> Delete(int id)
        {
            _students.RemoveAll(x => x.StudentId == id);
            return _students;
        }

        public List<Student> getAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.Where(x => x.StudentId == id).SingleOrDefault();
        }

        public List<Student> Insert(Student item)
        {
            _students.Add(item);
            return _students;
        }
    }
}

