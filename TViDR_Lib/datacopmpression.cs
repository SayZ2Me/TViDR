using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            CreateAlphabet();
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
            defaultAlphabet = new char[arrPtr];

            for (int i = 0; i < arrPtr; i++) 
            {
                this.defaultAlphabet[i] = alphabet[i];
            }
        }
        public string Data
        {
            get { return data; }
            set 
            { 
                data = value;
                CreateAlphabet();
            }
        }
        public char[] Alphabet 
        {
            get { return defaultAlphabet; }
        }
        public string EncryptedData
        {
            get { return encryptedData; }
        }
        public void encrypt()
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data string can not be null.");
            }
        }
        public static void Main() {}
    }
}