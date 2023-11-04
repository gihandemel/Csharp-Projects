// initialize variables - graded assignments 
int currentAssignments = 5;
decimal finalScore = 0.0m;
string grade = "";

// Declare an array of tuples to hold student name and their scores
var studentScores = new[]
{
    ("Sophia", new int[] { 90, 86, 87, 98, 100 }),
    ("Andrew", new int[] { 92, 89, 81, 96, 90 }),
    ("Emma", new int[] { 90, 85, 87, 98, 68 }),
    ("Logan", new int[] { 90, 95, 87, 88, 96 }),
    // Add more students as needed
};

//
Console.WriteLine("Student\t\tGrade\n");

// Run a loop over the tuples and get the student name and their corresponding scores
for (int i = 0; i < studentScores.Length; i++)
{
    var (name, scores) = studentScores[i];

    finalScore = (decimal)scores.Sum() / currentAssignments;

    if ((int)finalScore >= 97)
    {
        grade = "A+";
    }

    else if ((int)finalScore >= 93 && (int)finalScore <=96)
    {
        grade = "A";
    }

    else if ((int)finalScore >= 90 && (int)finalScore <=92)
    {
        grade = "A-";
    }

    else if ((int)finalScore >= 87 && (int)finalScore <=89)
    {
        grade = "B+";
    }

    else if ((int)finalScore >= 83 && (int)finalScore <=86)
    {
        grade = "B";
    }

    else if ((int)finalScore >= 80 && (int)finalScore <=82)
    {
        grade = "B-";
    }


    Console.WriteLine($"{name}:\t\t{finalScore}\t{grade}");
}