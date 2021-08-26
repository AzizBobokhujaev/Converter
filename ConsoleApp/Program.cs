using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLine("----------HomeWork_1----------");
            Converter cnvrt = new Converter(10.32, 13.30, 0.1525);

            PrintLine("Выберите валюту: ");
            PrintLine("a-SOM\nb-USD\nc-EUR\nd-RUB");
            string text = Console.ReadLine();
            switch (text)
            {
                case "a":
                    {
                        Print("Введите сумму(в сомони): ");
                        double SOM = Convert.ToDouble(Console.ReadLine());
                        PrintLine("Для конвертации сомони в доллар нажмите - 1");
                        PrintLine("Для конвертации сомони в евро нажмите - 2");
                        PrintLine("Для конвертации сомони в рубль нажмите - 3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        switch (a)
                        {
                            case 1: PrintLine($"{SOM} сомони = {cnvrt.SomToUsd(SOM)} доллар"); break;
                            case 2: PrintLine($"{SOM} сомони = {cnvrt.SomToEur(SOM)} евро"); break;
                            case 3: PrintLine($"{SOM} сомони = {cnvrt.SomToRub(SOM)} рубль"); break;
                            default: PrintLine("Упс!!!Нажали не ту кнопку"); break;
                        }
                    }
                    break;
                case "b":
                    {
                        Print("Введите сумму(в долларах): ");
                        double USD = Convert.ToDouble(Console.ReadLine());
                        PrintLine("Для конвертации доллара в сомони нажмите - 1");
                        PrintLine("Для конвертации доллара в евро нажмите - 2");
                        PrintLine("Для конвертации доллара в рубль нажмите - 3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        switch (a)
                        {
                            case 1: PrintLine($"{USD} доллар = {cnvrt.UsdToSom(USD)} сомони"); break;
                            case 2: PrintLine($"{USD} доллар = {cnvrt.UsdToEur(USD)} евро"); break;
                            case 3: PrintLine($"{USD} доллар = {cnvrt.UsdToRub(USD)} рубль"); break;
                            default: PrintLine("Упс!!!Нажали не ту кнопку"); break;
                        }
                    }
                    break;
                case "c":
                    {
                        Print("Введите сумму(в евро): ");
                        double EUR = Convert.ToDouble(Console.ReadLine());
                        PrintLine("Для конвертации евро в сомони нажмите - 1");
                        PrintLine("Для конвертации евро в доллар нажмите - 2");
                        PrintLine("Для конвертации евро в рубль нажмите - 3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        switch (a)
                        {
                            case 1: PrintLine($"{EUR} евро = {cnvrt.EurToSom(EUR)} сомони"); break;
                            case 2: PrintLine($"{EUR} евро = {cnvrt.EurToUsd(EUR)} доллар"); break;
                            case 3: PrintLine($"{EUR} евро = {cnvrt.EurToRub(EUR)} рубль"); break;
                            default: PrintLine("Упс!!!Нажали не ту кнопку"); break;
                        }
                    }
                    break;
                case "d":
                    {
                        Print("Введите сумму(в рублях): ");
                        double RUB = Convert.ToDouble(Console.ReadLine());
                        PrintLine("Для конвертации рубля в сомони нажмите - 1");
                        PrintLine("Для конвертации рубля в доллар нажмите - 2");
                        PrintLine("Для конвертации рубля в евро нажмите - 3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        switch (a)
                        {
                            case 1: PrintLine($"{RUB} рубль = {cnvrt.RubToSom(RUB)} сомони"); break;
                            case 2: PrintLine($"{RUB} рубль = {cnvrt.RubToUsd(RUB)} доллар"); break;
                            case 3: PrintLine($"{RUB} рубль = {cnvrt.RubToEur(RUB)} евро"); break;
                            default: PrintLine("Упс!!!Нажали не ту кнопку"); break;
                        }
                    }
                    break;
                default:
                    Print("Введено неверное значение: Error"); break;}
            PrintLine("----------HomeWork_2----------");
            Employee employee = new Employee();
            employee.ShowListOfExperience();
            System.Console.Write("Введите имю: ");
            employee.Name = Console.ReadLine();
            System.Console.Write("Введите фамилию: ");
            employee.LastName = Console.ReadLine();
            System.Console.Write("Введите профессию: ");
            employee.Position = Console.ReadLine();
            System.Console.Write("Введите стаж рфботы: ");
            employee.Experience = int.Parse(Console.ReadLine());
            employee.GetInfo();
            employee.ShowoSalary();
            Console.WriteLine($"Зарплата с учетом стажа работы = " + employee.PlusExperience());
            employee.ShowTax();
        }
        public static void PrintLine(string text)
        {
            System.Console.WriteLine(text);
        }
        public static void Print(string text)
        {
            System.Console.Write(text);
        }
    }
    public class Converter

    {
        public double USD { get; set; }
        public double EUR { get; set; }
        public double RUB { get; set; }
        public Converter()
        {

        }
        public Converter(double usd, double eur, double rub)
        {
            this.USD = usd;
            this.EUR = eur;
            this.RUB = rub;
        }
        //Somoni
        public double SomToUsd(double som)
        {
            return som / USD;
        }
        public double SomToEur(double som)
        {
            return som / EUR;
        }
        public double SomToRub(double som)
        {
            return som / RUB;
        }
        //USDollar              
        public double UsdToSom(double usd)
        {
            return usd * USD;
        }
        public double UsdToEur(double usd)
        {
            return usd * (USD / EUR);
        }
        public double UsdToRub(double usd)
        {
            return usd * (USD / RUB);
        }
        //Euro
        public double EurToSom(double eur)
        {
            return eur * EUR;
        }
        public double EurToUsd(double eur)
        {
            return eur * (EUR / USD);
        }
        public double EurToRub(double eur)
        {
            return eur * (EUR / RUB);
        }
        //Rubl
        public double RubToSom(double rub)
        {
            return rub * RUB;
        }
        public double RubToUsd(double rub)
        {
            return rub * (RUB / USD);
        }
        public double RubToEur(double rub)
        {
            return rub * (RUB / EUR);
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }
        public Employee(string Name, string LastName, string position, int experience)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Position = position;
            this.Experience = experience;
        }
        private static string[] PositionArr = { "Программист", "Экономисть", "Врач", "Уборщик", "Менеджер", "Учитель", "Водитель", "Юрист", "Маршедр", "Охрана" };
        private static int[] salary = { 1200, 3000, 2300, 1500, 2700, 1234, 4134, 1340, 1234, 5435 };
        private static int[] ExperienceArr = { 0, 100, 200, 300, 400, 500, 600, 700, 800, 900 };
        public void GetInfo()
        {
            System.Console.WriteLine($"Должность: {Position}\nИмя: {Name}\nФамилия: {LastName}");
        }
        public int PlusExperience()
        {
            int sum = 0;
            for (int i = 0; i < ExperienceArr.Length; i++)
            {
                if (PositionArr[i] == Position)
                {
                    sum += salary[i];
                }
                if (Experience > ExperienceArr.Length - 1 && i < 1)
                {
                    sum += ExperienceArr[ExperienceArr.Length - 1];
                }
                else if (i == Experience)
                {
                    sum += ExperienceArr[i];
                }
            }
            return sum;
        }
        public Employee() { }
        public void ShowListOfExperience()
        {
            System.Console.Write("Список профессий: ");
            for (int i = 0; i < PositionArr.Length; i++)
            {
                if (i == PositionArr.Length - 1)
                {
                    System.Console.Write(PositionArr[i] + " ");
                }
                else
                {
                    System.Console.Write(PositionArr[i] + ", ");
                }
            }
            System.Console.WriteLine();
        }
        public void ShowoSalary()
        {
            for (int i = 0; i < PositionArr.Length; i++)
            {
                if (PositionArr[i] == Position)
                {
                    System.Console.WriteLine($"У {PositionArr[i]}а зарплата = {salary[i]}");
                }
            }
        }
        public void ShowTax()
        {
            double salary = 0;
            for (int i = 0; i < PositionArr.Length; i++)
            {
                if (PositionArr[i] == Position)
                {
                    salary += Employee.salary[i];
                }
                if (Experience > ExperienceArr.Length - 1 && i < 1)
                {
                    salary += ExperienceArr[ExperienceArr.Length - 1];
                }
                else if (i == Experience)
                {
                    salary += ExperienceArr[i];
                }
            }
            Console.WriteLine($"Размер зарплаты учитывая 13%({salary * 0.13} сомон) налога и 1%({salary * 0.01} сомон) пенсионного фонда с общей суммы");

            Console.WriteLine($"Выплате: {salary - ((salary * 0.13) + (salary * 0.01))}");
        }
    }
}
