using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public class ACM
    {
        private string data;
        private Dictionary<char, decimal> dict;

        private static ACM instance;
        private ACM(string data) 
        {
            this.data = data;
        }
        public static ACM GetInstance (string data)
        {
            if (instance == null)
            {
                instance = new ACM(data);
            }
            else 
            {
                instance.Data = data;
            }
            instance.FillDictionary();
            return instance;
        }
        private void FillDictionary()
        {
            dict = new Dictionary<char, decimal>();

            decimal sum = 0;

            foreach (char charBuffer in data) 
            {
                if (dict.ContainsKey(charBuffer))
                {
                    dict[charBuffer] += 1;
                }
                else
                {
                    dict.Add(charBuffer, 1);
                }
                sum += 1;
            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            decimal increment = 0;
            List<char> keyList = new List<char>(dict.Keys);
            foreach(char key in keyList)
            {
                increment += dict[key];
                dict[key] = increment / sum;
            }
        }
        public string Data 
        {
            get { return data; }
            set {
                data = value;
                instance.FillDictionary();
            }
        }
        public Dictionary<char, decimal> Dict 
        {
            get { return dict; }
        }
    }
    public class MTF
    {
        private char[] alphabet_ru_RU = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', ' ', '.', ',', '!', '?', '-', '_', '*', ';', ':', '@', '(', ')', '[', ']', '{', '}' };
        private char[] alphabet_en_US = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '.', ',', '!', '?', '-', '_', '*', ';', ':', '@', '(', ')', '[', ']', '{', '}' };
        private string language;
        private string data;
        private int[] compressedData;
        private char[] processingAlphabet;

        private static MTF instance;

        private MTF(string data)
        {
            this.data = data;
        }

        public static MTF GetInstance(string data)
        {
            if (instance == null)
            {
                instance = new MTF(data);
            }
            else
            {
                instance.data = data;
            }
            instance.DefineLanguage();
            return instance;
        }
        private void DefineLanguage()
        {
            if (string.IsNullOrEmpty(data)) { throw new ArgumentNullException("Data string can not be null."); }
            if (alphabet_ru_RU.findIndex(data[0]) >= 0)
            {
                this.language = "ru_RU";
            }
            else if (alphabet_en_US.findIndex(data[0]) >= 0)
            {
                this.language = "en_US";
            }
            else
            {
                this.language = null;
            }
        }
        public string Data
        {
            get { return data; }
            set
            {
                data = value;
                DefineLanguage();
            }
        }
        public int[] CompressedData
        {
            get { return compressedData; }
        }
        public string Language
        {
            get { return language; }
        }
        public void CompressData()
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data string can not be null.");
            }
            if (language == null)
            {
                throw new ArgumentNullException("Only Russian and English laguages supported. If program can not identify language, try to set language settings manualy.");
            }
            compressedData = new int[data.Length];
            if (language == "ru_RU")
            {
                processingAlphabet = new char[alphabet_ru_RU.Length];
                for (int i = 0; i < alphabet_ru_RU.Length; i++)
                {
                    processingAlphabet[i] = alphabet_ru_RU[i];
                }
            }
            if (language == "en_US")
            {
                processingAlphabet = new char[alphabet_en_US.Length];
                for (int i = 0; i < alphabet_en_US.Length; i++)
                {
                    processingAlphabet[i] = alphabet_en_US[i];
                }
            }
            char processingBuffer = ' ';
            for (int i = 0; i < data.Length; i++)
            {
                processingBuffer = processingAlphabet[processingAlphabet.findIndex(data[i])];
                compressedData[i] = processingAlphabet.findIndex(data[i]);
                for (int j = processingAlphabet.findIndex(data[i]); j > 0; j--)
                {
                    processingAlphabet[j] = processingAlphabet[j - 1];
                }
                processingAlphabet[0] = processingBuffer;
            }
        }
    }
    public class BTW
    {
        private string data;
        private string transformedData;
        private string dataBuffer;
        private string[] DataTransformationBuffer;

        private static BTW instance;
        private BTW(string data)
        {
            this.data = data;
        }
        public static BTW GetInstance(string data)
        {
            if (instance == null)
            {
                instance = new BTW(data);
            }
            else
            {
                instance.data = data;
            }
            return instance;

        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public string TransformedData
        {
            get { return transformedData; }
        }
        private void shiftDataBuffer()
        {
            dataBuffer = dataBuffer.Substring(1, dataBuffer.Length - 1) + dataBuffer.Substring(0, 1);
        }
        public void TrasformData()
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data string can not be null.");
            }

            dataBuffer = data;

            DataTransformationBuffer = new string[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                DataTransformationBuffer[i] = dataBuffer;
                shiftDataBuffer();
            }
            Array.Sort(DataTransformationBuffer);
            for (int i = 0; i < DataTransformationBuffer.Length; i++)
            {
                transformedData += DataTransformationBuffer[i][DataTransformationBuffer.Length - 1];
            }
        }
    }
}