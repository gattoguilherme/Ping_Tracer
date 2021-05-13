using PingLoL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PingLoL.Helpers
{
    public class Ping
    {
        private ComponentsModel Components { get; set; }
        public Ping(ComponentsModel components)
        {
            this.Components = components;
        }

        public void Execute()
        {
            var IP = Components.txtIp.Text;
            int hit = 0;
            int total = 0;

            Components.Disable();

            var ping = new System.Net.NetworkInformation.Ping();

            while (hit < Convert.ToInt32(Components.txtHitCount.Text))
            {
                var task = Task.Run(() => GetPing(ping, IP));
                IpModel freshIpModel = task.Result;

                if (string.IsNullOrEmpty(freshIpModel.Ip))
                {
                    Components.Enable();
                    MessageBox.Show(string.Format("Error on Ping Request!{0}Verify your internet connection and if the ping address is valid.", Environment.NewLine));
                    break;
                }

                if (freshIpModel.RoundtripTime != null)
                {
                    total += Int32.Parse(freshIpModel.RoundtripTime);
                    hit++;

                    Components.txtResult.Text += string.Format("{4} | Ping to {1} Successful - Response delay = {3} | HIT: {5}{0}",
                        Environment.NewLine, freshIpModel.Ip, freshIpModel.Address, freshIpModel.RoundtripTime, DateTime.Now, hit);

                    Components.txtAverage.Text = (total / hit).ToString();
                    Components.txtMin.Text = Int32.Parse(freshIpModel.RoundtripTime) <= Int32.Parse(Components.txtMin.Text) ? freshIpModel.RoundtripTime : Components.txtMin.Text;
                    Components.txtMax.Text = Int32.Parse(freshIpModel.RoundtripTime) >= Int32.Parse(Components.txtMax.Text) ? freshIpModel.RoundtripTime : Components.txtMax.Text;
                    Components.lblStats.Text = string.Format("Em Execução ({0}/{1})", hit, Components.txtHitCount.Text);
                }
                Helpers.Timer.Wait(500);
            }
            Components.lblStats.Text = string.Format("Execução finalizada (100/{0})", Components.txtHitCount.Text);
            Components.Enable();
        }

        private IpModel GetPing(System.Net.NetworkInformation.Ping ping, string IP)
        {
            PingReply pingResponse;
            try
            {
                pingResponse = ping.Send(IP);

                if (pingResponse.Status == IPStatus.Success)
                {
                    return new IpModel(IP.ToString(), pingResponse.Address.ToString(), pingResponse.RoundtripTime.ToString());
                }
                return new IpModel();
            }
            catch
            {
                return new IpModel();
            }
            
        }
    }
}
