using System;

namespace CS_Day1
{
    public class Program
    {
        static void Main(String[] args)
        {
            List<Member> member = new List<Member>(){
                new Member{
                    FirstName = "Loc",
                    LastName = "Pham Duc",
                    Gender = "Male",
                    Birth = new DateTime(1999,01,12),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Loc 2",
                    LastName = "Pham Duc",
                    Gender = "Male",
                    Birth = new DateTime(1999,01,12),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "An",
                    LastName = "Nguyen Hai",
                    Gender = "Male",
                    Birth = new DateTime(2004,12,03),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Thai Nguyen",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Nhung",
                    LastName = "Nguyen Hong",
                    Gender = "Female",
                    Birth = new DateTime(2000,08,08),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Thai Binh",
                    IsGraduated = false
                },
            };

            Console.WriteLine("Cau 1: ");
            foreach(Member n in member){
                if(String.Equals(n.Gender,"Male")){
                    Console.WriteLine("{0} {1}", n.FirstName, n.LastName);
                }
            }

            Console.WriteLine("\nCau 2: ");
            int MaxAge = 0;
            foreach(Member n in member){
                if(MaxAge < n.Age){
                    MaxAge = n.Age;
                    Console.WriteLine("{0} {1} {2}", n.FirstName, n.LastName, n.Age);
                    break;
                }
            }

            Console.WriteLine("\nCau 3: ");
            foreach(Member n in member){
                Console.WriteLine("{0} {1}", n.LastName, n.FirstName);
            }

            Console.WriteLine("\nCau 4: ");
            List<Member> LessThan2k = new List<Member>();
            List<Member> GreaterThan2k = new List<Member>();
            List<Member> Equals2k = new List<Member>();

            foreach(Member n in member){
                switch(n.Birth.Year){
                    case < 2000:
                        LessThan2k.Add(n);
                        break;
                    case > 2000:
                        GreaterThan2k.Add(n);
                        break;
                    default:
                        Equals2k.Add(n);
                        break;
                }
            }
            
            Console.WriteLine("Less than 2000:");
            foreach(Member n in LessThan2k){
                Console.WriteLine("\t{0} {1} {2}", n.FirstName, n.LastName, n.Birth.Year);
            }

            Console.WriteLine("\nEqual 2000:");
            foreach(Member n in Equals2k){
                Console.WriteLine("\t{0} {1} {2}", n.FirstName, n.LastName, n.Birth.Year);
            }

            Console.WriteLine("\nGreater than 2000:");
            foreach(Member n in GreaterThan2k){
                Console.WriteLine("\t{0} {1} {2}", n.FirstName, n.LastName, n.Birth.Year);
            }

            Console.WriteLine("\nCau 5: ");
            int i = 0;       
            while(i <= member.Count){
                if(String.Equals(member[i].BirthPlace,"Ha Noi")){
                    Console.WriteLine("{0} {1} {2}", member[i].FirstName, member[i].LastName, member[i].BirthPlace);
                    break;
                }
                i++;
            }
        }
    }
}