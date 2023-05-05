using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public class Student_Info
        {
            public string name;
            public int roll_no;
            public float cGPA;
            public int matricMarks;
            public int fscMarks;
            public int ecatMarks;
            public string homeTown;
            public string isHostile;
            public string isTakingScholarship;
            public Student_Info(string name,int roll_no,float cGPA,int matricMarks,int fscMarks,int ecatMarks,string homeTown,string isHostile, string isTakingScholarship)
            {
                this.name = name;
                this.roll_no = roll_no;
                this.cGPA = cGPA;
                this.matricMarks = matricMarks;
                this.fscMarks = fscMarks;
                this.ecatMarks = ecatMarks;
                this.homeTown = homeTown;
                this.isHostile = isHostile;
                this.isTakingScholarship = isTakingScholarship;
            }
        }
        static void Main(string[] args)
        {
            string name, homeTown, isHostile, isTakingScholarship;
            int roll_no, matricMarks, fscMarks, ecatMarks;
            float cGPA;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Roll No: ");
            roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cGPA: ");
            cGPA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Matric Marks: ");
            matricMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc Marks: ");
            fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat Marks: ");
            ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Home Town: ");
            homeTown = Console.ReadLine();
            Console.WriteLine("Enter if Hostile (yes or no): ");
            isHostile = Console.ReadLine();
            Console.WriteLine("Enter if Already Taking Scholarship (yes or no): ");
            isTakingScholarship = Console.ReadLine();
            Student_Info data = new Student_Info(name, roll_no, cGPA, matricMarks, fscMarks, ecatMarks, homeTown, isHostile, isTakingScholarship);
            bool isEligible = isEligible_for_scholarship(fscMarks, ecatMarks, isHostile, isTakingScholarship);
            if (isEligible==true)
            {
                Console.WriteLine("The Student is Eligible for Schlarship. ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The Student is not Eligible for Schlarship. ");
                Console.ReadKey();
            }
        }
       static bool isEligible_for_scholarship(int fscMarks, int ecatMarks, string isHostile, string isTakingscholarship)
        {
            bool flag;
            float merit = (fscMarks * 0.80f) + (ecatMarks * 0.40f);
            if (merit>=80 && isTakingscholarship == "no" && isHostile == "yes")
            {
                flag = true;
            }
            flag = false;
            return flag;
        }

    }
}
