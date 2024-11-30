using App.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace App.Dialogs.ObjednavkaDialogs
{
    public partial class ObjednavkyStatsDialog : Form
    {
        private ObjednavkaRepo _objednavkaRepo { get; set; }
        public ObjednavkyStatsDialog(ObjednavkaRepo repo)
        {
            this._objednavkaRepo = repo;
            InitializeComponent();
            LoadStatistiky();
        }

        private void LoadStatistiky()
        {
            OrderStatistics statistics = _objednavkaRepo.GetOrderStatistics();

            txtTotalOrders.Text = statistics.TotalOrders.ToString();
            txtAveragePrice.Text = statistics.AveragePrice.ToString("C");
            txtTotalPrice.Text = statistics.TotalPrice.ToString("C");
            txtCompletedOrders.Text = statistics.CompletedOrders.ToString();
            txtPendingOrders.Text = statistics.PendingOrders.ToString();
            txtMostExpensiveOrder.Text = statistics.MostExpensiveOrder.ToString("C");
            txtLeastExpensiveOrder.Text = statistics.LeastExpensiveOrder.ToString("C");
            txtMostExpensiveCustomer.Text = statistics.MostExpensiveCustomer.ToString();
            txtLeastExpensiveCustomer.Text = statistics.LeastExpensiveCustomer.ToString();

            Chart pieChart = new Chart();
            pieChart.Width = (this.Width / 2)-50;
            pieChart.Height = (this.Height / 2)-50;
            pieChart.Location = new Point(500, 54);

            ChartArea chartArea = new ChartArea();
            pieChart.ChartAreas.Add(chartArea);

            Series pieSeries = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            pieSeries.Points.AddXY("Ve stavu vyřízeno", statistics.CompletedOrders);
            pieSeries.Points.AddXY("Ve stavu zpracovává se", statistics.PendingOrders);

            Legend legend = new Legend();
            pieChart.Legends.Add(legend);

            pieChart.Series.Add(pieSeries);

            this.Controls.Add(pieChart);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
