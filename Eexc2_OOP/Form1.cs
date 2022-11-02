using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eexc2_OOP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int A = 0;
		int B = 0;
		int answer1 = 0;
		int answer2 = 0;
		int answer3 = 0;
		int answer4 = 0;
		private void buttonNewGame_Click(object sender, EventArgs e)
		{

			
			do
			{
				int seed = Guid.NewGuid().GetHashCode();
				Random random = new Random(seed);
				answer1 = random.Next(1, 10);
				answer2 = random.Next(0, 10);
				answer3 = random.Next(0, 10);
				answer4 = random.Next(0, 10);
			}
			while
			(
				answer1 == answer2 || answer1 == answer3 || answer1 == answer4 ||
				answer2 == answer3 || answer2 == answer4 ||
				answer3 == answer4
			);
			labelHint.Text = $"{A}A{B}B{answer1}{answer2}{answer3}{answer4}";
		}

		private void buttonGuess_Click(object sender, EventArgs e)
		{
			
			string string1 = textBox1.Text;
			string string2 = textBox2.Text;
			string string3 = textBox3.Text;
			string string4 = textBox4.Text;
			
			int input1 = Convert.ToInt32(string1);
			int input2 = Convert.ToInt32(string2);
			int input3 = Convert.ToInt32(string3);
			int input4 = Convert.ToInt32(string4);
			int[] answers = { answer1, answer2, answer3, answer4 };

			int[] inputs = { input1, input2, input3, input4 };

			for (int i = 0; i < answers.Length; i++)
			{
				for (int j = 0; j < inputs.Length; j++)
				{
					if (inputs[j] == answers[i])
					{
						B += 1;
						if (i == j)
						{
							B -= 1;
							A += 1;
						}
					}
				}
			}
			labelHint.Text = $"{A}A{B}B{answer1}{answer2}{answer3}{answer4}";
			A = 0;
			B = 0;

		}
	}
}
