namespace Graphs_and_Dijkstra_Algoritm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.Panel();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.BuildExistingGraphButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DijkstraEnd = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DijstraStart = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MatrixOutWindow = new System.Windows.Forms.RichTextBox();
            this.EntryVWindow = new System.Windows.Forms.DomainUpDown();
            this.ExitVWindow = new System.Windows.Forms.DomainUpDown();
            this.EdgeBuilder = new System.Windows.Forms.Button();
            this.WeightWindow = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Amount_of_Vertices = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_of_Vertices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.DimGray;
            this.Menu.Controls.Add(this.OpenFileButton);
            this.Menu.Controls.Add(this.BuildExistingGraphButton);
            this.Menu.Controls.Add(this.ExitButton);
            this.Menu.Controls.Add(this.label8);
            this.Menu.Controls.Add(this.DijkstraEnd);
            this.Menu.Controls.Add(this.label7);
            this.Menu.Controls.Add(this.button2);
            this.Menu.Controls.Add(this.label6);
            this.Menu.Controls.Add(this.DijstraStart);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.EntryVWindow);
            this.Menu.Controls.Add(this.ExitVWindow);
            this.Menu.Controls.Add(this.EdgeBuilder);
            this.Menu.Controls.Add(this.WeightWindow);
            this.Menu.Controls.Add(this.label5);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.label3);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.Amount_of_Vertices);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.RestartButton);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(196, 800);
            this.Menu.TabIndex = 0;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(13, 315);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(170, 32);
            this.OpenFileButton.TabIndex = 24;
            this.OpenFileButton.Text = "Открыть Файл";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // BuildExistingGraphButton
            // 
            this.BuildExistingGraphButton.Location = new System.Drawing.Point(12, 353);
            this.BuildExistingGraphButton.Name = "BuildExistingGraphButton";
            this.BuildExistingGraphButton.Size = new System.Drawing.Size(170, 61);
            this.BuildExistingGraphButton.TabIndex = 23;
            this.BuildExistingGraphButton.Text = "Построить Граф с Файла";
            this.BuildExistingGraphButton.UseVisualStyleBackColor = true;
            this.BuildExistingGraphButton.Click += new System.EventHandler(this.BuildExistingGraphButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 576);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(168, 34);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "Закрыть программу";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Маршрут до";
            // 
            // DijkstraEnd
            // 
            this.DijkstraEnd.Location = new System.Drawing.Point(124, 484);
            this.DijkstraEnd.Name = "DijkstraEnd";
            this.DijkstraEnd.ReadOnly = true;
            this.DijkstraEnd.Size = new System.Drawing.Size(59, 31);
            this.DijkstraEnd.TabIndex = 20;
            this.DijkstraEnd.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(4, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Алгоритм Дейкстра";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Start Algoritm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DijkstraAlgoritmStartButtonClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Начальная V";
            // 
            // DijstraStart
            // 
            this.DijstraStart.Location = new System.Drawing.Point(124, 447);
            this.DijstraStart.Name = "DijstraStart";
            this.DijstraStart.ReadOnly = true;
            this.DijstraStart.Size = new System.Drawing.Size(59, 31);
            this.DijstraStart.TabIndex = 16;
            this.DijstraStart.Text = "A";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Матр. Смежности";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuildAdjMatrix);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.MatrixOutWindow);
            this.panel1.Location = new System.Drawing.Point(0, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 184);
            this.panel1.TabIndex = 14;
            // 
            // MatrixOutWindow
            // 
            this.MatrixOutWindow.Location = new System.Drawing.Point(0, 0);
            this.MatrixOutWindow.Name = "MatrixOutWindow";
            this.MatrixOutWindow.Size = new System.Drawing.Size(196, 184);
            this.MatrixOutWindow.TabIndex = 0;
            this.MatrixOutWindow.Text = "";
            // 
            // EntryVWindow
            // 
            this.EntryVWindow.Location = new System.Drawing.Point(121, 150);
            this.EntryVWindow.Name = "EntryVWindow";
            this.EntryVWindow.ReadOnly = true;
            this.EntryVWindow.Size = new System.Drawing.Size(59, 31);
            this.EntryVWindow.TabIndex = 13;
            this.EntryVWindow.Text = "B";
            // 
            // ExitVWindow
            // 
            this.ExitVWindow.Location = new System.Drawing.Point(121, 119);
            this.ExitVWindow.Name = "ExitVWindow";
            this.ExitVWindow.ReadOnly = true;
            this.ExitVWindow.Size = new System.Drawing.Size(59, 31);
            this.ExitVWindow.TabIndex = 12;
            this.ExitVWindow.Text = "A";
            // 
            // EdgeBuilder
            // 
            this.EdgeBuilder.Location = new System.Drawing.Point(10, 225);
            this.EdgeBuilder.Name = "EdgeBuilder";
            this.EdgeBuilder.Size = new System.Drawing.Size(170, 34);
            this.EdgeBuilder.TabIndex = 11;
            this.EdgeBuilder.Text = "Создать Ребро";
            this.EdgeBuilder.UseVisualStyleBackColor = true;
            this.EdgeBuilder.Click += new System.EventHandler(this.EdgeBuilder_Click);
            // 
            // WeightWindow
            // 
            this.WeightWindow.Location = new System.Drawing.Point(121, 180);
            this.WeightWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeightWindow.Name = "WeightWindow";
            this.WeightWindow.Size = new System.Drawing.Size(59, 31);
            this.WeightWindow.TabIndex = 10;
            this.WeightWindow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выходящая";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Входящая";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Добавление Ребра";
            // 
            // Amount_of_Vertices
            // 
            this.Amount_of_Vertices.Location = new System.Drawing.Point(126, 58);
            this.Amount_of_Vertices.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.Amount_of_Vertices.Name = "Amount_of_Vertices";
            this.Amount_of_Vertices.Size = new System.Drawing.Size(54, 31);
            this.Amount_of_Vertices.TabIndex = 3;
            this.Amount_of_Vertices.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "число вершин";
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Silver;
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.Location = new System.Drawing.Point(12, 12);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(163, 34);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Сбросить";
            this.RestartButton.UseVisualStyleBackColor = false;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picture.Location = new System.Drawing.Point(210, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1278, 776);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Menu);
            this.MaximumSize = new System.Drawing.Size(1522, 856);
            this.MinimumSize = new System.Drawing.Size(1522, 856);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WeightWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_of_Vertices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Menu;
        public Button RestartButton;
        private Label label1;
        private PictureBox picture;
        private NumericUpDown Amount_of_Vertices;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button EdgeBuilder;
        private NumericUpDown WeightWindow;
        private DomainUpDown EntryVWindow;
        private DomainUpDown ExitVWindow;
        private Panel panel1;
        private RichTextBox MatrixOutWindow;
        private Button button1;
        private Label label7;
        private Button button2;
        private Label label6;
        private DomainUpDown DijstraStart;
        private Label label8;
        private DomainUpDown DijkstraEnd;
        private Button ExitButton;
        private Button OpenFileButton;
        private Button BuildExistingGraphButton;
    }
}