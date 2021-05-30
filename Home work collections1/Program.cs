using System;
using System.Collections.Generic;

namespace Home_work_collections1
{
    class Student
    {
        private string surname;
        private int courseOfStudy;
        private Guid bookNum;


        public Guid BookNum
        {
            get { return bookNum; }
            set { bookNum = value; }
        }


        public int CourseOfStudy
        {
            get { return courseOfStudy; }
            set { courseOfStudy = value; }
        }


        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public Student(string surname, int courseOfStudy, Guid bookNum)
        {
            Surname = surname;
            CourseOfStudy = courseOfStudy;
            BookNum = bookNum;
        }
        public virtual void Print()
        {
            Console.WriteLine($"фамилия:{surname}, курс обучения:{courseOfStudy}, номер зачетной книги:{bookNum}");
        }

    }
    class Aspirant : Student
    {
        private string  candidate;

        public string  Candidate
        {
            get { return candidate; }
            set { candidate = value; }
        }
        public Aspirant(string candidate, string surname, int courseOfStudy, Guid bookNum) : base(surname, courseOfStudy, bookNum)
        {
            Candidate = candidate;
        }
        public override void Print()
        {
            Console.WriteLine($"фамилия:{Surname}, курс обучения:{CourseOfStudy}, номер зачетной книги:{BookNum}, desertacia:{candidate}");
        }

    }
    class Program
    {
        public static void Display()
        {
            Console.WriteLine("1)Добавить Студента");
            Console.WriteLine("2)Добавить Аспиранта");
            Console.WriteLine("3)Вывести количество студентов");
            Console.WriteLine("4)Вывести количество аспирантов");
            Console.WriteLine("5)Вывести список всех студентов");
            Console.WriteLine("6)Вывести список всех аспирантов");
            Console.WriteLine("7)Вывести студента по порядковому индексу");
            Console.WriteLine("8)Вывести аспиранта по порядковому индексу");
            Console.WriteLine("9)Удаление студента по порядковому индексу");
            Console.WriteLine("10)Удаление аспиранта по порядковому индексу");
            Console.WriteLine("11)Exit");
        }
        static void Main(string[] args)
        {
            bool temp = false;
            bool temp1 = false;
            List<Student> studentsList = new List<Student>();
            LinkedList <Student> studentsLink= new LinkedList<Student>();
            List<Aspirant> aspirantsList = new List<Aspirant>();
            LinkedList<Aspirant> aspirantsLink = new LinkedList<Aspirant>();

            do
            {
                Display();
                do
                {
                    Console.Write("Укажите пункт:");
                    string userChoise = Console.ReadLine();
                    switch (userChoise)
                    {
                        case "1":
                            {
                                Console.WriteLine("Укажите фамилию студента");
                                string surname = AskSurname();
                                Console.WriteLine("Укажите курс обучения студента");
                                int courseOfStudy = Num();
                                studentsList.Add(new Student(surname, courseOfStudy, Guid.NewGuid()));
                                studentsLink.AddLast(new Student(surname, courseOfStudy, Guid.NewGuid()));
                                break;
                            }
                        case "2":
                            {


                                Console.WriteLine("Укажите фамилию аспиранта");
                                string surname = AskSurname();
                                Console.WriteLine("Укажите курс обучения аспиранта");
                                int courseOfStudy = Num();
                                Console.WriteLine("Введите десертацию:");
                                string candidate = Console.ReadLine();
                                aspirantsList.Add(new Aspirant(candidate, surname, courseOfStudy, Guid.NewGuid()));
                                aspirantsLink.AddLast(new Aspirant(candidate, surname, courseOfStudy, Guid.NewGuid()));
                                break;
                            }
                        case "3":
                            {
                                int studentQuantityList = studentsList.Count;
                                int studentQuantityLink = studentsLink.Count;
                                Console.WriteLine($"Количество студентов по методу ArrayList:{studentQuantityList}");
                                Console.WriteLine($"Количество студентов по методу LinkedList:{studentQuantityLink}");
                                break;
                            }
                        case "4":
                            {
                                int aspirantQuantityList = aspirantsList.Count;
                                int aspirantQuantityLink = aspirantsLink.Count;
                                Console.WriteLine($"Количество аспирантов по методу ArrayList:{aspirantQuantityList}");
                                Console.WriteLine($"Количество аспирантов по методу LinkedList:{aspirantQuantityLink}");
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Вывод списка студентов по методу ArrayList:");
                                foreach (Student list in studentsList)
                                {
                                    list.Print();
                                }
                                Console.WriteLine("Вывод списка студентов по методу LinkedList:");
                                foreach (Student link in studentsLink)
                                {
                                    link.Print();
                                }
                                break;
                            }
                        case "6":
                            {
                                Console.WriteLine("Вывод списка аспирантов по методу ArrayList:");
                                foreach (Student list in aspirantsList)
                                {
                                    list.Print();
                                }
                                Console.WriteLine("Вывод списка аспирантов по методу LinkedList:");
                                foreach (Student link in aspirantsLink)
                                {
                                   link.Print();
                                }
                                break;
                            }
                        case "7":
                            {
                                if (studentsList.Count == 0)
                                {
                                    Console.WriteLine("Студентов нет.");
                                }
                                else if (studentsList.Count != 0)
                                {


                                    Console.WriteLine("Укажите индекс студента:");
                                    int studentIndex = Index();
                                    if (studentsList[studentIndex] == null)
                                    {
                                        Console.WriteLine("Такого студента нет.");
                                    }
                                    else
                                    {
                                        studentsList[studentIndex].Print();
                                    }
                                }

                                break;

                            }
                        case "8":
                            {
                                if (aspirantsList.Count == 0)
                                {
                                    Console.WriteLine("Аспирантов нет.");
                                }
                                else if (aspirantsList.Count != 0)
                                {
                                    Console.WriteLine("Укажите индекс аспиранта:");
                                    int aspirantIndex = Index();
                                    if (aspirantsList[aspirantIndex] == null)
                                    {
                                        Console.WriteLine("Такого аспиранта нет.:");
                                    }
                                    else
                                    {
                                        aspirantsList[aspirantIndex].Print();
                                    }
                                }
                                break;
                            }
                        case "9":
                            {
                                if (studentsList.Count == 0)
                                {
                                    Console.WriteLine("Студентов нет.");
                                }
                                else if (studentsList.Count != 0)
                                {
                                    Console.WriteLine("Укажите индекс студента, котрого хотите удалить:");
                                    int studentIndex = Index();
                                    studentsList.RemoveAt(studentIndex);


                                    Console.WriteLine($"Студент с индексом {studentIndex} удалён.");
                                }
                                break;
                            }
                        case "10":
                            {
                                if (aspirantsLink.Count == 0)
                                {
                                    Console.WriteLine("Аспирантов нет.");
                                }
                                else if (aspirantsLink.Count != 0)
                                {
                                    Console.WriteLine("Укажите индекс аспиранта, котрого хотите удалить:");
                                    int aspirantIndex = Index();
                                    aspirantsList.RemoveAt(aspirantIndex);
                                    Console.WriteLine($"Аспирант с индексом {aspirantIndex} удалён.");
                                }
                                break;
                            }
                        case "11":
                            {
                                temp1 = true;
                                temp = true;
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Error");
                                Display();
                                break;
                            }
                    }

                } while (temp1 == false);


            } while (temp == false);
            Console.WriteLine("До свидания.");
            Console.ReadKey();
        }
        static int Num()
        {
            int num = 0;
            for (; ; )
            {
                string read1 = Console.ReadLine();

                int.TryParse(read1, out num);
                if (num <= 0)
                {
                    Console.WriteLine("Не правильно, укажите правильную информацию.");
                }
                else
                {
                    break;
                }
            }
            return num;

        }
        static int Index()
        {
            int num = 0;
            for (; ; )
            {
                string read1 = Console.ReadLine();

                int.TryParse(read1, out num);
                if (num < 0)
                {
                    Console.WriteLine("Не правильно, укажите правильную информацию.");
                }
                else
                {
                    break;
                }
            }
            return num;

        }
        static string AskSurname()
        {
            bool checkerName = true;
            string personName = "";
            do
            {
                personName = Console.ReadLine();

                for (int i = 0; i < personName.Length; i++)
                {
                    char element = personName[i];

                    if (!Char.IsLetter(element))
                    {
                        checkerName = false;
                        Console.WriteLine("Не корректная информация, укажите правильно: ");
                        break;
                    }
                    else
                    {
                        checkerName = true;
                    }
                }

                if (personName.Length < 1)
                {
                    Console.WriteLine("Не корректная информация, укажите правильно:");
                    checkerName = false;
                }
            }
            while (checkerName == false);

            return personName;
        }
    }
}
