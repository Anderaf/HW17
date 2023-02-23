namespace HW17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var normalAccount = new NormalAccount(10000);
            var sallaryAccount = new SallaryAccount(10000);
            Calculator.CalculateInterest(normalAccount);
            Calculator.CalculateInterest(sallaryAccount);
            Console.WriteLine(normalAccount.Balance);
            Console.WriteLine(normalAccount.Interest);
            Console.WriteLine(sallaryAccount.Balance);
            Console.WriteLine(sallaryAccount.Interest);

            normalAccount.CalculateInterest();
            sallaryAccount.CalculateInterest();
            Console.WriteLine(normalAccount.Balance);
            Console.WriteLine(normalAccount.Interest);
            Console.WriteLine(sallaryAccount.Balance);
            Console.WriteLine(sallaryAccount.Interest);
            //Я не уверен, что выполнил задание правильно, так как класс Calculator потерял свой смысл. Нарушил ли я принцип single responsibility?
        }
    }
}