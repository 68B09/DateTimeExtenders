namespace DateTimeExtenders
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtYear = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMonth = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDay = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDay2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMonth2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtYear2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(12, 12);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(37, 20);
			this.txtYear.TabIndex = 0;
			this.txtYear.Text = "2015";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "年";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(111, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "月";
			// 
			// txtMonth
			// 
			this.txtMonth.Location = new System.Drawing.Point(82, 12);
			this.txtMonth.Name = "txtMonth";
			this.txtMonth.Size = new System.Drawing.Size(24, 20);
			this.txtMonth.TabIndex = 2;
			this.txtMonth.Text = "1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(168, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "日";
			// 
			// txtDay
			// 
			this.txtDay.Location = new System.Drawing.Point(138, 12);
			this.txtDay.Name = "txtDay";
			this.txtDay.Size = new System.Drawing.Size(24, 20);
			this.txtDay.TabIndex = 4;
			this.txtDay.Text = "10";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(168, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "日";
			// 
			// txtDay2
			// 
			this.txtDay2.Location = new System.Drawing.Point(138, 38);
			this.txtDay2.Name = "txtDay2";
			this.txtDay2.Size = new System.Drawing.Size(24, 20);
			this.txtDay2.TabIndex = 10;
			this.txtDay2.Text = "9";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(111, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "月";
			// 
			// txtMonth2
			// 
			this.txtMonth2.Location = new System.Drawing.Point(82, 38);
			this.txtMonth2.Name = "txtMonth2";
			this.txtMonth2.Size = new System.Drawing.Size(24, 20);
			this.txtMonth2.TabIndex = 8;
			this.txtMonth2.Text = "1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(55, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "年";
			// 
			// txtYear2
			// 
			this.txtYear2.Location = new System.Drawing.Point(12, 38);
			this.txtYear2.Name = "txtYear2";
			this.txtYear2.Size = new System.Drawing.Size(37, 20);
			this.txtYear2.TabIndex = 6;
			this.txtYear2.Text = "2016";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 32);
			this.button1.TabIndex = 12;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblResult
			// 
			this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblResult.Location = new System.Drawing.Point(14, 133);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(317, 141);
			this.lblResult.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 283);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDay2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtMonth2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtYear2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMonth);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtYear);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMonth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDay;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDay2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMonth2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtYear2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblResult;
	}
}

