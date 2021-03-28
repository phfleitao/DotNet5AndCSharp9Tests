using System;

namespace DotNet5AndCSharp9Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Records - Abordagem 1");
            Console.WriteLine("------------------------------------------------");
            var father = new FamilyMemberApproach1("Pedro", "Henrique", "Leitão");
            var mother = father with { FirstName = "Carina", MiddleName = "dos Santos" };
            var (first, _, last) = father; // o underline pode definir campos que não se necessita

            Console.WriteLine(father.ToString());
            Console.WriteLine(mother.ToString());
            Console.WriteLine($"{first} {last}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Records - Abordagem 2");
            Console.WriteLine("------------------------------------------------");
            var father2 = new FamilyMemberApproach2("Pedro", "Henrique", "Leitão");
            var mother2 = father2 with { FirstName = "Carina", MiddleName = "dos Santos" };
            var (first2, middle2, last2) = father2; 

            Console.WriteLine(father2.ToString());
            Console.WriteLine(mother2.ToString());
            Console.WriteLine($"{first2} {middle2} {last2}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Records - Abordagem 3");
            Console.WriteLine("------------------------------------------------");
            var father3 = new FamilyMemberApproach2("Pedro", "Henrique", "Leitão");
            var mother3 = father3 with { FirstName = "Carina", MiddleName = "dos Santos" };
            var (first3, middle3, last3) = father3;

            Console.WriteLine(father3.ToString());
            Console.WriteLine(mother3.ToString());
            Console.WriteLine($"{first3} {middle3} {last3}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Records - Abordagem - Class + Record Property");
            Console.WriteLine("------------------------------------------------");
            var deliverAdress1 = new Address("Rua A", "45", "Niterói", "RJ", "Brasil");
            var invoice = new Invoice(Guid.NewGuid(), 100.74M, deliverAdress1);
            Console.WriteLine(invoice);

            var deliverAdress2 = deliverAdress1 with { Street = "Rua B", Number = "18" };
            invoice.ChangeDeliverAddress(deliverAdress2);
            Console.WriteLine(invoice);
        }
    }
}
