using System.Windows.Forms;
using MvpCarExamplePlot.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace MvpCarExamplePlot
{
    public partial class Form1 : Form
    {
        private readonly PlotModel _plotModel = new PlotModel { Title = "Car movement" };
        private readonly LineSeries _carMovementSeries = new LineSeries
        {
            StrokeThickness = 2,
            MarkerSize = 1,
        };

        private Car _car = new Car(0, 0, 0.8F);

        public Form1()
        {
            InitializeComponent();

            _plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = -200, Maximum = 200, Title = "X" });
            _plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = -200, Maximum = 200, Title = "Y" });

            plotView1.Model = _plotModel;
            _plotModel.Series.Add(_carMovementSeries);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _car.Forward();

            _carMovementSeries.Points.Add(new DataPoint(_car.Position.X, _car.Position.Y));
            plotView1.InvalidatePlot(true);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            _car.TurnLeft(15);

            _carMovementSeries.Points.Add(new DataPoint(_car.Position.X, _car.Position.Y));
            plotView1.InvalidatePlot(true);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            _car.TurnRight(15);

            _carMovementSeries.Points.Add(new DataPoint(_car.Position.X, _car.Position.Y));
            plotView1.InvalidatePlot(true);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            _car = new Car(0, 0, 0.8F);
            _carMovementSeries.Points.Clear();
            plotView1.InvalidatePlot(true);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            _car.Throttle(5);
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            _car.Break();
        }
    }
}
