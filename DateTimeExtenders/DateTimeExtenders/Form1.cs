using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimeExtenders
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime birthday = new DateTime(int.Parse(this.txtYear.Text), int.Parse(this.txtMonth.Text), int.Parse(this.txtDay.Text));
			DateTime today = new DateTime(int.Parse(this.txtYear2.Text), int.Parse(this.txtMonth2.Text), int.Parse(this.txtDay2.Text));

			this.lblResult.Text = "";

			string eto = DateTimeExtender.GetEto(today.Year);
			this.lblResult.Text = eto;

			int age = DateTimeExtender.GetAge(birthday, today, DateTimeExtender.AgeCalculateType.Normal);
			this.lblResult.Text += string.Format("\n通例 {0} 歳 ※当日に年を取る", age);

			age = DateTimeExtender.GetAge(birthday, today, DateTimeExtender.AgeCalculateType.Legal);
			this.lblResult.Text += string.Format("\n法令 {0} 歳 ※前日に年を取る", age);

			age = DateTimeExtender.GetAge(birthday, today, DateTimeExtender.AgeCalculateType.Kazoe);
			this.lblResult.Text += string.Format("\n数年 {0} 歳", age);
		}
	}
}
