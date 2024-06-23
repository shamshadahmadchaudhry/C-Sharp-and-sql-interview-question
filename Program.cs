#region namespace
// A namespace is a way to organize our code elements such as classes,interface,structs,enum and delegates into a
// a hirerchical formats.
// The biggest advantage of using namespace we can create class with the same name into different namesapce it will not clash
// we can make nested namspace in a single solution.
//using System;
//using TestConsoleApp1.TestNameSpace;
//namespace TestConsoleApp
//{ 
//        public class Program
//        { 
//            static void Main(string[] args)
//            {
//                TestConsoleApp1.TestNameSpace.Program testApp = new TestConsoleApp1.TestNameSpace.Program();
//                Console.WriteLine("Enter name");
//                string name = Console.ReadLine();
//                Console.WriteLine("Enter Age");
//                int age = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Hi, Your Name is:" + name + " and Your Age is " + age);
//                Console.WriteLine("Hi, Your Name is: {0} and your age is {1}", name, age); //instead of concatenating string we can use this method also in order to add variable
//            }
//        } 
//}
//namespace TestConsoleApp1
//{
//    namespace TestNameSpace
//    {
//        public class Program
//        {
//            public Program()
//            {
//                Console.WriteLine("Enter name");
//                string name = Console.ReadLine();
//                Console.WriteLine("Enter Age");
//                int age = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Hi, Your Name is:" + name + " and Your Age is " + age);
//                Console.WriteLine("Hi, Your Name is: {0} and your age is {1}", name, age); //instead of concatenating string we can use this method also in order to add variable
//            }
//        }
//    }
//}
#endregion
#region Dynamic keyword
// In C# dynamic keyword is used to declare the dynamic variable, dynamic variable is not cheking type at compile time 
// the type is checking at runtime for the checking of the type we will use GetType() method.
// In dynamic variable we can change and assign value at compile time like int,string,bool etc.
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            dynamic dynamicvariable = 10;
//            Console.WriteLine(dynamicvariable);
//            dynamicvariable = "Shamshad";
//            Console.WriteLine(dynamicvariable);
//            dynamicvariable = new { Name = "Shamshad", Age = 28 };
//            Console.WriteLine(dynamicvariable.Name+ " " + dynamicvariable.Age);
//        }
//    }
//}
#endregion
#region var keyword
// var keyword is used to declare the implicit type that specifies the type of varible on initial value.
// if we are assigned a value as a integer then we can not change the value like as a string if we are changing
// then it will give compile time error.

//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            var age = 19;
//            //age = "abc"; Here we can not changes varibale like as string because type of define in var based on the initial value
//            // Here will give the compile time error
//            Console.WriteLine(age);
//        }
//    }
//}
#endregion
#region Object
// object is a refrence type that can store any type of value or refrence type,it is the base type of all other types in C#
//using System; 
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            Object value = 10;
//            value = "Shamshad"; 
//            Console.WriteLine(value);
//        }
//    }
//}
#endregion
#region classes and constructor
// Classes: The class is define in c# using class keyword.The class class consist of members and all the members
// are define into the class body
// Constructor: constructor is a special method that has the same name as the class in c#. when we are
// creating a object of the class the constructor will call automatically, this type of constructor is called default
// constructor.It can used to set the initial value for fields.
//using System;
//namespace TestConsoleApp
//{
//    public class Employee
//    {
//        public int EmployeeId;
//        public string EmployeeName;  
//        public Employee(int employeeId, string employeeName)
//        {
//            EmployeeId = employeeId;
//            EmployeeName = employeeName;
//        }
//        public void printDetails()
//        {
//            Console.WriteLine("Emplyee Name is {0} and employeeId is {1}", EmployeeName, EmployeeId);
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee employee = new Employee(2,"Shamshad");
//            employee.printDetails();
//        }
//    }
//}
#endregion
#region Constructors
// Types of constructor:There are five types of constructor.
// 1.Default Constructor 2.Parametrized Constructor 3.Copy Constructor 4.Private Constructor 5. Static Constructor
#region Default Constructor
// A constructor with no parameters thats called default constructor,default constructor initializes all numeric
// fields to zero and all string and object fields to null within the class.
//using System;
//namespace TestConsoleApp
//{
//    public class Test
//    {
//        int num; // Here the default constructor set the value of the fields is zero 
//        string name; // Here the default constructor set the value of the fields is null 
//        public Test()
//        {

//        }
//        public void print()
//        {
//            Console.WriteLine("Default Constructor number {0} and name {1}",num,name);
//        }
//    }
//    public class program
//    {
//        static void Main(string[] args)
//        {
//            Test test = new Test();
//            test.print();
//        } 
//    }
//}
#endregion
#region Parameterized Constructor
// A constructor having atleast one parameter is called parametrized constructor.It can initialize each instance 
// of the class to different value.
//using System;
//namespace TestConsoleApp
//{
//    public class Test
//    {
//        string Name;
//        int age;
//        public Test(string name, int age)
//        {
//            Name = name;
//            this.age = age;
//        }
//        public void printDetails()
//        {
//            Console.WriteLine("Student name is {0},and age is {1}",Name,age);
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Test test = new Test("Shamshad",19);
//            test.printDetails();
//        }
//    }
//}
#endregion
#region Copy Constructor
// This constructor creates an object by copying another objects.Its main use is to initialize a new instance to the values
// of an existing instance.
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        private string month;
//        private int year;

//        // Declaring a copy constructor 
//        public MyClass(MyClass myClass)
//        {
//            month = myClass.month;
//            year = myClass.year;
//        }
//        // declaring instance constructor
//        public MyClass(string month,int year)
//        {
//            this.month = month;
//            this.year = year;
//        }
//        public string Details
//        {
//            get
//            {
//                return "Month : " + month +
//                    "\n Year : " + year;
//            }
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass("April",1994);
//            //Here is myClass object copied to myClass1
//            MyClass myClass1 = new MyClass(myClass);
//            Console.WriteLine(myClass1.Details);
//        }
//    }
//}
#endregion
#region Private Constructor
// if constructor is creats with private keyword thats called private constructor it is not possible for other classes to derive
// from this class and we can not create an instance of the class.
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        public static int age;
//        public static string name;
//        private MyClass()
//        {

//        } 
//        public static void printDetails()
//        {
//            Console.WriteLine("The name is {0} and age is {1}", name, age);
//        } 
//    }
//    public class program
//    {
//        static void Main(string[] args)
//        { 
//            MyClass.age = 19;
//            MyClass.name = "Shamshad";
//            MyClass.printDetails();
//        }
//    }
//}
// Note:- It is the implementation of the singleton class pattern.
//  use private constructor when only we have static member.
// using private constructor prevent the create instance of the class.

#endregion
#region Static Constructor
// Static Constructor has to be invoked only once in the class and it has been invoked during the creation of the first object 
// to a static member in the class.
// A static constructor is initialized static fields or data of the class and to be execute only once.

//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        private static int level;
//        static MyClass()
//        {
//            level = 0;
//            Console.WriteLine("This is static constructor level is {0}",level);;
//        }
//        public MyClass(int age, string name)
//        {
//            Console.WriteLine("The name is {0} and age is {1}", name, age);
//        }
//        public MyClass(int age, string name, int salary)
//        {
//            Console.WriteLine("The name is {0} and age is {1} and slary is {2}", name, age, salary);
//        }

//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass(19, "shamshad");
//            MyClass myClass1 = new MyClass(19, "shamshad", 10000);
//        }
//    }
//}
//Note:- Its can not be called directly.
// It does not take access modifiers or any parameter.
// It is called automatically to initialize the class before the first instance created.
#endregion
#endregion
#region Difference between static constructor and private constructor
/*
 *      Static Constructor                                             Private Constructor
 *      1.static construcor is declared with static keyword.           1.private constructor is declared with private keyword.
 *      2.static  constructor invoked only once in class when          2.If we are declaring private constructor the we can not 
 *        first instance is created.                                     create a instance of the class its prevent to create the object
 *      3.A static constructor can store the field as a static only      of the class.                                                         
 *      4.It does not take access modifiers or any parameter.          3.private constructor we are using when all the data member and                                                    
 *                                                                       member function are static.
 *                                                                      4.private constructor we are using for the singleton design class 
 *                                                                    
 */
#endregion
#region Destructors
// Destructor is a method inside the class used to destroy instance of the class when they are no longer needed.
// The destructor is called by the garbage collector.
// In a class can have only one destructor.
// A destructor has no return type and same name as the class name and for the declaration using Tiled Symbol(~)
// A destructor has not accept any parameter and modifires.
// It can not be overloaded or inherited.
// It is called when the program exits.
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        public int age;
//        public string name;
//        public MyClass()
//        {
//            age = 19;
//            name = "Shamshad";
//        }
//        public void setValue(int age,string name)
//        {
//            this.age = age;
//            this.name = name;
//        }
//        public void print()
//        {
//            Console.WriteLine("The name is {0} and age is {1}", name, age);
//        }
//        ~MyClass()
//        {
//            Console.WriteLine("Destructor was called.");
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.setValue(20, "Javed");
//            myClass.print();
//        }
//    }
//}
#endregion
#region Access Specifires and access modifires
/*
 * Public : Public class and method is accesible within the class and out side the class.
 * Private : Private class and method is accesible within the class not outside the class.
 * Protected : protected access modifires are accessible within the class and is accessible into dervied of that class.
 * internal : internal access modifires are accessible within the class and its own assembly.
 * protected internal : protected internal is accessible within the assembly and out side the assembly with derived class object of that class.
 * private protected : private protected is accessible within the class and current assembly with derived class object of that class.
 */
