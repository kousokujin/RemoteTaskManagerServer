﻿using System;
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
            string str;
            str = string.Format("{0},{1},0", per.cpu_count(), per.max_mem());

            tcp.send(str);
            bool ok = false;
            while(!ok)
            {
                if(tcp.recive() == "OK")
                {
                    ok = true;
                }
            }

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
            int cpu = per.get_all_cpu();
            int mem = per.get_use_mem();

            cpu_lab.Text = string.Format("{0}%", cpu);
            mem_use_lab.Text = string.Format("{0}MB", mem);

            if(conection)
            {
                string sendstr;
                //tcp.send(sendstr);
                //System.Console.WriteLine("send:{0}",sendstr);

                sendstr = string.Format("{0},{1}", mem, cpu);
                for (int i = 0; i < per.cpu_count(); i++)
                {
                    string str = string.Format(",{0}", per.get_thread_cpu(i));
                    sendstr += str;
                }

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
