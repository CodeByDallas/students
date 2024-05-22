using System.Formats.Tar;

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\t\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
Console.WriteLine("-------------------------");

// This code Imports students name and score then outputs average and student count
string fail = "F";
string merit = "merit";
string pass = "Pass";
string passA = "A*";

List<string> studentNames = new List<string>();
List<int> studentScores = new List<int>();
List<string> studentGrades = new List<string>();

int sum = 0;
int studentScore;

while (true)
{
    Console.WriteLine("Enter name (or 'exit' to finish):");
    string student = Console.ReadLine();
    if (student.ToLower() == "exit") 
    break;

    Console.WriteLine("Enter student score:");
    studentScore = Convert.ToInt32(Console.ReadLine());

    studentNames.Add(student);
    studentScores.Add(studentScore);

    string grade;
    if (studentScore > 15 && studentScore < 35 ) {
        grade = merit;
    }
    else if (studentScore > 35 && studentScore < 60 ) {
        grade = pass;
    }
    else if (studentScore > 60 && studentScore < 75 ) {
        grade = passA;
    }
    else if (studentScore < 10) 
    {
        grade = fail;
    }
    else 
    {
        grade = "No Grade";
    }
    studentGrades.Add(grade);
    sum += studentScore;  
}

int numberOfStudents = studentNames.Count;
int divideAverageScore = sum / numberOfStudents;

 Console.WriteLine("STUDENTS\t\tGRADES\n");
for (int i = 0; i < studentNames.Count; i++)
{
    Console.WriteLine($"{studentNames[i]}\t\t{studentGrades[i]}");
}

Console.WriteLine($"\nClass average score: {divideAverageScore}");
Console.WriteLine("---------------------------");


//This code counts correct answers and gives a score
Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
{
    { "What is the capital of France?", "Paris" },
    { "What is 2 + 2?", "4" },
    { "What is 3  3", "6" },
    { "What is 100 - 10", "90"},
    { "What do you call a baby cat", "Kitten"},
};

Random rand = new Random();
List<string> keys = new List<string>(questionsAndAnswers.Keys);

int score = 0;

for (int i = 0; i < questionsAndAnswers.Count; i++)
{
    string randomKey = keys[rand.Next(keys.Count)];
    string value = questionsAndAnswers[randomKey];

    Console.WriteLine(randomKey);
    string answer = Console.ReadLine();

    if (answer.ToLower() == value.ToLower())
    {
        score++;
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine($"Incorrect! The correct answer is {value}.");
    }

    keys.Remove(randomKey);
}

Console.WriteLine($"Your total score is: {score}");





