using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AramaAG.Sprint6.TaskReview.V17.Lib;

namespace Tyuiu.AramaAG.Sprint6.TaskReview.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] arrayValues;
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOut_AAG.ColumnCount = 50;
            dataGridViewOut_AAG.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewOut_AAG.Columns[i].Width = 25;
            }
        }
        private void buttonDone_AAG_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(textBoxDigitalC_AAG.Text);
                int k = Convert.ToInt32(textBoxDigitalK_AAG.Text);
                int l = Convert.ToInt32(textBoxDigitalL_AAG.Text);
                int c1 = Convert.ToInt32(textBoxDigitalM_AAG.Text);
                int n = Convert.ToInt32(textBoxDigitalN_AAG.Text);
                int m = Convert.ToInt32(textBoxDigitalM_AAG.Text);

                if (k <= l && c < c1 && c > -1 && k > -1 && l > -1)
                {
                    textBoxResultat_AAG.Text = ds.resultGetMatrix(arrayValues, c, k, l).ToString();
                }
                else
                {
                    MessageBox.Show("Данные введены не корректно");
                }
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно Catch");
            }
        }

        private void buttonGenerating_AAG_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxDigitalN_AAG.Text);
                int m = Convert.ToInt32(textBoxDigitalM_AAG.Text);
                int n1 = Convert.ToInt32(textBoxDigitalN1_AAG.Text);
                int n2 = Convert.ToInt32(textBoxDigitalN2_AAG.Text);

                if (n1 < n2)
                {
                    arrayValues = ds.GeneratingMatrix(n, m, n1, n2);
                    dataGridViewOut_AAG.ColumnCount = m;
                    dataGridViewOut_AAG.RowCount = n;

                    for (int i = 0; i < m; i++)
                    {
                        dataGridViewOut_AAG.Columns[i].Width = 25;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            dataGridViewOut_AAG.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    buttonDone_AAG.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Данные введены не корректно");
                }
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно Catch");
            }
        }
    }
}
