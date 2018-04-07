using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSB_demo.Code
{
    class Encode
    {
        public enum State
        {
            Hiding,
            Fill_Zeros
        };

        public static Bitmap encode(string text, Bitmap bmp)
        {
            State state = State.Hiding;
            int charIndex = 0;
            int charValue = 0;
            long allPixelIndex = 0;
            int zero = 0;
            int R = 0, G = 0, B = 0;

            //VÒNG LẶP
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);
                    //Lấy ra LSB
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    for (int n = 0; n < 3; n++)
                    {
                        if (allPixelIndex % 8 == 0)
                        {
                            if (state == State.Fill_Zeros && zero == 8)
                            {
                                //Sử dụng pixel cuối trong hình
                                if ((allPixelIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                //trả về bitmap với text đã được giấu vào
                                return bmp;
                            }

                            //Kiểm tra xem tất cả các kí tự đã được giấu hết hay chưa
                            if (charIndex >= text.Length)
                            {
                                state = State.Fill_Zeros;
                            }
                            else
                            {
                                //chuyển tới kí tự tiếp theo và làm lại tiến trình
                                charValue = text[charIndex++];
                            }
                        }
                            //check xem pixel nào có chứa LSB đã được đổi bit
                            switch (allPixelIndex % 3)
                            {
                                case 0:
                                    {
                                        if (state == State.Hiding)
                                        {
                                            R += charValue % 2;

                                            charValue /= 2;
                                        }
                                    }
                                    break;
                                case 1:
                                    {
                                        if (state == State.Hiding)
                                        {
                                            G += charValue % 2;
                                            charValue /= 2;
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        if (state == State.Hiding)
                                        {
                                            B += charValue % 2;
                                            charValue /= 2;
                                        }
                                        bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                    }
                                    break;
                            }
                            allPixelIndex++;
                            if (state == State.Fill_Zeros)
                            {
                                zero++;
                            }
                        }
                    }
                }

            
            return bmp;
        }
    }
}
