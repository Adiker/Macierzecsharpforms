using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macierzeforms
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MultiplyMatricesButton.Click += MultiplyMatricesButton_Click;
        }


        private void InitializeTableLayoutPanel1(double[,] matrix1, TableLayoutPanel tableLayoutPanel1)
        {
            
            tableLayoutPanel1.Controls.Clear();
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            tableLayoutPanel1.RowCount = rows;
            tableLayoutPanel1.ColumnCount = columns;

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    TextBox textBox = new TextBox();
                    textBox.Text = "0";
                    matrix1[i, j] = double.Parse(textBox.Text);
                    tableLayoutPanel1.Controls.Add(textBox, j, i);

                }
            }
            
        }
        private void InitializeTableLayoutPanel2(double[,] matrix2, TableLayoutPanel tableLayoutPanel2)
        {
            tableLayoutPanel2.Controls.Clear();
            int rows = matrix2.GetLength(0);
            int columns = matrix2.GetLength(1);
            tableLayoutPanel2.RowCount = rows;
            tableLayoutPanel2.ColumnCount = columns;

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {

                    TextBox textBox = new TextBox();
                    textBox.Text = "0";
                    matrix2[i, j] = double.Parse(textBox.Text);
                    tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    tableLayoutPanel2.Controls.Add(textBox, j, i);
                }
            }
            
        }


        private void MatricesCreate_Click(object sender, EventArgs e)
        {
            int rows1, rows2, columns1, columns2;
            if ((int)FirstMatrixRowsNumericUpDown.Value > 0 && (int)FirstMatrixColumnsNumericUpDown.Value > 0 &&
                (int)SecondMatrixRowsNumericUpDown.Value > 0 && (int)SecondMatrixColumnsNumericUpDown.Value > 0)
            {
                rows1 = (int)FirstMatrixRowsNumericUpDown.Value;
                columns1 = (int)FirstMatrixColumnsNumericUpDown.Value;
                rows2 = (int)SecondMatrixRowsNumericUpDown.Value;
                columns2 = (int)SecondMatrixColumnsNumericUpDown.Value;


                double[,] matrix1 = new double[rows1, columns1];
                double[,] matrix2 = new double[rows2, columns2];


                if (columns1 != rows2)
                {
                    MessageBox.Show("Liczba kolumn macierzy 1 musi się równać liczbie wierszy macierzy 2.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                InitializeTableLayoutPanel1(matrix1, tableLayoutPanel1);
                InitializeTableLayoutPanel2(matrix2, tableLayoutPanel2);




            }
        }
       

        private void MultiplyMatricesButton_Click(object sender, EventArgs e)
            {

            int rows1 = tableLayoutPanel1.RowCount;
            int columns1 = tableLayoutPanel1.ColumnCount;
            int rows2 = tableLayoutPanel2.RowCount;
            int columns2 = tableLayoutPanel2.ColumnCount;

               double[,] matrix1 = new double[rows1, columns1];
               double [,] matrix2 = new double[rows2, columns2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    TextBox textBox = tableLayoutPanel1.GetControlFromPosition(j, i) as TextBox;
                    bool isdouble = double.TryParse(textBox.Text, out double result);
                    if (isdouble)
                    {
                        matrix1[i, j] = double.Parse(textBox.Text); 
                    }
                    else
                    {
                        MessageBox.Show("Brawo, teraz podaj liczbę w każdym polu");
                        return;
                    }
                }
            }

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    TextBox textBox = tableLayoutPanel2.GetControlFromPosition(j, i) as TextBox;
                    bool isdouble = double.TryParse(textBox.Text, out double result);
                    if (result > 0)
                    {
                        matrix2[i, j] = double.Parse(textBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Brawo, teraz podaj liczbę w każdym polu");
                        return;
                    }
                }
            }

            int rows3 = rows1;
            int columns3 = columns2;
            double[,] resultMatrix = new double[rows3, columns3];

            for (int i = 0; i < rows3; i++)
            {
                for (int j = 0; j < columns3; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < columns1; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            tableLayoutPanel3.Controls.Clear();
            tableLayoutPanel3.RowCount = rows3;
            tableLayoutPanel3.ColumnCount = columns3;

            for (int i = 0; i < rows3; i++)
            {
                for (int j = 0; j < columns3; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = resultMatrix[i, j].ToString();
                    tableLayoutPanel3.Controls.Add(textBox, j, i);
                }
            }




        }

       
    }
    }