#region Public Modifires
////// The public access modifires is accessible within the class and outside the class
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        public int age = 0;
//        public void print()
//        {
//            Console.WriteLine("The age is {0}", age);
//        }
//    }
//    public class program
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.age = 9;
//            myClass.print();
//        }
//    }
//}
#endregion
#region Private Modifires
//// The private access modifires is accessible within the class only not outside the class
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        private int age = 0;
//        private void print()
//        {
//            Console.WriteLine("The age is {0}", age);
//        }
//    }
//    public class program 
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.age = 9;// It is not accessible due to its protection level with private keyword
//            myClass.print();// It is not accessible due to its protection level with private keyword
//        }
//    }
//}
#endregion
#region Protected Modifires
//// Protected access modifires is accessible within the class and derived of that class with derived class object.
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        protected int age = 0;
//        protected void print()
//        {
//            Console.WriteLine("The age is {0}", age);
//        }
//    }
//    public class program : MyClass
//    {
//        static void Main(string[] args)
//        { 
//            program p = new program();
//            p.age = 9;
//            p.print();
//        }
//    }
//}
#endregion
#region internal Modifires
//// Internal access modifires is accessible within the class and its own assembly.
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        internal int age = 0;
//        internal void print()
//        {
//            Console.WriteLine("The age is {0}", age);
//        }
//    }
//    public class program
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.age = 9;
//            myClass.print();
//        }
//    }
//}
#endregion
#region protected internal Modifires
//// Protected internal access modifires is accessible within the the assembly and outside the assembly with derive class object of that class.
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        protected internal int age = 0;
//        protected internal void print()
//        {
//            Console.WriteLine("The age is {0}", age);
//        }
//    }
//    public class program
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.age = 9;
//            myClass.print();
//        }
//    }
//}
#endregion
#region private protected Modifires
//// private protected access modifires is accessible within the the class and current assembly with derive class object of that class.
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        private protected int age = 0;
//        private protected void print()
//        {
//            Console.WriteLine("The age is {0}", age);
//        }
//    }
//    public class program : MyClass
//    {
//        static void Main(string[] args)
//        {
//            program myClass = new program();
//            myClass.age = 9;
//            myClass.print();
//        }
//    }
//}
#endregion
#endregion
#region Method Parameter
/// There are 4 types of method parameter
/// 1) Value Parameter:- Creates a copy of parameter passed,so modification does not affect to each other.
#region Value Parameter
//using System;
//namespace TestConsoleApp
//{ 
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int age = 30;
//            myMethod(age);
//            Console.WriteLine(age);
//        }
//        public static void myMethod(int age)
//        {
//            int j = 40;
//            age = j;
//            Console.WriteLine(age);
//        }
//    }
//}
#endregion
/// 2.) Refrence Parameter :- The ref keyword is used to passing the value type as refrence if any changes made in this argument in the method 
/// then will reflect into the variable when the control return to the calling method.
/// Note:- It is necessary to initialze the parameter before pass it to ref.
#region Ref Parameter
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int age = 30;
//            string name = "shamshad";
//            myMethod(ref age,name);
//            Console.WriteLine("Name:{0},Age:{1}",name,age);
//        }
//        public static void myMethod(ref int age, string name)
//        {
//            int j = 40;
//            age = j;
//            string i = "javed";
//            name = i;
//            Console.WriteLine("Name:{0},Age:{1}", name, age);
//        }
//    }
//} 
#endregion
/// 3.) Out Parameter:- The out keyword is used to passing the argument as refrence type.It is generally used when a methods return multiple values
/// Note:- It is not necessary to initialize before pass it to the out.but we need to initialze into the method otherwise it will 
///   give the compile time error.
#region Out Parameter
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int age;
//            string name;
//            myMethod(out age, out name);
//            Console.WriteLine("Name:{0},Age:{1}", name, age);
//        }
//        public static void myMethod(out int age, out string name)
//        {
//            int j = 40;
//            age = j;
//            string i = "javed";
//            name = i;
//            Console.WriteLine("Name:{0},Age:{1}", name, age);
//        }
//    }
//}
#endregion
/// 4.) Parameters Array:- Using params you are allowed to pass any variable number of arguments.Only one params allowed in a function 
/// during declaration.
#region  Parameters Array
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = new int[3];
//            numbers[0] = 101;
//            numbers[1] = 102;
//            numbers[2] = 103;
//            string[] arrstring = new string[1];
//            arrstring[0] = "shamshad";
//            myMethod(numbers); 
//        }
//        public static void myMethod(params int[] numbers
//            //, params string[] arrstring // only one params keyword allowed in a function during the declaration none of other
//            )
//        {
//            foreach (var item in numbers)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
#endregion
#endregion
#region Classess
/// There are 4 types of class 
/*
 * Abstract Class
 * Static Class
 * Sealed Class
 * Partial Class
 */
// 1.) Abstract Class:- The abstact class is creat with the abstract keyword.
// We can not create a object of the abstract class.
// An abstarct can only be used as base class 
// An abstract class can not be sealed class
// An abstract class can have abstarct and non abstract both memeber and member function. 
// In An abstract class can have constructor and destructor.
// An abstarct class does not support multiple inheritance.
// An abstract can not be inherited from the structures.

