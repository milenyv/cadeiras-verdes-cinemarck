using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamico02
{
    public partial class Form1 : Form
    {
        Button[,] b = new Button[10,20];
        char letra = 'A'; // 0100 0001 em decimal 65 e em hexa 41

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object cachorrinho, EventArgs peludinho)
        {
            int linha = 20;
            int coluna = 20;

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 20; j++)
                {

                    b[i, j] = new Button();
                    b[i, j].Name = "Botão " + (i + 1);
                    b[i, j].Text = "" + letra + (j + 1);
                    b[i, j].Location = new Point(coluna,linha);
                    b[i, j].BackColor = System.Drawing.Color.Chartreuse;
                    b[i, j].ClientSize = new System.Drawing.Size(40, 20);
                    coluna += 65;
                    
                    Controls.Add(b[i, j]);

                }
                linha += 20;
                coluna = 20;
                ++letra;
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {

        }
            }
        }
    

