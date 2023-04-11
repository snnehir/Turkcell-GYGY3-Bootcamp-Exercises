public class TeacherService : ITeacherService
{
    List<Teacher> teachers;
    public TeacherService(List<Teacher> teachers)
    {
        this.teachers = teachers;
    }
    public TeacherService()
    {
        teachers = new();
    }
    public void Add(Teacher entity)
    {
        teachers.Add(entity);
    }
    public Teacher? GetById(int Id)
    {
        return teachers.FirstOrDefault(x => x.Id == Id);
    }

    public List<Teacher> GetAll() => teachers;

    public void Remove(int Id)
    {
        Teacher? teacher = GetById(Id);
        if (teacher == null)
            throw new Exception("Teacher not found.");
        else
        {
            teachers.Remove(teacher);
        }
    }

    public void Update(Teacher entity)
    {
        Teacher? teacher = GetById(entity.Id);
        if (teacher == null)
            throw new Exception("Student not found.");
        else
        {
            int index = teachers.IndexOf(teacher);
            teachers[index] = entity;
        }
    }

    public List<Teacher> GetTeachersByFullName(string firstName, string lastName) => teachers.Where(t => t.FirstName == firstName && t.LastName == lastName).ToList();

}