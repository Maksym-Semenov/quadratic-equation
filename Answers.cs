using System;
namespace quadratic_equation
{
    public class Answers
    {
        public string GetAnswer(double[] array)
        {
            if (array == null)
               return "Уравнение не имеет рациональных корней";
            else if (array[0] != array[1])
               return "Дискриминант больше 0, поэтому есть два решения: X1 = {array[0]}, X2 = {array[1]}";
            else if (array[0] == array[1])
               return "Дискриминант равен 0, поэтому есть два одинаковых решения: X1 = X2 = {array[0]}";
        }
    }
}
