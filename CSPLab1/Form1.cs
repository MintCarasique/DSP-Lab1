using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
using System.Windows.Forms;

namespace CSPLab1
{
    public partial class Form1 : Form
    {
        private int _a = 10;

        private int _n = 511;
        private double _fi = Math.PI/2;
        private int _f = 2;
        private int _N = 512;

        public double[] Frequences = {Math.PI, 0, Math.PI/3, Math.PI/6, Math.PI/2};

        public Form1()
        {
            InitializeComponent();
            var harmonicModel = new PlotModel(){Title =  "Harmonic signal"};
            Func<double, double> harmonicFunc = Calc;
            for (int i = 0; i < 5; i++)
            {
                _fi = Frequences[i];
                _a = int.Parse(this.amplitudeTextBox.Text);
                _f = int.Parse(frequencyTextBox.Text);
                harmonicModel.Series.Add(new FunctionSeries(harmonicFunc, 0, _n, 0.5, "fi"+ (i + 1).ToString()));
            }

            this.plotView1.Model = harmonicModel;
            //this.plotView.Model = harmonicModel;
        }

        public double Calc(double n)
        {
            return _a * Math.Sin(2 * Math.PI * _f * n / _N + _fi);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("fi1");
            dt.Columns.Add("fi2");
            dt.Columns.Add("fi3");
            dt.Columns.Add("fi4");
            dt.Columns.Add("fi5");
            DataRow r = dt.NewRow();
            for (int i = 1; i <= 5; i++)
            {
                r["fi" + i.ToString()] = Frequences[i - 1];
            }

            dt.Rows.Add(r);

            frequenciesGridView.DataSource = dt;
        }
    }
}