#region Abstarct Class
//using System;
//namespace TestConsoleApp
//{
//    public abstract class BaseClass
//    {
//        public abstract void Printdetails();
//    }
//    public class DerivedClass : BaseClass
//    {
//        public override void Printdetails()
//        {
//            Console.WriteLine("Print printdetails method");
//        } 
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        { 
//            DerivedClass derivedClass = new DerivedClass();
//            derivedClass.Printdetails();
//        }
//    }
//} 
#endregion
/// 2.) Static Class:- In static class all the methods and parameter will be static and we can not create an object static class
/// we can call the member and member function with the class name.
#region Static Class
//using System;
//namespace TestConsoleApp
//{
//    static class MyClass 
//        //: Iinterface // Note:- In static class can not implement interface
//    {
//        public static int age;
//        public static string name;
//        public static void Printdetails()
//        {
//            Console.WriteLine("The name is {0} and age is {1}", name, age);
//        }

//        //public void print()
//        //{
//        //    throw new NotImplementedException();
//        //}
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass.age = 19;
//            MyClass.name = "Shamshad";
//            MyClass.Printdetails();
//        }
//    }
//    interface Iinterface
//    {
//        void print();
//    }
//}
#endregion
/// 3.) Sealed Class :- Selaed class is used to prevent the inheritance of that class we can create a object of the sealed class
/// 
#region Sealed Class
//using System;
//namespace TestConsoleApp
//{
//    public sealed class SealedClass
//    {
//        public void printSealedclass()
//        {
//            Console.WriteLine("This is first partial class");
//        }
//    }

//    public class Program
//    {
//        static void Main()
//        {
//            SealedClass sealedClass = new SealedClass();
//            sealedClass.printSealedclass();  
//        }
//    }
//}
#endregion
/// 4.) The partial class is declared with the partial keyword we can create multiple class with the same name in the
///     assembly and create only one class objects and call member function of another class.
///     The partial class can not use in another namespace.
#region Partial Class
//using System;
//namespace TestConsoleApp
//{
//    public partial class MyClass
//    {
//        public void printFirstPartial()
//        {
//            Console.WriteLine("This is first partial class");
//        }
//    }
//    public partial class MyClass
//    {
//        public void printSecondPartial()
//        {
//            Console.WriteLine("This is second partial class");
//        }
//    }
//    public partial class MyClass
//    {
//        public void printThirdPartial()
//        {
//            Console.WriteLine("This is third partial class");
//        }
//    }
//    public class Program
//    {
//        static void Main()
//        {
//            MyClass myClass = new MyClass();
//            myClass.printFirstPartial();
//            myClass.printSecondPartial();
//            myClass.printThirdPartial();
//            myClass.printFourthPartial();
//           // myClass.printAnotherAssembly(); // Here we can not use the patial class in another namespace
//        }
//    }  
//}
//namespace TestConsoleApp
//{
//    public partial class MyClass
//    {
//        public void printFourthPartial()
//        {
//            Console.WriteLine("This is fourth partial class.");
//        }
//    }
//}
//namespace TestConsoleApp1
//{
//    public partial class MyClass
//    {
//        public void printAnotherAssembly()
//        {
//            Console.WriteLine("This is fourth partial class.");
//        }
//    }
//}
#endregion
#endregion
#region Difference Between static class and singleton class
/*
 *                  Static Class                                                        Singleton Class
 *    1. We can not create a object of static class                     1. In Sigleton class we can create only one instance of the class
 *    2. We can not inheit of static class from other class                and reuse it.
 *    3. In static class all the member and member function will        2. we can implement interface into singleton class.
 *       be static.
 *    4. Static class member and member functions calls with class name
 *    5. We can not implement interface in static class
 */
#endregion
#region Cllections
/// Collection types are designed to store, manage and manipulate data more effeciently.Data manipulation includes adding
/// searching storing and deleting and inserting the data into collection.
/// Adding and inserting items into collection.
/// Removing items from collection
/// Finding Searching snd Sorting from collection.
/// Replacing item from collection.
// .Net Support two types of collection.
// 1.generic collection Note:- generic collection exist in namespace (using System.Collections.Generic)
// 2.non generic collection Note:- non generic collection is exist in namespace (using System.Collections)
/*
    Generic Collections -> using System.Collections.Generic                     Non Generic Colletcion -> using Syste.collections
                    List                                                                        ArrayList
                    Dictionary                                                                  Hashtable
                    SortedList                                                                  SortedList
                    Stack                                                                       Stack
                    Queue                                                                       Queue
 */
// 1. Generic Collection:- Generic collection worked on the specific type.
// Specific type
// Array size is not fixed
// Elements can be added/removed at runtime.

// 1.) List:-
#region List  
//using System; 
//using System.Collections.Generic;

//namespace TestConsoleApp
//{

//    public class Program
//    { 
//        static void Main(string[] args)
//        {
//            List<int> lst = new List<int>();
//            lst.Add(100);
//            lst.Add(200);
//            lst.Add(300);
//            foreach (var item in lst)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}
#endregion

// 2.) Dictionary
#region Dictionary  
//using System;
//using System.Collections.Generic;

//namespace TestConsoleApp
//{

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> dictionary = new Dictionary<int, string>();
//            dictionary.Add(100, "Shamshad");
//            dictionary.Add(200, "Nafis");
//            dictionary.Add(300, "Javed");
//            foreach (KeyValuePair<int, string> item in dictionary)
//            {
//                Console.WriteLine("The key is {0} and the value is {1}", Convert.ToString(item.Key), item.Value);
//            }

//        }
//    }
//}
#endregion
// 3.) Sorted List
#region Sorted List  
//using System;
//using System.Collections.Generic;

//namespace TestConsoleApp
//{

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            SortedList<int, string> sortedlist = new SortedList<int, string>();
//            sortedlist.Add(100, "Shamshad");
//            sortedlist.Add(200, "Nafis");
//            sortedlist.Add(300, "Javed");
//            foreach (KeyValuePair<int, string> item in sortedlist)
//            {
//                Console.WriteLine("The key is {0} and the value is {1}", Convert.ToString(item.Key), item.Value);
//            }

//        }
//    }
//}
#endregion
// 4.) Stack:- The statck is working like as LIFO(Last in First Out). Here we are using push method for the stack
#region Stack 
//using System;
//using System.Collections.Generic;

//namespace TestConsoleApp
//{

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Stack<int> stack = new Stack<int>();
//            stack.Push(100);
//            stack.Push(200);
//            stack.Push(300);
//            foreach (var item in stack)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}
#endregion
// 5.) Queue:- The queue is working like as FIFO(First in First Out).Here we are using Enqueue keyword for the queue
#region Queue  
//using System;
//using System.Collections.Generic;

//namespace TestConsoleApp
//{

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Queue<int> queue = new Queue<int>();
//            queue.Enqueue(100);
//            queue.Enqueue(200);
//            queue.Enqueue(300);
//            foreach (var item in queue)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}
#endregion
/// 2. Non Generic collection:- Non Generic collection is work on any type of.The collection size are not fixed item 
/// can be added or remove at runtime.
// 1.) Array List:-
// Array list can store values various type.
// Array list does not have specific size
// Any number of elements can be store
#region Array List
//using System;
//using System.Collections;

//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            ArrayList arrayList = new ArrayList();
//            arrayList.Add("Shamshad");
//            arrayList.Add(101);
//            arrayList.Add(true);
//            foreach (var item in arrayList)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
#endregion
// 2.) HashTable:- Hashtable represnts the item as combination of the key/value pair
#region Hashtable
//using System;
//using System.Collections;

//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            Hashtable hashtable = new Hashtable();
//            hashtable.Add(1,"Shamshad");
//            hashtable.Add(2,"Javed");
//            hashtable.Add(3,"Nafis");
//            foreach (DictionaryEntry item in hashtable) // Here we are using Dictinaryentry for reading key value pair in non generic collection
//            {
//                Console.WriteLine("The key is {0} and the value is {1}",Convert.ToString(item.Key), item.Value);
//            }
//        }
//    }
//}
#endregion
// 3.) SortedList:- Sorted list also represnts the item as combination of the key/value pair
#region Sorted List
//using System;
//using System.Collections;

//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            SortedList sortedList = new SortedList();
//            sortedList.Add(1, "Shamshad");
//            sortedList.Add(2, "Javed");
//            sortedList.Add(3, "Nafis");
//            foreach (DictionaryEntry item in sortedList) // Here we are using Dictinaryentry for reading key value pair in non generic collection
//            {
//                Console.WriteLine("The key is {0} and the value is {1}",Convert.ToString(item.Key), item.Value);
//            }
//        }
//    }
//}
#endregion
// 4.) Statck:- Stack is working like as LIFO(Lat in First Out).
#region Stack 
//using System;
//using System.Collections;

//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            Stack stack = new Stack();
//            stack.Push("Shamshad");
//            stack.Push(101);
//            stack.Push(false);
//            foreach (var item in stack) 
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
#endregion
// 5.) Queue:- Queu is working like as FIFO(First in First Out).
#region Stack 
//using System;
//using System.Collections;

//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            Queue queue = new Queue();
//            queue.Enqueue("Shamshad");
//            queue.Enqueue(101);
//            queue.Enqueue(false);
//            foreach (var item in queue)
//            {
//                Console.WriteLine(item);
//            } 
//        }
//    }
//}
#endregion
#endregion
#region Difference between Array and ArryList
/*
 *              Array                                                   ArrayList
 *    1.Array is a fixez size when we are creating      1. In arrylist does not define the size of the aaray list 
 *      then we need to define the size of the array       the size of the arraylist can be change at runtime baed on the requirement
 *    2.In array define the specific type of the array  2. In the arraylist we can store any type of at runtime we do not need to define
                                                            specific type.
      3.Array belongs to System.Array namespace         3. ArrayList belongs to System.Collections namespace
      4.Array is strongly type which means it can be    4. ArrayList is not strongly type.it can be store any type.
        only specific type of item
      5.Array can be null                               5. ArrayList can accept null
 */
#region Array and ArrayList
//using System;
//using System.Collections;

//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            string[] array = new string[2]; 
//            array[0] = null;
//            array[1] = "shamshad";
//            foreach (var item in array)
//            {
//                Console.WriteLine(item);
//            }
//            ArrayList arrayList = new ArrayList();
//            arrayList.Add("Shamshad");
//            arrayList.Add("Nafis");
//            arrayList.Add("Javed");
//            arrayList.Add(null);
//            foreach (var item in arrayList)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}
#endregion
#endregion
#region string and stringBuilder
// string:- a string is an immutable object.
// It belongs to System namespace, creating a new instance instead of changing the old one.
// Performance wise is slow becaus creating new instance to override the previous value.
// string Builder:- A string Builder is an mutable object.
// It belongs to System.Text namespace, 
// Performance wise is fast because its not creating a new instance using same instance of the stringBuilder object.
//using System;
//using System.Text;

//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            string val = "Hello";
//            val += "I am ";
//            val += "Shamshad Ahmad ";
//            val += "Chaudhry";
//            Console.WriteLine(val);
//            //In case of string concatenation system is creating new memory block every time.
//            StringBuilder stringBuilder = new StringBuilder();
//            stringBuilder.Append("Hello");
//            stringBuilder.Append("I am ");
//            stringBuilder.Append("Shamshad Ahmad ");
//            stringBuilder.Append("Chaudhry");
//            Console.WriteLine(stringBuilder);
//            //In case of StringBuilder system is not creating new memory block.

//        }
//    }
//}
#endregion
#region Enum
// An enum is a value type.
// The enum keyword is used to declare the enumeration.
// It is a primitive data type that can be user define.
// An enum type can be integer (float, int, byte, double etc).

//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee employee = new Employee();
//            employee.age = 28;
//            employee.name = "Shamshad";
//            employee.WeekDays = Convert.ToInt32(WeekDays.Monday); // Here we will get values from enums called days
//            Console.WriteLine("The age is {0} and name is {1} and workdays {2}",employee.age,employee.name,employee.WeekDays);
//        }   
//    }
//    public enum WeekDays
//    {
//        Sunday,
//        Monday,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday
//    }
//    public class Employee
//    {
//        public int age { get; set; }
//        public string name { get; set; }
//        public int WeekDays { get; set; }
//    }
//}
#endregion
#region Extension Methods
// Extestion Methods allow add a new methods without changing in our sorce code.
// An extension method is a static method used to extend the functionality.
// Extension method are declared in a static class and are defined as a static methods with a special first parameter 
// called this parameter.
//using System;
//namespace TestConsoleApp
//{
//    public class Employee
//    {
//        public void AddEmployee()
//        {
//            Console.WriteLine("Add Employee");
//        }
//        public void UpdateEmployee()
//        {
//            Console.WriteLine("Update Employee");
//        }
//    }
//    public static class ExtendMethod
//    {
//        public static void DeleteEmployee(this Employee employee)
//        {
//            Console.WriteLine("Delete Employee");
//        }
//    }
//    public class Program
//    {
//        static void Main()
//        {
//            Employee employee = new Employee();
//            employee.AddEmployee();
//            employee.UpdateEmployee();
//            employee.DeleteEmployee();// Here we are getting extend method by extend with employee class
//        }
//    }
//}
///// Using Extension Method for right hand side substring
// Example
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            string name = "ShamshadAhmad";
//            string leftName = name.Substring(0, 8);
//            Console.WriteLine("First Name is: {0}",leftName);
//            string rightName = name.RightSubstring(5);
//            Console.WriteLine("Last Name is: {0}", rightName);
//        }
//    }
//    public static class ExtensionMethod
//    {
//        public static string RightSubstring(this string test,int count)
//        {
//            return test.Substring(test.Length - count, count);
//        }
//    }
//}
#endregion
#region Read Only and Constant
// Constatnt:- Const is nothing but constant a variable whose value is constant.
// In constatnt need to assign value at compile time otherwise it will give the error.
// ReadOnly:- Readonly is a keyword whose vlaue can be change at runtime at assign it at runtime.
//using System;  
//namespace TestConsoleApp
//{

//    public class ConstReadClass
//    {
//        const int Const=100;
//        readonly int ReadOnly;

//        public ConstReadClass()
//        {
//            // Const = 200; // Here it will give the error because we can not change the constant value at compile time
//            // into constructor
//            ReadOnly = 300;
//        }
//        public void Print()
//        {
//            Console.WriteLine("Print Constant {0}", Const);
//            Console.WriteLine("Print ReadOnly {0}", ReadOnly);
//        }
//    }
//    public class Program
//    {
//        static void Main()
//        {
//            ConstReadClass constReadClass = new ConstReadClass();
//            constReadClass.Print();
//        }
//    }
//}
#endregion
#region Exception Handling 
#region Basic Exception
// We use try catch and finally block for exception handling.
// try: The exception posiibly can occur in try block.
// catch : handle the exception
// finally: clean and free resource that the class was holding during the program execution.Finaly block is an optional
// Note:- It is a good practice to always release resource in the finally block. The finally block is gauranteed to execute whether the 
// exception is or not.
//using NPOI.OpenXml4Net.Exceptions; 
//using System;
//using System.IO;
//using System.Net.NetworkInformation; 
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("Enter First Number");
//                int FirstNumber = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter Second Number");
//                int SecondNymber = Convert.ToInt32(Console.ReadLine());

//                decimal thirdnumber = FirstNumber / SecondNymber; // If here exception will occur then dividebyzeroexception will handle
//                Console.WriteLine("Result is {0}", thirdnumber);
//                //throw new RuntimeException();  //  If here exception will occur then super type of exception will handle
//                //string text1 = File.ReadAllText("text1.txt"); // If here exception will occur then IOException block will handle
//            } 
//            catch (OutOfMemoryException mex) 
//            {
//                Console.WriteLine("Out of Memory Exception {0}", mex.Message);
//            }
//            catch (IOException IOex)
//            {
//                Console.WriteLine("IO Exception {0}", IOex.Message);
//            }
//            catch (InvalidFormatException fex) 
//            {
//                Console.WriteLine("Format Exception {0}", fex.Message);
//            }
//            catch (NetworkInformationException nex) 
//            {
//                Console.WriteLine("Network Exception {0}", nex.Message);
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Second should not be zero ,Exception Type is {0} and message is {1} ", ex.GetType().Name, ex.Message);
//            }
//            catch (Exception ex) // This catch block handle all the type of exception for thats called a super type exception                      
//            {                    // we can not use before any type of exception like as dividebyzero and etc.
//                Console.WriteLine("Message {0}", ex.Message);
//            }
//            finally
//            {

//            }

//        }
//    }
//}
#endregion
#region Inner Exception 
// The InnerException is property of Exception.The most current exception can obtain the prior exception in the InnerException 
// property.
// Lets an Example: we have an exception in try block dividebyzero exception and the catch block catches it and write it into file
// if filepath is not found then filenotfoundexception occur in and handle out side catches this exception.
// but the actual dividebyzeroexception that was thrown? Is it Lost? No the InnerException property contains the actual exception
//using System;
//using System.IO; 
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            { 
//                    try
//                    {
//                        Console.WriteLine("Enter First Number");
//                        int FirstNumber = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter Second Number");
//                        int SecondNymber = Convert.ToInt32(Console.ReadLine());

//                        decimal thirdnumber = FirstNumber / SecondNymber; // If here exception will occur then dividebyzeroexception will handle
//                        Console.WriteLine("Result is {0}", thirdnumber); 
//                    } 
//                    catch (DivideByZeroException ex)
//                    {
//                            //Console.WriteLine("Second should not be zero ,Exception Type is {0} and message is {1} ", ex.GetType().Name, ex.Message);
//                            string filepath = @"C:\Users\admin\OneDrive\Desktop\Learning\C#\Introduction\TestFile.txt";
//                            if(File.Exists(filepath))
//                            {
//                                StreamWriter sw = new StreamWriter(filepath);
//                                sw.WriteLine(ex.GetType().Name);
//                                sw.WriteLine(ex.Message);
//                                sw.WriteLine(ex.StackTrace);
//                                sw.Close();
//                            }
//                            else
//                            {
//                                throw new FileNotFoundException("File not found", ex);
//                            } 
//                    }

//            }
//            catch (Exception ex) // This catch block handle all the type of exception for thats called a super type exception                      
//            {                    // we can not use before any type of exception like as dividebyzero and etc.
//                Console.WriteLine("Exception occurred in the catch block  =>" + ex.GetType().Name);
//                //to get the inner exception type and name, use the InnerException property present in the Exception class  
//                Console.WriteLine("Inner Exception occurred in the catch block  =>" + ex.InnerException.GetType().Name);
//            }

//        }
//    }
//}
#endregion
#endregion
#region Coupling and Decoupling
// In case of coupling one class is dependent on another class, if you will change in one class then it will impact on another class
// But in case of decoupling with the technique we are making interface which first class has to inherit and then we are putting
// same interface into our second class constructor so if any thing will change in first class interface then it should prived in
// the second class constructor so your code will not impact somewhere else.
// Couple Code 
#region Coupling
//using System;
//namespace TestConsoleApp
//{
//    public class program
//    {
//        public class Square
//        {
//            public int SideLength { get; set; }
//        }
//        public class AreaCalculator
//        {
//            public int CalculateSquareArea()
//            {
//                Square square = new Square();
//                square.SideLength = 5;

//                // Calculate the area of the square
//                int area = square.SideLength * square.SideLength;

//                return area;
//            }
//        }
//        static void Main()
//        {
//            AreaCalculator areaCalculator = new AreaCalculator();
//            Console.WriteLine(areaCalculator.CalculateSquareArea());
//        }
//    }
//}
#endregion
// Decouple Code
#region Decoupling
//using System;
//namespace TestConsoleApp
//{
//    interface IMotor
//    {
//        public void StartMotor();
//    }
//    public class Motor : IMotor
//    {
//        public void StartMotor()
//        {
//            Console.WriteLine("Motor Get Started");
//        }
//    }
//    public class car
//    {
//        readonly IMotor motor;
//        public car(Motor motor)
//        {
//            this.motor = motor;
//        }
//        public void StartMotor()
//        {
//            motor.StartMotor();
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            Motor motor = new Motor();
//            car car = new car(motor);
//            car.StartMotor();
//        }
//    }
//}
#endregion
#endregion
#region Generic class and Methods
// Generic is a class thats allow the user can define classes and methods with the placeholder.
// C# provides a number of built in generic types, such as List<T>,Dictionary<TKey,TValue> and Nullable<T> 
// We can create our own generic classes methods and interface using syntax Syntax<T>.Where T is replaced parameter
// that can replace with any valid data type. 
//using System; 
//namespace TestConsoleApp
//{
//    public class program
//    {
//        static void Main()
//        {
//            Calculator calculator = new Calculator();
//            Console.WriteLine(calculator.checkIsGreater("12","112"));
//        }
//    }
//    public class Calculator
//    {
//        public bool checkIsGreater<T>(T FirstValue,T SecondValue)
//        {
//            if(Convert.ToInt32(FirstValue)> Convert.ToInt32(SecondValue))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}
//using System; 
//namespace TestConsoleApp
//{
//    public class program
//    {
//        static void Main()
//        {
//            Calculator<string> calculator = new Calculator<string>();
//            Console.WriteLine(calculator.checkIsGreater("121", "112"));
//        }
//    }
//    public class Calculator<T>
//    {
//        public bool checkIsGreater(T FirstValue, T SecondValue)
//        {
//            if (Convert.ToInt32(FirstValue) > Convert.ToInt32(SecondValue))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}
#endregion
#region Async and Await
/*
    In C# Task keyword refers to a type that represents an asynchronous operation.When combine async and await keyword that allow 
    to write asyncronous programing more easily.
    async is allow to define a method as async method,indicating that it might perform asyncronous operation.The async keyword allow the use of await keyword inside method.
    await is used to puase the execution of an async method until the await task is completed.it does not block the thread, instead it allow 
    it allows the method control back to the caller while waiting for the asyncronous operation to finish.

 */
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Main method started.");
//            Task Task1 = Swiming();
//            Task Task2 = Working();
//            Task Task3 = Cooking();
//            Task.WhenAll(Task1,Task2,Task3);
//            Thread t1 = new Thread(CarDrive);
//            t1.Start();
//            Thread t2 = new Thread(CarDrive1);
//            t2.Start();
//            Console.WriteLine("Main method completed.");
//        }
//        static void CarDrive()
//        {
//            for (int i = 0; i < 100; i++)
//            {
//                Console.WriteLine("first thread" + i);
//            }
//        }
//        static void CarDrive1()
//        {
//            for (int i = 0; i < 100; i++)
//            {
//                Console.WriteLine("second thread" + i);
//            }
//        }
//        static async Task Swiming()
//        {
//            Task.Delay(5).Wait();
//            Console.WriteLine("Swiming two hours");
//        }
//        static async Task Working()
//        {
//            Task.Delay(2000).Wait();
//            Console.WriteLine("Working 8 hours");
//        }
//        static async Task Cooking()
//        {
//            Task.Delay(2000).Wait();
//            Console.WriteLine("Cooked");
//        }
//    }

//}
#endregion
#region Difference between Syncronous and Asyncronous Programming
/*  
                        Syncronous Programing                           Asyncronous Programming 
    1.Syncronous is a blocking architecture.                1.Asyncronous is a non blocking architecture.
    2.In sycronous programing blocking the execution        2.Asyncronous programming allow the execution of code to continue
      of code until the task completed.                       while a task is being processed in the background.
    3. Syncronous programming is not usefull for long       3.Asyncronous programming is usefull for long operation while
       operation.                                             reading a file making a network request.
                                                          4.Asynchronous programming achieved using async and await keyword
 */
#endregion
#region  threading and multithreading
/*  
    Threading:- When C# program starts its a single threaded process by default. The main thread is responsible to execute your
    code line by line creating what is know as a single threading.
    In sigle Thread one command line process at single thread.
    Multithreading:- In case of multi threading allows to process manage two or more concurrent threads.Each thread can handle
    a task independently.For example one thread performs a complex calculation and another thread can update the user interface.
 */
#region Basics of Threading
//using System;
//using System.Threading;
//namespace TestConsoleApp
//{
//    public class program
//    {
//        // if i run this program without using thread then it will execute sequentially other wise paralelly
//        static void Main()
//        {
//            Thread t1 = new Thread(Function1);
//            Thread t2 = new Thread(Function2);
//            t1.Start();
//            t2.Start(); // it will execute both method parallely
//            //Function1();
//            //Function2(); // Here method will execute sequently
//        }
//        static void Function1()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Function 1 and Number is {0}", i);
//                Thread.Sleep(2000);
//            }
//        }
//        static void Function2()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Function 2 and Number is {0}", i);
//                Thread.Sleep(2000);
//            }
//        }
//    }
//}
#endregion
#region Forward and Backward Threading
/*  
   There are two types of thread foreground and background also known as forward and backwaord thread.
    Forward Threading :- In Forwared threading the thread will not wait for the main thread it complete our task its not dependent
    on main thread.
    Background Thraed:- In case of Background thread its process depends on the main thread if main thread process is finished
    then background thread process will finished. 
 */
// Forward and Backword Threading
//using System;
//using System.Threading;

//namespace TestConsoleApp
//{
//    public class program
//    {
//        static void Main()
//        {
//            Thread t = new Thread(mythread); 
//            t.IsBackground = true; // If we set false to it than it will be forward threading.
//            t.Start();
//            Console.WriteLine("Main Thread Ends!!");
//        }
//        static void mythread()
//        {
//            for (int c = 0; c <= 3; c++)
//            {

//                Console.WriteLine("mythread is in progress!!");
//                Thread.Sleep(1000);
//            } 
//        }
//    }
//}
#endregion
#endregion
#region SOLID Principle
/*
    stands for:-

Single Responsibility Principle:-One class should have one responsibility instead of multiple.so in case of change shuld have change only one.

Open Close Principles Principle:- open for extension and close for modification.Which means class can get inherit to the base class but not update.if need
some extrs features then instead of modification that class extend it and add to it.

Liskove Substitution Principle:-Every methods of the base class must be applicable to derived class.

Interface Segregation Principle:- Interface segregation means one interface does define all functionality whic is not required in all extended class.
for example if derived class is extending then all interface function can use in derived class

Dependency Inversion Principle:- Dependency inversion principles is saying instead of using concrete class use interface.

 */
/*
    Advantage of solid principle:
  Help us write better code
  Avoid duplicate coed
  Maintanable code
  Testable code 
  Easy to understand
  Reduce Complexity
  

 */
#endregion
#region Difference between IEnumrable and IQuerable
/*
                        IEnumerable                                                                 IQueriable
    1.It is a parent interface for all non generic collection                           1.It is a part of Linq.
      into system. IEnumerable belongs to namespace System.Collections.                 2.IQueryable is the way to write query on data like 
    2.IEnumerable is the best way to write quesry on collection data type                 remote database service collection.
      Like List,Array etc.                                                              3.IQueryable is a lazy loading so we can perform paging
    3.IEnumerable does not support lazy loading so it is not recoomended approach         kind of scnerion.
      for paging kind of scnerio.                                                       4.when we are using IQueriable then we can apply the filter
    4.when we are using IEnumerable we are fetching all the data from the data base       on server side and then fetch the data from database.
      and then filter criteria are implemented at client side.

 */
#endregion
#region Finalize and Dispose Method
#region Finalize
//using System;
//namespace TestConsoleApp
//{
//    public class Student
//    {
//        public string Name = "";
//        public int? Age = null;
//        public void StudentDetails()
//        {
//            Console.WriteLine("The name is {0} and age is {1}",Name,Age);
//        }
//        ~Student()
//        {
//                // Once class get execute properly than garbage collector automatically clean all unmanaged resource
//                // Finalize method automatically invoke
//                // No need of Implementation
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            Student S = new Student();
//            S.Name = "Shamshad";
//            S.Age = 28;
//            S.StudentDetails();
//        }
//    }
//}
#endregion
#region Dispose
//using System;
//namespace TestConsoleApp
//{
//    public class Student : IDisposable
//    {
//        public string name = "";
//        public int? age = null;
//        private bool disposedValue;
//        public void StudentDetails()
//        {
//            Console.WriteLine("Student Name is {0} and age is {1}", name, age);
//        }
//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposedValue)
//            {
//                if (disposing)
//                {
//                    // TODO: dispose managed state (managed objects)
//                }

//                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
//                // TODO: set large fields to null
//                disposedValue = true;
//            }
//        }

//        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
//        // ~Student()
//        // {
//        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
//        //     Dispose(disposing: false);
//        // }

//        public void Dispose()
//        {
//            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
//            Dispose(disposing: true);
//            GC.SuppressFinalize(this);
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            Student s = new Student();
//            s.name = "Shamshad";
//            s.age = 23;
//            s.StudentDetails();
//        }
//    }
//}
#endregion
/*
 Dispose                                                    Finalize
 1) It is used to free unmanaged resource like files,       1) It can be used to cleanup and free unmanaged resource 
    database connections etc. at any time.                     it is automatically called by the garbage collector
 2) Dispose belongs to the IDisposal interface             2) Finalize belongs to the class object
 3) We have to manually write code to implement it.         3) It is automatically called by garbage collection mechanism
 4) it is deterministic function as dispose method is       4) It is non deterministic function when garbage collector will call
    explicitly called by the user code                          finalize method
 5) Its implementing by the IDisposal interface with        5) It implements with the help of destructor in c++ or c#.
    Dispose() method.
 6) There is no performance cost is associated with Dispose 6) There is performance cost is associated with the finalize method
    method.
 
 */
#endregion



// OOps Concepts 
#region Inheritance and Type of Inheritance
/*
 Definition:Inheritance is a fundamental concept of object oriented programming that allows us to define a new class based 
 an existing class the new class inherits the properties and method into new class can also add new properties and methods
 of its own.
 The class whose members are inherited is called base class.

Note:Base class should be public or protected 
   
Types of inheritance in c#
 */
#region Single Inheritance
// Single inheritance means one base class and one derived class
// Syntax 
// Class A
// {
//    Some content in A
// }
// class B:A
// {
//   some content B and from A also  
// } 
//using System;
//namespace TestConsoleApp
//{
//    public class BaseClass
//    {
//        protected int studentAge;
//        protected string studentName;
//        public void StudentDetails(string name,int age)
//        {
//            Console.WriteLine("The student name is {0} and age is {1}", studentName, studentAge);
//        }
//    }
//    public class DerivedClass : BaseClass
//    {
//        static void Main()
//        {
//            DerivedClass B = new DerivedClass();
//            B.studentAge = 20;
//            B.studentName = "Shamshad";
//            B.StudentDetails(B.studentName,B.studentAge);
//        }
//    }
//} 
#endregion
#region Multi-level Inheritance
// Definiton: A derive class that inherits from base class and the derive class itself becomes the base class for another derive class.
// Syntax
/*    class A
      {
        some content for class A
      }
      class B : A { Child Class 
        some content for class A and B also
      }
      class C : B{
        some content in C and from B as well from A
      }
*/
//using System;
//namespace TestConsoleApp
//{
//    public class BaseClass
//    {
//        protected int studentAge;
//        protected string studentName;
//        public void StudentDetails(string name, int age)
//        {
//            Console.WriteLine("The student name is {0} and age is {1}", studentName, studentAge);
//        }
//        public void StudentFullDetails(string name, int age,string Email,string Address)
//        {
//            Console.WriteLine("The student name is {0} and age is {1} and Email is {2} and Address is {3}",
//                studentName, studentAge, Email, Address);
//        }
//    }
//    public class FirstChild : BaseClass
//    {
//        protected string Email;
//        protected string Address;
//        public static void FirstChildMethod()
//        {
//            FirstChild First = new FirstChild();
//            First.studentAge = 20;
//            First.studentName = "Shamshad";
//            First.StudentDetails(First.studentName,First.studentAge);
//        }
//    }
//    public class SecondChild : FirstChild
//    {
//        public static void SecondChildMethod()
//        {
//            SecondChild Second = new SecondChild();
//            Second.studentAge = 20;
//            Second.studentName = "Shamshad";
//            Second.Email = "shamshad@gmail.com";
//            Second.Address = "Govandi";
//            Second.StudentFullDetails(Second.studentName, Second.studentAge, Second.Email, Second.Address);
//        }
//        static void Main()
//        {
//            FirstChild.FirstChildMethod();
//            SecondChild.SecondChildMethod();
//        }
//    }
//}
#endregion
#region Hierarchical Inheritance
// Definition: A base class that serves as a parent class for two or more derived class
//syntax:

//calss A{        Base Class
//some content in A
//}
//class B :A{     Child Class
//Some content in B and from A as wells
//}
//class C :A{     Child Class
//Some content in C and from A as wells
//}


//using System;
//namespace mynamespacce
//{

//    public class BaseClass
//    {
//        protected int studentage;
//        protected string StudentName;
//        protected void StudentDetails(string name, int age)
//        {
//            Console.WriteLine("Student Report: Name of student is {0} and age is {1}", name, age);
//        }
//    }
//    public class FirstChildClass : BaseClass
//    {
//        public static void FirstChildMethod()
//        {
//            FirstChildClass First = new FirstChildClass();
//            First.studentage = 22;
//            First.StudentName = "shamshad Ahmad";
//            First.StudentDetails(First.StudentName, First.studentage);
//        }
//    }
//    public class SecondChild : BaseClass
//    {
//        public static void SecondChildMethod()
//        {
//            SecondChild Second = new SecondChild();
//            Second.studentage = 28;
//            Second.StudentName = "Javed Khan";
//            Second.StudentDetails(Second.StudentName, Second.studentage);
//        }
//        public static void Main()
//        {
//            FirstChildClass.FirstChildMethod();
//            SecondChild.SecondChildMethod();
//        }
//    }
//}
#endregion
#endregion
#region Abstract Class
/*
  abstract class : An abstract class is declared with abstract keyword
  An abstract class can not create object 
  An abstract class can be use as base class
  An abstract class can not be a sealed class
  In an abstract can have constructor and desctructor
  In an abstract class can have abstract and non abstract member and member function
  An abstract class does not support multiple inheritance
  
 */
//using System;
//namespace TestConsoleApp
//{
//    public abstract class BaseClass
//    {
//        public abstract void PrintDetails();
//    }
//    public class DerivedClass : BaseClass
//    {
//        public override void PrintDetails()
//        {
//            Console.WriteLine("Print details of derived class method");
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            DerivedClass D = new DerivedClass();
//            D.PrintDetails();
//        }
//    }
//}
#endregion
#region Abstraction
/*
    Abstraction means showing only required thing and hiding the background details.
    we can take an example of SubString() method of string class we do not know the implementation of that method only we are using this 
    method .net framework thats also called as an abstraction.

 */
//using System;
//namespace TestConsoleApp
//{
//    public abstract class EmployeeSalary
//    {
//        public int CalculateSalary()
//        {
//            return 10 * 15000;
//        }
//    } 
//    public class Employee : EmployeeSalary
//    {
//        static void Main()
//        {
//            Employee E = new Employee();
//            int sal =   E.CalculateSalary();
//            Console.WriteLine("Salary"+sal);
//        }
//    }
//}
#endregion
#region Encapsulation
/*
    Encapsulation:- Encapsulation is defined as the wrapping up of data into single unit.Encapsulation is used to hide the data
    In encapsulation the variable and data is hidden from other classes so also it is known as data hiding.
    Encapsulation can be achieved declaring all the variables in the class in private and using C# properties to get and set the data 
    into variable.

 */
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        private int age;
//        private string name;
//        public int Age {
//            get { return age; }
//            set { age = value; } 
//        }
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        } 
//    }
//    public class program
//    {
//        static void Main()
//        {
//            MyClass myClass = new MyClass();
//            myClass.Age = 23;
//            myClass.Name = "Shamshad";
//            Console.WriteLine("Student age is"+myClass.Age);
//            Console.WriteLine("Student name is" + myClass.Name);
//        }
//    }
//}
#endregion
#region Polymorphism
// Polymorphism means one name many forms. In polymorphism allow a class to have multiple implemetation with the same name
// There are two types of polymorphism.
// 1. Static/compile time Polymorphism
// 2. Dynamic/Run time Polymorphism
// Compile time polymorphism is achieved by method overloading or operator overloading
// Run time polymorphism is achieved by method overriding using virtual keyword in base class method
// virtual keyword indicates the method can be overriden in any derived class.

#region Method Overloading
// In Method overloading the method name will be same with the different signature
//using System;
//namespace TestConsoleApp
//{
//    public class MyClass
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }
//        public int Add(decimal a, int b)
//        {
//            return Convert.ToInt32(a) + b;
//        }
//        public string Add(string a, string b, string c)
//        {
//            return a + b + c;
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            MyClass myClass = new MyClass();
//            Console.WriteLine("Addition is" + myClass.Add(9, 8));
//            Console.WriteLine("Addition float" + myClass.Add(10, 8));
//            Console.WriteLine(myClass.Add("Shamshad", "Ahmad", "chaudhry"));
//        }
//    }
//}
#endregion
#region Method Overriding
//using System;
//namespace TestConsoleApp
//{
//    public class BaseClass
//    {
//        public virtual void PrintMethod()
//        {
//            Console.WriteLine("This is base class methods");
//        }
//    }
//    public class FirstDerived : BaseClass
//    {
//        public override void PrintMethod()
//        {
//            Console.WriteLine("This is first derived methods");
//        }
//    }
//    public class SecondDerived : BaseClass
//    {
//        public override void PrintMethod()
//        {
//            Console.WriteLine("This is second derived methods");
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            BaseClass F = new FirstDerived();
//            BaseClass S = new SecondDerived();
//            F.PrintMethod();
//            S.PrintMethod();

