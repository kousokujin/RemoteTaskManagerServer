using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteTaskManagerServer
{
    public partial class CPU_Count_lab : Form
    {
        performance per;
        tcp_conection tcp;
        bool conection;
        
        private void listen()
        {
            tcp.listen();
            network_status_lab.Text = "接続完了";
            conection = true;
        }

        //イベント
        public CPU_Count_lab()
        {
            InitializeComponent();
            per = new performance();

            port_box.Text = "1000";
            conection = false;

            cpu_lab.Text = string.Format("{0}%", per.get_all_cpu());
            mem_max_lab.Text = string.Format("{0}MB", per.max_mem());
            mem_use_lab.Text = string.Format("{0}MB", per.get_use_mem());

            tick_timer.Enabled = true;
        }

        private void tick_timer_Tick(object sender, EventArgs e)
        {
            cpu_lab.Text = string.Format("{0}%", per.get_all_cpu());
            mem_use_lab.Text = string.Format("{0}MB", per.get_use_mem());

            if(conection)
            {
                string sendstr = per.get_string();
                tcp.send(sendstr);
                System.Console.WriteLine("send:{0}",sendstr);
            }

        }

        private async void server_start_button_Click(object sender, EventArgs e)
        {
            network_status_lab.Text = "クライアント待機中";
            //tcp.listen();
            int port = int.Parse(port_box.Text);
            server_start_button.Enabled = false;

            if(tcp == null)
            {
                tcp = new tcp_conection("0.0.0.0",port);
            }

            await Task.Run(() => listen());
        }
    }
}
