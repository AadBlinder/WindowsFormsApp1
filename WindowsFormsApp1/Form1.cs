using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_MouseEnter(object sender, EventArgs e)
		{
			button1.Visible = false;
		}

		private void button1_MouseLeave(object sender, EventArgs e)
		{
			button1.Visible = true;
		}

		private void button2_MouseEnter(object sender, EventArgs e)
		{
			//Cursor.Position = new Point(button3.Location.X+10,button3.Location.Y+120);
			MessageBox.Show(MousePosition.ToString());
		}

		private void button3_MouseEnter(object sender, EventArgs e)
		{
			//Cursor.Position = new Point(button2.Location.X +100, button2.Location.Y + 172);
			MessageBox.Show(MousePosition.ToString());
			//tableLayoutPanel1.
		}

		private void button4_MouseDown(object sender, MouseEventArgs e)
		{
			MessageBox.Show(MousePosition.ToString());
		}
	}
}
