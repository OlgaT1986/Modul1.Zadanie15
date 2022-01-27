using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie15
{
    interface ISeries
    {
        // метод принимает аргументы - начальное значение и шаг
        void setStart(int x); 
        //метод возвращает следующее число
        int getNext(); 
        // метод сбрасывает
        void reset(); 
    }
    // класс реализует интерфейс
    class ArithProgression : ISeries 
    {
        // шаг
        int step;  
        // начальное значение
        int startValue;  
        // следующее значение
        int currentValue;  
        public int getNext()
        {
            // увеличение на шаг
            currentValue += step; 
            // возврат этого числа
            return currentValue;  
        }
        public void reset()
        {
            currentValue = startValue;
        }
        public void setStart(int x)
        {
            // в начальное значение присваиваем х
            startValue = x; 
            currentValue = startValue;
        }
        // метод принимает s (это для шага)
        public void setStep(int s) // метод принимает s
        {
            step = s; 
        }

    }
    class GeomProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }
        public void reset()
        {
            currentValue = startValue;
        }
        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }

}

