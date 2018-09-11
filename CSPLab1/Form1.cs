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
using CSPLab1.SignalLib;

namespace CSPLab1
{
    public partial class Form1 : Form
    {
        private int a = 10;

        private int n = 511;
        private double fi = Math.PI/2;
        private int f = 2;
        private int k = 10;
        private int N = 512;

        public Form1()
        {
            InitializeComponent();
            var harmonicModel = new PlotModel(){Title =  "Harmonic signal"};
            Func<double, double> HarmonicFunc = Calc;
            
            harmonicModel.Series.Add(new FunctionSeries(HarmonicFunc, 0, n, 0.5, "Harmonic"));
            this.plotView.Model = harmonicModel;
        }

        public double Calc(double n)
        {
            return a * Math.Sin(2 * Math.PI * f * n / N + fi);
        }
    }
}
