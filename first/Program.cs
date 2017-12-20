using System;
using System.Collections;

namespace testing
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter Size of Array");
			int Size = Convert.ToInt32 (Console.ReadLine());

			Console.WriteLine ("Enter Array Elements ");
			int num;
			ArrayList arr = new ArrayList();
			for (int i = 0; i < Size; i++) {
				num = Convert.ToInt32 (Console.ReadLine());
				//num = Console.Read();
				arr.Add (num);
			}
			arr.Sort ();
			arr.Reverse ();

			int k; 
			Console.WriteLine ("Enter K element");
			k = Convert.ToInt32 (Console.ReadLine ());
			if (k < 0 || k > Size) {
				Console.WriteLine ("Invalid Input");
			} else {
				Console.WriteLine (arr [k - 1]);
			}
			//Console.Write(Size);
		}
	}
}
