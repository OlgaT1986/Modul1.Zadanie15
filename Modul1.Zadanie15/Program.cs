using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_Арифметическая прогрессия_");
            ArithProgression arithProgression = new ArithProgression();
            // установка начального значения
            arithProgression.setStart(4);  
            // установка шага
            arithProgression.setStep(2); 
            // вывод значения ариф.прогрессии
            Console.WriteLine(arithProgression.getNext()); 
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            // сброс
            arithProgression.reset(); 
            Console.WriteLine("Сброс до начального значения-");
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine();
            Console.WriteLine("_Геометрическая прогрессия_");
            GeomProgression geom = new GeomProgression();
            geom.setStart(4);
            geom.setStep(2);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            geom.reset(); 
            Console.WriteLine("Сброс до начального значения-");
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}

