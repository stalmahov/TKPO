using Lab1;

IArchive archive = new InMemoryArchive();

Teacher teacher = new("Василий");
Teacher teacher2 = new("Джабраил");

Course course = new("Мобильная Разработка", teacher);
Course course2 = new("ИКТ", teacher2);

Student student = new("Иван");
Student student2 = new("Сандер");

Console.WriteLine("перед: " + course);
Console.WriteLine("       "+ course2);
Console.WriteLine();


teacher.announceEnrollment(course);
teacher2.announceEnrollment(course2);

Enrollment enrollment = student.enroll(course);
Enrollment enrollment2 = student2.enroll(course2);

course.addEnrollment(enrollment);
course2.addEnrollment(enrollment2);

Grade grade = teacher.gradeStudent(enrollment, 5);
Grade grade2 = teacher2.gradeStudent(enrollment2, 2);

archive.save(grade);
archive.save(grade2);


Console.WriteLine("после: " + course);
Console.WriteLine("       "+ course2);
Console.WriteLine();
Console.WriteLine(archive);
Console.WriteLine();
Console.WriteLine("Оценки Ивана: " + string.Join("; ", archive.findByStudent(student)));
