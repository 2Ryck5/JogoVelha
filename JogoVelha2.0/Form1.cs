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

       // Variáveis

        int Jogador = -1;
        int Jogadas = 9;
        int[,] matriz = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        // Função chamada em qualquer evento de botão
        void Evento(int row, int colum)
        {
            if (matriz[row, colum] == 0)
            {
                Jogadas -= 1;
                TxtJogadas.Text = (Jogadas).ToString();

                Matriz(colum, row, ReplacePlayer());
            }
        }
        //----------------------------------------------

        // Faz alterações na Matriz Principal
        void Matriz(int colum, int row, int player)
        {

            matriz[row, colum] = player;

            TrocaDeTelas();
            ShowPlayer(colum, row, player);
        }
        //----------------------------------------------

        // Troca o Jogador entre X e Y
        int ReplacePlayer()
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
        //----------------------------------------------

        // Checa se todas as casas estão completas (Questão de empate)
        bool TudoCompleto()
        {
            bool anterior = false;
            bool nova = false;

            /* Testa se a casa anterior é verdadeira,
             * Se a casa for != 0 define a casa nova como true, caso contrario como false
             * Retorna a casa nova (True = Tudo completo, False = Falta alguma casa) */


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    if ((matriz[i, j] != 0) && !nova)
                    {
                        anterior = true;
                    }
                    if (anterior)
                    {
                        if (matriz[i, j] != 0)
                        {
                            nova = true;
                        }
                        else
                        {
                            nova = false;
                        }
                    }
                    if (nova)
                    {
                        anterior = nova;
                    }
                }
            }

            return nova;

        }
        //----------------------------------------------

        // Calcula os resultados
        int Resultados()
        {

            // Verificar linhas
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] == 1 && matriz[i, 1] == 1 && matriz[i, 2] == 1 && !TudoCompleto())
                {
                    return 1;
                }
                else if (matriz[i, 0] == -1 && matriz[i, 1] == -1 && matriz[i, 2] == -1 && !TudoCompleto())
                {
                    return -1;
                }
            }

            // Verificar colunas
            for (int i = 0; i < 3; i++)
            {
                if (matriz[0, i] == 1 && matriz[1, i] == 1 && matriz[2, i] == 1 && !TudoCompleto())
                {
                    return 1;
                }
                else if (matriz[0, i] == -1 && matriz[1, i] == -1 && matriz[2, i] == -1 && !TudoCompleto())
                {
                    return -1;
                }
            }

            // Verificar diagonais
            if ((matriz[0, 0] == 1 && matriz[1, 1] == 1 && matriz[2, 2] == 1) ||
                (matriz[0, 2] == 1 && matriz[1, 1] == 1 && matriz[2, 0] == 1) && !TudoCompleto())
            {
                return 1;
            }
            if ((matriz[0, 0] == -1 && matriz[1, 1] == -1 && matriz[2, 2] == -1) ||
                (matriz[0, 2] == -1 && matriz[1, 1] == -1 && matriz[2, 0] == -1) && !TudoCompleto())
            {
                return -1;
            }

            return 0;
        }
        //----------------------------------------------

        // Troca as telas 
        void TrocaDeTelas()
        {
            Empate empate1 = new Empate();
            XWin xwin = new XWin();
            YWin ywin = new YWin();

            if (Resultados() == 1)
            {
                this.Hide();
                xwin.Closed += (s, args) => this.Close();
                xwin.Show();
            }
            if (Resultados() == -1)
            {
                this.Hide();
                ywin.Closed += (s, args) => this.Close();
                ywin.Show();
            }
            if (TudoCompleto() && Jogadas < 1)
            {
                this.Hide();
                empate1.Closed += (s, args) => this.Close();
                empate1.Show();
            }
        }
        //----------------------------------------------

        // Mostra as jogadas no form (OUTPUT)
        void ShowPlayer(int colum, int row, int player)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string pos = i + " " + j;

                    if (matriz[i, j] == 1)
                    {
                        if (pos == "0 0")
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
                    if (matriz[i, j] == -1)
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
        //----------------------------------------------

        // Botões (INPUT)
        private void BntA00_Click(object sender, EventArgs e)
        {
            Evento(0, 0);
        }

        private void BntA01_Click(object sender, EventArgs e)
        {
            Evento(0, 1);
        }

        private void BntA02_Click(object sender, EventArgs e)
        {
            Evento(0, 2);
        }

        private void BntA10_Click(object sender, EventArgs e)
        {
            Evento(1, 0);
        }

        private void BntA11_Click(object sender, EventArgs e)
        {
            Evento(1, 1);
        }

        private void BntA12_Click(object sender, EventArgs e)
        {
            Evento(1, 2);
        }

        private void BntA20_Click(object sender, EventArgs e)
        {
            Evento(2, 0);
        }

        private void BntA21_Click(object sender, EventArgs e)
        {
            Evento(2, 1);
        }

        private void BntA22_Click(object sender, EventArgs e)
        {
            Evento(2, 2);
        }
        //----------------------------------------------
    }
}

