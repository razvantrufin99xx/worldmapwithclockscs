/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/23/2024
 * Time: 9:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace controlClock
{
	/// <summary>
	/// Description of clk.
	/// </summary>
	public partial class clk : UserControl
	{
		public clk()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public double localtime = 0;
		public void setClock(double lc)
		{
			this.localtime = lc;
		}
		
		public DateTime dt = new DateTime();
		public bool set()
		{
			dt.AddHours(this.localtime);
			
			DateTime lclTime = DateTime.Now;
			DateTime ept = lclTime.ToUniversalTime().AddHours(this.localtime);
				
			dt = ept;
			this.label1.Text = dt.ToShortTimeString();
			this.label2.Text = localtime.ToString();
			//if(label1.BackColor == Color.Gray){label1.BackColor=Color.Red; return true;}
			//else{label1.BackColor=Color.Gray; return true;}
			return false;
		}
		void ClkLoad(object sender, EventArgs e)
		{
			dt = DateTime.Now;
			double h = dt.Hour ;
			dt.AddHours( h + this.localtime);
			this.label2.Text = localtime.ToString();
			this.label1.Text = dt.ToShortTimeString();
		}
		
	}
}
