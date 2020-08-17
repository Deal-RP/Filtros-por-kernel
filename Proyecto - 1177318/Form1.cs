using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Proyecto___1177318
{
    public partial class Form1 : Form
    {
        double[,] grayMatrix;
        int width;
        int height;
        Bitmap origin;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManejoMatriz(0.0625, 0.125, 0.0625, 0.125, 0.25, 0.125, 0.0625, 0.125, 0.0625);
        }

        private void BT_Subir_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "Image Files(*.png)|*.png";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        origin = new Bitmap(open.FileName);
                        width = origin.Width;
                        height = origin.Height;
                        grayMatrix = new double[height + 2, width + 2];
                        grayScale();
                        BT_Aplicar.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Formato de imagen no es soportado por el programa");
                    }
                }
            }
        }

        #region PROCESO DE FILTRADO
        private void BT_Aplicar_Click(object sender, EventArgs e)
        {
            var kernel = obtenerKernel();
            var filterMatrix = new double[height, width];

            //Aplicar kernel
            for (int x = 1; x <= width; x++)
            {
                for (int y = 1; y <= height; y++)
                {
                    var filter = 0.0;
                    for (int yk = 0; yk < 3; yk++)
                    {
                        for (int xk = 0; xk < 3; xk++)
                        {
                            filter += kernel[yk, xk] * grayMatrix[y + yk - 1, x + xk - 1];
                        }
                    }

                    filterMatrix[y - 1, x - 1] = filter;
                }
            }

            //Reescalado
            var result = new Bitmap(origin);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var filter = filterMatrix[y, x] < 0 ? 0 : filterMatrix[y, x] > 255 ? 255 : filterMatrix[y, x];
                    var col = Convert.ToInt32(filter);
                    var newcolor = Color.FromArgb(col, col, col);
                    result.SetPixel(x, y, newcolor);
                }
            }
            PB_Filtro.Image = result;
        }

        double[,] obtenerKernel()
        {
            TB_11.Text = TB_11.Text == "" ? "0" : TB_11.Text;
            TB_12.Text = TB_12.Text == "" ? "0" : TB_12.Text;
            TB_13.Text = TB_13.Text == "" ? "0" : TB_13.Text;
            TB_21.Text = TB_21.Text == "" ? "0" : TB_21.Text;
            TB_22.Text = TB_22.Text == "" ? "0" : TB_22.Text;
            TB_23.Text = TB_23.Text == "" ? "0" : TB_23.Text;
            TB_31.Text = TB_31.Text == "" ? "0" : TB_31.Text;
            TB_32.Text = TB_32.Text == "" ? "0" : TB_32.Text;
            TB_33.Text = TB_33.Text == "" ? "0" : TB_33.Text;
            return new double[3, 3]
            {
                { Convert.ToDouble(TB_11.Text), Convert.ToDouble(TB_12.Text), Convert.ToDouble(TB_13.Text) },
                { Convert.ToDouble(TB_21.Text), Convert.ToDouble(TB_22.Text), Convert.ToDouble(TB_23.Text) },
                { Convert.ToDouble(TB_31.Text), Convert.ToDouble(TB_32.Text), Convert.ToDouble(TB_33.Text) }
            };
        }
        #endregion

        #region ESCALA DE COLORES
        //Se aplica filtro de escala de grises
        void grayScale()
        {
            var result = new Bitmap(origin);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var col = origin.GetPixel(x, y);
                    var grayPixel = (col.R + col.G + col.B) / 3;
                    var newcolor = Color.FromArgb(grayPixel, grayPixel, grayPixel);
                    result.SetPixel(x, y, newcolor);
                    colorMatrix(x, y, grayPixel);
                }
            }
            PB_Original.Image = result;
        }

        //Llenar la matriz en la cual se aplica el kernel
        void colorMatrix(int x, int y, double value)
        {
            if (x == 0)
            {
                grayMatrix[y + 1, x] = value;
            }
            else if (x == width - 1)
            {
                grayMatrix[y + 1, x + 2] = value;
            }

            if (y == 0)
            {
                grayMatrix[y, x + 1] = value;
            }
            else if (y == height - 1)
            {
                grayMatrix[y + 2, x + 1] = value;
            }

            if (x == 0 && y == 0)
            {
                grayMatrix[y, x] = value;
            }
            else if (x == width - 1 && y == 0)
            {
                grayMatrix[y, x + 2] = value;
            }
            else if (x == 0 && y == height - 1)
            {
                grayMatrix[y + 2, x] = value;
            }
            else if (x == width - 1 && y == height - 1)
            {
                grayMatrix[y + 2, x + 2] = value;
            }

            grayMatrix[y + 1, x + 1] = value;
        }
        #endregion

        #region RADIO BUTTON CONFIG
        void ManejoMatriz(double a, double b, double c, double d, double e, double f, double g, double h, double i)
        {
            TB_11.Text = Convert.ToString(a);
            TB_12.Text = Convert.ToString(b);
            TB_13.Text = Convert.ToString(c);
            TB_21.Text = Convert.ToString(d);
            TB_22.Text = Convert.ToString(e);
            TB_23.Text = Convert.ToString(f);
            TB_31.Text = Convert.ToString(g);
            TB_32.Text = Convert.ToString(h);
            TB_33.Text = Convert.ToString(i);
        }

        private void RB_R_Click(object sender, EventArgs e)
        {
            ManejoMatriz(-2, -1, 0, -1, 1, 1, 0, 1, 2);
        }

        private void RB_D_Click(object sender, EventArgs e)
        {
            ManejoMatriz(0.0625, 0.125, 0.0625, 0.125, 0.25, 0.125, 0.0625, 0.125, 0.0625);
        }

        private void RB_SI_Click(object sender, EventArgs e)
        {
            ManejoMatriz(-1, -2, -1, 0, 0, 0, 1, 2, 1);
        }

        private void RB_SS_Click(object sender, EventArgs e)
        {
            ManejoMatriz(1, 2, 1, 0, 0, 0, -1, -2, -1);
        }

        private void RB_SIZ_Click(object sender, EventArgs e)
        {
            ManejoMatriz(1, 0, -1, 2, 0, -2, 1, 0, -1);
        }

        private void RB_SD_Click(object sender, EventArgs e)
        {
            ManejoMatriz(-1, 0, 1, -2, 0, 2, -1, 0, 1);
        }

        private void RB_P_Click(object sender, EventArgs e)
        {
            ManejoMatriz(0, 0, 0, 0, 0, 0, 0, 0, 0);
        }

        private void RB_C_Click(object sender, EventArgs e)
        {
            ManejoMatriz(-1, -1, -1, -1, 8, -1, -1, -1, -1);
        }

        private void RB_A_Click(object sender, EventArgs e)
        {
            ManejoMatriz(0, -1, 0, -1, 5, -1, 0, -1, 0);
        }

        private void RB_O_Click(object sender, EventArgs e)
        {
            ManejoMatriz(0, 0, 0, 0, 1, 0, 0, 0, 0);
        }
        #endregion
    }
}
