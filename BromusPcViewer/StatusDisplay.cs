using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;

namespace BromusPcViewer
{
    public static class StatusDisplay
    {
        static System.Windows.Forms.Label statusLabel;
		static System.Timers.Timer animTimer = new System.Timers.Timer(500);
		static int frame = 0;
		static String[] messages;

		public static void AssignLabelObj(System.Windows.Forms.Label label)
        {
            statusLabel = label;
        }

        public static void WriteStatus(String message)
        {
			animTimer.Enabled = false;
			statusLabel.Invoke((MethodInvoker)delegate {
				statusLabel.ForeColor = System.Drawing.Color.Black;
				statusLabel.Text = "Status: " + message;
            });
        }

		public static void WriteAnimatedStatus(String[] messages, int period)
		{
			StatusDisplay.messages = messages;
			statusLabel.Invoke((MethodInvoker)delegate {
				statusLabel.ForeColor = System.Drawing.Color.Black;
				statusLabel.Text = "Status: " + messages[0];
			});

			animTimer.Interval = period;
			animTimer.Elapsed += OnTimedEvent;
			animTimer.AutoReset = true;
			animTimer.Enabled = true;
		}

		private static void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			frame++;
			if (frame > messages.Length-1) frame = 0;
			statusLabel.Invoke((MethodInvoker)delegate {
				statusLabel.ForeColor = System.Drawing.Color.Black;
				statusLabel.Text = "Status: " + messages[frame];
			});
		}

		public static void WriteError(String message)
		{
			animTimer.Enabled = false;
			statusLabel.Invoke((MethodInvoker)delegate {
                statusLabel.ForeColor = System.Drawing.Color.Red;
				statusLabel.Text = "Error: " + message;
			});
		}
	}

}