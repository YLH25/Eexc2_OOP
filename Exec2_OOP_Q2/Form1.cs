using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_OOP_Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int dice1 = 0;
			int dice2 = 0;
			int dice3 = 0;
			int dice4 = 0;
			int result = 0;
			int minResult1 = 0;
			


			do
			{
				int seed = Guid.NewGuid().GetHashCode();
				Random random = new Random(seed);
				dice1 = random.Next(1, 7);
				dice2 = random.Next(1, 7);
				dice3 = random.Next(1, 7);
				dice4 = random.Next(1, 7);

			}
			while (
				dice1 != dice2 && dice1 != dice3 && dice1 != dice4 &&
				dice2 != dice3 && dice2 != dice4 &&
				dice3 != dice4);
			int[] dices = { dice1, dice2, dice3, dice4 };
			
			for (int i = 0; i < dices.Length; i++)
			{
				for (int j = 0; j < dices.Length; j++)
				{
					if (dices[i] == dices[j] && i != j)
					{
						result = dices[i] * 2;
						if (result < minResult1)
						{
							minResult1 = result;
						}
					}
				}
			}
			int answer = dice1 + dice2 + dice3 + dice4;
			if (minResult1 == 0)
			{ 
				answer = answer - result;
			}
			else
			{ 
				answer = answer - minResult1;
			}
			label1.Text = $"{dice1}";
			label2.Text = $"{dice2}";
			label3.Text = $"{dice3}";
			label4.Text = $"{dice4}";
			label5.Text=$"{answer}";
		}
	}
}
