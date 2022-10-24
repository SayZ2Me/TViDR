using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlTypes;
using System.IO;

namespace imageprocessing
{
    public struct QuantityOfPixels
    {
        public uint quantity;
        public Color pixel;
    }
    public class YIQ
    {
        private Bitmap image;
        private Bitmap imageY;
        private Bitmap imageI;
        private Bitmap imageQ;
        public YIQ(string path)
        {
            image = new Bitmap(path);
            imageY = new Bitmap(path);
            imageI = new Bitmap(path);
            imageQ = new Bitmap(path);
        }
        public Bitmap Image
        {
            set
            {
                image = new Bitmap(value);
                imageY = new Bitmap(value);
                imageI = new Bitmap(value);
                imageQ = new Bitmap(value);
            }
        }
        public Bitmap ImageY
        {
            get { return imageY; }
        }
        public Bitmap ImageI
        {
            get { return imageI; }
        }
        public Bitmap ImageQ
        {
            get { return imageQ; }
        }
        private void ConvertGray()
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);

                    float R = color.R;
                    float G = color.G;
                    float B = color.B;

                    float Y = 0.299f * R + 0.587f * G + 0.114f * B;
                    float I = 0.596f * R - 0.275f * G - 0.321f * B;
                    float Q = 0.212f * R - 0.523f * G + 0.311f * B;
                    if (Y < 0)
                    {
                        Y = 0;
                    }
                    if (I < 0)
                    {
                        I = 0;
                    }
                    if (Q < 0)
                    {
                        Q = 0;
                    }

                    imageI.SetPixel(x, y, Color.FromArgb(255, (int)I, (int)I, (int)I));
                    imageY.SetPixel(x, y, Color.FromArgb(255, (int)Y, (int)Y, (int)Y));
                    imageQ.SetPixel(x, y, Color.FromArgb(255, (int)Q, (int)Q, (int)Q));
                }
            }
        }
        private void ConvertColor()
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);

                    float R = color.R;
                    float G = color.G;
                    float B = color.B;

                    float Y = 0.299f * R + 0.587f * G + 0.114f * B;
                    float I = 0.596f * R - 0.275f * G - 0.321f * B;
                    float Q = 0.212f * R - 0.523f * G + 0.311f * B;

                    R = Y;
                    G = Y;
                    B = Y;

                    imageY.SetPixel(x, y, Color.FromArgb(255, (int)R, (int)G, (int)B));

                    R = 127 + 0.956f * I;
                    G = 127 - 0.272f * I;
                    B = 127 - 1.107f * I;

                    if (R > 255) { R = 255; }
                    if (G > 255) { G = 255; }
                    if (B > 255) { B = 255; }

                    if (R < 0) { R = 0; }
                    if (G < 0) { G = 0; }
                    if (B < 0) { B = 0; }

                    imageI.SetPixel(x, y, Color.FromArgb(255, (int)R, (int)G, (int)B));

                    R = 127 + 0.621f * Q;
                    G = 127 - 0.647f * Q;
                    B = 127 + 1.704f * Q;

                    if (R > 255) { R = 255; }
                    if (G > 255) { G = 255; }
                    if (B > 255) { B = 255; }

                    if (R < 0) { R = 0; }
                    if (G < 0) { G = 0; }
                    if (B < 0) { B = 0; }
                    imageQ.SetPixel(x, y, Color.FromArgb(255, (int)R, (int)G, (int)B));
                }
            }
        }
        public void Convert(bool gray)
        {
            if (gray)
            {
                ConvertGray();
            }
            else
            {
                ConvertColor();
            }
        }
    }

    public class IPM
    {
        private Bitmap image;
        private int width;
        private int height;
        private Color[] data;
        private List<QuantityOfPixels> rleEncodedData;
        public IPM(string path)
        {
            image = new Bitmap(path);
            width = image.Width;
            height = image.Height;
            data = new Color[width * height];
            rleEncodedData = new List<QuantityOfPixels>();
        }
        public Bitmap Image
        {
            set { image = new Bitmap(value); }
            get { return image; }
        }
        public List<QuantityOfPixels> EncodedData
        {
            get { return rleEncodedData; }
        }
        public void RLE() 
        {
            Color dataBuffer = data[0];
            uint runLenght = 0;
            QuantityOfPixels series = new QuantityOfPixels();
            for (int i = 0; i < data.Length; i++)
            {
                if (dataBuffer != data[i])
                {
                    series.quantity = runLenght;
                    series.pixel = data[i - 1];
                    rleEncodedData.Add(series);
                    runLenght = 0;
                    dataBuffer = data[i];
                }
                runLenght++;
            }
            series.quantity = runLenght;
            series.pixel = data[data.Length-1];
            rleEncodedData.Add(series);
        }
        public void Huffman()
        {

        }
        private void GetPixel(int x, int y, int i)
        {
            try
            {
                Color color = image.GetPixel(x, y);

                data[i] = color;
            }
            catch (Exception e)
            {
                throw new Exception("GetPixel X= " + x.ToString() + "; Y= " + y.ToString() + "; i= " + i.ToString() + " " + image.Size.ToString() + e.Message);
            }
        }
        public void ZigZag()
        {
            int x = 0;
            int y = 0;

            int step = 1;

            int i = 0;

            while (x < width && y < height)
            {
                GetPixel(x, y, i);
                if (x == width - 1)
                {
                    y++;
                    i++;
                    GetPixel(x, y, i);
                    step = -1;
                }
                else if (y == height - 1)
                {
                    x++;
                    i++;
                    GetPixel(x, y, i);
                    step = 1;
                }
                else if (y == 0)
                {
                    x++;
                    i++;
                    GetPixel(x, y, i);
                    step = -1;
                }
                else if (x == 0)
                {
                    y++;
                    i++;
                    GetPixel(x, y, i);
                    step = 1;
                }

                x += step;
                y -= step;

                i++;
            }
        }
    }
}