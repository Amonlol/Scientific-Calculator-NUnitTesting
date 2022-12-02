using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using Calculator;

namespace CalculatorNUnitTests
{
	public class UnitTests
	{
		static User user;
		static User.operations userOperation;
		static string stringOperation;

		public static List<TestClass> TestCases = new List<TestClass>();

		static int time = 10;
		static string path = Path.GetFullPath(@"UnitTesting.txt");
		static double received, expected;
		static bool pass;

		public static void WriteToFile()
		{
			using (StreamWriter writer = new StreamWriter(path))
			{
				string write = JsonConvert.SerializeObject(TestCases);
				writer.Write(JsonConvert.SerializeObject(TestCases, Formatting.Indented));
			}
		}

		[SetUp]
		public static void Setup()
		{
			Environment.CurrentDirectory = @"D:/";
			File.CreateText(path).Dispose();

			user = new User();
		}

		[Test]
		public void TestAdd()
		{
			userOperation = User.operations.ADDITION;
			TestCases.Add(new TestClass(userOperation));

			//ADD predefined
			pass = Utils.Add(1d, 1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Add(2d, 5d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Add(2.5d, 6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Add(100000d, 0.123d, out received);
			Assert.IsTrue(pass);

			//ADD random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				double a = random.NextDouble() * 1000;
				double b = random.NextDouble() * 1000;

				pass = Utils.Add(a, b, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestSub()
		{
			userOperation = User.operations.SUBTRACTION;
			TestCases.Add(new TestClass(userOperation));

			//SUBTRACTION predefined
			pass = Utils.Sub(1d, 1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sub(2d, 5d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sub(2.5d, 6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sub(100000d, 0.123d, out received);
			Assert.IsTrue(pass);

			//SUBTRACTION random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				double a = random.NextDouble() * 1000;
				double b = random.NextDouble() * 1000;

				pass = Utils.Sub(a, b, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestMulti()
		{
			userOperation = User.operations.MULTIPLICATION;

			//MULTIPLICATION predefined
			pass = Utils.Multi(1d, 1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sub(2d, 5d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sub(2.5d, 6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sub(100000d, 0.123d, out received);
			Assert.IsTrue(pass);

			//MULTIPLICATION random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				double a = random.NextDouble() * 1000;
				double b = random.NextDouble() * 1000;

				pass = Utils.Sub(a, b, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestDivide()
		{
			userOperation = User.operations.DIVISION;

			//DIVISION predefined
			pass = Utils.Divide(1d, 1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Divide(2d, 5d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Divide(2.5d, 6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Divide(100000d, 0.123d, out received);
			Assert.IsTrue(pass);

			//DIVISION random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				double a = random.NextDouble() * 1000;
				double b = random.NextDouble() * 1000;

				pass = Utils.Divide(a, b, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestPower()
		{
			userOperation = User.operations.POWER;

			//POWER predefined
			pass = Utils.Power(1d, 1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Power(2d, 5d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Power(2.5d, 6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Power(100000d, 0.123d, out received);
			Assert.IsTrue(pass);

			//POWER random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				double a = random.NextDouble() * 100;
				double b = random.NextDouble() * 10;

				pass = Utils.Power(a, b, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestFactor()
		{
			stringOperation = "!";

			//FACTORIAL predefined
			pass = Utils.Factor(1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Factor(2d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Factor(6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Factor(10d, out received);
			Assert.IsTrue(pass);

			//FACTORIAL random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				int a = (int)Math.Abs(random.NextDouble() * 10);

				pass = Utils.Factor(a, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestLn()
		{
			stringOperation = "ln";

			//LN predefined
			pass = Utils.Ln(1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Ln(2d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Ln(6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Ln(Math.E, out received);
			Assert.IsTrue(pass);

			//LN random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				int a = (int)Math.Abs(random.NextDouble() * 1000);

				pass = Utils.Ln(a, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestLog()
		{
			stringOperation = "log";

			//LOG10 predefined
			pass = Utils.Log10(1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Log10(2d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Log10(6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Log10(10d, out received);
			Assert.IsTrue(pass);

			//LOG10 random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				int a = (int)Math.Abs(random.NextDouble() * 1000);

				pass = Utils.Log10(a, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestSqrt()
		{
			stringOperation = "√";

			//SQRT predefined
			pass = Utils.Sqrt(1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sqrt(2d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sqrt(4d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Sqrt(100d, out received);
			Assert.IsTrue(pass);

			//SQRT random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				int a = (int)Math.Abs(random.NextDouble() * 1000);

				pass = Utils.Sqrt(a, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestNegate()
		{
			stringOperation = "-n";

			//NEgate predefined
			pass = Utils.Negate(1d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Negate(2d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Negate(6d, out received);
			Assert.IsTrue(pass);

			pass = Utils.Negate(100d, out received);
			Assert.IsTrue(pass);

			//NEgate random
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				int a = (int)Math.Abs(random.NextDouble() * 1000);

				pass = Utils.Negate(a, out received);
				Assert.IsTrue(pass);
			}
		}
		[Test]
		public void TestConst()
		{
			//Exponent
			pass = Utils.Exponent(out received);
			Assert.IsTrue(pass);

			//Pi
			pass = Utils.PI(out received);
			Assert.IsTrue(pass);

		}
		[Test]
		public void TestMemory()
		{
			stringOperation = "Memory";

			//MemAdd
			pass = Utils.MemAdd(100d, 1d, out received);
			Assert.IsTrue(pass);

			//MemSub
			pass = Utils.MemSub(100d, 1d, out received);
			Assert.IsTrue(pass);

			//MemMC
			pass = Utils.MemMC(out received);
			Assert.IsTrue(pass);

		}
		[Test]
		public void TestAngles()
		{
			double degree, radian, grad;

			//ConvertToRadian
			stringOperation = "ToRadian";
			degree = 570;
			grad = 444;

			pass = Utils.ToRadians("degree", degree, out received);
			Assert.IsTrue(pass);

			pass = Utils.ToRadians("grad", grad, out received);
			Assert.IsTrue(pass);

			//ConvertToGradian
			stringOperation = "ToGradian";
			degree = 260;
			radian = 895;

			pass = Utils.ToGrad("degree", degree, out received);
			Assert.IsTrue(pass); 
			
			pass = Utils.ToGrad("radian", radian, out received);
			Assert.IsTrue(pass);

			//ConvertToDegree
			stringOperation = "ToDegree";
			grad = 1490;
			radian = 256;

			pass = Utils.ToDegrees("radian", radian, out received);
			Assert.IsTrue(pass);

			pass = Utils.ToDegrees("grad", grad, out received);
			Assert.IsTrue(pass);
		}

		public class TestClass
		{
			public string number1, number2;
			public string operation;
			public string recieved, expected;
			public string pass;

			public TestClass(User.operations operation)
			{
				this.operation = operation.ToString().ToUpper();
			}
			public TestClass(string operation)
			{
				this.operation = operation.ToUpper();
			}

			public TestClass(User.operations operation, double number1, double number2, double expected, double recieved, bool pass)
			{
				this.number1 = number1.ToString();
				this.number2 = number2.ToString();
				this.operation = operation.ToString();
				this.recieved = recieved.ToString();
				this.expected = expected.ToString();
				this.pass = pass.ToString();
			}
			public TestClass(string operation, double number1, double expected, double recieved, bool pass)
			{
				this.number1 = number1.ToString();
				number2 = "NO_SECOND_NUMBER";
				this.operation = operation.ToUpper();
				this.recieved = recieved.ToString();
				this.expected = expected.ToString();
				this.pass = pass.ToString();
			}

			public static double CalculateFactorial(double number)
			{
				if(number < 0)
				{
					return double.NaN;
				}

				if(number == 1 || number == 0)
				{
					return 1d;
				}

				double result = 1;

				for (int i = (int)number; i > 0; i--)
				{
					result *= i;
				}

				return result;

			}
		}
	}

	public class IntegralTests
	{
		static string path = Path.GetFullPath(@"IntegralTesting.txt");

		const int time = 10;
		double received;

		[SetUp]
		public static void Setup()
		{
			Environment.CurrentDirectory = @"D:/";
			File.CreateText(path).Dispose();
		}

		[Test]
		public void TestBasic()
		{
			double a, b;
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);
				
				a = random.NextDouble() * 100;
				b = random.NextDouble() * 100;
				Utils.Add(a, b, out received);

				a = received;
				b = random.NextDouble() * 100;
				Utils.Multi(a, b, out received);

				a = received;
				b = random.NextDouble() * 100;
				Utils.Divide(a, b, out received);

				a = received;
				b = random.NextDouble() * 100;
				Utils.Sub(a, b, out received);

				a = received;
				b = random.NextDouble() * 4;
				Utils.Power(a, b, out received);
			}
		}
		[Test]
		public void TestFuncion()
		{
			double a;
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);

				a = (int)(random.NextDouble() * 10);
				Utils.Factor(a, out received);

				a = received;
				Utils.Ln(a, out received);

				a = received;
				Utils.Log10(a, out received);

				a = received;
				Utils.Sqrt(a, out received);

				a = received;
				Utils.Negate(a, out received);
			}
		}
		[Test]
		public void TestAnglesConversion()
		{
			double a;
			for (int i = 0; i < time; i++)
			{
				Random random = new Random((int)DateTime.Now.Ticks + i);

				a = (int)(random.NextDouble() * 10000);
				Utils.ToDegrees("radian", a, out received);

				a = received;
				Utils.ToDegrees("grad", a, out received);

				a = received;
				Utils.ToGrad("degree", a, out received); 
				
				a = received;
				Utils.ToGrad("radian", a, out received);

				a = received;
				Utils.ToRadians("grad", a, out received); 
				
				a = received;
				Utils.ToRadians("degree", a, out received);
			}
		}
	}

	public class Utils
	{
		static User user = new User();
		static User.operations userOperation;
		static string stringOperation;

		static double received, expected;
		static bool pass;

		public static bool Add(double a, double b, out double received)
		{
			userOperation = User.operations.ADDITION;
			expected = a + b;

			pass = user.calculateResult(userOperation, a, b, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(userOperation, a, b, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Sub(double a, double b, out double received)
		{
			userOperation = User.operations.SUBTRACTION;
			expected = a - b;

			pass = user.calculateResult(userOperation, a, b, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(userOperation, a, b, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Multi(double a, double b, out double received)
		{
			userOperation = User.operations.MULTIPLICATION;
			expected = a * b;

			pass = user.calculateResult(userOperation, a, b, a * b, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(userOperation, a, b, a * b, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Divide(double a, double b, out double received)
		{
			userOperation = User.operations.DIVISION;
			expected = a / b;

			pass = user.calculateResult(userOperation, a, b, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(userOperation, a, b, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Power(double a, double b, out double received)
		{
			userOperation = User.operations.POWER;
			expected = Math.Pow(a, b);

			pass = user.calculateResult(userOperation, a, b, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(userOperation, a, b, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Factor(double a, out double received)
		{
			stringOperation = "!";
			expected = UnitTests.TestClass.CalculateFactorial(a);

			pass = user.function(stringOperation, a, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Ln(double a, out double received)
		{
			stringOperation = "ln";
			expected = Math.Log(a);

			pass = user.function(stringOperation, a, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Log10(double a, out double received)
		{
			stringOperation = "log";
			expected = Math.Log10(a);

			pass = user.function(stringOperation, a, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Sqrt(double a, out double received)
		{
			stringOperation = "√";
			expected = Math.Sqrt(a);

			pass = user.function(stringOperation, a, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Negate(double a, out double received)
		{
			stringOperation = "-n";
			expected = a * (-1);

			pass = user.function(stringOperation, a, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool Exponent(out double received)
		{
			expected = Math.E;

			pass = user.e_button_Click(expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass("exp", Math.E, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;

		}
		public static bool PI(out double received)
		{
			expected = Math.PI;

			pass = user.pi_button_Click(expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass("PI", Math.PI, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;

		}
		public static bool MemAdd(double memory, double b, out double received)
		{
			stringOperation = "MemAdd";

			user.memory = memory;
			expected = memory + b;
			pass = user.madd_button_Click(b, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, b, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool MemSub(double memory, double b, out double received)
		{
			stringOperation = "MemSub";

			user.memory = memory;
			expected = memory - b;
			pass = user.msub_button_Click(b, expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, b, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool MemMC(out double received)
		{
			stringOperation = "MemMC";

			expected = 0;
			pass = user.mc_button_Click(expected, out received);
			UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, 0, expected, received, pass));
			UnitTests.WriteToFile();

			return pass;
		}
		public static bool ToRadians(string angle, double a, out double received)
		{
			received = 0;
			double degree, radian, grad;

			//ConvertToRadian
			stringOperation = "ToRadian";

			if(angle == "degree")
			{
				degree = a;
				radian = Calculator.Angles.Converter.radians(degree, Calculator.Angles.units.DEGREES);
				received = radian;
				expected = degree * Math.PI / 180;
				pass = Equals(received, expected);
				UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			}
			else if (angle == "grad")
			{
				grad = a;
				radian = Calculator.Angles.Converter.radians(grad, Calculator.Angles.units.GRADIANS);
				received = radian;
				expected = grad * Math.PI / 200;
				pass = Equals(received, expected);
				UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			}

			UnitTests.WriteToFile();
			return pass;
		}
		public static bool ToDegrees(string angle, double a, out double received)
		{
			received = 0;
			double degree, radian, grad;

			//ConvertToDegree
			stringOperation = "ToDegree";

			if (angle == "radian")
			{
				radian = a;
				degree = Calculator.Angles.Converter.degrees(radian, Calculator.Angles.units.RADIANS);
				received = degree;
				expected = radian * 180 / Math.PI;
				pass = Equals(received, expected);
				UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			}
			else if (angle == "grad")
			{
				grad = a;
				degree = Calculator.Angles.Converter.degrees(grad, Calculator.Angles.units.GRADIANS);
				received = degree;
				expected = grad * 180 / 200;
				pass = Equals(received, expected);
				UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			}

			UnitTests.WriteToFile();
			return pass;
		}
		public static bool ToGrad(string angle, double a, out double received)
		{
			received = 0;
			double degree, radian, grad;

			//ConvertToGrad
			stringOperation = "ToGrad";

			if (angle == "radian")
			{
				radian = a;
				grad = Calculator.Angles.Converter.gradians(radian, Calculator.Angles.units.RADIANS);
				received = grad;
				expected = radian * 200 / Math.PI;
				pass = Equals(received, expected);
				UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			}
			else if (angle == "degree")
			{
				degree = a;
				grad = Calculator.Angles.Converter.gradians(degree, Calculator.Angles.units.DEGREES);
				received = grad;
				expected = degree * 200 / 180;
				pass = Equals(received, expected);
				UnitTests.TestCases.Add(new UnitTests.TestClass(stringOperation, a, expected, received, pass));
			}

			return pass;
		}
	}
}