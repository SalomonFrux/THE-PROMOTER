using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Employee_Promoter_App
{
   public delegate bool Promoter(Staff stf); //(declaration of the delegate)
    public class Staff
    {
        public string Name { set; get; }
        public int Experience { set; get; }
        public int Age { set; get; }
        public int Attendance { set; get; }

        public static void PromotionMethod( List<Staff> ListOfTheStaff, Promoter IsPromotable) // Using the delegate to change the logic
        {
            //This App can Tell you if a member of your staff is promoted or not based on their experience and more.
            //to make the code below more effective re-usable, i decided to use delegate instead of harcoding.

            //foreach (Staff member in ListOfTheStaff)
            //{
            //    if (member.Experience > 5)

            //    {
            //        Console.WriteLine(member.Name + "Is promoted");
            //    }
            //    else
            //    {
            //        Console.WriteLine(member.Name + "Can not be promoted");
            //    }
            //}


            foreach (Staff member in ListOfTheStaff)  
            {
                if (IsPromotable(member))

                {
                    Console.WriteLine(member.Name + " Is promoted");
                }
                else
                {
                    Console.WriteLine(member.Name + " Can not be promoted");
                }
            }

        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> TheListOfstaff = new List<Staff>();
           
              TheListOfstaff.Add (new Staff { Name = " Sam ", Age = 24, Attendance = 90, Experience = 7 });
              TheListOfstaff.Add( new Staff { Name = " Alina ", Age = 26, Attendance = 60, Experience = 4 });
           
            Promoter promoter = new Promoter(PromoteTheMember);

            Staff.PromotionMethod(TheListOfstaff, promoter);
            Console.Read();

        }
        public static bool PromoteTheMember( Staff menber )
        {
            if(menber.Experience>5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
   
    }
}