//        }
//    }
//}
#endregion
#endregion
#region Method Hiding
// Definition C# also provides the conecpt to hide method from the base class to derived class this concept is also know as 
// method hiding.In method hiding you can hide the implementation of the methods of a base class from the derived class using new keyword.
//using System;
//namespace TestConsoleApp
//{
//    public class BaseClass
//    {
//        public void TodaysDate()
//        {
//            Console.WriteLine(DateTime.Now.ToString());
//        }
//    }
//    public class ChildClass : BaseClass
//    {
//        public new void TodaysDate()
//        {
//            Console.WriteLine("Child class current date" + DateTime.Now.ToString());
//        }
//    }
//    public class program
//    {
//        static void Main()
//        { 
//            ChildClass C = new ChildClass();
//            C.TodaysDate();
//        }
//    }
//}

// Different ways to invoke base class member from derived class
// 1.) Use base Keyword
#region Base Keeyword
//using System;
//namespace TestConsoleApp
//{
//    public class BaseClass
//    {
//        public void TodaysDate()
//        {
//            Console.WriteLine(DateTime.Now.ToString());
//        }
//    }
//    public class ChildClass : BaseClass
//    {

//        public new void TodaysDate()
//        {
//            base.TodaysDate(); 
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {

//            ChildClass C = new ChildClass();
//            C.TodaysDate();
//        }
//    }
//}
#endregion
// 2.)cast child type to parent and invoke hidden member
#region Cast Child type to Parent type
//using System;
//namespace TestConsoleApp
//{
//    public class BaseClass
//    {
//        public void TodaysDate()
//        {
//            Console.WriteLine(DateTime.Now.ToString());
//        }
//    }
//    public class ChildClass : BaseClass
//    {
//        public new void TodaysDate()
//        {
//            Console.WriteLine("Child class current date" + DateTime.Now.ToString());
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            ChildClass C = new ChildClass();
//            ((BaseClass)C).TodaysDate();
//        }
//    }
//}
#endregion
// 3.) ParentClass PC = new ChildClass()
// PC.HiddenMethod();
#region Making Refrence of Parent Class
//using System;
//namespace TestConsoleApp
//{
//    public class BaseClass
//    {
//        public void TodaysDate()
//        {
//            Console.WriteLine(DateTime.Now.ToString());
//        }
//    }
//    public class ChildClass : BaseClass
//    {
//        public new void TodaysDate()
//        {
//            Console.WriteLine("Child class current date" + DateTime.Now.ToString());
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            BaseClass C = new ChildClass();
//           C.TodaysDate();
//        }
//    }
//}
#endregion
#endregion
#region Difference between method overriding and method hiding
/*
    The main difference is method overriding and hiding in method overriding using override keyword into derived class
    and method hiding using new keyword in to derived class method.
 */
//using System;
//namespace TestConsoleApp
//{
//    public class BaseClass
//    {
//        public void HidingMethod()
//        {
//            Console.WriteLine("Base Class hiding method.");
//        }
//        public virtual void OverridingMethod()
//        {
//            Console.WriteLine("Base Class over riding method.");
//        }
//    }
//    public class ChildClass : BaseClass
//    {
//        public new void HidingMethod()
//        {
//            Console.WriteLine("Derived Class hiding method.");
//        }
//        public override void OverridingMethod()
//        {
//            Console.WriteLine("Derived Class Override Method");
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            ChildClass C = new ChildClass();
//            C.HidingMethod();
//            C.OverridingMethod();
//        }
//    }
//}
#endregion
#region Difference between Abstract class and interface
// Difference between abstract and interface
/*
                Abstract                                                     Interface 
    1.we can not create an object of an abstract class             1. we can not create an object of interface 
    2.In an abstract class can have constructor and destructor     2. In interface can not have constructor and destructor
    3.abstarct class does not allow multiple inheritance           3. interface allow multiple inheritance.
    4.an abstract class use as a base class  and implementation    4. in interface only method declaration not implementation
    5.we can declare a member field in abstract class              5. In interface we can not declare member field
    6.an abstract class can not be sealed class
*/
#endregion
#region Struct and Classes
/*
  1.) Struct is a value type and class is a refrence type.
  2.) Struct is storing data into stack and class is storing data into heap.
  3.) Struct is used for small amount of data and classes are used to large amount of data.
  4.) Struct is not allowed parameterless constructor and destructor whears classes are allowed all types 
      of constructor.  
 */

//using System;
//namespace TestConsoleApp
//{
//    public struct MyStruct
//    {
//        public string name;
//        public int age; 
//    }
//    public class MyClass
//    {
//        public string name;
//        public int age;
//    }

//    public class program
//    {
//        static void Main()
//        {
//            MyClass myClass = new MyClass();
//            myClass.age = 23;
//            myClass.name = "shamshad";
//            MyClass myClass1 = myClass;
//            myClass1.age = 24;
//            myClass1.name = "Javed";
//            Console.WriteLine("My name is {0} and age is {1}",myClass.name,myClass.age);
//            /*
//                Here above i made object of the class and assign some value into there class variable and then i make another object
//                of first object and when assign the value of second object and try to get first object value then it will return second object value
//             */
//            MyStruct ST = new MyStruct();
//            ST.age = 25;
//            ST.name = "shamshad";
//            MyStruct ST1 = ST;
//            ST1.age = 26;
//            ST1.name = "Nafis";
//            Console.WriteLine("My name is {0} and age is {1}", ST.name, ST.age);
//            /*
//                Here above i made object of the struct and assign some value in struct variable and then i make another object
//                of first object and when assign the value of second object and try to get first object value then it will return same
//             */
//        }
//    }
//}
#endregion
#region Difference between Value type and refrence type
/*
    ValueType                                               RefrenceType
    1) Value types are stored on the satck                  1) Refrence type are stored in the heap
    2) Value types create a copy of the data when they are  2) Refrence type use the same instance of the data when they are 
       are assigned or passed.                                 assigned or passed.
    3) Value types compare the data by value                3) Refrence type compare the data by refrence.
    4) Value type are immutable which means that they can   4) Refrence type are mutable which means that they can be changes
       not be changed after they are created.                  after they are created.
    5) Value types are used for simple and primitive data   5) Refrence types are used for complex and dynamic data such as 
       such members,booleans and structs.                      objects arrays and classes.
 */
#endregion
#region Interface
// Interface
/*
    1.) We create an interface using interface keyword.interface also contains properties methods delegates but only declaration no implementation
    2.) Interface members are public by default and they don't allow explicit access modifires.
    3.) Interface can not contains fields.
    4.) If class or struct inherits interface it must provide implementation for all interface member.Otherwise we get compile time error.
    5.) A class or struct can inherit more than one interface at that same time.
    
 */
//using System;
//namespace TestConsoleApp
//{
//    interface IStudent
//    {
//        void StudentAge();
//        void StudentName();
//    }
//    interface ITeacher
//    {
//        void TeacherAge();
//        void TeacherName();
//    }
//    public class ClassRoom : IStudent, ITeacher // Multiple inheritance are not allowed in class whears allowed in case of interface
//    {
//        public void StudentAge()
//        {
//            Console.WriteLine("The Student age is 22");
//        }

//        public void StudentName()
//        {
//            Console.WriteLine("The Student name is shamshad");
//        }

//        public void TeacherAge()
//        {
//            Console.WriteLine("The Teacher age is 29");
//        }

//        public void TeacherName()
//        {
//            Console.WriteLine("The Teacher name is Javed");
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            ClassRoom classRoom = new ClassRoom();
//            classRoom.StudentAge();
//            classRoom.StudentName();
//            classRoom.TeacherAge();
//            classRoom.TeacherName(); 
//        }
//    }
//}

/*
 Suppose i have two interface nad both has same method and i want to provide same implementation to both method then i will follow given below
 */

//using System;
//namespace TestConsoleApp
//{
//    interface IInterfaceA
//    {
//        void CommonMethod();
//    }
//    interface IInterfaceB
//    {
//        void CommonMethod();
//    }
//    public class MyClass : IInterfaceA, IInterfaceB
//    {
//        // Implementing method required by both interface
//        public void CommonMethod()
//        {
//            Console.WriteLine("Common method implementation");
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            MyClass myClass = new MyClass();
//            myClass.CommonMethod(); // Common method implementation
//        }
//    }
//}

/*
    Suppose i have two interface with same method signature and implementing those interface in derived class i want to provide different
    implementation to both.
 */
//using System;
//namespace TestConsoleApp
//{
//    interface IInterfaceA
//    {
//        void CommonMethod();
//    }
//    interface IInterfaceB
//    {
//        void CommonMethod();
//    }
//    public class MyClass : IInterfaceA, IInterfaceB
//    {
//        // Explicit implementation of interface A method
//        void IInterfaceA.CommonMethod()
//        {
//            Console.WriteLine("Implementation of interfaceA method");
//        }
//        // Explicit implementation of interface B method
//        void IInterfaceB.CommonMethod()
//        {
//            Console.WriteLine("Implementation of interfaceB method");
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            MyClass obj = new MyClass();
//            // Calling method for IInterface A
//            ((IInterfaceA)obj).CommonMethod(); // OutPut: Implementation for IInterfaceA method

//            // Calling Method for IInterface B
//            ((IInterfaceB)obj).CommonMethod(); //OutPut: Implementation for IInterfaceB method
//        }
//    }
//}
#endregion
#region Explicit interface implementation
// Question: A class inherits from 2 interfaces and both the interfaces have the same method name.How should the class implement the method for both the interface?
//Answer: We are using Explicit Interface Implementation technique to solver this problem
//using System;
//namespace TestConsoleApp
//{
//    interface IStudent
//    {
//        void StudentName();
//    }
//    interface ITeacher
//    {
//        void StudentName(); 
//    }
//    public class MyClass : IStudent,ITeacher
//    {
//        void IStudent.StudentName()
//        {
//            Console.WriteLine("First Method");
//        }
//        void ITeacher.StudentName()
//        {
//            Console.WriteLine("Second Method");
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            MyClass myClass = new MyClass();
//            ((IStudent)myClass).StudentName();
//            ((ITeacher)myClass).StudentName();
//        }
//    }
//}
#endregion
#region Delegates
/*
   Delegate is a variable that hold the refrence of methods or pointer to a function.
   Delegate refers more than on method which signature are same.
   It comes in use when we have to pass method as a parameter.
   A delegate is type safe function pointer. That is it holds a refrence(pointer) to a function.
   The signature of delegate must match the signature of the function, the delegate point to, otherwise it will give compilation error.
   This is reason the delegate called as type safe function.
   A delegate is similar to class.you can create an instance of it and you can pass function as a parameter into delegate constructor.

 */
//using System;
//namespace TestConsoleApp
//{
//    public delegate void printStudentDetailsDelegate(int age, string firstname, string lastname, string address);
//    public class delegateClass
//    {
//        public void printStudentDetails(int age, string firstname, string lastname, string address)
//        {
//            Console.WriteLine("The student age is {0}, firstname is {1}, lastname is {2} and address is {3}",
//                age,firstname,lastname,address);
//        }
//    }
//    public class program
//    {
//        static void Main()
//        {
//            delegateClass DC = new delegateClass();
//            printStudentDetailsDelegate PD = new printStudentDetailsDelegate(DC.printStudentDetails);
//            PD(23, "shamshad", "ahmad", "Mumbai-43");
//        }
//    }
//}

#endregion


// Micro Services

#region What is microservices
/*
    What is Micros services.
    Answer:- Microservices is small loosly coupled distributed service.Each microservice is designed to perform a specific 
    business function and can developed,deployed and scaled independently.It allows to take a large application and decompose and
    break it into easily managable small components with narrowly defined responsibility.
 */
#endregion
#region Benifits of using Microservices Architecture
/*
    Microservices offers benefits like scalibility ease of maintaince technology flexible and improved fault isolation.
 */
#endregion
#region How do microservices communicate with each other
/*
    Microservices communicate through light weight protocol like HTTP/REST messaging queues or grpc.
 */
#endregion
#region what is the difference between monolithic and micro services architecture
/*
 Monolithic architecture involves building an application as tightly coupled single unit. while microservices divide into smaller 
independent components.
 */
#endregion
#region What is API Gateway Pattern?
/*
    API Gateway acts as a single entry point for clients and route requests to appropriate microservices,often handling
    authentication,rate limiting,and caching.
 */
#endregion


// Data Structure Algorithm

#region print revrse string without any reverse function
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = "one two three four five";
//            int length = name.Length; 
//            for (int i = 0; i < name.Length; i++)
//            {
//                Console.Write(name[length-1]);  
//                length = length - 1;
//            }
//        }
//    }
//}
#endregion
#region Multiply one element to another and skip one from another in array
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            int[] arr = { 1, 2, 3, 4 };  // Out put: 24 12 8 6
//            for (int i = 0; i < arr.Length; i++)
//            {
//                int result = 1;
//                for (int j = 0; j < arr.Length; j++)
//                {
//                    if(i==j)
//                    {
//                        continue;
//                    }
//                    result = result * arr[j];
//                }
//                Console.WriteLine(result);
//            }
//        }
//    }
//}
#endregion
#region  Find min and max number from the array
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            int[] array = { 9, 10, 20, 30, 45, 1, 2, 4, 5 };
//            int max = 1;
//            int min = 1;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] > max)
//                {
//                    max = array[i];
//                }
//                if (array[i] < min)
//                {
//                    min = array[i];
//                }
//            }
//            Console.WriteLine("Max Number:"+ max);
//            Console.WriteLine("Min Number:" + min);
//        }
//    }
//}
#endregion
#region Sort Array
//using System;
//namespace TestConsoleApp
//{ 
//    public class Program
//    {
//        static void Main()
//        {
//            int[] array = { 3, 4, 5, 1, 7, 5, 2, 8, 9 };
//            int temp = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = 0; j < array.Length; j++)
//                {
//                    if (array[i] > array[j])
//                    {
//                        temp = array[i];
//                        array[i] = array[j];
//                        array[j] = temp; 
//                    }
//                }
//            }
//            for (int k = 0; k < array.Length; k++)
//            {
//                Console.Write(array[k]);
//            }
//        }
//    }
//}
#endregion
#region Second Largest number from the array
//using System;
//namespace TestConsoleApp
//{
//    public class program
//    {
//        static void Main()
//        {
//            int largest = 0;
//            int second = 0;
//            int[] array = { 1, 2, 3, 4, 5, 8, 9, 5, 6 };
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] > largest)
//                {
//                    second = largest;
//                    largest = array[i];

