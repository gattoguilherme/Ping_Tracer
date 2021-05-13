using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingLoL.Models
{
    public class ComponentsModel
    {
        public RichTextBox txtResult { get; set; }
        public Label txtMin { get; set; }
        public Label txtAverage { get; set; }
        public Label txtMax { get; set; }
        public Label lblStats { get; set; }
        public TextBox txtIp { get; set; }
        public TextBox txtHitCount { get; set; }
        public Button btnExecute { get; set; }

        public ComponentsModel(RichTextBox _txtResult, Label _txtMin, Label _txtAverage, Label _txtMax, Label _lblStats, TextBox _txtIp, TextBox _hitCount, Button _btnExecute)
        {
            this.txtResult = _txtResult;
            this.txtMin = _txtMin;
            this.txtAverage = _txtAverage;
            this.txtMax = _txtMax;
            this.lblStats = _lblStats;
            this.txtIp = _txtIp;
            this.txtHitCount = _hitCount;
            this.btnExecute = _btnExecute;

            SetComponentValues();
        }

        private void SetComponentValues()
        {
            lblStats.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtResult.ReadOnly = true;
            txtMin.Text = "500000";
            txtMax.Text = "0";
            lblStats.Text = "Iniciando Execução";


            if (string.IsNullOrEmpty(txtHitCount.Text) || !txtHitCount.Text.All(char.IsNumber) || Convert.ToInt32(txtHitCount.Text) <= 0)
            {
                txtHitCount.Text = "100";
            }
        }

        public void Disable()
        {
            txtIp.ReadOnly = true;
            txtHitCount.ReadOnly = true;
            btnExecute.Enabled = false;
        }

        public void Enable()
        {
            txtIp.ReadOnly = false;
            txtHitCount.ReadOnly = false;
            btnExecute.Enabled = true;
        }
    }
}
