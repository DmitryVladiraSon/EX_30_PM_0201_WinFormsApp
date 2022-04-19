using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_30_PM_0201_WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCreateArr_Click(object sender, EventArgs e)
        {
            int columns = Convert.ToInt32(tbColumns.Text);
            int rows = columns;
            int maxVauleOfArray = 0;
            Random rnd = new Random();
            var cellArr = new TextBox[columns, rows];

            for (int i = 0; i < columns; i++)
            {

                for (int j = 0; j < rows; j++)
                {
                    cellArr[i, j] = new TextBox()
                    {
                        Name = "cellArr" + i.ToString() + j.ToString(),
                        Size = new Size(30, 150)
                    };

                    cellArr[i, j].Location = new System.Drawing.Point(50 + j * 50, 100 + i * 30);
                    cellArr[i, j].Size = new System.Drawing.Size(30, 150);

                    cellArr[i, j].Text = rnd.Next(1, 100).ToString();
                    cellArr[i, j].Font = new Font("Arial", 14, FontStyle.Bold);
                    cellArr[i, j].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;


                    Controls.Add(cellArr[i, j]);

                    maxVauleOfArray = Math.Max(maxVauleOfArray, Convert.ToInt32(cellArr[i, j].Text));
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbColumns.Text);
            int m = n;
            for (int i = 0; i <= m; i++)
            {
                dataGridView1.Columns.Add("", "");
                if (i > 0) dataGridView1.Columns[i].HeaderText = Convert.ToString(i - 1);
                dataGridView1.Columns[i].Width = 40;
            }
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), "");
            }

            int[,] aa = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j + 1].Value = rnd.Next(1, 100).ToString();
                    aa[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j + 1].Value);
                }
            }
        }
    }
}