//                }else if (array[i]>second)
//                {
//                    second = array[i];
//                }
//            }
//            Console.WriteLine(second);
//            Console.WriteLine(largest);

//        }
//    }
//}
#endregion
#region Count Pair from the array
//using System;
//namespace TestConsoleApp
//{
//    public class Program
//    {
//        static void Main()
//        {
//            int[] array = { 32, 34, 56, 34, 56, 78, 78, 89, 34 };
//            int count = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = i+1; j < array.Length; j++)
//                {
//                    if (array[i] == array[j])
//                    {
//                        count++;
//                    }
//                }
//            }
//            Console.WriteLine(count);
//        }
//    }
//}
#endregion

#region count duplicate charector from string
//using System;
//using System.Collections.Generic;

//namespace TestConsoleApp
//{
//    public class program
//    {
//        public static void Main()
//        {
//            var name = "shamshad"; 
//            Dictionary<char,int> charcount = new Dictionary<char, int>();
//            foreach (var item in name)
//            {
//                if (charcount.ContainsKey(item))
//                {
//                    charcount[item]++;
//                }
//                else
//                {
//                    charcount[item] = 1;
//                }
//            }
//            foreach (var pair in charcount)
//            {
//                //if (pair.Value > 1)
//                //{
//                    Console.WriteLine($"{pair.Key}: {pair.Value}");
//                //}
//            }  
//        }
//    }
//}

