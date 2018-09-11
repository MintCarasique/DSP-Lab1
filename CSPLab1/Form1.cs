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
        public Form1()
        {
            InitializeComponent();
            var harmonicModel = new PlotModel(){Title =  "Harmonic signal"};
            harmonicModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.5, "sin(x)"));
            this.plotView.Model = harmonicModel;
        }
    }
}
