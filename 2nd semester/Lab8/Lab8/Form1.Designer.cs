
namespace Lab8
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
			this.singleThreadButton = new System.Windows.Forms.Button();
			this.multiThreadButton = new System.Windows.Forms.Button();
			this.createButton = new System.Windows.Forms.Button();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.columnsTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.execTimeTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.sumTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.replacesTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.redoButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(439, 426);
			this.dataGridView1.TabIndex = 0;
			// 
			// singleThreadButton
			// 
			this.singleThreadButton.Enabled = false;
			this.singleThreadButton.Location = new System.Drawing.Point(466, 364);
			this.singleThreadButton.Name = "singleThreadButton";
			this.singleThreadButton.Size = new System.Drawing.Size(81, 74);
			this.singleThreadButton.TabIndex = 1;
			this.singleThreadButton.Text = "Begin (Single Thread)";
			this.singleThreadButton.UseVisualStyleBackColor = true;
			this.singleThreadButton.Click += new System.EventHandler(this.singleThreadButton_Click);
			// 
			// multiThreadButton
			// 
			this.multiThreadButton.Enabled = false;
			this.multiThreadButton.Location = new System.Drawing.Point(707, 364);
			this.multiThreadButton.Name = "multiThreadButton";
			this.multiThreadButton.Size = new System.Drawing.Size(81, 74);
			this.multiThreadButton.TabIndex = 2;
			this.multiThreadButton.Text = "Begin (Multi Thread)";
			this.multiThreadButton.UseVisualStyleBackColor = true;
			this.multiThreadButton.Click += new System.EventHandler(this.multiThreadButton_Click);
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(565, 123);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(124, 30);
			this.createButton.TabIndex = 3;
			this.createButton.Text = "Create Matrix";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Location = new System.Drawing.Point(466, 75);
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(100, 20);
			this.rowsTextBox.TabIndex = 4;
			// 
			// columnsTextBox
			// 
			this.columnsTextBox.Location = new System.Drawing.Point(688, 75);
			this.columnsTextBox.Name = "columnsTextBox";
			this.columnsTextBox.Size = new System.Drawing.Size(100, 20);
			this.columnsTextBox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(488, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Rows";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(703, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Columns";
			// 
			// execTimeTextBox
			// 
			this.execTimeTextBox.Location = new System.Drawing.Point(565, 418);
			this.execTimeTextBox.Name = "execTimeTextBox";
			this.execTimeTextBox.ReadOnly = true;
			this.execTimeTextBox.Size = new System.Drawing.Size(124, 20);
			this.execTimeTextBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(568, 390);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Execution Time";
			// 
			// sumTextBox
			// 
			this.sumTextBox.Location = new System.Drawing.Point(564, 280);
			this.sumTextBox.Name = "sumTextBox";
			this.sumTextBox.ReadOnly = true;
			this.sumTextBox.Size = new System.Drawing.Size(124, 20);
			this.sumTextBox.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(604, 254);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Sum";
			// 
			// replacesTextBox
			// 
			this.replacesTextBox.Location = new System.Drawing.Point(564, 335);
			this.replacesTextBox.Name = "replacesTextBox";
			this.replacesTextBox.ReadOnly = true;
			this.replacesTextBox.Size = new System.Drawing.Size(124, 20);
			this.replacesTextBox.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(565, 309);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 20);
			this.label5.TabIndex = 13;
			this.label5.Text = "Replaces Count";
			// 
			// redoButton
			// 
			this.redoButton.Enabled = false;
			this.redoButton.Location = new System.Drawing.Point(664, 198);
			this.redoButton.Name = "redoButton";
			this.redoButton.Size = new System.Drawing.Size(124, 30);
			this.redoButton.TabIndex = 14;
			this.redoButton.Text = "Redo matrix";
			this.redoButton.UseVisualStyleBackColor = true;
			this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.redoButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.replacesTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.sumTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.execTimeTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.columnsTextBox);
			this.Controls.Add(this.rowsTextBox);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.multiThreadButton);
			this.Controls.Add(this.singleThreadButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button singleThreadButton;
		private System.Windows.Forms.Button multiThreadButton;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.TextBox columnsTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox execTimeTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox sumTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox replacesTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button redoButton;
	}
}

