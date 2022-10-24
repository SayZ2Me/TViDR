using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace datacompression
{
    public struct Point
    {
        public decimal low, high;
    }
    public static class Extensions
    {
        public static int FindIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }
    public class ACM
    {
        private string data;
        private Dictionary<char, decimal> charCodeDict;
        private Point messageCode;
        private List<char> keyList;

        private static ACM instance;
        private ACM(string data) 
        {
            this.data = data;
            messageCode = new Point();
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
            charCodeDict = new Dictionary<char, decimal>();

            decimal sum = 0;

            foreach (char charBuffer in data) 
            {
                if (charCodeDict.ContainsKey(charBuffer))
                {
                    charCodeDict[charBuffer] += 1;
                }
                else
                {
                    charCodeDict.Add(charBuffer, 1);
                }
                sum += 1;
            }
            charCodeDict = charCodeDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            decimal increment = 0;

            keyList = new List<char>(charCodeDict.Keys);

            foreach(char key in keyList)
            {
                increment += charCodeDict[key];
                charCodeDict[key] = increment / sum;
            }
        }
        public void ProccessData()
        {
            decimal high = 0;
            decimal low = 0;
            decimal highSym, lowSym;

            for (int i = 0; i < Data.Length; i++) 
            {
                if (charCodeDict.ElementAt(0).Key == Data[i])
                {
                    lowSym = 0;
                }
                else
                {
                    lowSym = charCodeDict.ElementAt(keyList.IndexOf(Data[i])-1).Value;
                }

                highSym = charCodeDict.ElementAt(keyList.IndexOf(Data[i])).Value;

                if (i == 0)
                {
                    low = lowSym;
                    high = highSym;
                }

                high = low + (high - low) * highSym;
                low = low + (high - low) * lowSym;
            }
            messageCode.low = low;
            messageCode.high = high;
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
            get { return charCodeDict; }
        }
        public Point Code
        {
            get { return messageCode; }
        }
    }
    public class MTF
    {
        private readonly char[] alphabet_ru_RU = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', ' ', '.', ',', '!', '?', '-', '_', '*', ';', ':', '@', '(', ')', '[', ']', '{', '}', '—', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private readonly char[] alphabet_en_US = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '.', ',', '!', '?', '-', '_', '*', ';', ':', '@', '(', ')', '[', ']', '{', '}', '—', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
            if (alphabet_ru_RU.FindIndex(data[0]) >= 0)
            {
                this.language = "ru_RU";
            }
            else if (alphabet_en_US.FindIndex(data[0]) >= 0)
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
            char processingBuffer;
            for (int i = 0; i < data.Length; i++)
            {
                try
                {
                    processingBuffer = processingAlphabet[processingAlphabet.FindIndex(data[i])];
                    compressedData[i] = processingAlphabet.FindIndex(data[i]);
                    for (int j = processingAlphabet.FindIndex(data[i]); j > 0; j--)
                    {
                        processingAlphabet[j] = processingAlphabet[j - 1];
                    }
                    processingAlphabet[0] = processingBuffer;
                }
                catch (Exception)
                {
                    throw new Exception("Symbol" + data[i] + "not in alphabet");
                }
            }
        }
    }
    public class BWT
    {
        private string data;
        private int index;
        private string transformedData;
        private string dataBuffer;
        private string[] DataTransformationBuffer;

        private static BWT instance;
        private BWT(string data)
        {
            this.data = data;
        }
        public static BWT GetInstance(string data)
        {
            if (instance == null)
            {
                instance = new BWT(data);
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
        private void ShiftDataBuffer()
        {
            dataBuffer = dataBuffer.Substring(1, dataBuffer.Length - 1) + dataBuffer.Substring(0, 1);
        }
        public void TrasformData()
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data string can not be null.");
            }

            transformedData = "";

            dataBuffer = data;

            DataTransformationBuffer = new string[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                DataTransformationBuffer[i] = dataBuffer;
                ShiftDataBuffer();
            }
            Array.Sort(DataTransformationBuffer);
            index = DataTransformationBuffer.FindIndex(data);
            for (int i = 0; i < DataTransformationBuffer.Length; i++)
            {
                transformedData += DataTransformationBuffer[i][DataTransformationBuffer.Length - 1];
            }
        }
    }
}