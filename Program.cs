// See https://aka.ms/new-console-template for more information

//trabajo practico cañificaciones y promedios
//por consola
//escala de calificación
/* 97 - 100    A+
93 - 96     A
90 - 92     A-
87 - 89     B+
83 - 86     B */
/* 
Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A
*/
// initialize variables - graded assignments 

int currentAssignments = 5;//tareas =5
//             /////puntuaciones/////
//sophia
int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
//nicolas
int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
//zahirah
int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
//jeong
int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
///////////////////////////////////////////////
/* suma de la puntuacion de todas las tareas */
int sophiaSuma = sophia1+sophia2+sophia3+sophia4+sophia5;
int nicolasSuma = nicolas1+nicolas2+nicolas3+nicolas4+nicolas5;
int zahirahSuma= zahirah1+zahirah2+zahirah3+zahirah4+zahirah5;
int jeongSuma = jeong1+jeong2+jeong3+jeong4+jeong5;
/* promedio del resultado de la suma de la puntuacion de tareas,/ (dividido) las 5 tareas */
//suma de la puntuacion de todas las tareas en decimal
decimal sophiaScoreDecimal = (decimal) sophiaSuma / currentAssignments;
decimal nicolasScoreDecimal = (decimal) nicolasSuma / currentAssignments;
decimal zahirahScoreDecimal = (decimal) zahirahSuma / currentAssignments;
decimal jeongScoreDecimal = (decimal) jeongSuma / currentAssignments;

Console.WriteLine();
Console.WriteLine("*** *** *** ***Puntos total Tareas y Promedio *** *** *** *** ***");
Console.WriteLine($@"The Sophia  Total Asignments Points results is: {sophiaSuma}, and this promedy is: {sophiaScoreDecimal} " );
Console.WriteLine($@"Nicolas results is: {nicolasSuma}, and this promedy is: {nicolasScoreDecimal} "  );
Console.WriteLine($@"Zahirah results is: {zahirahSuma}, and this promedy is: {zahirahScoreDecimal} "  );
Console.WriteLine($@"Jeong results is: {jeongSuma}, and this promedy is: {jeongScoreDecimal} "+ "\n"  );

////tabla de notas segun promedio
Console.WriteLine("*** *** *** *** *** *** *** *** ***");
Console.WriteLine("Student\t\tGrade");
Console.WriteLine("Sophia:\t\t" + sophiaScoreDecimal + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScoreDecimal + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScoreDecimal + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScoreDecimal + "\tA");
// con condicionales

 /* if (sophiaScoreDecimal >= 97)
    {
    Console.WriteLine("Sophia:  " + sophiaScoreDecimal + "  A+");  
    } 
 if (sophiaScoreDecimal >= 93 && sophiaScoreDecimal <= 96  )
    {
    Console.WriteLine("Sophia:  " + sophiaScoreDecimal + "  A");
    }
 if (sophiaScoreDecimal <= 90 && sophiaScoreDecimal >= 92 )
    {
     Console.WriteLine("Sophia:  " + sophiaScoreDecimal + "  A-");
    }
 if (sophiaScoreDecimal <= 89 && sophiaScoreDecimal < 87  )
    {
     Console.WriteLine("Sophia:  " + sophiaScoreDecimal + "  B+");
    }
 if (sophiaScoreDecimal >= 83 && sophiaScoreDecimal <= 86  )
    {
     Console.WriteLine("Sophia:  " + sophiaScoreDecimal + "  B");
    } */

/////////////////GPA Final/////////////////////
//nombre estudiante "Sophia Johnson"
string studentName = "Sophia Johnson";
//cursos
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";
//notas de curso
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;
//grado equivalante a notas de curso 
int gradeA = 4;
int gradeB = 3;
/* int gradeC = 2;
int gradeD = 1;
int gradeF = 0 */;

// almacenarán valores numéricos para cada curso
int course1Grade = gradeA;//4
int course2Grade = gradeB;//3
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;//4

// inicilizamos  un acumulador totalCreditHours en 0
int totalCreditHours = 0;

// totalCreditHours suma las notas del curso // total de 17
totalCreditHours += course1Credit;//3
totalCreditHours += course2Credit;//3
totalCreditHours += course3Credit;//4
totalCreditHours += course4Credit;//4
totalCreditHours += course5Credit;//3

// inicilizamos  un acumulador totalGradePoints /* puntos de calificacion */
int totalGradePoints = 0;
//puntos de calificación obtenidos por curso = course1Credit * course1Grade obtenida
totalGradePoints += course1Credit * course1Grade;//3horas * 4 = 12
totalGradePoints += course2Credit * course2Grade;//3 * 3 = 9
totalGradePoints += course3Credit * course3Grade;//4 * 3 =12
totalGradePoints += course4Credit * course4Grade;//4 * 3 = 12
totalGradePoints += course5Credit * course5Grade;//3 * 4 = 12

//int totalGradePoints = 57;
decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;
Console.WriteLine($"Total de Puntos de Grado:{totalGradePoints} , Total Horas Extras {totalCreditHours}\n");//57/17

int leadingDigit = (int) gradePointAverage;
int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);

//Tabla final
Console.WriteLine("*** *** *** *** *** *** *** *** ***");
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");
//final GPA
Console.WriteLine($"\nFinal GPA:{leadingDigit}.{trailingDigits}");
// 3.3529411764705882352941176471

Console.WriteLine("*** *** *** *** *** *** *** ***");


///////////////////// Methods /////////////////////////

///// System.Console | WriteLine() and Write() method ////
//// System.Random / Next() method ////

/* Console.WriteLine();
Console.WriteLine("Methods");
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);
var roll4 = dice.Next(1,7);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
Console.WriteLine($"Fourth roll: {roll4}"); */

//// System Math  | Max() method  ////

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);