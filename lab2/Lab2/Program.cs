using Lab2;


// init
var stud = new Student("ivan");

var test = new Test("linal", questionCount: 10);
var exam = new  Exam("matanal", ticketCount: 5);
var finalExam = new FinalExam("Diplom",ticketCount:20 ,commission: ["teacher_good", "teacher_bad"]);

var archive = new InMemoryResultArchive();
var session = new Session(archive);

// Пример LSP --  все три как Испытание.
session.Add(test);
session.Add(exam);
session.Add(finalExam);


// Провести все экзамены, у всех разные реализации этого.
session.ConductAll(stud, [5,4,3]);

foreach (Result r in archive.FindByStudent(stud)){
    Console.WriteLine(r.ToString());
}

var stud2 = new Student("Sander");
session.ConductAll(stud2, [2,2,2]);


foreach (Result r in archive.FindByStudent(stud2)){
    Console.WriteLine(r.ToString());
}