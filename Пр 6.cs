using System;

namespace UniversityList

{

class Program

{

const string UkrUniv1 = "University 1 (Ukraine)";

const string UkrUniv2 = "University 2 (Ukraine)";

const string UkrUniv3 = "University 3 (Ukraine)";

const string UkrUniv4 = "University 4 (Ukraine)";

const string UsaUniv1 = "University 1 (USA)";

const string UsaUniv2 = "University 2 (USA)";

const string UsaUniv3 = "University 3 (USA)";

const string UsaUniv4 = "University 4 (USA)";

static void Main(string[] args)

{

string[] ukrainianUniversities = { UkrUniv1, UkrUniv2, UkrUniv3, UkrUniv4 };

string[] usaUniversities = { UsaUniv1, UsaUniv2, UsaUniv3, UsaUniv4 };

Console.WriteLine("Choose a country (1 - Ukraine, 2 - USA):");

int choice = Convert.ToInt32(Console.ReadLine());

string[] universities;

string country;

if (choice == 1)

{

universities = ukrainianUniversities;

country = "Ukraine";

}

else

{

universities = usaUniversities;

country = "USA";

}

Console.WriteLine($"You have chosen {country}. Enter the numbers of universities, separated by commas:");

string input = Console.ReadLine();

string[] numbers = input.Split(',');

Console.WriteLine($"List of universities in {country}:");

foreach (var number in numbers)

{

int universityNumber;

if (int.TryParse(number, out universityNumber) && universityNumber >= 1 && universityNumber <= universities.Length)

{

Console.WriteLine($"{universityNumber} - {universities[universityNumber - 1]}");

}

else

{

Console.WriteLine($"Invalid university number: {number}");

}

}

Console.WriteLine("Program author: [Tkachenko Vladyslav]");

Console.ReadLine();

}

}

}