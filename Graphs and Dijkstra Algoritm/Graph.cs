using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_and_Dijkstra_Algoritm
{
    internal class Graph
    {
        
        public List<Vertex> Vertices;
        public List<Edge> Edges;
        public int[,] adjacencyMatrix => Fill_Adjacency_Matrix();
        public Graph(List<Vertex> vertices, List<Edge> edges)
        {
            Vertices = vertices;
            Edges = edges;
        }
        public Graph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public Graph(double[,] matr)
        {

        }

        //Матрица смежности 
        public int[,] Fill_Adjacency_Matrix()
        {
            var res = new int[Vertices.Count,Vertices.Count];
            for (int i=0; i < Vertices.Count; i++)
            {
                for (int j=0; j<Vertices.Count; j++)
                {
                    res[i, j] = 0;
                }
            }
            for (int i = 0; i < Edges.Count; i++)
            {
                res[Edges[i].Exit.number, Edges[i].Entry.number] = Edges[i].Waight;
            }
            return res;
        }

        public string Dijkstra_Algoritm(int start, int end)
        {

            int[] Dist = new int[Vertices.Count]; //Массив маршрутов до вершин, которые мы помечаем в алгоритме
            bool[] Marked = new bool[Vertices.Count]; //Информация помечена ли вершина
            int temp, index_of_minDist, min_dist; 
            var curr_prev = new int[Vertices.Count];//предыдущие пройденные вершины. Нужен для заполнения prev[]
            var prev = new int[Vertices.Count]; // Хранит Маршрут.

            //Инициализация вершин и расстояний
            for (int i = 0; i < Vertices.Count; i++)
            {
                Dist[i] = 10000; //Типа Бесконечность 
                Marked[i] = false;
                curr_prev[i] = -1;
            }
            Dist[start] = 0; // Путь из начала в начало
            curr_prev[start] = -2;
            prev[start] = -2;
            // -2 - спец.значение. Чтобы при выводе маршрута понять где остановиться 

            // Шаг алгоритма
            do
            {
                index_of_minDist = 10000;
                min_dist = 10000; // бесконечность
                
                for (int i = 0; i < Vertices.Count; i++)
                {
                    //Переписываем значения если находим более короткий путь
                    if ((Marked[i] == false) && (Dist[i] < min_dist))
                    { 
                        min_dist = Dist[i];
                        index_of_minDist = i;
                    }
                }


                if (index_of_minDist != 10000)
                {
                    for (int i = 0; i < Vertices.Count; i++)
                    {
                        //Проверяем в какие вершины ведут ребра 
                        if (adjacencyMatrix[index_of_minDist,i] > 0)
                        {
                            //добавляем вес ребер кротчайшего маршрута 
                            temp = min_dist + adjacencyMatrix[index_of_minDist,i];
                            if (temp < Dist[i])
                            {
                                Dist[i] = temp;
                                curr_prev[i] = index_of_minDist;
                            }
                        }
                    }
                    //помечаем вершину как пройденную и заносим её в массив хранящий маршрут
                    Marked[index_of_minDist] = true;
                    prev[index_of_minDist] = curr_prev[index_of_minDist];
                }
            } while (index_of_minDist < 10000);
            
            //Вывод
            var sb = new StringBuilder();
            sb.Append("\nКратчайшие расстояния до вершин: \n");

            //Просто пишем все Буквы 
            for (int i = 0; i < Vertices.Count; i++)
            {
                sb.Append(Vertices[i].name);
                sb.Append("  ");
            }

            sb.Append("\n");
            bool flag = false;// Проверяем можно ли попасть из вершины в другие

            //Выводим кротчайшие маршруты до всех вершин
            for (int i = 0; i < Vertices.Count; i++)
            {
                sb.Append(Dist[i] == 10000 ? "inf " : Dist[i] + " ");
                if (Dist[i] == 10000)
                {
                    flag = true;
                }
            }

            //Вывод Маршрута
            //Если путь до какой-то вершины = бесконечности, то отменяем вывод маршрута
            //потому что это вызывает сложности в обработке вывода
            sb.Append("\nКротчайший Маршрут\n");
            if (flag == false)
            {
                int k = end;
                var Stack = new Stack<int>();
                Stack.Push(-10); // -10 спец значение для остановки вывода из стэка
                Stack.Push(end); 

                // Бегаем по массиву и ищем маршрут. Записываем в стэк 
                for (int i = 0; k != -2; i++)
                {
                    if (i == k)
                    {
                        Stack.Push(prev[i]);
                        k = prev[i];
                        i = -1;
                    }
                }

                //Непосредственный вывод маршрута 
                while (Stack.Peek() != -10)
                {
                    if (Stack.Peek() == -2) Stack.Pop();
                    sb.Append((char)(Stack.Pop() + 65) + " ");
                }
            }
            
            //Если проблемы с выводом пути
            else
            {
                
                sb.Append("Сложности в построении Маршрута");
                // По сути при варианте, где из Начальной вершины нельзя попасть во все остальные 
                // Возникают ошибки которые у меня нет сил найти T_T 
            }
            
            return sb.ToString();

        }
    }

    //Вспомогательные Классы для Организации Графа
    class Vertex
    {
        public int x, y; //Координаты на Холсте 
        public char name;
        public int number => name - 'A';

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Vertex(int x, int y, char name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }

    class Edge
    {
        public Vertex Exit, Entry;
        public int Waight { get; set; } = 1;

        public Edge(Vertex exit, Vertex entry, int weight)
        {
            this.Exit = exit;
            this.Entry = entry;
            this.Waight = weight;
        }
    }

}
