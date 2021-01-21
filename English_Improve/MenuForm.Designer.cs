namespace English_Improve
{
	partial class MenuForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btAddPic = new System.Windows.Forms.Button();
			this.btAddManga = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("SVN-Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(57, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 53);
			this.label1.TabIndex = 0;
			this.label1.Text = "Main Menu";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btAddPic
			// 
			this.btAddPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btAddPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btAddPic.Location = new System.Drawing.Point(161, 103);
			this.btAddPic.Name = "btAddPic";
			this.btAddPic.Size = new System.Drawing.Size(109, 42);
			this.btAddPic.TabIndex = 1;
			this.btAddPic.Text = "Add Picture";
			this.btAddPic.UseVisualStyleBackColor = true;
			// 
			// btAddManga
			// 
			this.btAddManga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btAddManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btAddManga.Location = new System.Drawing.Point(161, 164);
			this.btAddManga.Name = "btAddManga";
			this.btAddManga.Size = new System.Drawing.Size(109, 39);
			this.btAddManga.TabIndex = 1;
			this.btAddManga.Text = "Add Manga";
			this.btAddManga.UseVisualStyleBackColor = true;
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 263);
			this.Controls.Add(this.btAddManga);
			this.Controls.Add(this.btAddPic);
			this.Controls.Add(this.label1);
			this.Name = "MenuForm";
			this.Text = "MenuForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btAddPic;
		private System.Windows.Forms.Button btAddManga;
	}
}