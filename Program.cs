namespace exp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            int pinNumber = 123;
            Boolean isMatch = false;

            for (int i = 0; i < 3; i++) {
                Console.Write("Please enter the PIN: ");
                int pinAttemp = Convert.ToInt32(Console.ReadLine());

                if (pinAttemp == pinNumber) {
                    isMatch = true;
                    break;
                    }
                Console.WriteLine("Incorrect PIN");
            }

            if (isMatch)
                Console.WriteLine("Access Granted");
            else
                Console.WriteLine("Sorry your account will be temporarily suspended. Visit your nearest branch for reactivation");
            
        }
    }
}