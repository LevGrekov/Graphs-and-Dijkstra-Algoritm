using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs_and_Dijkstra_Algoritm
{
    public partial class WorkWithFileForm : Form
    {
        public WorkWithFileForm()
        {
            this.Text = "Загрузить Граф по Матрице Смежности";
            InitializeComponent();
            button2.Click += button2_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            this.textBox1.Text = File.ReadAllText("GraphAdjMatrix.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;

            using (FileStream File = new FileStream("GraphAdjMatrix.txt", FileMode.Truncate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(data);
                File.Write(array,0, array.Length);
            }
            MessageBox.Show("Файл Сохранён");
        }
    }
}
