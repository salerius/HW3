using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DefiningAllPrimitivesTypes();
            Console.ReadLine();

            Casts();

            SysStr();
            Console.ReadLine();

            VarMethod1();
            VarMethod2();
            Varmethod3();
            VarMethod4();
            VarMethod5();

            TypessInt();
            TypessFloat();
            TypessStreeng();
            TypessBool();

            IfElse1();
            IfElse2();
            Switch1();
            Switch2();
            For1();
            For2();
            Foreach1();
            Foreach2();
            While1();
            While2();
            DoWhile1();
            DoWhile2();
            UnChecked1();
            Checked1();


        }


        public static void DefiningAllPrimitivesTypes()
        {
            sbyte sbbyte = -20;
            byte bbyte = 252;
            short sshort = -30114;
            ushort usshort = 58544;
            int iint = -250244;
            uint uiint = 352457;
            long llong = 234455642;
            ulong ullong = 347583243422;
            char cchar = 'M';
            float ffloat = 5.54f;
            double ddouble = 345.3d;
            decimal ddecimal = -12.23m;
            bool bbool = true;


            Console.WriteLine("Sbyte is: {0}, Byte is: {1}", sbbyte, bbyte);
            Console.WriteLine("Short is: {0}, Ushort is: {1}", sshort, usshort);
            Console.WriteLine("Int is: {0}, Uint is: {1}", iint, uiint);
            Console.WriteLine("Long is: {0}, Ulong is: {1}", llong, ullong);
            Console.WriteLine("Char is: {0}", cchar);
            Console.WriteLine("Float is: {0}, Double is: {1}", ffloat, ddouble);
            Console.WriteLine("Decimal is: {0}, Bool is: {1}", ddecimal, bbool);

            Console.ReadLine();

        }


        //Casts
        public static void Casts()
        {
            byte cup1 = 134;
            byte cup2 = 130;
            int summ = (short)cup1 + cup2;
            Console.WriteLine("Cast to int : {0}", summ);


            string andrii = "Андрій має зріст : ";
            int age = 15;
            string sentence = andrii + age.ToString();
            //string sentence = andrii + age.ToString();
            Console.WriteLine(sentence);

        }


        
        public static void SysStr()
        {
            string abcOne = "Hello my friend. How are you?";
            string abcTwo = "Thanks, I'm fine";
            string abcThree = "friend";
            string abcFour = "friend";

            Console.WriteLine("The leanght first string is: " + abcOne.Length);
            Console.WriteLine(string.Compare(abcOne, abcTwo)); // String.Compare
            Console.WriteLine(abcOne.Contains(abcThree)); // String.Contains
            Console.WriteLine(Equals(abcThree, abcFour)); // String.Equals


            //Format
            string strFormat = String.Format("Hello today is {0:d} at {0:t}", DateTime.Now);
            Console.WriteLine(strFormat);



            //String.Insert
            abcTwo = abcTwo.Insert(6, " Andrii");
            Console.WriteLine(abcTwo);


            //PedLeft PedRight
            string stringPed = "simple";
            char exclamation = '!';
            Console.WriteLine(stringPed.PadRight(15, exclamation));
            Console.WriteLine(stringPed.PadLeft(15, exclamation));

            // Remove
            string m = "Hello my world";
            Console.WriteLine("Text {0}", m.Remove(5, 3));


            //Replace
            Console.WriteLine(abcOne.Replace('o', '!'));

            //Split
            string strSplit = "My name is Alihandro. I'm from Nipal";
            string[] arr = strSplit.Split(' ');
            foreach (string rez in arr)
            {
                Console.WriteLine(rez);
            }

            //Trim
            string strTrim = "!!!Hello World**";
            char[] charTrim = { '!', '*' };
            Console.WriteLine(strTrim.Trim(charTrim));

            //ToUpper ToLower
            string textTo = "Hello, this is a beautiful day!";
            Console.WriteLine(textTo.ToUpper());
            Console.WriteLine(textTo.ToLower());
        }



        public static void TypessInt()
        {
            int variable = 1;
            Console.WriteLine($"'{nameof(variable)}' type: {variable.GetType()}");
            Console.WriteLine($"'{nameof(variable)}' string representation: {variable.ToString()}");
            Console.WriteLine($"'{nameof(variable)}' equals 0: {variable.Equals(0)}");
            Console.WriteLine($"'{nameof(variable)}' hashcode: {variable.GetHashCode()}");
        }

        public static void TypessFloat()
        {
            float variable = 1.3f;
            Console.WriteLine($"'{nameof(variable)}' type: {variable.GetType()}");
            Console.WriteLine($"'{nameof(variable)}' string representation: {variable.ToString()}");
            Console.WriteLine($"'{nameof(variable)}' equals 1.3: {variable.Equals(1.3f)}");
            Console.WriteLine($"'{nameof(variable)}' hashcode: {variable.GetHashCode()}");
        }

        public static void TypessStreeng()
        {
            string variable = "Assa";
            Console.WriteLine($"'{nameof(variable)}' type: {variable.GetType()}");
            Console.WriteLine($"'{nameof(variable)}' string representation: {variable.ToString()}");
            Console.WriteLine($"'{nameof(variable)}' equals Asra: {variable.Equals("Asra")}");
            Console.WriteLine($"'{nameof(variable)}' hashcode: {variable.GetHashCode()}");
        }

        public static void TypessBool()
        {
            bool variable = true;
            Console.WriteLine($"'{nameof(variable)}' type: {variable.GetType()}");
            Console.WriteLine($"'{nameof(variable)}' string representation: {variable.ToString()}");
            Console.WriteLine($"'{nameof(variable)}' equals true: {variable.Equals(true)}");
            Console.WriteLine($"'{nameof(variable)}' hashcode: {variable.GetHashCode()}");
        }



        public static void VarMethod1()
        {
            Console.WriteLine("!!!!!!!VarMethod1!!!!!!");
            var num1 = 55;
            var num2 = 34.6;
            Console.WriteLine(num1 + num2);
        }

        public static void VarMethod2()
        {
            Console.WriteLine("!!!!!!!VarMethod2!!!!!!!");
            var boolRez = true;
            var x = 5;
            var y = 10;
            if (x < y)
            {
                Console.WriteLine(boolRez);
            }
            else
            {
                boolRez = false;
                Console.WriteLine(boolRez);
            }
        }

        public static void Varmethod3()
        {
            Console.WriteLine("!!!!!!!!VerMathod3!!!!!!!");
            var strVar = "I'm a doctor and I'm ";
            var strVar2 = " years old";
            var age = 37;
            Console.WriteLine(strVar + age + strVar2);
        }

        public static void VarMethod4()
        {
            Console.WriteLine("!!!!!!!!VerMathod4!!!!!!!");
            var space1 = 75;
            var space2 = -12345.3;
            var universal = space2 - space1;
            Console.WriteLine(universal);

        }

        public static void VarMethod5()
        {
            Console.WriteLine("!!!!!!!!VerMathod5!!!!!!!");
            var mars = "red";
            var earch = "blue";
            var sun = "yellow";
            Console.WriteLine("The Mars is: {0}, Earch is: {1}, Sun is: {2}", mars, earch, sun);

        }


        //if else, 
        public static void IfElse1()
        {
            var andrii = 5;
            int sergii = 10;
            if (andrii > sergii)
            {
                Console.WriteLine("Andrii is bigger then Sergii");
            }
            else Console.WriteLine("Sergii is bigger then Andrii");
        }

        public static void IfElse2()
        {
            bool andriiStudent = false;
            if (andriiStudent)
            {
                Console.WriteLine("Andrii is student");
            }
            else Console.WriteLine("Sergii is teacher");
        }


        //switch, 
        public static void Switch1()
        {
            int apples = 22;
            switch (apples)
            {
                case 1:
                    Console.WriteLine("Apple is one");
                    break;
                case 2:
                    Console.WriteLine("Apples is two");
                    break;
                default:
                    Console.WriteLine("Apples are very many");
                    break;

            }
        }


        public static void Switch2()
        {
            bool logic = false;
            switch (logic)
            {
                case true:
                    Console.WriteLine("true");
                    break;
                default:
                    Console.WriteLine("false");
                    break;

            }
        }



        //for

        public static void For1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("The number is: {0}", i);
            }
        }


        public static void For2()
        {
            int fori = 1;
            for (int i = 0; i < 10; i++)
            {
                if (fori > 5)
                {
                    Console.WriteLine("fori is {0}", fori);
                };
                fori++;
            };
        }

        //foreach

        public static void Foreach1()
        {
            float[] numbers22 = { 2.54f, 54.3f, 67.3f };

            foreach (float e in numbers22)
            {
                Console.WriteLine(e);
            }
        }


        public static void Foreach2()
        {
            string[] colors = { "green", "black", "yellow" };
                foreach (string s in colors)
            {
                Console.WriteLine(s);

            }
        }


        //while
        public static void While1()
        {
            int createdCars = 0;
            while (createdCars<5)
            {
                Console.WriteLine("We need more cars. We have only {0} cars",createdCars);
                createdCars++;
            }
            Console.WriteLine("We do it!!!!");

        }

        public static void While2()
        {
            int phones = 5;
            while (phones>=0)
            {
                Console.WriteLine("we have phones");
                phones--;
            }
            Console.WriteLine("The phones are over");
        }

        //do while
        public static void DoWhile1()
        {
            int st = 2;
            do
            {
                Console.WriteLine("number st : {0}", st);
                st++;
            }
            while (st < 8);
        }

        public static void DoWhile2()
        {
            int sm = 25;
            do
            {
                Console.WriteLine("number sm:{0}", sm);
                sm--;
            }
            while (sm > 20);

        }

        public static void UnChecked1()
        {
            int a1 = 2147483647;
            int a2 = 100;
            
            unchecked
            {
                int aw3 = a1 + a2;
                Console.WriteLine(aw3);
            }
        }



        public static void Checked1()
        {
            int a1 = 2147483647;
            int a2 = 100;

            checked
            {
                //int aw4 = a1 + a2;
                //Console.WriteLine(aw4);
            }
        }



    }
}



