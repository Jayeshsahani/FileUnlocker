using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUnlocker.Tool.BAL
{
    class BruteForce
    {
     //   private string character = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890~!@#$%^&*()-_=+[]{}\\|;:'\"<>,./?*";
        private string character = "abcdefghijklmnopqrstuvwxyz";

        // private string character = "123";

        private char[] GetArray() => this.character.ToCharArray();

        private char GetFirstChar() => this.GetArray()[0];
       
        public List<string> GetString()
        {
            List<string> keyWordslists = new List<string>();
            List<string> temp = new List<string>();
            string startString = string.Empty;
            char[] charArray = GetArray();
            long length = 0;
            foreach (var first in charArray)
            {
                keyWordslists.Add(first.ToString());
            }
            length++;
            temp = keyWordslists.Join(temp);
            bool isStop = false;

            while (!isStop)
            {
                temp = WordIncrement(temp, charArray);
                keyWordslists = keyWordslists.Join(temp);
                length++;
                if (length>=3)
                {
                    isStop = true;
                }
            }
          
            return keyWordslists;
        }
        private List<string> WordIncrement(List<string> words,char[] charArray)
        {
            List<string> temp = new List<string>();
            foreach (string word in words)
            {
                foreach (var charaters in charArray)
                {
                    temp.Add(word + charaters);
                }
            }
            return temp;
        }

        public List<string> GetString(long min,long max)
        {
            List<string> keyWordslists = new List<string>();
            string startString = string.Empty;
            char[] charArray = GetArray();
            if (min>0 && max>=min)
            {
                char firstChar = GetFirstChar();
                startString = firstChar.ToString();
                for (int i = 0; i < max-1; i++)
                {
                    startString += charArray[0];
                }

            }
            foreach (var ch in charArray)
            {

            }
            return keyWordslists;
        }

       



    }
}
