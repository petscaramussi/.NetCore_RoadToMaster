using ApiCrudUsingGeneric.IService;
using ApiCrudUsingGeneric.Models;

namespace ApiCrudUsingGeneric.Service
{
    public class TeacherService : IGenericService<Teacher>
    {
        List<Teacher> _teacher = new List<Teacher>();

        public TeacherService()
        {
            for (int i = 1; i <= 9; i++)
            {
                _teacher.Add(new Teacher
                {
                    TeacherId = i,
                    Name = "Teach" + i,
                    Subject = "Sub" + 1,
                });
            }
        }
        public List<Teacher> Delete(int id)
        {
            _teacher.RemoveAll(x => x.TeacherId == id);
            return _teacher;
        }

        public List<Teacher> getAll()
        {
            return _teacher;
        }

        public Teacher GetById(int id)
        {
            return _teacher.Where(x => x.TeacherId == id).SingleOrDefault();
        }

        public List<Teacher> Insert(Teacher item)
        {
            _teacher.Add(item);
            return _teacher;
        }
    }
}
