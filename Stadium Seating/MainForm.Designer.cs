/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/11/2021
 * Time: 10:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Stadium_Seating
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox ClassCTickettextBox;
		private System.Windows.Forms.TextBox ClassBTickettextBox;
		private System.Windows.Forms.TextBox ClassATickettextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox TotalRevenuetextBox;
		private System.Windows.Forms.TextBox ClassCRevenuetextBox;
		private System.Windows.Forms.TextBox ClassBRevenuetextBox;
		private System.Windows.Forms.TextBox ClassARevenuetextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button CalculateRevenuebutton;
		private System.Windows.Forms.Button Clearbutton;
		private System.Windows.Forms.Button Exitbutton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ClassCTickettextBox = new System.Windows.Forms.TextBox();
			this.ClassBTickettextBox = new System.Windows.Forms.TextBox();
			this.ClassATickettextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.TotalRevenuetextBox = new System.Windows.Forms.TextBox();
			this.ClassCRevenuetextBox = new System.Windows.Forms.TextBox();
			this.ClassBRevenuetextBox = new System.Windows.Forms.TextBox();
			this.ClassARevenuetextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.CalculateRevenuebutton = new System.Windows.Forms.Button();
			this.Clearbutton = new System.Windows.Forms.Button();
			this.Exitbutton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
			this.groupBox1.Controls.Add(this.ClassCTickettextBox);
			this.groupBox1.Controls.Add(this.ClassBTickettextBox);
			this.groupBox1.Controls.Add(this.ClassATickettextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox1.Location = new System.Drawing.Point(38, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(299, 276);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ticket Sold";
			// 
			// ClassCTickettextBox
			// 
			this.ClassCTickettextBox.BackColor = System.Drawing.Color.DarkGray;
			this.ClassCTickettextBox.Location = new System.Drawing.Point(144, 179);
			this.ClassCTickettextBox.Name = "ClassCTickettextBox";
			this.ClassCTickettextBox.Size = new System.Drawing.Size(100, 26);
			this.ClassCTickettextBox.TabIndex = 6;
			// 
			// ClassBTickettextBox
			// 
			this.ClassBTickettextBox.BackColor = System.Drawing.Color.DarkGray;
			this.ClassBTickettextBox.Location = new System.Drawing.Point(144, 142);
			this.ClassBTickettextBox.Name = "ClassBTickettextBox";
			this.ClassBTickettextBox.Size = new System.Drawing.Size(100, 26);
			this.ClassBTickettextBox.TabIndex = 5;
			// 
			// ClassATickettextBox
			// 
			this.ClassATickettextBox.BackColor = System.Drawing.Color.DarkGray;
			this.ClassATickettextBox.Location = new System.Drawing.Point(144, 106);
			this.ClassATickettextBox.Name = "ClassATickettextBox";
			this.ClassATickettextBox.Size = new System.Drawing.Size(100, 26);
			this.ClassATickettextBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(47, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Class C:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(47, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Class B:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Class A:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(22, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter the number of tickets sold for each class of seats.";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Desktop;
			this.groupBox2.Controls.Add(this.TotalRevenuetextBox);
			this.groupBox2.Controls.Add(this.ClassCRevenuetextBox);
			this.groupBox2.Controls.Add(this.ClassBRevenuetextBox);
			this.groupBox2.Controls.Add(this.ClassARevenuetextBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox2.Location = new System.Drawing.Point(364, 25);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(298, 276);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Revenue Generated";
			// 
			// TotalRevenuetextBox
			// 
			this.TotalRevenuetextBox.BackColor = System.Drawing.Color.DarkGray;
			this.TotalRevenuetextBox.Enabled = false;
			this.TotalRevenuetextBox.Location = new System.Drawing.Point(119, 180);
			this.TotalRevenuetextBox.Name = "TotalRevenuetextBox";
			this.TotalRevenuetextBox.Size = new System.Drawing.Size(100, 26);
			this.TotalRevenuetextBox.TabIndex = 7;
			// 
			// ClassCRevenuetextBox
			// 
			this.ClassCRevenuetextBox.BackColor = System.Drawing.Color.DarkGray;
			this.ClassCRevenuetextBox.Enabled = false;
			this.ClassCRevenuetextBox.Location = new System.Drawing.Point(119, 142);
			this.ClassCRevenuetextBox.Name = "ClassCRevenuetextBox";
			this.ClassCRevenuetextBox.Size = new System.Drawing.Size(100, 26);
			this.ClassCRevenuetextBox.TabIndex = 6;
			// 
			// ClassBRevenuetextBox
			// 
			this.ClassBRevenuetextBox.BackColor = System.Drawing.Color.DarkGray;
			this.ClassBRevenuetextBox.Enabled = false;
			this.ClassBRevenuetextBox.Location = new System.Drawing.Point(119, 102);
			this.ClassBRevenuetextBox.Name = "ClassBRevenuetextBox";
			this.ClassBRevenuetextBox.Size = new System.Drawing.Size(100, 26);
			this.ClassBRevenuetextBox.TabIndex = 5;
			// 
			// ClassARevenuetextBox
			// 
			this.ClassARevenuetextBox.BackColor = System.Drawing.Color.DarkGray;
			this.ClassARevenuetextBox.Enabled = false;
			this.ClassARevenuetextBox.Location = new System.Drawing.Point(119, 60);
			this.ClassARevenuetextBox.Name = "ClassARevenuetextBox";
			this.ClassARevenuetextBox.Size = new System.Drawing.Size(100, 26);
			this.ClassARevenuetextBox.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(41, 182);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 23);
			this.label8.TabIndex = 3;
			this.label8.Text = "Total:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(34, 145);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "Class C:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(34, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "Class B:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(34, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Class A:";
			// 
			// CalculateRevenuebutton
			// 
			this.CalculateRevenuebutton.BackColor = System.Drawing.SystemColors.Desktop;
			this.CalculateRevenuebutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CalculateRevenuebutton.ForeColor = System.Drawing.Color.White;
			this.CalculateRevenuebutton.Location = new System.Drawing.Point(138, 321);
			this.CalculateRevenuebutton.Name = "CalculateRevenuebutton";
			this.CalculateRevenuebutton.Size = new System.Drawing.Size(135, 49);
			this.CalculateRevenuebutton.TabIndex = 2;
			this.CalculateRevenuebutton.Text = "Calculate Revenue";
			this.CalculateRevenuebutton.UseVisualStyleBackColor = false;
			this.CalculateRevenuebutton.Click += new System.EventHandler(this.CalculateRevenuebuttonClick);
			// 
			// Clearbutton
			// 
			this.Clearbutton.BackColor = System.Drawing.SystemColors.Desktop;
			this.Clearbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Clearbutton.ForeColor = System.Drawing.Color.White;
			this.Clearbutton.Location = new System.Drawing.Point(315, 321);
			this.Clearbutton.Name = "Clearbutton";
			this.Clearbutton.Size = new System.Drawing.Size(98, 49);
			this.Clearbutton.TabIndex = 3;
			this.Clearbutton.Text = "Clear";
			this.Clearbutton.UseVisualStyleBackColor = false;
			this.Clearbutton.Click += new System.EventHandler(this.ClearbuttonClick);
			// 
			// Exitbutton
			// 
			this.Exitbutton.BackColor = System.Drawing.SystemColors.Desktop;
			this.Exitbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Exitbutton.ForeColor = System.Drawing.Color.White;
			this.Exitbutton.Location = new System.Drawing.Point(452, 321);
			this.Exitbutton.Name = "Exitbutton";
			this.Exitbutton.Size = new System.Drawing.Size(85, 49);
			this.Exitbutton.TabIndex = 4;
			this.Exitbutton.Text = "Exit";
			this.Exitbutton.UseVisualStyleBackColor = false;
			this.Exitbutton.Click += new System.EventHandler(this.ExitbuttonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(698, 409);
			this.Controls.Add(this.Exitbutton);
			this.Controls.Add(this.Clearbutton);
			this.Controls.Add(this.CalculateRevenuebutton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Stadium Seating";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
