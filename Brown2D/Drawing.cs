using System;
using System.Drawing;

namespace Brown2D;

internal class Drawing
{
    static Random random = new Random();
    public Pen pen = new Pen(Color.Red);
    int xp = 150;
    int yp = 150;
    static int maxBound;
    static int minBound;
    public static void getBounds(string minBoundStr, string maxBoundStr)
    {

        maxBound = int.Parse(maxBoundStr);
        minBound = int.Parse(minBoundStr);

        if (maxBound < minBound) throw new ArgumentOutOfRangeException();
    }

    public static Tuple<Bitmap,Point> Brown(int xp, int yp, Pen pen)
    {
        var oldX = xp;
        var oldY = yp;

        var bitmap = new Bitmap(300, 300);

        //for (int i = 0; i < 10; i++)
        {
            var x = random.Next(minBound, maxBound);
            var y = random.Next(minBound, maxBound);

            var newX = oldX + x;
            var newY = oldY + y;

            if (newX > 300)
            {
                newX -= 300;
                bitmap = draw(new Point(oldX, oldY), new Point(300, oldY), pen, bitmap);
                bitmap = draw(new Point(0, oldY), new Point(newX, newY), pen, bitmap);
            }
            else if (newX < 0)
            {
                newX += 300;
                bitmap = draw(new Point(oldX, oldY), new Point(0, oldY), pen, bitmap);
                bitmap = draw(new Point(300, oldY), new Point(newX, newY), pen, bitmap);
            }
            else if (newY > 300)
            {
                newY -= 300;
                bitmap = draw(new Point(oldX, oldY), new Point(oldX, 300), pen, bitmap);
                bitmap = draw(new Point(oldX, 0), new Point(newX, newY), pen, bitmap);
            }
            else if (newY < 0)
            {
                newY += 300;
                bitmap = draw(new Point(oldX, oldY), new Point(oldX, 0), pen, bitmap);
                bitmap = draw(new Point(oldX, 300), new Point(newX, newY), pen, bitmap);
            }
            else if (newX > 300 && newY > 300)
            {
                newX -= 300;
                newY -= 300;

                bitmap = draw(new Point(oldX, oldY), new Point(300, 300), pen, bitmap);
                bitmap = draw(new Point(0, 0), new Point(newX, newY), pen, bitmap);
            }
            else if (newX < 0 && newY < 0)
            {
                newX += 300;
                newY += 300;

                bitmap = draw(new Point(oldX, oldY), new Point(0, 0), pen, bitmap);
                bitmap = draw(new Point(300, 300), new Point(newX, newY), pen, bitmap);
            }
            else if (newX > 300 && newY < 0)
            {
                newX -= 300;
                newY += 300;

                bitmap = draw(new Point(oldX, oldY), new Point(300, 0), pen, bitmap);
                bitmap = draw(new Point(0, 300), new Point(newX, newY), pen, bitmap);
            }
            else if (newX < 0 && newY > 300)
            {
                newX += 300;
                newY -= 300;

                bitmap = draw(new Point(oldX, oldY), new Point(0, 300), pen, bitmap);
                bitmap = draw(new Point(300, 0), new Point(newX, newY), pen, bitmap);
            }
            else
            {
                var sPoint = new Point(oldX, oldY);
                var ePoint = new Point(newX, newY);

                bitmap = draw(sPoint, ePoint, pen, bitmap);
            }

            oldX = newX;
            oldY = newY;

        }
        return new Tuple<Bitmap, Point>(bitmap, new Point(oldX, oldY));
    }

    static Bitmap draw(Point start, Point end, Pen pen, Bitmap bitmap)
    {
        var bmp = bitmap;

        using (Graphics graphics = Graphics.FromImage(bmp))
        {
            graphics.DrawLine(pen, start, end);
        }

        return bmp;
    }

    public void setPicture(PictureBox pb)
    {
        var bmp = new Bitmap(300, 300);
        var brownResult = Brown(xp, yp, pen);
        var endPoint = brownResult.Item2;

        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.DrawImage(pb.Image, 0, 0);

            g.DrawImage(brownResult.Item1, 0, 0);
        }
        xp = endPoint.X;
        yp = endPoint.Y;
        pb.Image = bmp;
    }
}
