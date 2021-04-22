
namespace Server
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.textBoxLocalPort = new System.Windows.Forms.TextBox();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.portText = new System.Windows.Forms.Label();
			this.buttonBind = new System.Windows.Forms.Button();
			this.textActions = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// textBoxLocalPort
			// 
			this.textBoxLocalPort.Location = new System.Drawing.Point(500, 22);
			this.textBoxLocalPort.Name = "textBoxLocalPort";
			this.textBoxLocalPort.Size = new System.Drawing.Size(129, 20);
			this.textBoxLocalPort.TabIndex = 0;
			// 
			// textBoxLog
			// 
			this.textBoxLog.AllowDrop = true;
			this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLog.Location = new System.Drawing.Point(26, 60);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.Size = new System.Drawing.Size(751, 378);
			this.textBoxLog.TabIndex = 1;
			// 
			// portText
			// 
			this.portText.AutoSize = true;
			this.portText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.portText.Location = new System.Drawing.Point(442, 20);
			this.portText.Name = "portText";
			this.portText.Size = new System.Drawing.Size(52, 20);
			this.portText.TabIndex = 2;
			this.portText.Text = "Порт:";
			// 
			// buttonBind
			// 
			this.buttonBind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonBind.Location = new System.Drawing.Point(635, 16);
			this.buttonBind.Name = "buttonBind";
			this.buttonBind.Size = new System.Drawing.Size(144, 29);
			this.buttonBind.TabIndex = 3;
			this.buttonBind.Text = "Открыть порт";
			this.buttonBind.UseVisualStyleBackColor = true;
			this.buttonBind.Click += new System.EventHandler(this.buttonBind_Click);
			// 
			// textActions
			// 
			this.textActions.AutoSize = true;
			this.textActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textActions.Location = new System.Drawing.Point(21, 22);
			this.textActions.Name = "textActions";
			this.textActions.Size = new System.Drawing.Size(113, 25);
			this.textActions.TabIndex = 4;
			this.textActions.Text = "Действия:";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textActions);
			this.Controls.Add(this.buttonBind);
			this.Controls.Add(this.portText);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.textBoxLocalPort);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "Form1";
			this.Text = "Сервер";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxLocalPort;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.Label portText;
		private System.Windows.Forms.Button buttonBind;
		private System.Windows.Forms.Label textActions;
		private System.Windows.Forms.Timer timer1;
	}
}

