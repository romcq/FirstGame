using System;
using System.Drawing;

namespace FirstGame
{
    class MapChanges
    {
        public Image imageSet;

        public const int mapWidth = 20;
        public const int mapHeight = 30;

        public int[,] map = new int[mapHeight, mapWidth];

        public MapChanges() => imageSet = new Bitmap("D:\\GameImg\\arcanoid.png");

        public void AddLine()
        {
            for (int i = mapHeight - 2; i > 0; i--)
            {
                for (int j = 0; j < mapWidth; j += 2)
                {
                    map[i, j] = map[i - 1, j];
                }
            }
            Random r = new Random();
            for (int j = 0; j < mapWidth; j += 2)
            {
                map[0, j] = r.Next(1, 5);
                map[0, j + 1] = r.Next(1, 5) + (r.Next(1, 5) * 10);
            }
        }

        public void DrawMap(Graphics g, Player player)
        {
            g.DrawImage(imageSet, new Rectangle(new Point(player.platformX, player.platformY), new Size(60, 20)), 398 + (170 * player.platformAnnimationFrame), 17, 150, 50, GraphicsUnit.Pixel);
            g.DrawImage(imageSet, new Rectangle(new Point(player.ballX, player.ballY), new Size(20, 20)), 806, 548, 73, 73, GraphicsUnit.Pixel);
            for (int i = mapHeight - 1; i >= 0; i--)
            {
                for (int j = mapWidth - 1; j >= 0; j--)
                {
                    if (map[i, j] == 1)
                    {
                        g.DrawImage(imageSet, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 16, 170, 59, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 2)
                    {
                        g.DrawImage(imageSet, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 16 + (77 * (map[i, j] - 1)), 170, 59, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 3)
                    {
                        g.DrawImage(imageSet, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 16 + (77 * (map[i, j] - 1)), 170, 59, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 4)
                    {
                        g.DrawImage(imageSet, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 16 + (77 * (map[i, j] - 1)), 170, 59, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 5)
                    {
                        g.DrawImage(imageSet, new Rectangle(new Point(j * 20, i * 20), new Size(40, 20)), 20, 16 + (77 * (map[i, j] - 1)), 170, 59, GraphicsUnit.Pixel);
                    }
                }
            }
        }

        public void DrawArea(Graphics g) => g.DrawRectangle(Pens.Black, new Rectangle(0, 0, mapWidth * 20, mapHeight * 20));
    }
}
