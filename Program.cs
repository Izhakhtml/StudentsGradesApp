using StudentsGradesApp;

List<string> stringList = new List<string>();
List<Lecturer> studentList = new List<Lecturer>();

///  print name and array grades \\

void printNameAndGarrdes(List<Lecturer> list)
{
    Console.WriteLine($"name student:{list[0].studentName} array grades:{list[0].grades}");
}
void printFromFile(string name)
{
    FileStream fs = new FileStream(@$"C:\lecturer\{name}.txt", FileMode.Open);
    using(StreamReader reader = new StreamReader(fs))
    {
        string part = reader.ReadLine();
        int x = part.IndexOf("NAME");
        int y = part.IndexOf("");
        Console.WriteLine(part.Substring(x,y));
    }
}
printFromFile(Console.ReadLine());
//printFromFile();
///  create file \\\

void CreateFile(string name, Lecturer studentObject, int id)
{
    FileStream fs = new FileStream(@$"C:\lecturer\{name}.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(fs))
    {
        writer.Write($" ID:{id} NAME:{studentObject.studentName} TAZ:{studentObject.taz} GRADES:{studentObject.grades[0]} {studentObject.grades[1]} {studentObject.grades[2]},\n");
        //stringList.Add($"ID:{id}" +
        //            $"NAME:{studentObject.studentName} " +
        //            $"TAZ:{studentObject.taz} " +
        //            $"GRADES:{studentObject.grades[0]} {studentObject.grades[1]} {studentObject.grades[2]},\n");
    }
}

/// read file \\\

void readFromFile(string name)
{
    FileStream fs = new FileStream(@$"C:\lecturer\{name}.txt",FileMode.Open);
    using(StreamReader reader = new StreamReader(fs))
    {
        int x = 0;
        while (x < reader.Peek())
        {
            stringList.Add(reader.ReadLine());
            x++;
        }
        stringList.Add(reader.ReadToEnd());

    }

}

/// create new instance \\\

 void createInstance(string name,int num)
{
   
    int i = 0;
    while (i < num)
    {
        Lecturer student = new Lecturer();
        student.lecturerName = name;
        Console.WriteLine("The name of student?");
        student.studentName = Console.ReadLine();
        Console.WriteLine("The taz of student?");
        student.taz = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3 grades?");
        student.grades = new int[]{int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())};
        studentList.Add(student);
        CreateFile(name,student,i);
        readFromFile(name);
        //if (studentList.Count<3) { TheMainFunction();  }
        i++;
    }

}

///  the main function \\\

 void TheMainFunction()
{
    try {
        Console.WriteLine("To create studnt propile tap 1");
        Console.WriteLine("To show first studnt propile tap 2");
        int user = int.Parse(Console.ReadLine());
        string userName;
        switch (user)
        {
            case 1:
                    Console.WriteLine("The name's lecturer?");
                    userName = Console.ReadLine();
                    Console.WriteLine("How mach students enter to system?");
                    int userNum = int.Parse(Console.ReadLine());
                    createInstance(userName, userNum);
                break;
            case 2:
                //printNameAndGarrdes(studentList);
                //printFromFile(userName);
                break;
            default:
                break;
        }
        }catch (FormatException ex) { Console.WriteLine(ex.Message); TheMainFunction(); }
         catch (Exception ex) { Console.WriteLine(ex.Message); }
}

//TheMainFunction();
