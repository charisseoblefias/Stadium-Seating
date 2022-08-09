/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/11/2021
 * Time: 10:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Stadium_Seating
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CalculateRevenuebuttonClick(object sender, EventArgs e)
		{
			int CATickets = Convert.ToInt16(ClassATickettextBox.Text) * 15;
			int CBTickets = Convert.ToInt16(ClassBTickettextBox.Text) * 12;
			int CCTickets = Convert.ToInt16(ClassCTickettextBox.Text) * 9;
			int TotalRevenue = CATickets + CBTickets + CCTickets;
			
			ClassARevenuetextBox.Text=CATickets.ToString("c");
			ClassBRevenuetextBox.Text=CBTickets.ToString("c");
			ClassCRevenuetextBox.Text=CCTickets.ToString("c");
			TotalRevenuetextBox.Text=TotalRevenue.ToString("c");
		}
		void ClearbuttonClick(object sender, EventArgs e)
		{
			ClassATickettextBox.Clear();
			ClassBTickettextBox.Clear();
			ClassCTickettextBox.Clear();
			ClassARevenuetextBox.Clear();
			ClassBRevenuetextBox.Clear();
			ClassCRevenuetextBox.Clear();
			TotalRevenuetextBox.Clear();
		}
		void ExitbuttonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
