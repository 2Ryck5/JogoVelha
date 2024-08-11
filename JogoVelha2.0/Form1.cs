using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int Jogador = -1;
        int Jogadas = 9;
        int[,] matriz = new int[3, 3] { { 0,0,0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        public void Evento(int row, int colum)
        {
            if (matriz[row, colum] == 0)
            {
                Debug.WriteLine($"-------------------------");

                Jogadas -= 1;
                TxtJogadas.Text = (Jogadas).ToString();


                Matriz(colum, row, ReplacePlayer());
            }

        }

        public void Matriz(int colum, int row, int player)
        {

            matriz[row, colum] = player;

            foreach (var item in matriz)
            {
                Debug.WriteLine($"{item}");
            }

            Resultados()
            ShowPlayer(colum, row, player);
        }

        public int ReplacePlayer()
        {
            if (Jogador == 1)
            {
                TxtJogadorDaVez.Text = "X";
                Jogador = -1;

            }
            else
            {
                TxtJogadorDaVez.Text = "Y";
                Jogador = 1;
            }
            return Jogador;
        }


        public void Resultados()
        {


            Empate empate1 = new Empate();
            XWin xwin = new XWin();
            YWin ywin = new YWin();



        }

        public void ShowPlayer(int colum, int row, int player)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string pos = i + " " + j;

                    if (matriz[i,j] == 1)
                    {
                        if ( pos == "0 0")
                        {
                            BntA00.Text = "X";
                        }
                        if (pos == "0 1")
                        {
                            BntA01.Text = "X";
                        }
                        if (pos == "0 2")
                        {
                            BntA02.Text = "X";
                        }
                        if (pos == "1 0")
                        {
                            BntA10.Text = "X";
                        }
                        if (pos == "1 1")
                        {
                            BntA11.Text = "X";
                        }
                        if (pos == "1 2")
                        {
                            BntA12.Text = "X";
                        }
                        if (pos == "2 0")
                        {
                            BntA20.Text = "X";
                        }
                        if (pos == "2 1")
                        {
                            BntA21.Text = "X";
                        }
                        if (pos == "2 2")
                        {
                            BntA22.Text = "X";
                        }

                    }
                    if(matriz[i, j] == -1)
                    {
                        if (pos == "0 0")
                        {
                            BntA00.Text = "Y";
                        }
                        if (pos == "0 1")
                        {
                            BntA01.Text = "Y";
                        }
                        if (pos == "0 2")
                        {
                            BntA02.Text = "Y";
                        }
                        if (pos == "1 0")
                        {
                            BntA10.Text = "Y";
                        }
                        if (pos == "1 1")
                        {
                            BntA11.Text = "Y";
                        }
                        if (pos == "1 2")
                        {
                            BntA12.Text = "Y";
                        }
                        if (pos == "2 0")
                        {
                            BntA20.Text = "Y";
                        }
                        if (pos == "2 1")
                        {
                            BntA21.Text = "Y";
                        }
                        if (pos == "2 2")
                        {
                            BntA22.Text = "Y";
                        }
                    }

                }
            }
        }

        private void BntA00_Click(object sender, EventArgs e)
        {
            Evento(0,0);
        }

        private void BntA01_Click(object sender, EventArgs e)
        {
            Evento(0,1);
        }

        private void BntA02_Click(object sender, EventArgs e)
        {
            Evento(0,2);
        }

        private void BntA10_Click(object sender, EventArgs e)
        {
            Evento(1,0);
        }

        private void BntA11_Click(object sender, EventArgs e)
        {
            Evento(1, 1);
        }

        private void BntA12_Click(object sender, EventArgs e)
        {
            Evento(1,2);
        }

        private void BntA20_Click(object sender, EventArgs e)
        {
            Evento(2,0);
        }

        private void BntA21_Click(object sender, EventArgs e)
        {
            Evento(2,1);
        }

        private void BntA22_Click(object sender, EventArgs e)
        {
            Evento(2,2);
        }
    }
}
