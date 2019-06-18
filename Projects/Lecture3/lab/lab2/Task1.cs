using System;
using System.IO;

namespace pp2.lab2
{
    public class Task1
    {
		
		public bool isPalindrome(string filePath) 
		{
            //TODO: place code here
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader st = new StreamReader(fs);

            string input = st.ReadLine();

            //return true if input string is palindrom
            //else false


			return false;
		}			
    }
}
