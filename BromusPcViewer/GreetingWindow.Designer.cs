namespace BromusPcViewer
{
    partial class GreetingWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.connectHostIpTxt = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.connectBtn = new System.Windows.Forms.Button();
			this.startHostBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.localIplbl = new System.Windows.Forms.Label();
			this.statusLbl = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.localHostIpTxt = new System.Windows.Forms.TextBox();
			this.startHostPortTxt = new System.Windows.Forms.TextBox();
			this.remoteHostPortTxt = new System.Windows.Forms.TextBox();
			this.remotePassTxt = new System.Windows.Forms.TextBox();
			this.loacalPassTxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// connectHostIpTxt
			// 
			this.connectHostIpTxt.Location = new System.Drawing.Point(87, 95);
			this.connectHostIpTxt.Name = "connectHostIpTxt";
			this.connectHostIpTxt.Size = new System.Drawing.Size(157, 20);
			this.connectHostIpTxt.TabIndex = 0;
			this.connectHostIpTxt.Tag = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "host IP:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "host port:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// connectBtn
			// 
			this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.connectBtn.Location = new System.Drawing.Point(15, 178);
			this.connectBtn.Name = "connectBtn";
			this.connectBtn.Size = new System.Drawing.Size(229, 33);
			this.connectBtn.TabIndex = 4;
			this.connectBtn.Text = "Connect";
			this.connectBtn.UseVisualStyleBackColor = true;
			this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
			// 
			// startHostBtn
			// 
			this.startHostBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startHostBtn.Location = new System.Drawing.Point(264, 178);
			this.startHostBtn.Name = "startHostBtn";
			this.startHostBtn.Size = new System.Drawing.Size(229, 33);
			this.startHostBtn.TabIndex = 7;
			this.startHostBtn.Text = "Start as host";
			this.startHostBtn.UseVisualStyleBackColor = true;
			this.startHostBtn.Click += new System.EventHandler(this.startHostBtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(261, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "port:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(481, 61);
			this.label4.TabIndex = 8;
			this.label4.Text = "Start as a host if you want to broadcast screen, or as a client if you want to re" +
    "cive screen from another PC";
			// 
			// localIplbl
			// 
			this.localIplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.localIplbl.Location = new System.Drawing.Point(13, 238);
			this.localIplbl.Name = "localIplbl";
			this.localIplbl.Size = new System.Drawing.Size(480, 62);
			this.localIplbl.TabIndex = 9;
			this.localIplbl.Text = "Your IP:";
			// 
			// statusLbl
			// 
			this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.statusLbl.Location = new System.Drawing.Point(13, 319);
			this.statusLbl.Name = "statusLbl";
			this.statusLbl.Size = new System.Drawing.Size(480, 171);
			this.statusLbl.TabIndex = 10;
			this.statusLbl.Text = "Status:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(261, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "ip (optional):";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.label6.UseMnemonic = false;
			// 
			// localHostIpTxt
			// 
			this.localHostIpTxt.Location = new System.Drawing.Point(353, 95);
			this.localHostIpTxt.Name = "localHostIpTxt";
			this.localHostIpTxt.Size = new System.Drawing.Size(140, 20);
			this.localHostIpTxt.TabIndex = 13;
			this.localHostIpTxt.Tag = "";
			// 
			// startHostPortTxt
			// 
			this.startHostPortTxt.Location = new System.Drawing.Point(353, 124);
			this.startHostPortTxt.Name = "startHostPortTxt";
			this.startHostPortTxt.Size = new System.Drawing.Size(140, 20);
			this.startHostPortTxt.TabIndex = 14;
			this.startHostPortTxt.Text = "1234";
			// 
			// remoteHostPortTxt
			// 
			this.remoteHostPortTxt.Location = new System.Drawing.Point(87, 124);
			this.remoteHostPortTxt.Name = "remoteHostPortTxt";
			this.remoteHostPortTxt.Size = new System.Drawing.Size(157, 20);
			this.remoteHostPortTxt.TabIndex = 15;
			this.remoteHostPortTxt.Text = "1234";
			// 
			// remotePassTxt
			// 
			this.remotePassTxt.Location = new System.Drawing.Point(87, 152);
			this.remotePassTxt.Name = "remotePassTxt";
			this.remotePassTxt.PasswordChar = '◉';
			this.remotePassTxt.Size = new System.Drawing.Size(157, 20);
			this.remotePassTxt.TabIndex = 19;
			// 
			// loacalPassTxt
			// 
			this.loacalPassTxt.Location = new System.Drawing.Point(353, 152);
			this.loacalPassTxt.Name = "loacalPassTxt";
			this.loacalPassTxt.PasswordChar = '◉';
			this.loacalPassTxt.Size = new System.Drawing.Size(140, 20);
			this.loacalPassTxt.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(261, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "password:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(12, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 17);
			this.label7.TabIndex = 16;
			this.label7.Text = "password:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// GreetingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 499);
			this.Controls.Add(this.remotePassTxt);
			this.Controls.Add(this.loacalPassTxt);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.remoteHostPortTxt);
			this.Controls.Add(this.startHostPortTxt);
			this.Controls.Add(this.localHostIpTxt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.statusLbl);
			this.Controls.Add(this.localIplbl);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.startHostBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.connectBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.connectHostIpTxt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "GreetingWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Bromus PC Viewer";
			this.Load += new System.EventHandler(this.GreetingWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox connectHostIpTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button startHostBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label localIplbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox localHostIpTxt;
		private System.Windows.Forms.TextBox startHostPortTxt;
		private System.Windows.Forms.TextBox remoteHostPortTxt;
		private System.Windows.Forms.TextBox remotePassTxt;
		private System.Windows.Forms.TextBox loacalPassTxt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
	}
}

