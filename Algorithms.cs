using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace coins
{
    public class DIP
    {
        public static void GrayScale(ref Bitmap a)
        {
            Color pixel;
            int average;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    average = (pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(average, average, average);
                    a.SetPixel(x, y, gray);
                }
            }
        }
        public static void Binary(ref Bitmap a)
        {
            Color pixel;
            int avg;
            int threshold = 200;
            for (int x = 0; x < a.Width; x++)
            {

                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    avg = (pixel.R + pixel.G + pixel.B) / 3;

                    if (avg < threshold)
                        a.SetPixel(x, y, Color.Black);
                    else
                        a.SetPixel(x, y, Color.White);
                }
            }
        }

    }
    public class Algorithms
    {
        public const float PESO_FIVE     = 5;
        public const float PESO_ONE      = 1;
        public const float CENT_25       = 0.25f;
        public const float CENT_10       = 0.10f;
        public const float CENT_5        = 0.05f;
        public static void CountCoins(Bitmap a, ref float res, ref int count)
        {

            Color pixel;
            bool[,] visited = new bool[a.Width, a.Height];

            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    if (visited[x,y]) { continue; }

                    visited[x, y] = true;

                    pixel = a.GetPixel(x, y);
                    int pixelCount;

                    if (IsBlack(pixel))
                    {
                        pixelCount = BFS(ref a, ref visited, x, y);
                        if (pixelCount < 1000)
                            continue;

                        count++;
                        res += GetCoinType(pixelCount);
                    }
                }
            }

        }

        private static float GetCoinType(int pixelCount)
        {
            if (pixelCount > 7000)
				return PESO_FIVE;
			if (pixelCount > 5000)
				return PESO_ONE;
			if (pixelCount > 4000)
                return CENT_25;
			if (pixelCount > 3000)
                return CENT_10;
			if (pixelCount > 1000)
                return CENT_5;
			return 0; 
        }
        private static int BFS(ref Bitmap a, ref bool[,] visited, int x, int y)
        {
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue([x, y]);
            int pixelCount = 0;
            int[] top;
            while (queue.Count > 0)
            {
                top = queue.Dequeue();
                pixelCount++;
                int currX = top[0], currY = top[1];
                
                if (currY - 1 >= 0 && a.GetPixel(currX, currY - 1).R == 0 && !visited[currX, currY - 1])
                {
                    queue.Enqueue([currX, currY - 1]);
                    visited[currX, currY - 1] = true;
                }
                if (currY + 1 < a.Height && a.GetPixel(currX, currY + 1).R == 0 && !visited[currX, currY + 1])
                {
                    queue.Enqueue([currX, currY + 1]);
                    visited[currX, currY + 1] = true;
                }
                if (currX - 1 >= 0 && a.GetPixel(currX - 1, currY).R == 0 && !visited[currX - 1, currY])
                {
                    queue.Enqueue([currX - 1, currY]);
                    visited[currX - 1, currY] = true;
                }
                if (currX + 1 < a.Width && a.GetPixel(currX + 1, currY).R == 0 && !visited[currX + 1, currY])
                {
                    queue.Enqueue([currX + 1, currY]);
                    visited[currX + 1, currY] = true;
                }

            }
            return pixelCount;
        }

        private static bool IsBlack(Color a)
        {
            return a.R == 0;
        }

    }
}
