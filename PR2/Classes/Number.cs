using System.Windows;

namespace PR2
{
    public class Number
    {
        public int number { get; set; }
        public Number(int number)
        {
            this.number = number;
        }
        public void Check()
        {
            int multiplication = 1;
            int[] numbers = new int[number.ToString().Length];
            int numberEx = number;
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = numberEx % 10;
                numberEx = (numberEx - numberEx % 10)/10;
                multiplication *= numbers[x];
            }
            if (multiplication * 3 == number) MessageBox.Show("Утроенное произведение цифр числа равно числу");
            else MessageBox.Show("Утроенное произведение цифр числа не равно числу");
        }
    }
}