#endregion

#region count duplicate value from array
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace TestConsoleApp
//{
//    public class program
//    {
//        public static void Main()
//        {
//            int[] number = { 1, 2, 3, 4, 5, 3, 2, 6, 7, 8, 1, 9, 2 };
//            Dictionary<int, int> charcount = new Dictionary<int, int>();
//            foreach (var item in number)
//            {
//                if (charcount.ContainsKey(item))
//                {
//                    charcount[item]++;
//                }
//                else
//                {
//                    charcount[item] = 1;
//                }
//            }
//            foreach (var pair in charcount)
//            {
//                //if (pair.Value > 1)
//                //{
//                Console.WriteLine($"{pair.Key}: {pair.Value}");
//                //}
//            }
//        }
//    }
//}

#endregion

#region compare two string
//using System;
//using System.Collections.Generic;
//using System.Text; 
//namespace TestConsoleApp
//{
//    public class Compare
//    {
//        public bool CompareString(string str1, string str2)
//        {
//            HashSet<char> dic = new();

//            if (str2 == str1)
//                return true;
//            else
//            {
//                foreach (char c in str2)
//                {
//                    dic.Add(c);
//                }
//                for (int i = 0; i < str1.Length; i++)
//                {
//                    if (dic.Contains(str1[i]))
//                        dic.Remove(str1[i]);
//                }
//            }
//            return dic.Count == 0;
//        } 
//    }
//    public class Program
//    {
//        public static void Main()
//        {
//            Compare compare = new Compare();
//            var result = compare.CompareString("h3esallll","hello");
//            Console.WriteLine(result);
//        }
//    }
//}
#endregion
#region  Sort Array
//using System;
//namespace TestConsoleApp
//{
//    public class SortNumber
//    {
//        int[] arr = { 20, 10, 25, 77, 11, 55 };
//        public void sort()
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                int temp;
//                for (int j = i+1; j < arr.Length; j++)
//                {
//                    if (arr[i] > arr[j])
//                    {
//                        temp = arr[i];
//                        arr[i] = arr[j];
//                        arr[j] = temp;
//                    }
//                }
//            }
//            for (int k = 0; k < arr.Length; k++)
//            {
//                Console.WriteLine(arr[k]);
//            }
//        }

