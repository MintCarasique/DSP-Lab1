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

        public double[] FiValues = {Math.PI, 0, Math.PI/3, Math.PI/6, Math.PI/2};
        public string[] FiStrings = { "π", "0", "π/3", "π/6", "π/2" };

        public Form1()
        {
            InitializeComponent();
            //this.plotView.Model = harmonicModel;
        }


        public PlotModel DrawAllFirst()
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            Func<double, double> harmonicFunc = Calc;
            for (int i = 0; i < 5; i++)
            {
                _fi = FiValues[i];
                _a = int.Parse(this.amplitudeTextBox.Text);
                _f = int.Parse(frequencyTextBox.Text);
                harmonicModel.Series.Add(new FunctionSeries(harmonicFunc, 0, _n, 0.5, "fi" + (i + 1).ToString()));
            }

            return harmonicModel;
        }
        public double Calc(double n)
        {
            return _a * Math.Sin(2 * Math.PI * _f * n / _N + _fi);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frequenciesGridView.DataSource = GenerateTable(FiStrings, "fi");
            frequenciesGridView.AllowUserToAddRows = false;


            var harmonicModel = DrawAllFirst();
            this.plotView1.Model = harmonicModel;
        }

        public DataTable GenerateTable<T>(T[] values, string colName)
        {
            DataTable dt = new DataTable();
            
            DataRow r = dt.NewRow();
            for (int i = 1; i <= 5; i++)
            {
                dt.Columns.Add(colName + i);
                r["fi" + i] = FiStrings[i - 1];
            }

            dt.Rows.Add(r);
            return dt;
        }

        private void drawAllButton_Click(object sender, EventArgs e)
        {
            var harmonicModel = DrawAllFirst();
            this.plotView1.Model = harmonicModel;
        }

        private void frequenciesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            Func<double, double> harmonicFunc = Calc;
            _fi = FiValues[e.ColumnIndex];
            _a = int.Parse(this.amplitudeTextBox.Text);
            _f = int.Parse(frequencyTextBox.Text);
            harmonicModel.Series.Add(new FunctionSeries(harmonicFunc, 0, _n, 0.5, "fi" + (e.ColumnIndex + 1)));
            plotView1.Model = harmonicModel;
        }

        private void rebuildButton_Click(object sender, EventArgs e)
        {
            var harmonicModel = DrawAllFirst();
            this.plotView1.Model = harmonicModel;
        }

        private void amplitudeTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
