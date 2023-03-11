
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Graphs_and_Dijkstra_Algoritm
{
    public partial class Form1 : Form
    {
        DrawGraph GDraw;
        Graph G = new Graph();

        int selectedExit = -1;
        int selectedEntry = -1;

        public Form1()
        {

            InitializeComponent();
            this.Text = "Графострой 3000 и Алгоритм Дейкстры";
            GDraw = new DrawGraph(picture.Width, picture.Height);
            picture.Image = GDraw.GetBitmap();
            RestartButton.Click += ReDrawButtonClick;
            Amount_of_Vertices.Click += ReDrawButtonClick;
            DrawVertexes();

        }

        public void DrawVertexes()
        {
            //Обнуление всего
            G.Vertices.Clear();
            G.Edges.Clear();
            GDraw.ClearPicture();
            picture.Image = GDraw.GetBitmap();

            //Для удобстава. Помещает имя последней вершины в окно для поиска Маршрута в алгортиме дейкстры 
            var a = (char)(64 + int.Parse(Amount_of_Vertices.Text));
            DijkstraEnd.Text = a.ToString();

            int count = int.Parse(Amount_of_Vertices.Text);
            double Rx = 500;
            double Ry = 300;
            char name = 'A';
            // Цикл По Элипсу
            for (double angle = 0.0; angle < 2 * Math.PI; angle += 2 * Math.PI / count)
            {
                if (G.Vertices.Count == count) break;
                int x = (int)(Rx * Math.Cos(angle - Math.PI / 12) + picture.Width / 2); // Делаем элипс кривоватым
                int y = (int)(Ry * Math.Sin(angle) + picture.Height / 2);

                //Непосредственное добавление вершин в граф и на рисунок 
                G.Vertices.Add(new Vertex(x, y, name));
                GDraw.drawVertex(x, y, name.ToString());

                picture.Image = GDraw.GetBitmap();

                DijkstraEnd.Items.Add(name);
                DijstraStart.Items.Add(name);
                EntryVWindow.Items.Add(name);
                ExitVWindow.Items.Add(name);

                name++;

            }
        }

        private void EdgeBuilder_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(WeightWindow.Text);
            int exitV = char.Parse(ExitVWindow.Text) - 'A';
            int entryV = char.Parse(EntryVWindow.Text) - 'A';
            var E = new Edge(G.Vertices[exitV], G.Vertices[entryV], weight);
            G.Edges.Add(E);
            GDraw.drawEdge(G.Vertices[exitV], G.Vertices[entryV], weight);
            picture.Image = GDraw.GetBitmap();
        }
        void ReDrawButtonClick(object sender, EventArgs e)
        {
            DrawVertexes();
        }

        //Вывод матрицы смежности
        private void BuildAdjMatrix(object sender, EventArgs e)
        {
            var matrix = G.Fill_Adjacency_Matrix();
            var sb = new StringBuilder();
            sb.Append("   ");
            for (int n = 0; n < matrix.GetLength(0); n++)
            {
                sb.Append(G.Vertices[n].name);
                sb.Append(' ');
            }
            sb.Append("\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sb.Append(G.Vertices[i].name + " ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j]);
                    sb.Append(' ');
                }
                sb.Append("\n");
            }
            MatrixOutWindow.Text = sb.ToString();
            MessageBox.Show(sb.ToString());
        }
        private void DijkstraAlgoritmStartButtonClick(object sender, EventArgs e)
        {

            int start = char.Parse(DijstraStart.Text) - 'A';
            int end = char.Parse(DijkstraEnd.Text) - 'A';
            MatrixOutWindow.Text = G.Dijkstra_Algoritm(start, end);
        }

        //Для ручного рисования Ребер графа
        
        private void picture_Click(object sender, MouseEventArgs e)
        {
            int weight = int.Parse(WeightWindow.Text);
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < G.Vertices.Count; i++)
                {
                    if (Math.Pow((G.Vertices[i].x - e.X), 2) + Math.Pow((G.Vertices[i].y - e.Y), 2) <= GDraw.R * GDraw.R)
                    {
                        if (selectedExit == -1)
                        {
                            GDraw.drawSelectedVertex(G.Vertices[i].x, G.Vertices[i].y);
                            selectedExit = i;
                            picture.Image = GDraw.GetBitmap();
                            break;
                        }
                        if (selectedEntry == -1)
                        {
                            GDraw.drawSelectedVertex(G.Vertices[i].x, G.Vertices[i].y);
                            selectedEntry = i;

                            var E = new Edge(G.Vertices[selectedExit], G.Vertices[selectedEntry], weight);
                            G.Edges.Add(E);
                            GDraw.drawEdge(G.Vertices[selectedExit], G.Vertices[selectedEntry], weight);
                            selectedExit = -1;
                            selectedEntry = -1;
                            picture.Image = GDraw.GetBitmap();
                            break;
                        }
                    }
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) => Close();

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var newForm = new WorkWithFileForm();
            newForm.Show();
            newForm.Text = "Загрузить Граф по Матрице Смежности";
        }


        //Построить Массив С Графа!
        private void BuildExistingGraphButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("GraphAdjMatrix.txt").Take(26).ToArray();
                int size = lines.Length;
                int[,] arr = new int[size, size];

                // разобрать в массив
                for (int i = 0; i < size; i++)
                {
                    int[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    for (int j = 0; j < size; j++)
                    {
                        arr[i, j] = row[j];
                    }
                }

                var sb = new StringBuilder();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        sb.Append(arr[i, j] + " ");
                    }
                    sb.Append("\n");
                }

                MatrixOutWindow.Text = sb.ToString();


                //  Начало Движа!

                Amount_of_Vertices.Text = (arr.GetLength(0)).ToString();
                DrawVertexes();

                if (size >= 26)
                {
                    MessageBox.Show("Слишком Большой Граф", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (arr[i, j] != 0)
                        {
                            var E = new Edge(G.Vertices[i], G.Vertices[j], arr[i, j]);
                            G.Edges.Add(E);
                            GDraw.drawEdge(G.Vertices[i], G.Vertices[j], arr[i, j]);

                        }
                        else continue;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Файл не может быть обработан корректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}