//    }
//    public class program
//    {
//        public static void Main()
//        {
//            SortNumber sortNumber = new SortNumber();
//            sortNumber.sort();
//        }
//    }
//}

#endregion
#region
//using System;
//using System.Collections.Generic;

//namespace TestConsoleApp
//{
//    public class program
//    {
//        public static void Main()
//        {
//            int[] arr = { 1,2,3,4,5,6};
//            int[] arr1 = { 2, 4, 6,2 };
//            for (int i = 0; i < arr.Length; i++)
//            {
//                int result=0;
//                for (int j = 0; j < arr1.Length; j++)
//                {
//                    if(arr[i] == arr1[j])
//                    {
//                        if (result > 0)
//                        {
//                            result = result + arr1[j];
//                        }
//                        else {
//                            result = arr[i] + arr1[j];
//                        }
//                    }

//                }
//                if(result>0)
//                {
//                    Console.WriteLine(result);
//                } 
//            }
//        }
//    }
//}
#endregion



// Sql Queries
#region Find highest salary with dens rank in sql
/*
    select * from (
    select emp_name,salary,DENSE_RANK() over (Order by salary desc) as ranking from employees) as k
    where ranking=4
 */
#endregion
#region delete duplicate record from the table
/*
    delete empduplicate from (
    select *,ROW_NUMBER() over (partition by city order by id) rownumber from employee
    ) as duplicateemployee
    where rownumber > 1
 */
#endregion
#region get fourth highest salary with CTE and ranking
/*
    WITH CTE(emp_name,salary,ranking) As 
    (
        select emp_name,salary,DENSE_RANK() over (Order by salary desc) as ranking from employees
    ) 
    select * from CTE where ranking=4
 */
#endregion
#region CTE (Commom Table Expression)
/*
    1.) A common table expression that return a temporary result set.
    2.) The resultset can be declared once and refrenced multiple time in a query
    3.) The CTE is declared WITH Keyword.
    4.) CTE offers the same functinality as view
 */
