using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSB_demo.Code
{
    class Decode
    {
        public static string decode(Bitmap bmp)
        {
            int colorUnit = 0;
            int charValue = 0;
            //
            string decodedText = String.Empty;
            //
            for (int i = 0; i < bmp.Height; i++)
            {
                //
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    //
                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnit % 3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        colorUnit++;
                        //
                        if (colorUnit % 8 == 0)
                        {
                            charValue = reverseBits(charValue);

                            //
                            if (charValue == 0)
                            {
                                return decodedText;
                            }
                            //
                            char m = (char)charValue;
                            //
                            decodedText += m.ToString();
                        }
                    }
                }
            }

            return decodedText;
        }
        public static int reverseBits(int n)
        {
            int ketqua = 0;

            for (int i = 0; i < 8; i++)
            {
                ketqua = ketqua * 2 + n % 2;

                n /= 2;
            }

            return ketqua;
        }
    }
}
