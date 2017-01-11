using System;
using System.Threading;

namespace digitalniClock
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//create a array of 55 cells
			string[] cisla = new string[55];
			// 0
			cisla [0] = "■■■";
			cisla [1] = "■ ■";
			cisla [2] = "■ ■";
			cisla [3] = "■ ■";
			cisla [4] = "■■■";
			// 1
			cisla [5] = "■";
			cisla [6] = "■";
			cisla [7] = "■";
			cisla [8] = "■";
			cisla [9] = "■";
			//2
			cisla [10] = "■■■";
			cisla [11] = "  ■";
			cisla [12] = "■■■";
			cisla [13] = "■  ";
			cisla [14] = "■■■";
			//3
			cisla [15] = "■■■";
			cisla [16] = "  ■";
			cisla [17] = "■■■";
			cisla [18] = "  ■";
			cisla [19] = "■■■";
			//4
			cisla [20] = "■ ■";
			cisla [21] = "■ ■";
			cisla [22] = "■■■";
			cisla [23] = "  ■";
			cisla [24] = "  ■";
			//5
			cisla [25] = "■■■";
			cisla [26] = "■  ";
			cisla [27] = "■■■";
			cisla [28] = "  ■";
			cisla [29] = "■■■";
			//6
			cisla [30] = "■  ";
			cisla [31] = "■  ";
			cisla [32] = "■■■";
			cisla [33] = "■ ■";
			cisla [34] = "■■■";
			//7
			cisla [35] = "■■■";
			cisla [36] = "  ■";
			cisla [37] = "  ■";
			cisla [38] = " ■ ";
			cisla [39] = " ■ ";
			//8
			cisla [40] = "■■■";
			cisla [41] = "■ ■";
			cisla [42] = "■■■";
			cisla [43] = "■ ■";
			cisla [44] = "■■■";
			//9
			cisla [45] = "■■■";
			cisla [46] = "■ ■";
			cisla [47] = "■■■";
			cisla [48] = "  ■";
			cisla [49] = "■■■";
			//:
			cisla [50] = "   ";
			cisla [51] = " ■ ";
			cisla [52] = "   ";
			cisla [53] = " ■ ";
			cisla [54] = "   ";

			int a = 0; //just some random nammed variable 

			while (true) {
				Console.Clear ();
				string time = DateTime.Now.ToString ("hh:mm:ss"); //get currenttime
				while (a < 5) {
					Console.WriteLine (""); //got to new line
					foreach (var s in time) {
						switch (s) {
						case '0':
							Console.Write (cisla [0 + a] + " ");
							break;
						case '1':
							Console.Write (cisla [5 + a] + " ");
							break;
						case '2':
							Console.Write (cisla [10 + a] + " ");
							break;
						case '3':
							Console.Write (cisla [15 + a] + " ");
							break;
						case '4':
							Console.Write (cisla [20 + a] + " ");
							break;
						case '5':
							Console.Write (cisla [25 + a] + " ");
							break;
						case '6':
							Console.Write (cisla [30 + a] + " ");
							break;
						case '7':
							Console.Write (cisla [35 + a] + " ");
							break;
						case '8':
							Console.Write (cisla [40 + a] + " ");
							break;
						case '9':
							Console.Write (cisla [45 + a] + " ");
							break;
						case ':':
							Console.Write (cisla [50 + a] + " ");
							break;
						default:
							break;
						}
					}
					a += 1;
				}
				a -= a; //null the a variable

				Thread.Sleep (1000); //sleep for one second
				Console.Clear (); //clear the console
			} 
		}
	}
}