// CTE Query
/*
    WITH CTE as
    (
	 
		    select * from employee e
		    join Salary s on e.id = s.EmployeeId  
    )
    select * from CTE
 */
#endregion
#region Difference between Storedprocedure and function
/*
 Function (UDF)                                                Stored Procedure
 1.Function must return a value.                               1.StoredProcedure may or not return values.
 2.Function allow only select statement not allow DML          2.StoredProcedure allow both slect and DML Statement
   statement.                                                    such as insert,update and delete
 3.It will allow input parameter does not support out put      3.It can have both input and output parameter.
   parameter.
 4.It will not allow use to try catch block                    4.For exception handling we can use try catch blocks.
 5.Transactions are not allowed within function                5.Can use transaction within functions.
 6.We can use only table variable it will not allowing         6.Can use both variable as well as temporary table.
   temporary table.
 7.Stored Procedure can not be called from function            7.Can be call function from stored procedure.
 8.Functions can be called from select statement.              8.Procedure can not be called from select statement for calling using Execute keyword
 */
/*
 Stored Procedure Syntax

    Create Procedure ProcedureName
    As
    sql_statement
    GO;
 */
/*
    Function Syntax
    create function joinempcolumn
    (
	    @empcontact varchar(10),
	    @empemail varchar(10),
	    @empcity varchar(10)
    )
    returns nvarchar(100)
    as
    Begin
	    return (select @empcontact +' '+ @empemail +' '+ @empcity);
    end

    select dbo.joinempcolumn('8080022944','shamshad0894@gmail.com','Mumbai') as Address
    
 */
#endregion
#region Rank and DensRank
/*
    RANK():- Rank function assign a unique rank to each distinct row in the result set,with tied rows receiving the same rank 
    and leaving gaps in subsequent rank.
    Example:-if two rows tie for first place then the next row will receive the rank of 3.

    Query:- select *,RANK() over (order by salary desc) as ranking from employees
    
    DENSE_RANK():- Dense Rank also assign the rank based on the criteria it does not leave the gap between ranks in case of tied
    rows.This means that if there are ties the next rank will not skip any rank.

    Query:- select *,DENSE_RANK() over (order by salary desc) as ranking from employees
    
 */
#endregion
#region Transaction
/*
    Transaction:- A transaction is set of operation performed and all the operation gauranteed to succeed or fail into unit.
    
    When To Use Transaction:- you should use transaction when several operations must succeed or faild as a unit.
    1. In batch processing where multiple rows must be inserted, updated or deleted as a single unit.
    2. When modifying data in two or more database concurrently.
 */
#endregion

//using System;
//using System.Reflection;

//namespace TestConsoleApp
//{
//    public class program
//    {
//        public static void Main()
//        {
//            Type t = typeof(string);
//            Console.WriteLine("Name : {0}", t.Name);
//            Console.WriteLine("Full Name : {0}", t.FullName);
//            Console.WriteLine("Namespace : {0}", t.Namespace);
//            Console.WriteLine("Base Type : {0}", t.BaseType);
//            Assembly assembly= Assembly.GetExecutingAssembly();
//        }
//    }
//}


//using System;
//namespace CopyToClone
//{
//        public class program
//    {
//        public static void Main()
//        {
//            string[] str1 = { "A", "B", "C", "D" };
//            string[] str2 = new string[4];
//            str1.CopyTo(str2, 0);
//            str2[1] = null; 
//            Console.WriteLine(str2);

//            //string[] str1 = { "A", "B", "C", "D" };
//            //string[] str2 = (string[])str1.Clone();   
//            //Console.WriteLine(str2);

//        }
//    }
//} 

#region called third party api 
//using DocumentFormat.OpenXml.Office2021.DocumentTasks;
//using Newtonsoft.Json; 
//using System.Net.Http;
//using System.Text;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace TestConsoleApp
//{ 
//    public class ApiResponse
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string EmailId { get; set; }
//    }
//    public class CRUD
//    {
//        public CRUD()
//        { 
//        }
//        private readonly HttpClient _httpClient;
//        public CRUD(HttpClient httpClient)
//        {
//            _httpClient = httpClient;
//        }
//        public async Task<ApiResponse> GetAsync(string url)
//        {
//            var response = await _httpClient.GetAsync(url);
//            response.EnsureSuccessStatusCode();
//            var content = await response.Content.ReadAsStringAsync();
//            return JsonConvert.DeserializeObject<ApiResponse>(content);
//        }
//        public async Task<ApiResponse> PostAsync(string url,ApiResponse data)
//        {
//            var json = JsonConvert.SerializeObject(data);
//            var content = new StringContent(json, Encoding.UTF8, "Application/json");
//            var response = await _httpClient.PostAsync(url, content);
//            response.EnsureSuccessStatusCode();
//            var responseContent = await response.Content.ReadAsStringAsync();
//            return JsonConvert.DeserializeObject<ApiResponse>(responseContent);
//        }
//    }
//    public class program
//    {
//        public static void Main()
//        {
//            CRUD cRUD = new CRUD();
//            cRUD.GetAsync("");
//        }
//    }
//}
#endregion

#region
//using DocumentFormat.OpenXml.Wordprocessing;
//using System;
//namespace TestConsoleApp
//{
//    public class program
//    {
//        public static void Main()
//        {
//            //var name = "shamshad";
//            //int length = name.Length;
//            //for (int i = 0; i < name.Length; i++)
//            //{
//            //    Console.Write(name[length - 1]);
//            //    length = length - 1;
//            //}
//            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//            int length = arr.Length;
//            Console.WriteLine(length);
//            for (int i = 0; i < length/2; i++)
//            {
//                //Console.WriteLine("rem"+length);
//                //Console.WriteLine("i" + i);
//                int temp = arr[i];
//                arr[i] = arr[length - 1 - i];
//                arr[length - 1 - i] = temp;
//            }
//            Console.WriteLine("New arry" + string.Join(",", arr));
//        }
//    }
//} 
#endregion

#region
//using System;
//namespace TestConsoleApp
//{
//    public class program
//    {
//        public static void Main()
//        {
//            int[] numbers = { 1, 2, 3,12, 4,11, 5,10, 6, 8, 7 };
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                int temp;
//                for (int j = i+1; j < numbers.Length; j++)
//                {
//                    if (numbers[i] > numbers[j])
//                    {
//                        temp = numbers[i];
//                        numbers[i] = numbers[j];
//                        numbers[j] = temp;
//                    }
//                }
//            }
//            Console.WriteLine("Sorted Array");
//            for (int k = 0; k < numbers.Length; k++)
//            {
//                Console.Write(string.Join(",", numbers[k]));
//            }
//            Console.WriteLine();
//            int length = numbers.Length;
//            for (int i = 0; i < length/2; i++)
//            {
//                int temp = numbers[i];
//                numbers[i] = numbers[length - 1 - i];
//                numbers[length - 1 - i] = temp;
//            }
//            Console.WriteLine("Reverse Array");
//            for (int k = 0; k < numbers.Length; k++)
//            {
//                Console.Write(string.Join(",", numbers[k]));
//            }
//        }
//    }
//}
#endregion

#region
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Test
//{
//    public class program
//    {
//        public static void Main()
//        {
//            var name = "shamshad ahmad";
//            Dictionary<char,int> charCount = new Dictionary<char, int>();

//            foreach (var item in name)
//            { 
//                if(char.IsWhiteSpace(item))
//                {
//                    continue;
//                }
//                if (charCount.ContainsKey(item))
//                {
//                    charCount[item]++;
//                }
//                else
//                {
//                    charCount[item] = 1;
//                }
//            }
//            foreach (var pair in charCount)
//            {
//                Console.WriteLine($"{pair.Key}:{pair.Value}");
//            }
//        }
//    }
//}
#endregion

#region
//using System;
//using System.Collections.Generic;

//namespace TestConsoleApp
//{
//    public class program
//    {
//        public static void Main()
//        {
//            int[] arr = { 1, 2, 3, 4, 5, 4, 3, 4, 5, 2, 7, 8, 9, 6, 9, 6 };
//            Dictionary<int, int> intCount = new Dictionary<int, int>();

//            foreach (var item in arr)
//            {
//                if(intCount.ContainsKey(item))
//                {
//                    intCount[item]++;
//                }
//                else
//                {
//                    intCount[item] = 1;
//                }
//            }
//            foreach (var pair in intCount)
//            {
//                Console.WriteLine($"{pair.Key}:{pair.Value}");
//            }
//        }
//    }
//}
#endregion

#region
//using System;
//using System.Collections.Generic;

//namespace TestConsoleApp
//{
//    public class CompareString
//    {
//        public bool chekString(string str1,string str2)
//        {
//            if(str1==str2)
//            {
//                return true;
//            }
//            HashSet<char> dic = new();
//            foreach (var item in str2)
//            {
//                dic.Add(item);
//            }
//            for (int i = 0; i < str1.Length; i++)
//            {
//                if (dic.Contains(str1[i]))
//                    dic.Remove(str1[i]);
//            }
//            return dic.Count == 0;
//        }
//    }
//    public class program
//    {
//        public static void Main()
//        {
//            CompareString compareString = new CompareString();
//            bool val = compareString.chekString("cordshnrvshdsdsarrr", "coder");
//            Console.WriteLine(val); 
//        }
//    }
//}
#endregion

#region
//using System;
//using System.Collections.Generic;

//namespace Test
//{
//    public class program
//    { 
//        public static void Main()
//        {
//             int a=0,b=1,c;
//            Console.Write("{0} {1} ", a, b);
//            for (int i = 0; i < 10; i++)
//            {
//                c = a + b;
//                Console.Write("{0} ", c);
//                a = b; 
//                b=c;
//            }
//        }
//    }
//}
#endregion




//using System;
//namespace TestConsoleApp
//{
//    public abstract class Animal
//    {
//        public abstract void MakeSound();
//        public void Eat()
//        {
//            Console.WriteLine("Eating......");
//        }
//    }
//    public class Cat : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("Meow.....");
//        }
//    }
//    public class Dog : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("Bhaw Bhaw.....");
//        }
//    }
//    public class program 
//    {
//        public static void Main()
//        { 
//            Cat cat = new Cat();
//            cat.Eat();
//            cat.MakeSound();
//            Dog dog= new Dog();
//            dog.Eat();
//            dog.MakeSound();
//        }

        
//    }
//}









