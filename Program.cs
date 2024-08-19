namespace StructureArray_july_190824
{
    struct student
    {
        public int roll;
        public string name;
        public int totalMarks;

        public void ShowStudent()
        {
            //Console.WriteLine("Roll="+roll+" Name="+name+" Total Marks="+totalMarks);
            Console.WriteLine($"Roll ={roll} Name = {name} Total Marks = {totalMarks}");//string interpolation
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region How to use dateTime
            //DateTime dt = new DateTime(2006, 08, 19);
            //Console.WriteLine("Year ="+dt.Year);
            //Console.WriteLine("month =" + dt.Month);
            //// DateTime dt1 = DateTime.Parse( DateTime.Now.ToShortDateString());
            //DateTime dt1 = DateTime.Now.Date;
            //Console.WriteLine(dt1);
            //var tp = dt1 - dt;

            //Console.WriteLine(dt1-dt);
            //if (tp.Days<6570)
            //{
            //    Console.WriteLine("under 18 not allowed...");
            //}
            //else
            //{
            //    Console.WriteLine("welcome");
            //}
            #endregion

            //student s1,s2;
            //Console.WriteLine("Enter roll number, name and total marks of student 1");
            //s1.roll = int.Parse(Console.ReadLine());
            //s1.name = Console.ReadLine();
            //s1.totalMarks= int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter roll number, name and total marks of student 2");
            //s2.roll = int.Parse(Console.ReadLine());
            //s2.name = Console.ReadLine();
            //s2.totalMarks = int.Parse(Console.ReadLine());
            //s1.ShowStudent();
            //s2.ShowStudent();

            //int[] x = new int[5];
            //x[0] = 999;
            //x[1] = 888;
            //x[2] = 333;
            //x[3] = 111;
            //x[4] = 555;
            //x[3].ToString();
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}
            ///---------------------------------------------------//
            student[] ss = new student[5];
            Console.WriteLine("Enter roll name and total Marks of 5 students");

            for (int i = 0; i < ss.Length; i++)
            {
                ss[i].roll = int.Parse(Console.ReadLine());//roll read
                ss[i].name = Console.ReadLine();//name read
                ss[i].totalMarks= int.Parse(Console.ReadLine());//total marks read
            }

            //show all students 

            for (int i = 0; i < ss.Length; i++)
            {
                ss[i].ShowStudent();
            }
            //topper logic
          student  maxx = ss[0];

            for (int i = 1; i < ss.Length; i++)
            {
                if (maxx.totalMarks < ss[i].totalMarks)
                {
                    maxx = ss[i];
                }
            }

            Console.WriteLine("Topper student is :");
            maxx.ShowStudent();
        }
    }
}
