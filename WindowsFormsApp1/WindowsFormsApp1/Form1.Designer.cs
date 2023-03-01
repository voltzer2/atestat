namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.buttonInserareArce = new System.Windows.Forms.Button();
            this.buttonStergereArce = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonBFS = new System.Windows.Forms.Button();
            this.buttonDFS = new System.Windows.Forms.Button();
            this.buttonSortareaTopologica = new System.Windows.Forms.Button();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStergereGraf = new System.Windows.Forms.Button();
            this.buttonDijkstra = new System.Windows.Forms.Button();
            this.buttonStartDijkstra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxRezultat);
            this.panel1.Location = new System.Drawing.Point(20, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 506);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rezultat :";
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(294, 469);
            this.textBoxRezultat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.ReadOnly = true;
            this.textBoxRezultat.Size = new System.Drawing.Size(265, 20);
            this.textBoxRezultat.TabIndex = 0;
            // 
            // buttonInserareArce
            // 
            this.buttonInserareArce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserareArce.Location = new System.Drawing.Point(899, 20);
            this.buttonInserareArce.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserareArce.Name = "buttonInserareArce";
            this.buttonInserareArce.Size = new System.Drawing.Size(99, 50);
            this.buttonInserareArce.TabIndex = 1;
            this.buttonInserareArce.Text = "Inserare arce";
            this.buttonInserareArce.UseVisualStyleBackColor = true;
            this.buttonInserareArce.Click += new System.EventHandler(this.buttonInserareArce_Click);
            // 
            // buttonStergereArce
            // 
            this.buttonStergereArce.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStergereArce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergereArce.Location = new System.Drawing.Point(899, 90);
            this.buttonStergereArce.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStergereArce.Name = "buttonStergereArce";
            this.buttonStergereArce.Size = new System.Drawing.Size(99, 57);
            this.buttonStergereArce.TabIndex = 2;
            this.buttonStergereArce.Text = "Stergere arce";
            this.buttonStergereArce.UseVisualStyleBackColor = true;
            this.buttonStergereArce.Click += new System.EventHandler(this.buttonStergereArce_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(57, 20);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(750, 50);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonBFS
            // 
            this.buttonBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBFS.Location = new System.Drawing.Point(898, 161);
            this.buttonBFS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(100, 54);
            this.buttonBFS.TabIndex = 4;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            this.buttonBFS.Click += new System.EventHandler(this.buttonBFS_Click);
            // 
            // buttonDFS
            // 
            this.buttonDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDFS.Location = new System.Drawing.Point(899, 232);
            this.buttonDFS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(99, 56);
            this.buttonDFS.TabIndex = 5;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            this.buttonDFS.Click += new System.EventHandler(this.buttonDFS_Click);
            // 
            // buttonSortareaTopologica
            // 
            this.buttonSortareaTopologica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortareaTopologica.Location = new System.Drawing.Point(899, 310);
            this.buttonSortareaTopologica.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSortareaTopologica.Name = "buttonSortareaTopologica";
            this.buttonSortareaTopologica.Size = new System.Drawing.Size(99, 57);
            this.buttonSortareaTopologica.TabIndex = 6;
            this.buttonSortareaTopologica.Text = "Sortarea topologica";
            this.buttonSortareaTopologica.UseVisualStyleBackColor = true;
            this.buttonSortareaTopologica.Click += new System.EventHandler(this.buttonSortareaTopologica_Click);
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(888, 478);
            this.textBoxStart.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(127, 20);
            this.textBoxStart.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(912, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nod Start :";
            // 
            // buttonStergereGraf
            // 
            this.buttonStergereGraf.AutoSize = true;
            this.buttonStergereGraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergereGraf.Location = new System.Drawing.Point(893, 511);
            this.buttonStergereGraf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStergereGraf.Name = "buttonStergereGraf";
            this.buttonStergereGraf.Size = new System.Drawing.Size(113, 58);
            this.buttonStergereGraf.TabIndex = 9;
            this.buttonStergereGraf.Text = "Stergere graf";
            this.buttonStergereGraf.UseVisualStyleBackColor = true;
            this.buttonStergereGraf.Click += new System.EventHandler(this.buttonStergereGraf_Click);
            // 
            // buttonDijkstra
            // 
            this.buttonDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDijkstra.Location = new System.Drawing.Point(858, 383);
            this.buttonDijkstra.Name = "buttonDijkstra";
            this.buttonDijkstra.Size = new System.Drawing.Size(98, 56);
            this.buttonDijkstra.TabIndex = 10;
            this.buttonDijkstra.Text = "Algoritmul lui Dijkstra";
            this.buttonDijkstra.UseVisualStyleBackColor = true;
            this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
            // 
            // buttonStartDijkstra
            // 
            this.buttonStartDijkstra.AutoSize = true;
            this.buttonStartDijkstra.Location = new System.Drawing.Point(962, 392);
            this.buttonStartDijkstra.Name = "buttonStartDijkstra";
            this.buttonStartDijkstra.Size = new System.Drawing.Size(70, 39);
            this.buttonStartDijkstra.TabIndex = 11;
            this.buttonStartDijkstra.Text = "Continuare";
            this.buttonStartDijkstra.UseMnemonic = false;
            this.buttonStartDijkstra.UseVisualStyleBackColor = true;
            this.buttonStartDijkstra.Click += new System.EventHandler(this.buttonStartDijkstra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1042, 613);
            this.Controls.Add(this.buttonStartDijkstra);
            this.Controls.Add(this.buttonDijkstra);
            this.Controls.Add(this.buttonStergereGraf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.buttonSortareaTopologica);
            this.Controls.Add(this.buttonDFS);
            this.Controls.Add(this.buttonBFS);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonStergereArce);
            this.Controls.Add(this.buttonInserareArce);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmi grafuri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInserareArce;
        private System.Windows.Forms.Button buttonStergereArce;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonBFS;
        private System.Windows.Forms.Button buttonDFS;
        private System.Windows.Forms.Button buttonSortareaTopologica;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.Button buttonStergereGraf;
        private System.Windows.Forms.Button buttonDijkstra;
        private System.Windows.Forms.Button buttonStartDijkstra;
    }
}

