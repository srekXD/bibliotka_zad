using bibliotka.Implementation;
using bibliotka.Models;
using System.Linq.Expressions;

namespace bibliotka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kniga kniga=new Kniga();
            KnigiMqsto knigiMqsto=new KnigiMqsto();

            KnigaRepo knigaRepo = new KnigaRepo();
            KnigiMqstoRepo knigiMqstoRepo = new KnigiMqstoRepo();
            Console.WriteLine("ko sa praim la");
            Console.WriteLine("1 e za sazdavane");
            Console.WriteLine("2 e za cetene");
            Console.WriteLine("3 e za ubdeitvane");
            Console.WriteLine("4 e za iztrivane");
            int edno = int.Parse(Console.ReadLine());
            if (edno==1)
            {

                Console.WriteLine("ime Kniga ");
                kniga.Name = Console.Read();
                Console.WriteLine("ime pisatel ");
                kniga.Pisatel= Console.Read();
                Console.WriteLine("broi stranici ");
                kniga.Stranici = Console.Read();
                Console.WriteLine("Otdel na rafta ot a do z ");
                string ot = Console.Read();
                int nomerbukvi = ot.Length;
                if (nomerbukvi!=1)
                {
                    return NewArrayExpression("samo ot a do z");
                }
                else
                {
                    knigiMqsto.OtdelPisatel = ot;
                }
                Console.WriteLine("red ");
                knigiMqsto.Red= Console.Read();

                Console.WriteLine("nomer ");
                knigiMqsto.Nomer = Console.Read();
                knigaRepo.Sazdai(kniga);
                knigiMqstoRepo.Sazdai(knigiMqsto);

            }
            else if (edno == 2)
            {
                Console.WriteLine("koq kniga po id iskas");
                int i_d=int.Parse(Console.ReadLine());
                Kniga kniga1 = knigaRepo.VzemiId(i_d);
                KnigiMqsto knigiMqsto1 = knigiMqstoRepo.VzemiId(i_d);
                if (kniga1 != null && knigiMqsto1 != null)
                {

                
                Console.WriteLine($"id {kniga1.KnigaID}");
                Console.WriteLine($"ime {kniga1.Name}");
                Console.WriteLine($"aftor {kniga1.Pisatel}");
                Console.WriteLine($"broi stranici {kniga1.Stranici}");
                Console.WriteLine($"otdel {knigiMqsto1.OtdelPisatel}");
                Console.WriteLine($"red {knigiMqsto1.Red}");
                Console.WriteLine($"nomer {knigiMqsto1.Nomer}");
                }
                else
                {
                    Console.WriteLine("namq takav laaaaa");
                }
            }
            else if (edno == 3)
            {
                Console.WriteLine("koq kniga po id iskas");
                int i_d = int.Parse(Console.ReadLine());
                Kniga kniga1 = knigaRepo.VzemiId(i_d);
                KnigiMqsto knigiMqsto1 = knigiMqstoRepo.VzemiId(i_d);
                if (kniga1!=null&&knigiMqsto1!=null)
                {
                    Console.WriteLine("ime Kniga ");
                    kniga.Name = Console.Read();
                    Console.WriteLine("ime pisatel ");
                    kniga.Pisatel = Console.Read();
                    Console.WriteLine("broi stranici ");
                    kniga.Stranici = Console.Read();
                    Console.WriteLine("Otdel na rafta ot a do z ");
                    string ot = Console.Read();
                    int nomerbukvi = ot.Length;
                    if (nomerbukvi != 1)
                    {
                        return NewArrayExpression("samo ot a do z");
                    }
                    else
                    {
                        knigiMqsto.OtdelPisatel = ot;
                    }
                    Console.WriteLine("red ");
                    knigiMqsto.Red = Console.Read();

                    Console.WriteLine("nomer ");
                    knigiMqsto.Nomer = Console.Read();
                    knigaRepo.Sazdai(kniga);
                    knigiMqstoRepo.Sazdai(knigiMqsto);
                }
                else
                {
                    Console.WriteLine("namq takav laaaaa");
                }

            }
            else if (edno == 4)
            {
                Console.WriteLine("koq kniga po id iskas");
                int i_d = int.Parse(Console.ReadLine());
                Kniga kniga1 = knigaRepo.VzemiId(i_d);
                KnigiMqsto knigiMqsto1 = knigiMqstoRepo.VzemiId(i_d);
                if (kniga1 != null && knigiMqsto1 != null)
                {
                    knigaRepo.Iztri(kniga1);
                    knigiMqstoRepo.Iztri(knigiMqsto1);
                }
                else
                {
                    Console.WriteLine("namq takav laaaaa");
                }

            }


        }
    }
}