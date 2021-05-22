using System;


namespace account
    {
        class Bank_Account
        {
            static String AccountNo;
            static String password;
            static Double Balance;


            static String Input_accNo()
            {
                Console.WriteLine(" NCEDA UFAKE INOMBOLO YE AKHAWUNTI ");
                AccountNo = Console.ReadLine();
                return AccountNo;
            }
            static String Input_Password()
            {
                Console.WriteLine(" NCEDA UFAKE INOMBOLO YOKUVULA ");
                password = Console.ReadLine();
                return password;
            }

            static Double Input_Balance()
            {
                Console.WriteLine(" NCEDA UFAKE IBHALANSI YOKUQALA ");
                Balance = Convert.ToDouble(Console.ReadLine());
                return Balance;
            }
          
            static string Transaction()
            {
                string a;
                Console.WriteLine(" INGABA UFUNA 'UKUKHUPHA' OKANYE 'UKUFAKA' IMALI ?");
                a = Console.ReadLine();
                return a;
            }
        static void Validation(string pass)
        {

            if (pass != password)
            {

                Console.WriteLine(" IGAMA LOKUGQITHISA ALILUNGANGA,");
                Console.WriteLine("__PHINDA UFAKE KWAKHONA");
                password = Console.ReadLine();

            }
        }
        static void Deposit()
        {
            Console.WriteLine();
            Console.WriteLine(" ______UZO DIPHOZITHA_______ ");
            Console.WriteLine();
            Console.WriteLine(" NCEDA UFAKE INOMBOLO YOKUVULA ");
            String password1 = Console.ReadLine();
            Validation(password1);
            Console.WriteLine(" FAKA IMALI ");
            Double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" INGABA UFUNA UKUBONISA IBHALANSI YAKHO ?");
            string Answer = Console.ReadLine();
            Console.WriteLine(" IBHALANSI :  R" + (amount + Balance));

        }
        static void Withdraw()
        {
            Console.WriteLine();
            Console.WriteLine("       ______UZOKHUPHA IMALI______   ");
            Console.WriteLine();
            Console.WriteLine(" NCEDA UFAKE INOMBOLO YOKUVULA ");
            String password1 = Console.ReadLine();
            Validation(password1);
            Double Amount;
            Console.WriteLine(" BHALA IMALI UZAKUYIKHUPHA");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" IBHALANSI : R" + (Balance - Amount));
        }

        static void Main(string[] args)
            {
                String Account = Input_accNo();
                String Password = Input_Password();
                Double Balanc = Input_Balance();
                String Answer = Transaction();
                if (Answer == "UKUKHUPHA")
                {

                    Withdraw();
                }
                else
                {
                    Deposit();
                }
            }
        }
    }
