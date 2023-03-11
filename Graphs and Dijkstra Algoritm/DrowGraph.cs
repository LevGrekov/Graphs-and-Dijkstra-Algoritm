using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_and_Dijkstra_Algoritm
{
    //
    class DrawGraph
    {
        Bitmap bitmap;
        Graphics graphics;

        Pen blackPen;
        Pen redPen;
        Pen greenPen;
        Pen selfLoopPen;
        Font fo;
        Brush br;

        PointF point;
        public int R = 30; //радиус окружности вершины

        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
            greenPen = new Pen(Color.Green);
            selfLoopPen = new Pen(Color.DarkGreen);
            selfLoopPen.Width = 1;
            fo = new Font("Times New Roman", 15);
            br = Brushes.Black;
        }
        public Bitmap GetBitmap() => bitmap;
        public void ClearPicture() => graphics.Clear(Color.White);
        public void drawVertex(int x, int y, string number)
        {
            graphics.FillEllipse(Brushes.LightGray, (x - R), (y - R), 2 * R, 2 * R);
            graphics.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 14 , y - 16);
            graphics.DrawString(number, fo, br, point);
        }
        public void drawSelectedVertex(int x, int y)
        {
            graphics.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
        }
        public void drawEdge(Vertex V1, Vertex V2, int weight)
        {
            
            if (V1 == V2)
            {
                graphics.DrawArc(selfLoopPen, (V1.x - 2 * R), (V1.y - 2 * R), 2 * R, 2 * R, 90, 270);
                drawVertex(V1.x, V1.y, V1.name.ToString());
            }
            else
            {
                //Махинация для измение толщины и цвета дуг графа
                var CEC = weight < 10 ? new AdjustableArrowCap(10, 30) : new AdjustableArrowCap(15,30);
                CEC.WidthScale = 0;
                greenPen.CustomEndCap = CEC;
                greenPen.Width = weight < 30 ? weight/2 : 15;
                if (weight > 0 && weight <= 15) greenPen.Color = Color.Green;
                if (weight > 15 && weight <= 30) greenPen.Color = Color.Orange;
                if (weight > 30) greenPen.Color = Color.Red;

                //

                graphics.DrawLine(greenPen, V1.x, V1.y, V2.x, V2.y);

                //Указать вес дуги
                var rand = new Random();
                var a = rand.NextDouble();
                var sign = (rand.Next(1,3) == 1) ? 1 : -1;

                point = new PointF((V1.x + V2.x) / 2 +  sign*(float)(20*Math.Cos(a*Math.PI)) , (V1.y + V2.y) / 2 + sign*(float)(20 * Math.Sin(a*Math.PI)));
                graphics.DrawString((weight).ToString(), fo, br, point);

                //Перересовываем заного вершины для корректного отображения дуг. Иначе будут идти до центра вершины
                drawVertex(V1.x, V1.y, V1.name.ToString());
                drawVertex(V2.x, V2.y, V2.name.ToString());
            }
        }
    }
    
}
