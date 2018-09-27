using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Processing
    {
        public Processing()
        {

        }

        public static bool ConvertToGray(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c1 = bitmap.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = g1 = b1 = gray;
                    bitmap.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool HorizontalMirroring(Bitmap bitmap)
        {
            int startColumn = 0;
            int endColumn = bitmap.Width - 1;
            while (Math.Abs(endColumn - startColumn) > 2)
            {
                for (int line = 0; line < bitmap.Height; line++)
                {
                    Color c1 = bitmap.GetPixel(startColumn, line);
                    Color c2 = bitmap.GetPixel(endColumn, line);

                    bitmap.SetPixel(startColumn, line, c2);
                    bitmap.SetPixel(endColumn, line, c1);
                }
                endColumn--;
                startColumn++;
            }
            return true;
        }

        public static bool VerticallMirroring(Bitmap bitmap)
        {
            int startLine = 0;
            int endLine = bitmap.Height - 1;
            while (Math.Abs(endLine - startLine) > 2)
            {
                for (int column = 0; column < bitmap.Width; column++)
                {
                    Color c1 = bitmap.GetPixel(column, startLine);
                    Color c2 = bitmap.GetPixel(column, endLine);

                    bitmap.SetPixel(column, startLine, c2);
                    bitmap.SetPixel(column, endLine, c1);
                }
                endLine--;
                startLine++;
            }
            return true;
        }

        public static bool Quantize(Bitmap bitmap, int nquant)
        {
            int[] rangeNumbers = new int[nquant];
            int quantRange = (int)Math.Floor((double)byte.MaxValue / nquant);
            int firstValue = (int)Math.Floor((double)quantRange / 2);

            for (int i = 0; i < nquant; i++)
            {
                rangeNumbers[i] = firstValue;
                firstValue += quantRange;
            }

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c1 = bitmap.GetPixel(i, j);
                    int r1 = c1.R;

                    int index = 0;
                    int range = Math.Abs(rangeNumbers[0] - r1);
                    for (int i2 = 1; i2 < nquant; i2++, index++)
                    {
                        int range2 = Math.Abs(r1 - rangeNumbers[i2]);
                        if (range < range2)
                            break;
                        else
                            range = range2;
                    }
                    bitmap.SetPixel(i, j, Color.FromArgb(rangeNumbers[index], rangeNumbers[index], rangeNumbers[index]));
                }
            }
            return true;
        }

        public static bool isGrayScale(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c1 = bitmap.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    if (r1 != g1 || r1 != b1)
                        return false;
                }
            }
            return true;
        }

        public static IList<HistogramInfo> CreateHistogramInfo(Bitmap copy)
        {
            IList<int> listOfValues = new List<int>(); 

            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    Color c1 = copy.GetPixel(i, j);
                    listOfValues.Add(c1.R);
                }
            }

            return listOfValues.GroupBy(p => p, (key, g) => new HistogramInfo { Value = key, Total = g.Count() }).OrderBy(p => p.Value).ToList();
        }
    }
}
