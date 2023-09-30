


//static void CheckPowerOfTwo(int n)
//{
//    while (n % 2 == 0)
//    {
//        n = n / 2;
//    }

//    if (n == 1)
//    {
//        Console.WriteLine("Quvvetidir");
//    }
//    else
//    {
//        Console.WriteLine("Quvveti deil");
//    }
//}

//CheckPowerOfTwo(4);


//var result = Math.Pow(2, 2);

//var result = Math.Sqrt(1600);


//Console.WriteLine(result);





//static int SumNumber(int[] nums)
//{
//    return nums.Where(m=>m%2 == 1).Sum();
//}

//int[] nums = { 1, 3, 5, 7, 9 };

//Console.WriteLine(SumNumber(nums));


//static string OddOrEven(int a)
//{
//    return a % 2 == 0 ? "Odd" : "Even";
//}

//Console.WriteLine(OddOrEven(9));


//static double SumNumber(int[] numbers)
//{
//    int sum = numbers.Where(n=>n%2 == 0).Sum(n=>n);

//    return Math.Pow(sum,2);
//}



using ConsoleApp1;
using System.Diagnostics.CodeAnalysis;


//static void GetEmployeeAge(int age)
//{
//    Employee[] employees = GetEmployees();

//    Employee[] filteredEmployee = employees.Where(m=>m.age>age).ToArray();

//    foreach (var employee in filteredEmployee)
//    {
//        Console.WriteLine(employee.name+employee.surname);
//    }
//}

//GetEmployeeAge(20);

//static int CountOfEmployeeByAge(int startAge, int endAge)
//{
//    Employee[] employees = GetEmployees();

//    int count = 0;

//    Employee[] filteredEmployee = employees.Where(m => startAge < m.age && endAge > m.age).ToArray();

//    return filteredEmployee.Length;
//}

//Console.WriteLine(CountOfEmployeeByAge(25, 30));





//static void SumOfEmployeeAge()
//{
//    Employee[]  employees = GetEmployees();

//    int sum = employees.Sum(m => m.age);

//    Console.WriteLine(sum);
//}

//SumOfEmployeeAge();


//static int SumOfEmployeeAge()
//{
//    Employee[] employees = GetEmployees();

//    int sum = 0;


//    foreach ( var item in employees)
//    {
//        sum = sum + item.age;
//    }

//    return sum;

//}


//Console.WriteLine(SumOfEmployeeAge());






//static void GetEmployeesByFilteredEmail(string str)
//{
//    Employee[] employees = GetEmployees();

//    Employee[] filteredEmployees = employees.Where(m=>m.email.ToLower().StartsWith(str.ToLower())).ToArray();

//    foreach ( var  employee in filteredEmployees)
//    {
//        string result = employee.email ;

//        Console.WriteLine(result);

//    }


//}


//GetEmployeesByFilteredEmail("a");








//static Employee[] GetEmployees()
//{



//    Employee employee1 = new()
//    {
//        name = "Semed",
//        surname = "Huseynov",
//        address = "Ehmedli",
//        email = "semed@mail.ru",
//        age = 27
//    };

//    Employee employee2 = new()
//    {
//        name = "Azer",
//        surname = "Memmedov",
//        address = "Sebail",
//        email = "Azer@gmail.com",
//        age = 24

//    };

//    Employee employee3 = new()
//    {
//        name = "Ilham",
//        surname = "Abasli",
//        address = "Lokbatan",
//        email = "ilham@gmail.com",
//        age = 19
//    };


//    Employee[] employees = { employee1, employee2, employee3 };

//    return employees;

//}









//Animal animal = new()
//{
//    name = "Canavar"
//};



//Bird bird = new()
//{
//    name = "Papuqay"
//};


//Console.WriteLine(animal.name);


//Console.WriteLine(bird.name);


//Fish fish = new()
//{
//    HasCaviar = true
//};

//Console.WriteLine(fish.HasCaviar);


//Bird bird = new();

//bird.Sound();




//Factiral factiral = new();


//int sumFactorial = factiral.GetFactorial(4);

//Console.WriteLine(factiral.Calculate(2,3)+sumFactorial);

//Factiral factiral = new();


//int sumFactorial = factiral.GetFactorial(4);

//Console.WriteLine(factiral.Calculate(2,3)+sumFactorial);



