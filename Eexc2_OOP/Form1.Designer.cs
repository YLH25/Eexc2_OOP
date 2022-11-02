namespace Eexc2_OOP
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonGuess = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelHint = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.buttonNewGame = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonGuess
			// 
			this.buttonGuess.Location = new System.Drawing.Point(103, 186);
			this.buttonGuess.Name = "buttonGuess";
			this.buttonGuess.Size = new System.Drawing.Size(75, 23);
			this.buttonGuess.TabIndex = 4;
			this.buttonGuess.Text = "Guess";
			this.buttonGuess.UseVisualStyleBackColor = true;
			this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox1.Location = new System.Drawing.Point(37, 100);
			this.textBox1.MaxLength = 1;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(43, 35);
			this.textBox1.TabIndex = 0;
			// 
			// labelHint
			// 
			this.labelHint.AutoSize = true;
			this.labelHint.Location = new System.Drawing.Point(118, 263);
			this.labelHint.Name = "labelHint";
			this.labelHint.Size = new System.Drawing.Size(33, 12);
			this.labelHint.TabIndex = 5;
			this.labelHint.Text = "0A0B";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox2.Location = new System.Drawing.Point(86, 100);
			this.textBox2.MaxLength = 1;
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(43, 35);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox3.Location = new System.Drawing.Point(135, 100);
			this.textBox3.MaxLength = 1;
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(43, 35);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox4.Location = new System.Drawing.Point(184, 100);
			this.textBox4.MaxLength = 1;
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(43, 35);
			this.textBox4.TabIndex = 3;
			// 
			// buttonNewGame
			// 
			this.buttonNewGame.Location = new System.Drawing.Point(103, 41);
			this.buttonNewGame.Name = "buttonNewGame";
			this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
			this.buttonNewGame.TabIndex = 4;
			this.buttonNewGame.Text = "NewGame";
			this.buttonNewGame.UseVisualStyleBackColor = true;
			this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 324);
			this.Controls.Add(this.labelHint);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonNewGame);
			this.Controls.Add(this.buttonGuess);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonGuess;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelHint;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button buttonNewGame;
	}
}

