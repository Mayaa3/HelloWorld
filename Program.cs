using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Start(); 
        }

        public static void Start()
        {

			Console.WriteLine("write 2 numbers");
			float number1 = float.Parse(Console.ReadLine());
			float number2 = float.Parse(Console.ReadLine());

			Console.WriteLine("Select an option\n1.-Add\n2.-Subtract\n3.-Multiply\n4.-Div");
			int option = int.Parse(Console.ReadLine());

			EvaluateOption(option, number1, number2);
        }

        public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;
            return result;
        }

		public static float SubtractTwoNumbers(float n1, float n2)
		{
			float result = n1 - n2;
			return result;
		}

		public static float MultiplyTwoNumbers(float n1, float n2)
		{
			float result = n1 * n2;
			return result;
		}

		public static float DivideTwoNumbers(float n1, float n2)
		{
			float result = n1 / n2;
			return result;
		}



		public static void EvaluateOption(int option, float n1, float n2)
        {
            if(option == 1)
            {
                Console.WriteLine("Result of the Additon: " + AddTwoNumbers(n1, n2));   
            }

            else if (option == 2) {

				Console.WriteLine("Result of the subtraction: " + SubtractTwoNumbers(n1, n2));
			}

			else if (option == 3)
			{

				Console.WriteLine("Result of the Multiplication: " + MultiplyTwoNumbers(n1, n2));
			}
			else if (option == 4)
			{

				Console.WriteLine("Result of the Division: " + DivideTwoNumbers(n1, n2));
			}

            else if(option == 5){

                return;
            }
			else 
			{

                Console.WriteLine("invalid option");
			}

            Start(); 
		}
    }
}
