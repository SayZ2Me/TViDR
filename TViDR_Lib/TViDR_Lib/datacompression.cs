using System;
using System.Runtime.CompilerServices;

namespace datacompression 
{
    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item) 
        {
            return Array.IndexOf(array, item);
        }
    }
    public class MTF 
    {
        private string data;
        private string encryptedData;
        private char[] defaultAlphabet;
        private char[] processingAlphabet;

        public MTF() { }
        public MTF(string data)
        {
            this.data = data;
        }
        private void CreateAlphabet()
        {
            char[] alphabet = new char[128];
            int arrPtr = 0;
            for (int i = 0; i < this.data.Length; i++)
            {
                if (alphabet.findIndex(data[i]) < 0)
                {
                    alphabet[arrPtr] = data[i];
                    arrPtr++;
                }
            }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public string EncryptedData 
        {
            get { return encryptedData; }
        }
        public void encrypt()
        {
            if (data == null) 
            {
                throw new Exception("Data string is null");
            }
        }
        public static void Main()
        {
        }
    }
}