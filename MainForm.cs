/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/23/2024
 * Time: 9:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace controlClock
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
		void MainFormLoad(object sender, EventArgs e)
		{
			clk1.setClock(0);
			clk2.setClock(1);
			clk3.setClock(2);
			clk4.setClock(3);
			clk5.setClock(4);
			clk6.setClock(5);
			clk7.setClock(6);
			clk8.setClock(7);
			clk9.setClock(8);
			clk10.setClock(9);
			clk11.setClock(10);
			clk12.setClock(11);
			clk13.setClock(-10);
			clk14.setClock(-9);
			clk15.setClock(-8);
			clk16.setClock(-7);
			clk17.setClock(-6);
			clk18.setClock(-5);
			clk19.setClock(-4);
			clk20.setClock(-3);
			clk21.setClock(-2);
			clk22.setClock(-1);
			clk23.setClock(-0);
			clk24.setClock(+13);
			clk25.setClock(+12);
			clk26.setClock(+12);
			
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			clk1.set();
			clk2.set();
			clk3.set();
			clk4.set();
			clk5.set();
			clk6.set();
			
			clk7.set();
			clk8.set();
			clk9.set();
			clk10.set();
			clk11.set();
			clk12.set();
			
			clk13.set();
			clk14.set();
			clk15.set();
			clk16.set();
			clk17.set();
			clk18.set();
			
			clk19.set();
			clk20.set();
			clk21.set();
			clk22.set();
			clk23.set();
			clk24.set();
			
			clk25.set();
			clk26.set();
			
			
			DateTime d = DateTime.Now;
			Text = d.ToShortTimeString();
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
	}
}
