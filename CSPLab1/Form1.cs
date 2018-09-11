using System;
using System.Data;
using OxyPlot;
using OxyPlot.Series;
using System.Windows.Forms;

namespace CSPLab1
{
    public partial class Form1 : Form
    {
        private int _a = 10;

        private int _n = 511;
        private double _fi = Math.PI / 2;
        private int _f = 2;
        private int _N = 512;

        public double[] FiValues = { Math.PI, 0, Math.PI / 3, Math.PI / 6, Math.PI / 2 };

        public int[] FreqValues = { 1, 5, 11, 6, 3 };

        public string[] FiStrings = { "π", "0", "π/3", "π/6", "π/2" };

        public Form1()
        {
            InitializeComponent();
        }


        public PlotModel DrawAllFirst()
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            Func<double, double> harmonicFunc = Calc;
            for (int i = 0; i < 5; i++)
            {
                _fi = FiValues[i];
                _a = int.Parse(amplitudeTextBox.Text);
                _f = int.Parse(frequencyTextBox.Text);
                harmonicModel.Series.Add(new FunctionSeries(harmonicFunc, 0, _n, 0.5, "fi" + (i + 1).ToString()));
            }

            return harmonicModel;
        }

        public PlotModel DrawAllSecond()
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            Func<double, double> harmonicFunc = Calc;
            for (int i = 0; i < 5; i++)
            {
                _f = FreqValues[i];
                _a = int.Parse(amplitudeTextBox2.Text);
                _fi = 3 * Math.PI / 4;
                harmonicModel.Series.Add(new FunctionSeries(harmonicFunc, 0, _n, 0.5, "f" + (i + 1).ToString()));
            }

            return harmonicModel;
        }
        public double Calc(double n)
        {
            return _a * Math.Sin(2 * Math.PI * _f * n / _N + _fi);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            fiGridView.DataSource = GenerateTable(FiStrings, "fi");
            fiGridView.AllowUserToAddRows = false;

            frequenciesGridView.DataSource = GenerateTable(FreqValues, "f");
            frequenciesGridView.AllowUserToAddRows = false;
            var harmonicModel1 = DrawAllFirst();
            var harmonicModel2 = DrawAllSecond();
            plotView1.Model = harmonicModel1;
            plotView2.Model = harmonicModel2;
        }

        public DataTable GenerateTable<T>(T[] values, string colName)
        {
            DataTable dt = new DataTable();

            DataRow r = dt.NewRow();
            for (int i = 1; i <= 5; i++)
            {
                dt.Columns.Add(colName + i);
                r[colName + i] = values[i - 1];
            }

            dt.Rows.Add(r);
            return dt;
        }

        private void drawAllButton_Click(object sender, EventArgs e)
        {
            var harmonicModel = DrawAllFirst();
            plotView1.Model = harmonicModel;
        }

        private void rebuildButton_Click(object sender, EventArgs e)
        {
            var harmonicModel = DrawAllFirst();
            plotView1.Model = harmonicModel;
        }

        private void amplitudeTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            Func<double, double> harmonicFunc = Calc;
            _fi = FiValues[e.ColumnIndex];
            _a = int.Parse(amplitudeTextBox.Text);
            _f = int.Parse(frequencyTextBox.Text);
            harmonicModel.Series.Add(new FunctionSeries(harmonicFunc, 0, _n, 0.5, "fi" + (e.ColumnIndex + 1)));
            plotView1.Model = harmonicModel;
        }

        private void DrawAll2button_Click(object sender, EventArgs e)
        {
            var harmonicModel = DrawAllSecond();
            plotView2.Model = harmonicModel;
        }

        private void frequenciesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            Func<double, double> harmonicFunc = Calc;
            _f = FreqValues[e.ColumnIndex];
            _a = int.Parse(amplitudeTextBox2.Text);
            _fi = 3 * Math.PI / 4;
            harmonicModel.Series.Add(new FunctionSeries(harmonicFunc, 0, _n, 0.5, "f" + (e.ColumnIndex + 1)));
            plotView2.Model = harmonicModel;
        }
    }
}
