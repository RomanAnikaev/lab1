using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Lab1Anikaev
{
    
    public class Student
    {
        //public int plgn[10];//
        public string full_name; //ПІБ
        public string rbn; // номер залікової книжки
        public int course; // курс
        public int[] array = new int[10];//
        public double Amark; // середній бал
        public Student() {
            //Перевірка введення ПІБ
            while (String.IsNullOrEmpty(full_name)) 
                {
                    Console.Write("Enter the Full name: ");
                    full_name = Console.ReadLine();
                foreach (char c in full_name)
                {
                    if (c >= '0' && c <= '9')
                    {
                        full_name = "";
                        break;
                    }
                }
                
            }//Перевірка введення Номеру залікової книжки
            while (String.IsNullOrEmpty(rbn))
            {
                Console.Write("Enter the RBN: ");
                rbn = Console.ReadLine();
                foreach (char c in rbn)
                {
                    if (!(c >= '0' && c <= '9'))
                    {
                        rbn = "";
                        break;
                    }
                }

            }
            //Введення Курсу
            Console.Write("Enter the Сourse: ");
            course = Convert.ToInt32(Console.ReadLine());
            //Формування масиву оцінок з предметів 
 
        }
        public void get_grd()
        {
            int sum = 0;
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(60, 100);
            }
            foreach (int i in array) sum += i; //Сума всіх оцінок
            Amark = sum / 10;
        }

    }
    
    public class Program
    {
        static int ch_sub;//обраний предмет
        static void Subjects()//Показати список предметів
        {
            Console.WriteLine("1 - : Math");
            Console.WriteLine("2 - : Art");
            Console.WriteLine("3 - : Biology");
            Console.WriteLine("4 - : History");
            Console.WriteLine("5 - : English");
            Console.WriteLine("6 - : Music");
            Console.WriteLine("7 - : Geography");
            Console.WriteLine("8 - : Economics");
            Console.WriteLine("9 - : Science");
            Console.WriteLine("10 - : Technology");
            Console.WriteLine("Press the key:");
            Console.ReadKey();
        }
        static int Method1() //Встановити оцінку по предмету
        {
            int grd;//оцінка

            Console.Write("Choose subject number from 1 to 10: ");
            ch_sub = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the grade: ");
            grd = Convert.ToInt32(Console.ReadLine());
            return grd;
        }
        static void Method2() //Отримати оцінку з даного предмету
        {
            Console.Write("Choose subject number from 1 to 10: ");
            ch_sub = Convert.ToInt32(Console.ReadLine());
        }
        static int[] Method3(int[] arr2, int[] arr3)
        {
            int[] arrayx = new int[10];//
            for(int i = 0; i < 10; i++)
            {
                arrayx[i] = arr2[i] - arr3[i];
            }
            return arrayx;
        }
         static void ToString(string y1, string y2, int y3, double y4)
        {
            Object x3 = y3;
            string X3 = x3.ToString();
            Object x4 = y4;
            string X4 = x4.ToString();
            string tostring = "";
            tostring = "Student: " + y1 + " " + y2 + ", Course " + X3 + "\nAverage mark - " + X4;
            Console.WriteLine(tostring);

        }
        static void Main()
        {
            //Перший студент
            Student st1 = new Student();
            st1.get_grd();

            int exit = 0;
            while(exit != 4)
            {
                //exit = 0;
                Console.Clear();//очищення екрану
                //Показати список предметів
                Console.WriteLine("Show list of subjects -> 1");
                //Встановити оцінку по прдмету
                Console.WriteLine("If you want to set a grade for a subject -> 2");
                //Отримати оцінку з даного предмету
                Console.WriteLine("If you want to sea the grade for a subject -> 3");
                //Перейти до другого студента
                Console.WriteLine("If you want to move to the second student -> 4");
                Console.Write("Enter the number:");
                exit = Convert.ToInt32(Console.ReadLine());

                Console.Clear();//очищення екрану
                if (exit == 1) Subjects();
                else if (exit == 2)
                {
                    int arr = Method1();
                    st1.array[ch_sub - 1] = arr;
                }
                else if (exit == 3)
                {
                    Method2();
                    Console.WriteLine($"Grade of this subject: {st1.array[ch_sub - 1]}");
                    Console.WriteLine("Press the key:");
                    Console.ReadKey();
                }
            }
            //Другий студент
            Student st2 = new Student();
            st2.get_grd();

            exit = 0;
            while (exit != 4)
            {
                //exit = 0;
                Console.Clear();//очищення екрану
                //Показати список предметів
                Console.WriteLine("Show list of subjects -> 1");
                //Встановити оцінку по прдмету
                Console.WriteLine("If you want to set a grade for a subject -> 2");
                //Отримати оцінку з даного предмету
                Console.WriteLine("If you want to sea the grade for a subject -> 3");
                //Перейти до другого студента
                Console.WriteLine("If you want to compare two students -> 4");
                Console.Write("Enter the number:");
                exit = Convert.ToInt32(Console.ReadLine());

                Console.Clear();//очищення екрану
                if (exit == 1) Subjects();
                else if (exit == 2)
                {
                    int arr = Method1();
                    st2.array[ch_sub - 1] = arr;
                }
                else if (exit == 3)
                {
                    Method2();
                    Console.WriteLine($"Grade of this subject: {st2.array[ch_sub - 1]}");
                    Console.WriteLine("Press the key:");
                    Console.ReadKey();
                }
            }
            ToString(st1.full_name, st1.rbn, st1.course, st1.Amark);
            ToString(st2.full_name, st2.rbn, st2.course, st2.Amark);

            Console.WriteLine("The result of comparing two students: ");
            int[] arrx1 = new int[10];//
            arrx1 = Method3(st1.array,st2.array);
            Console.WriteLine("Math - {0}", arrx1[0]);
            Console.WriteLine("Art - {0}", arrx1[1]);
            Console.WriteLine("Biology - {0}", arrx1[2]);
            Console.WriteLine("History - {0}", arrx1[3]);
            Console.WriteLine("English - {0}", arrx1[4]);
            Console.WriteLine("Music - {0}", arrx1[5]);
            Console.WriteLine("Geography - {0}", arrx1[6]);
            Console.WriteLine("Economics - {0}", arrx1[7]);
            Console.WriteLine("Science - {0}", arrx1[8]);
            Console.WriteLine("Technology - {0}", arrx1[9]);
            Console.Write("Press the key:");
            Console.ReadKey();

        }

    }
}
