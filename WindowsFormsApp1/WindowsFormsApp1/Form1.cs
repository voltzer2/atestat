using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        RoundButton[] b;
        int cntTextBoxDijkstra;
        int nrNoduri;
        Timer timer2;
        Timer timer3;
        int[] salvare;
        int[] salvarePozX, salvarePozY;
        int[,] matrice;
        int[] grInt;
        int[] vizDFS;
        Timer timerDFS;
        int[] salvareDFS;
        int nrElemDFS;
        int p, u;
        int[] c;
        int[] vizBFS;
        Timer timerBFS;
        int pas;
        int[] pozX,pozY;
        TextBox[] TextBoxDijkstra;
        int INF=100000; 
        int[] D;
        int[] pred;
        int[,] cost;
        int[] s;
        public Form1()
        {
            InitializeComponent();
            grInt = new int[20];
            matrice = new int[20, 20];
            panel1.BackColor = Color.White;
            timer2 = new Timer();
            timer3= new Timer();
            b = new RoundButton[100];
            panel1.Click += new EventHandler(OnClickPanel);
            salvare = new int[2];
            salvarePozX = new int[2];
            salvarePozY = new int[2];
            pozX = new int[100];
            pozY = new int[100];
            TextBoxDijkstra=new TextBox[100];
        }


        public class RoundButton : Button
        {
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(grPath);
                base.OnPaint(e);
            }
        }

        Graphics l;
        private void OnClickPanel(object sender, EventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);
            b[nrNoduri] = new RoundButton();
            b[nrNoduri].Size = new Size(40, 40);
            b[nrNoduri].Text = nrNoduri + 1 + "";
            b[nrNoduri].Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            b[nrNoduri].Click += new EventHandler(OnClickButton1);
            b[nrNoduri].Location = new Point(point.X - 23, point.Y - 23);
            pozX[nrNoduri]= b[nrNoduri].Location.X-23;
            pozY[nrNoduri] = b[nrNoduri].Location.Y-23;
            panel1.Controls.Add(b[nrNoduri]);
            nrNoduri++;
        }

        void OnTick(object sender, EventArgs e)
        {
            if (salvare[0] != 0 && salvare[1] != 0)
            {
                Pen p = new Pen(Color.Black, 5);
                p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                Graphics g = panel1.CreateGraphics();
                if (salvarePozX[0] < salvarePozX[1] && salvarePozY[0] < salvarePozY[1])
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] - 15, salvarePozY[1] - 10);
                else if (salvarePozX[0] > salvarePozX[1] && salvarePozY[0] < salvarePozY[1])
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] + 15, salvarePozY[1] - 15);
                else if (salvarePozX[0] < salvarePozX[1] && salvarePozY[0] > salvarePozY[1])
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] - 15, salvarePozY[1] + 10);
                else if (salvarePozX[0] > salvarePozX[1] && salvarePozY[0] > salvarePozY[1])
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] + 15, salvarePozY[1] + 15);
                else
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1], salvarePozY[1]);
                matrice[salvare[0] - 1, salvare[1] - 1] = 1;
                grInt[salvare[1] - 1]++;
                salvare[0] = 0;
                salvare[1] = 0;
            }

        }

        private void OnClickButton1(object sender, EventArgs e)
        {
            Button b = (RoundButton)sender;
            try 
            {
                if (salvare[0] == 0 && salvare[1] == 0)
                {
                    salvare[0] = Convert.ToInt32(b.Text);
                    salvarePozX[0] = b.Location.X + 20;
                    salvarePozY[0] = b.Location.Y + 20;

                }
                else if (salvare[1] == 0 && salvare[0] != 0)
                {
                    salvare[1] = Convert.ToInt32(b.Text);
                    salvarePozX[1] = b.Location.X + 20;
                    salvarePozY[1] = b.Location.Y + 20;
                }
                else if (salvare[1] != 0 && salvare[0] == 0)
                {
                    salvare[0] = Convert.ToInt32(b.Text);
                    salvarePozX[0] = b.Location.X + 20;
                    salvarePozY[0] = b.Location.Y + 20;
                }
            }
            catch
            {
                
            }
        }
        private void buttonInserareArce_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer2.Tick += new EventHandler(OnTick);
            salvare[0] = 0;
            salvare[1] = 0;
            timer2.Start();
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
        }
        PaintEventArgs f;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OnTick2(object sender, EventArgs e)
        {
            if (salvare[0] != 0 && salvare[1] != 0)
            {
                Pen p = new Pen(Color.White, 5);
                p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                Graphics g = panel1.CreateGraphics();
                if (salvarePozX[0] < salvarePozX[1] && salvarePozY[0] < salvarePozY[1])
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] - 15, salvarePozY[1] - 10);
                else if (salvarePozX[0] > salvarePozX[1] && salvarePozY[0] < salvarePozY[1])
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] + 15, salvarePozY[1] - 15);
                else if (salvarePozX[0] < salvarePozX[1] && salvarePozY[0] > salvarePozY[1])
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] - 15, salvarePozY[1] + 10);
                else if (salvarePozX[0] > salvarePozX[1] && salvarePozY[0] > salvarePozY[1])
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] + 15, salvarePozY[1] + 15);
                else
                    g.DrawLine(p, salvarePozX[0], salvarePozY[0], salvarePozX[1] - 20, salvarePozY[1]);
                matrice[salvare[0] - 1, salvare[1] - 1] = 0;
                grInt[salvare[1] - 1]--;
                salvare[0] = 0;
                salvare[1] = 0;
            }
        }
        private void buttonStergereArce_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            salvare[0] = 0;
            salvare[1] = 0;
            timer3.Tick += new EventHandler(OnTick2);
            timer3.Start();
        }

        private void functieBFS(object sender, EventArgs e)
        {
            if (p > u)
            {
                for (int i = 0; i < nrNoduri; i++)
                    b[i].BackColor = Color.White;
                for (int i = 0; i <= u; i++)
                    textBoxRezultat.Text += Convert.ToString(c[i] + 1) + " ";
                timerBFS.Stop();
                buttonDFS.Enabled = true;
                buttonSortareaTopologica.Enabled = true;
                return;
            }
            int x = c[p];
            p++;
            for (int i = 0; i < nrNoduri; i++)
                if (matrice[x, i] == 1 && vizBFS[i] == 0)
                {
                    b[i].BackColor = Color.Green;
                    u++;
                    c[u] = i;
                    vizBFS[i] = 1;
                }
        }

        private void buttonBFS_Click(object sender, EventArgs e)
        {
            if (nrNoduri == 0)
            {
                MessageBox.Show("Desenati graful!");
                return;
            }
            buttonDFS.Enabled = false;
            buttonSortareaTopologica.Enabled = false;
            int start;
            textBoxRezultat.Text = "";
            richTextBox1.Show();
            richTextBox1.Text = "Breath First Search sau Parcurgerea in latime va examina in mod sistematic nodurile grafului, plecand de la un varf de start. Se viziteaza toti vecinii varfului de start,apoi toti vecinii nevizitati ai vecinilor s.a.m.d.";
            try
            {
                start = Convert.ToInt32(textBoxStart.Text) - 1;
            }
            catch
            {
                MessageBox.Show("Nod de start invalid");
                return;
            }
            timerBFS = new Timer();
            timerBFS.Tick += new EventHandler(functieBFS);
            p = 0;
            u = 0;
            c = new int[20];
            vizBFS = new int[20];
            c[p] = start;
            vizBFS[start] = 1;
            timerBFS.Interval = 2000;
            b[start].BackColor = Color.Green;
            timerBFS.Start();
        }

        void DFS(int x)
        {
            vizDFS[x] = 1;
            textBoxRezultat.Text += Convert.ToString(x + 1) + " ";
            salvareDFS[nrElemDFS] = x;
            nrElemDFS++;
            for (int v = 0; v < nrNoduri; v++)
                if (vizDFS[v] == 0)
                    if (matrice[x, v] == 1)
                        DFS(v);
        }

        private void functieDFS(object sender, EventArgs e)
        {
            if(nrElemDFS==pas)
            {
                for (int i = 0; i < nrNoduri; i++)
                    b[i].BackColor = DefaultBackColor;
                timerDFS.Stop();
                buttonBFS.Enabled = true;
                buttonSortareaTopologica.Enabled = true;
                return;
            }
            b[salvareDFS[pas]].BackColor = Color.Cyan;
            pas++;
        }

        private void buttonDFS_Click(object sender, EventArgs e)
        {
            if (nrNoduri == 0)
            {
                MessageBox.Show("Desenati graful!");
                return;
            }
            buttonBFS.Enabled = false;
            buttonSortareaTopologica.Enabled = false;
            int start;
            textBoxRezultat.Text = "";
            richTextBox1.Show();
            richTextBox1.Text = "Depth First Search sau Parcurgerea in adancime va examina in mod sistematic nodurile grafului, plecand de la un varf de start.Se viziteaza primul vecin nevizitat (fie acesta x), apoi primul vecin nevizitat al lui x s.a.m.d.";
            try
            {
                start = Convert.ToInt32(textBoxStart.Text) - 1;
            }
            catch
            {
                MessageBox.Show("Nod de start invalid");
                return;
            }
            vizDFS = new int[20];
            b[start].BackColor = Color.Cyan;
            timerDFS = new Timer();
            timerDFS.Interval = 2000;
            salvareDFS=new int[20];
            DFS(start);
            timerDFS.Tick+=new EventHandler(functieDFS);
            timerDFS.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text =@"Pentru a insera noduri, apasati pe panoul gri,iar pentru a insera arce apasati pe butonul 'Inserare arce'";
        }

        private void buttonSortareaTopologica_Click(object sender, EventArgs e)
        {
            if (nrNoduri == 0)
            {
                MessageBox.Show("Desenati graful!");
                return;
            }
            textBoxRezultat.Text = "";
            richTextBox1.Show();
            richTextBox1.Text = "Prin sortarea topologica a unui graf orientat aciclic se intelege operatia de ordonare liniara a varfurilor sale, astfel incat daca in graf exista arcul (i,j), atunci i trebuie sa apara inaintea lui j.";
            int p = 1, u = 0;
            int[] c;
            c = new int[21];
            for (int i = 0; i < nrNoduri; i++)
                if (grInt[i] == 0)
                    c[++u] = i;
            while (p <= u)
            {
                int x = c[p];
                p++;
                for (int i = 0; i < nrNoduri; i++)
                    if (matrice[x, i] == 1)
                    {
                        grInt[i]--;
                        if (grInt[i] == 0)
                        {
                            u++;
                            c[u] = i;
                        }
                    }
            }
            for (int i = 1; i <= u; i++)
                textBoxRezultat.Text += Convert.ToString(c[i] + 1) + " ";
        }
        private void buttonDijkstra_Click(object sender, EventArgs e)
        {
            if (textBoxStart.Text == "")
            {
                MessageBox.Show("Introduceti nodul de start!");
                return;
            }
            if (nrNoduri == 0)
            {
                MessageBox.Show("Desenati graful!");
                return;
            }
            nodCurent = 0;
            buttonStartDijkstra.Enabled = true;
            richTextBox1.Text = "Algoritmul lui Dijkstra determină pentru un nod dat într-un graf orientat cu costuri costurile minime ale drumurilor care au acel nod ca extremitate inițială.";
            buttonDijkstra.Enabled = false;
            for (int i = 0; i<nrNoduri;i ++)
                for(int j=0;j<nrNoduri;j ++)
                    if(matrice[i,j] !=0 && i!=j)
                    {
                        TextBoxDijkstra[cntTextBoxDijkstra] = new TextBox();
                        if (pozX[i] < pozX[j] && pozY[i] < pozY[j])
                            TextBoxDijkstra[cntTextBoxDijkstra].Location = new Point((pozX[i] + pozX[j] ) / 2, (pozY[i] + pozY[j] +50) / 2);
                        else if (pozX[i] > pozX[j] && pozY[i] < pozY[j])
                            TextBoxDijkstra[cntTextBoxDijkstra].Location = new Point((pozX[i] + pozX[j] + 30) / 2, (pozY[i] + pozY[j] +50) / 2);
                        else if (pozX[i] < pozX[j] && pozY[i] > pozY[j])
                            TextBoxDijkstra[cntTextBoxDijkstra].Location = new Point((pozX[i] + pozX[j] ) / 2, (pozY[i] + pozY[j] + 50) / 2);
                        else if (pozX[i] > pozX[j] && pozY[i] > pozY[j])
                            TextBoxDijkstra[cntTextBoxDijkstra].Location = new Point((pozX[i] + pozX[j] + 30) / 2, (pozY[i] + pozY[j] + 50) / 2);
                        else
                            TextBoxDijkstra[cntTextBoxDijkstra].Location = new Point((pozX[i] + pozX[j] ) / 2, (pozY[i] + pozY[j]+35) / 2);
                        TextBoxDijkstra[cntTextBoxDijkstra].Size = new Size(30, 27);
                        panel1.Controls.Add(TextBoxDijkstra[cntTextBoxDijkstra]);
                        TextBoxDijkstra[cntTextBoxDijkstra].MouseMove += new MouseEventHandler(tb_MouseMove);
                        TextBoxDijkstra[cntTextBoxDijkstra].MouseDown += new MouseEventHandler(tb_MouseDown);
                        cntTextBoxDijkstra++;
                    }
        }

        protected void tb_MouseMove(object sender, MouseEventArgs e)
        {
            TextBox tb2 = (TextBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                tb2.Left = e.X + tb2.Left;
                tb2.Top = e.Y + tb2.Top;
            }
        }

        protected void tb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point MouseDownLocation = e.Location;
            }
        }


        void PrelucrareDijkstra (int x0)
        {
            int cnt = 0;
            cost = new int[100, 100];
            pred = new int[100];
            D = new int[100];
            s = new int[100];

            for (int i = 0; i < nrNoduri; i++)
                for (int j = 0; j < nrNoduri; j++)
                    if (i != j)
                        cost[i, j] = INF;
            for (int i = 0; i < nrNoduri; i++)
                for (int j = 0; j < nrNoduri; j++)
                    if (matrice[i, j] != 0)
                    {
                        cost[i, j] = Convert.ToInt32(TextBoxDijkstra[cnt].Text);
                        cnt++;
                    }
            for (int i = 0; i < nrNoduri; i++)
                if (i == x0)
                {
                    D[i] = 0; 
                    pred[i] = 0;
                }
                else if (cost[x0, i] < INF)
                {
                    D[i] = cost[x0, i];
                    pred[i] = x0;
                }
                else
                {
                    D[i] = INF;
                    pred[i] = 0;
                }
            s[x0] = 1;
            for (int k = 0; k < nrNoduri - 1; k++)
            {
                int x, mini = INF;
                x = new int();
                for (int i = 0; i < nrNoduri; i++)
                    if (s[i] == 0 && mini > D[i])
                    {
                        mini = D[i];
                        x = i;
                    }
                if (mini == INF)
                    break;
                s[x] = 1;
                for (int y = 0; y < nrNoduri; y++)
                    if (D[x] + cost[x, y] < D[y] && s[y] == 0)
                    {
                        D[y] = D[x] + cost[x, y];
                        pred[y] = x;
                    }
            }
        }

        void functieDEcolorareDijkstra()
        {
            for (int j = 0; j < nrNoduri; j++)
                if(j!=x0)
                    b[j].BackColor = Color.White;
        }

        int nodCurent=0,x0;

        public void buttonStartDijkstra_Click(object sender, EventArgs e)
        {
            if (nrNoduri == 0)
            {
                MessageBox.Show("Desenati graful!");
                return;
            }
            if(textBoxStart.Text=="")
                {
                    MessageBox.Show("Introduceti nodul de start!");
                    return;
                }
            if (nodCurent==nrNoduri)
                buttonDijkstra.Enabled = true;
            textBoxRezultat.Text = "";
            for (int i = 0; i < cntTextBoxDijkstra; i++)
                if (TextBoxDijkstra[i].Text == "")
                {
                    MessageBox.Show("Completati toate costurile!");
                    return;
                }
            x0 = new int();
            x0 = Convert.ToInt32(textBoxStart.Text) - 1;
            b[x0].BackColor = Color.Red;
            PrelucrareDijkstra(x0);
            richTextBox1.Text = "";
            if (nodCurent < nrNoduri)
            {
                if (nodCurent != x0)
                {
                    if (D[nodCurent] == INF)
                    {
                        int nodcur = nodCurent + 1, x01 = x0 + 1;
                        richTextBox1.Text = "Nu exista drum de la " + x01+1 + " la " + nodcur+1;
                        functieDEcolorareDijkstra();
                        b[x0].BackColor = Color.White;
                    }
                    else
                    {
                        int nodcur = nodCurent + 1, x01 = x0  +1;
                        richTextBox1.Text = "De la nodul " + x01 + " la " + nodcur + " costul drumului este " + D[nodCurent];
                        textBoxRezultat.Text = Convert.ToString(x0 + 1) + " ";
                        afisare_drum(nodCurent);
                    }
                }
                else
                    richTextBox1.Text = "Apasati din nou START pentru ca de la nodul " + x0+1 + " la nodul " + x0+1 + " nu exista drum";
                nodCurent++;
                buttonDijkstra.Enabled = true;
            }
            else
                buttonStartDijkstra.Enabled = false;
        }
        void afisare_drum(int i)
        {
            if (i == 0)
            {
                functieDEcolorareDijkstra();
                return; 
            }
            afisare_drum(pred[i]);
            textBoxRezultat.Text+= Convert.ToString(i+1) + " ";
            b[i].BackColor = Color.Red;
        }
        private void buttonStergereGraf_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nrNoduri; i++)
            {
                panel1.Controls.Remove(b[i]);
                grInt[i]=0;
                for (int j = 0; j < nrNoduri; j++)
                    matrice[i, j] = 0;
            }
            for (int i = 0; i < cntTextBoxDijkstra; i++)
                panel1.Controls.Remove(TextBoxDijkstra[i]);
            cntTextBoxDijkstra = 0;
            nrNoduri = 0;
            panel1.Refresh();
        }

    }
}
