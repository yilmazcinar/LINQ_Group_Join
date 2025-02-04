
using LİNQ_GroupJoin_Practice;

List<Student> students = new List<Student>()
{
    new Student() { StudentId = 1, StudentName = "John", ClassId = 1 },
    new Student() { StudentId = 2, StudentName = "Moin", ClassId = 1 },
    new Student() { StudentId = 3, StudentName = "Bill", ClassId = 2 },
    new Student() { StudentId = 4, StudentName = "Ram", ClassId = 2 },
    new Student() { StudentId = 5, StudentName = "Ron", ClassId = 3 }
};

List<Class> classes = new List<Class>()
{
    new Class() { ClassId = 1, ClassName = "Math" },
    new Class() { ClassId = 2, ClassName = "Geography" },
    new Class() { ClassId = 3, ClassName = "History" }
};

var query = classes.GroupJoin(students, classes => classes.ClassId, students => students.ClassId, (classes, studentsGroup) => new
{
    Class = classes,
    Students = studentsGroup.ToList()
});

foreach (var item in query)
{
    Console.WriteLine($"\nClass => {item.Class.ClassName}\n");
    foreach (var item1 in item.Students)
    {
        Console.WriteLine($"Student: {item1.StudentName}");
    }
}