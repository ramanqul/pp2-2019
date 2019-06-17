using System;

namespace task4
{
    public class Program
    {
		
		private string output = "";
		
		private void print(string s) {
			output += s;
		}
		private void println() {
			output += "\n";
		}
		
		public string DrawStarTriangle(int n) {
			//TODO: write code here
			
			for (int i=0;i<n;i++) {
				for (int j=0;j<=i;j++) {
					print("[*]");
				}
				
				println();
			}
			
			return output;
		}
		
        static void Main(string[] args)
        {
			string output = new Program().DrawStarTriangle(1);
			Console.WriteLine(output);
			
            Console.ReadKey();
        }
    }
}
