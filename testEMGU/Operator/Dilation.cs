using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEMGU.Operator
{
    class Dilation
    {
        private double[,] GaussianBlur;
        private Image<Bgr,byte> imageInput;
        public Bitmap GetBitmap (Image<Bgr,byte> input)
        {
            //input传入初始图片，传出bitmap
            imageInput = input;
            Bitmap bitmap = imageInput.ToBitmap();
            return bitmap;
        }
        public void Convolution()
        {
            //初始化高斯模糊卷积核
            int k = 273;
            GaussianBlur = new double[5, 5]{{(double)1/k,(double)4/k,(double)7/k,(double)4/k,(double)1/k},
                                            {(double)4/k,(double)16/k,(double)26/k,(double)16/k,(double)4/k},
                                            {(double)7/k,(double)26/k,(double)41/k,(double)26/k,(double)7/k},
                                            {(double)4/k,(double)16/k,(double)26/k,(double)16/k,(double)4/k},
                                            {(double)1/k,(double)4/k,(double)7/k,(double)4/k,(double)1/k}};
        }
        public Bitmap Smooth(Bitmap bitmap)
        {
            int[,,] InputPicture = new int[3, bitmap.Width, bitmap.Height];//以GRB以及位图的长宽建立整数输入的位图的数组

            Color color = new Color();//储存某一像素的颜色
            //循环使得InputPicture数组得到位图的RGB
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    InputPicture[0, i, j] = color.R;
                    InputPicture[1, i, j] = color.G;
                    InputPicture[2, i, j] = color.B;
                }
            }

            int[,,] OutputPicture = new int[3, bitmap.Width, bitmap.Height];//以GRB以及位图的长宽建立整数输出的位图的数组
            Bitmap smooth = new Bitmap(bitmap.Width, bitmap.Height);//创建新位图
            //循环计算使得OutputPicture数组得到计算后位图的RGB
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int R = 0;
                    int G = 0;
                    int B = 0;

                    //每一个像素计算使用高斯模糊卷积核进行计算
                    for (int r = 0; r < 5; r++)//循环卷积核的每一行
                    {
                        for (int f = 0; f < 5; f++)//循环卷积核的每一列
                        {
                            //控制与卷积核相乘的元素
                            int row = i - 2 + r;
                            int index = j - 2 + f;

                            //当超出位图的大小范围时，选择最边缘的像素值作为该点的像素值
                            row = row < 0 ? 0 : row;
                            index = index < 0 ? 0 : index;
                            row = row >= bitmap.Width ? bitmap.Width - 1 : row;
                            index = index >= bitmap.Height ? bitmap.Height - 1 : index;

                            //输出得到像素的RGB值
                            R += (int)(GaussianBlur[r, f] * InputPicture[0, row, index]);
                            G += (int)(GaussianBlur[r, f] * InputPicture[1, row, index]);
                            B += (int)(GaussianBlur[r, f] * InputPicture[2, row, index]);
                        }
                    }
                    color = Color.FromArgb(R, G, B);//颜色结构储存该点RGB
                    smooth.SetPixel(i, j, color);//位图存储该点像素值
                }
            }
            return smooth;
        }

    }
}
