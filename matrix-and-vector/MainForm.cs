using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix_and_vector
{
    public partial class MainForm : Form
    {
        double[] vector1 = { -2, 2, 1, -1 };
        double[] vector2 = { 1, 2, 3, 4 };
        double[,] matrix1 = { { 1, 2, 3, 4 }, { 4, 3, 2, 1 }, { -1, 2, 3, 0 }, { 1, -1, -2, 3 } };
        double[,] matrix2 = { { 4, 1, 3, -1 }, { -2, 3, -1, 4 }, { 3, 2, -3, 1 }, { 2, 3, -1, 2 } };
        double[,] matrix3 = { { 1, 3, 2 }, { 0, -1, 1 }, { -1, -2, 4 }, { 2, 0, 3 } };

        public MainForm()
        {
            InitializeComponent();
        }

        double[,] Vector2Matrix(double[] v)
        {
            double[,] m = new double[1, 4];
            for (int i = 0; i < 4; i++)
            {
                m[0, i] = v[i];
            }
            return m;
        }

        void Updating()
        {
            // Vector1
            vector1[0] = Convert.ToDouble(numericUpDown1.Value);
            vector1[1] = Convert.ToDouble(numericUpDown2.Value);
            vector1[2] = Convert.ToDouble(numericUpDown3.Value);
            vector1[3] = Convert.ToDouble(numericUpDown4.Value);

            // Vector2
            vector2[0] = Convert.ToDouble(numericUpDown5.Value);
            vector2[1] = Convert.ToDouble(numericUpDown6.Value);
            vector2[2] = Convert.ToDouble(numericUpDown7.Value);
            vector2[3] = Convert.ToDouble(numericUpDown8.Value);

            // Matrix1
            matrix1[0, 0] = Convert.ToDouble(numericUpDown9.Value);
            matrix1[0, 1] = Convert.ToDouble(numericUpDown10.Value);
            matrix1[0, 2] = Convert.ToDouble(numericUpDown11.Value);
            matrix1[0, 3] = Convert.ToDouble(numericUpDown12.Value);
            matrix1[1, 0] = Convert.ToDouble(numericUpDown13.Value);
            matrix1[1, 1] = Convert.ToDouble(numericUpDown14.Value);
            matrix1[1, 2] = Convert.ToDouble(numericUpDown15.Value);
            matrix1[1, 3] = Convert.ToDouble(numericUpDown16.Value);
            matrix1[2, 0] = Convert.ToDouble(numericUpDown17.Value);
            matrix1[2, 1] = Convert.ToDouble(numericUpDown18.Value);
            matrix1[2, 2] = Convert.ToDouble(numericUpDown19.Value);
            matrix1[2, 3] = Convert.ToDouble(numericUpDown20.Value);
            matrix1[3, 0] = Convert.ToDouble(numericUpDown21.Value);
            matrix1[3, 1] = Convert.ToDouble(numericUpDown22.Value);
            matrix1[3, 2] = Convert.ToDouble(numericUpDown23.Value);
            matrix1[3, 3] = Convert.ToDouble(numericUpDown24.Value);

            // Matrix2
            matrix2[0, 0] = Convert.ToDouble(numericUpDown25.Value);
            matrix2[0, 1] = Convert.ToDouble(numericUpDown26.Value);
            matrix2[0, 2] = Convert.ToDouble(numericUpDown27.Value);
            matrix2[0, 3] = Convert.ToDouble(numericUpDown28.Value);
            matrix2[1, 0] = Convert.ToDouble(numericUpDown29.Value);
            matrix2[1, 1] = Convert.ToDouble(numericUpDown30.Value);
            matrix2[1, 2] = Convert.ToDouble(numericUpDown31.Value);
            matrix2[1, 3] = Convert.ToDouble(numericUpDown32.Value);
            matrix2[2, 0] = Convert.ToDouble(numericUpDown33.Value);
            matrix2[2, 1] = Convert.ToDouble(numericUpDown34.Value);
            matrix2[2, 2] = Convert.ToDouble(numericUpDown35.Value);
            matrix2[2, 3] = Convert.ToDouble(numericUpDown36.Value);
            matrix2[3, 0] = Convert.ToDouble(numericUpDown37.Value);
            matrix2[3, 1] = Convert.ToDouble(numericUpDown38.Value);
            matrix2[3, 2] = Convert.ToDouble(numericUpDown39.Value);
            matrix2[3, 3] = Convert.ToDouble(numericUpDown40.Value);

            // Matrix3
            matrix3[0, 0] = Convert.ToDouble(numericUpDown41.Value);
            matrix3[0, 1] = Convert.ToDouble(numericUpDown42.Value);
            matrix3[0, 2] = Convert.ToDouble(numericUpDown43.Value);
            matrix3[1, 0] = Convert.ToDouble(numericUpDown44.Value);
            matrix3[1, 1] = Convert.ToDouble(numericUpDown45.Value);
            matrix3[1, 2] = Convert.ToDouble(numericUpDown46.Value);
            matrix3[2, 0] = Convert.ToDouble(numericUpDown47.Value);
            matrix3[2, 1] = Convert.ToDouble(numericUpDown48.Value);
            matrix3[2, 2] = Convert.ToDouble(numericUpDown49.Value);
            matrix3[3, 0] = Convert.ToDouble(numericUpDown50.Value);
            matrix3[3, 1] = Convert.ToDouble(numericUpDown51.Value);
            matrix3[3, 2] = Convert.ToDouble(numericUpDown52.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "V1 = ";
            richTextBox1.Text += Matrix.Vector2String(vector1);
            richTextBox1.Text += "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "M1 = \r\n";
            richTextBox1.Text += Matrix.Matrix2String(matrix1);
            richTextBox1.Text += "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "M1 × M2 = \r\n";
            richTextBox1.Text += Matrix.Matrix2String(Matrix.Multiplication(matrix1, matrix2));
            richTextBox1.Text += "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "M2 ×  M3 = \r\n";
            richTextBox1.Text += Matrix.Matrix2String(Matrix.Multiplication(matrix2, matrix3));
            richTextBox1.Text += "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "V1 ×  M1 = \r\n";
            richTextBox1.Text += Matrix.Matrix2String(Matrix.Multiplication(Vector2Matrix(vector1), matrix1));
            richTextBox1.Text += "\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "M1 × M1 = \r\n";
            richTextBox1.Text += Matrix.Matrix2String(Matrix.Multiplication(matrix1, matrix1));
            richTextBox1.Text += "\r\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "M1 + M2 = \r\n";
            richTextBox1.Text += Matrix.Matrix2String(Matrix.Addition(matrix1, matrix2));
            richTextBox1.Text += "\r\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "M1 - M2 = \r\n";
            richTextBox1.Text += Matrix.Matrix2String(Matrix.Subtraction(matrix1, matrix2));
            richTextBox1.Text += "\r\n";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "Norm of V1 = \r\n";
            richTextBox1.Text += Convert.ToString(Matrix.Norm(vector1));
            richTextBox1.Text += "\r\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Updating();
            double norm = Matrix.Norm(vector1);
            double[] v = new double[4];
            for (int i = 0; i < 4; i++)
            {
                v[i] = vector1[i] / norm;
            }
            richTextBox1.Text += "Unit Vector of V1 = \r\n";
            richTextBox1.Text += Matrix.Vector2String(v); ;
            richTextBox1.Text += "\r\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "V1 + V2 = \r\n";
            richTextBox1.Text += Matrix.Vector2String(Matrix.Addition(vector1, vector2));
            richTextBox1.Text += "\r\n";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "V1 - V2 = \r\n";
            richTextBox1.Text += Matrix.Vector2String(Matrix.Subtraction(vector1, vector2));
            richTextBox1.Text += "\r\n";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "V1 dot V2 = \r\n";
            richTextBox1.Text += Convert.ToString(Matrix.InnerProduct(vector1, vector2));
            richTextBox1.Text += "\r\n";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "Transpose of M3 = \r\n";
            richTextBox1.Text += Matrix.Matrix2String(Matrix.Transpose(matrix3));
            richTextBox1.Text += "\r\n";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Updating();
            richTextBox1.Text += "Determinant of M1 = \r\n";
            richTextBox1.Text += Convert.ToString(Matrix.Determinant(matrix1));
            richTextBox1.Text += "\r\n";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
