namespace RemoteTaskManagerServer
{
    partial class CPU_Count_lab
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpu_lab = new System.Windows.Forms.Label();
            this.mem_max_lab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mem_use_lab = new System.Windows.Forms.Label();
            this.tick_timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.network_status_lab = new System.Windows.Forms.ToolStripStatusLabel();
            this.server_start_button = new System.Windows.Forms.Button();
            this.port_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU使用率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最大物理メモリ";
            // 
            // cpu_lab
            // 
            this.cpu_lab.AutoSize = true;
            this.cpu_lab.Location = new System.Drawing.Point(112, 115);
            this.cpu_lab.Name = "cpu_lab";
            this.cpu_lab.Size = new System.Drawing.Size(35, 12);
            this.cpu_lab.TabIndex = 2;
            this.cpu_lab.Text = "label3";
            // 
            // mem_max_lab
            // 
            this.mem_max_lab.AutoSize = true;
            this.mem_max_lab.Location = new System.Drawing.Point(112, 159);
            this.mem_max_lab.Name = "mem_max_lab";
            this.mem_max_lab.Size = new System.Drawing.Size(35, 12);
            this.mem_max_lab.TabIndex = 3;
            this.mem_max_lab.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "使用中のメモリ";
            // 
            // mem_use_lab
            // 
            this.mem_use_lab.AutoSize = true;
            this.mem_use_lab.Location = new System.Drawing.Point(112, 180);
            this.mem_use_lab.Name = "mem_use_lab";
            this.mem_use_lab.Size = new System.Drawing.Size(35, 12);
            this.mem_use_lab.TabIndex = 5;
            this.mem_use_lab.Text = "label4";
            // 
            // tick_timer
            // 
            this.tick_timer.Interval = 1000;
            this.tick_timer.Tick += new System.EventHandler(this.tick_timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.network_status_lab});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // network_status_lab
            // 
            this.network_status_lab.Name = "network_status_lab";
            this.network_status_lab.Size = new System.Drawing.Size(43, 17);
            this.network_status_lab.Text = "未接続";
            // 
            // server_start_button
            // 
            this.server_start_button.Location = new System.Drawing.Point(153, 14);
            this.server_start_button.Name = "server_start_button";
            this.server_start_button.Size = new System.Drawing.Size(75, 23);
            this.server_start_button.TabIndex = 7;
            this.server_start_button.Text = "サーバ開始";
            this.server_start_button.UseVisualStyleBackColor = true;
            this.server_start_button.Click += new System.EventHandler(this.server_start_button_Click);
            // 
            // port_box
            // 
            this.port_box.Location = new System.Drawing.Point(75, 14);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(72, 19);
            this.port_box.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "ポート番号";
            // 
            // CPU_Count_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.port_box);
            this.Controls.Add(this.server_start_button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mem_use_lab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mem_max_lab);
            this.Controls.Add(this.cpu_lab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CPU_Count_lab";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cpu_lab;
        private System.Windows.Forms.Label mem_max_lab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mem_use_lab;
        private System.Windows.Forms.Timer tick_timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel network_status_lab;
        private System.Windows.Forms.Button server_start_button;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.Label label4;
    }
}

