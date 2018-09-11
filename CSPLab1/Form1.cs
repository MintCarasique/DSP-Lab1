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

        public int[] AmpValues = { 1, 2, 11, 4, 2 };

        public string[] FiStrings = { "π", "0", "π/3", "π/6", "π/2" };

        Func<double, double> _harmonicFunc;

        public Form1()
        {
            InitializeComponent();
        }


        public PlotModel DrawAllFirst()
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            for (int i = 0; i < 5; i++)
            {
                _fi = FiValues[i];
                _a = int.Parse(amplitudeTextBox.Text);
                _f = int.Parse(frequencyTextBox.Text);
                harmonicModel.Series.Add(new FunctionSeries(_harmonicFunc, 0, _n, 0.5, "fi" + (i + 1)));
            }

            return harmonicModel;
        }

        public PlotModel DrawAllSecond()
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            for (int i = 0; i < 5; i++)
            {
                _f = FreqValues[i];
                _a = int.Parse(amplitudeTextBox2.Text);
                _fi = 3 * Math.PI / 4;
                harmonicModel.Series.Add(new FunctionSeries(_harmonicFunc, 0, _n, 0.5, "f" + (i + 1)));
            }

            return harmonicModel;
        }

        public PlotModel DrawAllThird()
        {
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            for (int i = 0; i < 5; i++)
            {
                _f = int.Parse(frequencyTextBox2.Text); 
                _a = AmpValues[i];
                _fi = 3 * Math.PI / 4;
                harmonicModel.Series.Add(new FunctionSeries(_harmonicFunc, 0, _n, 0.5, "A" + (i + 1)));
            }

            return harmonicModel;
        }
        public double Calc(double n)
        {
            return _a * Math.Sin(2 * Math.PI * _f * n / _N + _fi);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _harmonicFunc = Calc;

            fiGridView.DataSource = GenerateTable(FiStrings, "fi");
            fiGridView.AllowUserToAddRows = false;

            frequenciesGridView.DataSource = GenerateTable(FreqValues, "f");
            frequenciesGridView.AllowUserToAddRows = false;

            amplitudeGridView.DataSource = GenerateTable(AmpValues, "A");
            amplitudeGridView.AllowUserToAddRows = false;
            plotView1.Model = DrawAllFirst();
            plotView2.Model = DrawAllSecond();
            plotView3.Model = DrawAllThird();
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
            plotView1.Model = DrawAllFirst();
        }

        private void fiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plotView1.Model = DrawSingle(FiValues[e.ColumnIndex], int.Parse(amplitudeTextBox.Text), int.Parse(frequencyTextBox.Text), int.Parse(nBox1.Text), int.Parse(NtextBox1.Text), e.ColumnIndex + 1);
        }

        public PlotModel DrawSingle(double fi, int a, int f, int n, int N, int colNum)
        {
            _fi = fi;
            _a = a;
            _f = f;
            _n = n;
            _N = N;
            var harmonicModel = new PlotModel() { Title = "Harmonic signal" };
            harmonicModel.Series.Add(new FunctionSeries(_harmonicFunc, 0, _n, 0.5, "fi" + colNum));
            return harmonicModel;
        }

        private void DrawAll2button_Click(object sender, EventArgs e)
        {
            plotView2.Model = DrawAllSecond();
        }

        private void frequenciesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plotView2.Model = DrawSingle(3 * Math.PI / 4, int.Parse(amplitudeTextBox2.Text), FreqValues[e.ColumnIndex], int.Parse(nBox2.Text), int.Parse(NtextBox2.Text), e.ColumnIndex + 1);
        }

        private void amplitudeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plotView3.Model = DrawSingle(3 * Math.PI / 4, AmpValues[e.ColumnIndex], int.Parse(frequencyTextBox2.Text),
                int.Parse(nBox3.Text), Int32.Parse(NtextBox3.Text), e.ColumnIndex + 1);
        }

        private void DrawAll3button_Click(object sender, EventArgs e)
        {
            plotView3.Model = DrawAllThird();
        }
    }
}
