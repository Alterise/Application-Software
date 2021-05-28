
namespace Lab4
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.shortNameOption = new System.Windows.Forms.RadioButton();
			this.nameOption = new System.Windows.Forms.RadioButton();
			this.atomicNumberOption = new System.Windows.Forms.RadioButton();
			this.radioTable = new System.Windows.Forms.GroupBox();
			this.findButton = new System.Windows.Forms.Button();
			this.findTextBox = new System.Windows.Forms.TextBox();
			this.showFullButton = new System.Windows.Forms.Button();
			this.keyLabel = new System.Windows.Forms.Label();
			this.periodOption = new System.Windows.Forms.RadioButton();
			this.groupOption = new System.Windows.Forms.RadioButton();
			this.atomicMassOption = new System.Windows.Forms.RadioButton();
			this.typeOption = new System.Windows.Forms.RadioButton();
			this.infoOption = new System.Windows.Forms.RadioButton();
			this.electronCountOption = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.radioTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(776, 196);
			this.dataGridView1.TabIndex = 0;
			// 
			// shortNameOption
			// 
			this.shortNameOption.AutoSize = true;
			this.shortNameOption.Location = new System.Drawing.Point(3, 39);
			this.shortNameOption.Name = "shortNameOption";
			this.shortNameOption.Size = new System.Drawing.Size(81, 17);
			this.shortNameOption.TabIndex = 1;
			this.shortNameOption.TabStop = true;
			this.shortNameOption.Text = "Short Name";
			this.shortNameOption.UseVisualStyleBackColor = true;
			// 
			// nameOption
			// 
			this.nameOption.AutoSize = true;
			this.nameOption.Location = new System.Drawing.Point(3, 16);
			this.nameOption.Name = "nameOption";
			this.nameOption.Size = new System.Drawing.Size(53, 17);
			this.nameOption.TabIndex = 0;
			this.nameOption.TabStop = true;
			this.nameOption.Text = "Name";
			this.nameOption.UseVisualStyleBackColor = true;
			// 
			// atomicNumberOption
			// 
			this.atomicNumberOption.AutoSize = true;
			this.atomicNumberOption.Location = new System.Drawing.Point(3, 62);
			this.atomicNumberOption.Name = "atomicNumberOption";
			this.atomicNumberOption.Size = new System.Drawing.Size(97, 17);
			this.atomicNumberOption.TabIndex = 2;
			this.atomicNumberOption.TabStop = true;
			this.atomicNumberOption.Text = "Atomic Number";
			this.atomicNumberOption.UseVisualStyleBackColor = true;
			// 
			// radioTable
			// 
			this.radioTable.Controls.Add(this.electronCountOption);
			this.radioTable.Controls.Add(this.infoOption);
			this.radioTable.Controls.Add(this.typeOption);
			this.radioTable.Controls.Add(this.atomicMassOption);
			this.radioTable.Controls.Add(this.groupOption);
			this.radioTable.Controls.Add(this.periodOption);
			this.radioTable.Controls.Add(this.atomicNumberOption);
			this.radioTable.Controls.Add(this.shortNameOption);
			this.radioTable.Controls.Add(this.nameOption);
			this.radioTable.Location = new System.Drawing.Point(24, 214);
			this.radioTable.Name = "radioTable";
			this.radioTable.Size = new System.Drawing.Size(200, 224);
			this.radioTable.TabIndex = 1;
			this.radioTable.TabStop = false;
			this.radioTable.Text = "Find by:";
			// 
			// findButton
			// 
			this.findButton.Location = new System.Drawing.Point(268, 314);
			this.findButton.Name = "findButton";
			this.findButton.Size = new System.Drawing.Size(333, 41);
			this.findButton.TabIndex = 2;
			this.findButton.Text = "Find";
			this.findButton.UseVisualStyleBackColor = true;
			this.findButton.Click += new System.EventHandler(this.findButton_Click);
			// 
			// findTextBox
			// 
			this.findTextBox.Location = new System.Drawing.Point(268, 273);
			this.findTextBox.Name = "findTextBox";
			this.findTextBox.Size = new System.Drawing.Size(333, 20);
			this.findTextBox.TabIndex = 3;
			// 
			// showFullButton
			// 
			this.showFullButton.Location = new System.Drawing.Point(713, 393);
			this.showFullButton.Name = "showFullButton";
			this.showFullButton.Size = new System.Drawing.Size(75, 45);
			this.showFullButton.TabIndex = 4;
			this.showFullButton.Text = "Show Full";
			this.showFullButton.UseVisualStyleBackColor = true;
			this.showFullButton.Click += new System.EventHandler(this.showFullButton_Click);
			// 
			// keyLabel
			// 
			this.keyLabel.AutoSize = true;
			this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.keyLabel.Location = new System.Drawing.Point(416, 251);
			this.keyLabel.Name = "keyLabel";
			this.keyLabel.Size = new System.Drawing.Size(33, 18);
			this.keyLabel.TabIndex = 5;
			this.keyLabel.Text = "Key";
			// 
			// periodOption
			// 
			this.periodOption.AutoSize = true;
			this.periodOption.Location = new System.Drawing.Point(3, 85);
			this.periodOption.Name = "periodOption";
			this.periodOption.Size = new System.Drawing.Size(55, 17);
			this.periodOption.TabIndex = 3;
			this.periodOption.TabStop = true;
			this.periodOption.Text = "Period";
			this.periodOption.UseVisualStyleBackColor = true;
			// 
			// groupOption
			// 
			this.groupOption.AutoSize = true;
			this.groupOption.Location = new System.Drawing.Point(3, 108);
			this.groupOption.Name = "groupOption";
			this.groupOption.Size = new System.Drawing.Size(54, 17);
			this.groupOption.TabIndex = 4;
			this.groupOption.TabStop = true;
			this.groupOption.Text = "Group";
			this.groupOption.UseVisualStyleBackColor = true;
			// 
			// atomicMassOption
			// 
			this.atomicMassOption.AutoSize = true;
			this.atomicMassOption.Location = new System.Drawing.Point(3, 131);
			this.atomicMassOption.Name = "atomicMassOption";
			this.atomicMassOption.Size = new System.Drawing.Size(85, 17);
			this.atomicMassOption.TabIndex = 5;
			this.atomicMassOption.TabStop = true;
			this.atomicMassOption.Text = "Atomic Mass";
			this.atomicMassOption.UseVisualStyleBackColor = true;
			// 
			// typeOption
			// 
			this.typeOption.AutoSize = true;
			this.typeOption.Location = new System.Drawing.Point(3, 154);
			this.typeOption.Name = "typeOption";
			this.typeOption.Size = new System.Drawing.Size(49, 17);
			this.typeOption.TabIndex = 6;
			this.typeOption.TabStop = true;
			this.typeOption.Text = "Type";
			this.typeOption.UseVisualStyleBackColor = true;
			// 
			// infoOption
			// 
			this.infoOption.AutoSize = true;
			this.infoOption.Location = new System.Drawing.Point(3, 177);
			this.infoOption.Name = "infoOption";
			this.infoOption.Size = new System.Drawing.Size(43, 17);
			this.infoOption.TabIndex = 6;
			this.infoOption.TabStop = true;
			this.infoOption.Text = "Info";
			this.infoOption.UseVisualStyleBackColor = true;
			// 
			// electronCountOption
			// 
			this.electronCountOption.AutoSize = true;
			this.electronCountOption.Location = new System.Drawing.Point(3, 200);
			this.electronCountOption.Name = "electronCountOption";
			this.electronCountOption.Size = new System.Drawing.Size(95, 17);
			this.electronCountOption.TabIndex = 7;
			this.electronCountOption.TabStop = true;
			this.electronCountOption.Text = "Electron Count";
			this.electronCountOption.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.keyLabel);
			this.Controls.Add(this.showFullButton);
			this.Controls.Add(this.findTextBox);
			this.Controls.Add(this.findButton);
			this.Controls.Add(this.radioTable);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.radioTable.ResumeLayout(false);
			this.radioTable.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RadioButton shortNameOption;
		private System.Windows.Forms.RadioButton nameOption;
		private System.Windows.Forms.RadioButton atomicNumberOption;
		private System.Windows.Forms.GroupBox radioTable;
		private System.Windows.Forms.Button findButton;
		private System.Windows.Forms.TextBox findTextBox;
		private System.Windows.Forms.Button showFullButton;
		private System.Windows.Forms.RadioButton typeOption;
		private System.Windows.Forms.RadioButton atomicMassOption;
		private System.Windows.Forms.RadioButton groupOption;
		private System.Windows.Forms.RadioButton periodOption;
		private System.Windows.Forms.Label keyLabel;
		private System.Windows.Forms.RadioButton electronCountOption;
		private System.Windows.Forms.RadioButton infoOption;
	}
}

