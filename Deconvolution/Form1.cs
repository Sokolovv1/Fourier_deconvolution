//Деконволюция свёртки методом 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Deconvolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
            double A1 = Convert.ToDouble(textBox_A1.Text);
            double A2 = Convert.ToDouble(textBox_A2.Text);
            double A3 = Convert.ToDouble(textBox_A3.Text);
            double[] A = { A1, A2, A3 };
            double Sigma1 = Convert.ToDouble(textBox_Sigma1.Text);
            double Sigma2 = Convert.ToDouble(textBox_Sigma2.Text);
            double Sigma3 = Convert.ToDouble(textBox_Sigma3.Text);
            double[] Sigma = { Sigma1, Sigma2, Sigma3 };
            double t0_1 = Convert.ToDouble(textBox_t01.Text);
            double t0_2 = Convert.ToDouble(textBox_t02.Text);
            double t0_3 = Convert.ToDouble(textBox_t03.Text);
            double Imp_A = Convert.ToDouble(textBox_ImpA.Text);
            double Imp_Sigma = Convert.ToDouble(textBox_ImpSigma.Text);
            //double Imp_Mu = Convert.ToDouble(textbox)
            double[] t0 = { t0_1, t0_2, t0_3 };
            int N = 64;
            double iter;
            double[] x = new double[N]; //Исходный сигнал
            double[] h = new double[N]; //Импульсная характеристика
            double[] y = new double[N]; //Сигнал после свёртки
            double[] Help_y = new double[N]; //
            double[] ConvolutionMass = new double[N]; //Сигнал после свёртки
            double[] Itog = new double[N];


            #region Вычисление исходного сигнала
            for (int t = 0; t < N; t++)
            {
                for (int n = 0; n < 3; n++)
                {
                    x[t] += A[n] * Math.Exp(-((t - t0[n]) / Sigma[n]) * ((t - t0[n]) / Sigma[n]));
                }
                chart1.Series["Series1"].Points.AddXY(t, x[t]);
            }
            #endregion

            #region Вычисление импульсной характеристики
            for (int t = 0; t < N; t++)
            {
                h[t] = Imp_A * Math.Exp(-(t - N / 2) * (t - N / 2) / (Imp_Sigma * Imp_Sigma));
            }
            for (int i = 0; i < N; i++)
            {
                Help_y[i] = h[i];
            }
            for (int i = 0; i < N / 2; i++)
            {
                h[i] = Help_y[i + N / 2];
                h[i + N / 2] = Help_y[i];
            }
            for (int t = 0; t < N; t++)
            {
                chart1.Series["Series2"].Points.AddXY(t, h[t]);
            }
            #endregion

            #region Свёртка
            ConvolutionMass = new double[N];
            for (int i = 0; i < N; i++)
            {
                iter = 0;
                for (int j = 0; j < N; j++)
                {
                    int m = i - j;
                    if (m < 0)
                    {
                        m += N;
                    }
                    iter += h[m] * x[j];
                }
                ConvolutionMass[i] = iter;
            }
            for (int i = 0; i < N; i++)
            {
                chart2.Series["Series1"].Points.AddXY(i, ConvolutionMass[i]);
            }
            #endregion

        }
    }
}