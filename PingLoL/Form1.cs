using PingLoL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PingLoL.Helpers;
using System.Configuration;

namespace PingLoL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            ComponentsModel components = new ComponentsModel(txtResult, txtMin, txtAverage, txtMax, lblStats, txtIp, txtHitCount, btnExecute);
            var ping = new Helpers.Ping(components);

            ping.Execute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIp.Text = ConfigurationManager.AppSettings["IP"];
            txtHitCount.Text = ConfigurationManager.AppSettings["HitCount"];
        }
    }
}
