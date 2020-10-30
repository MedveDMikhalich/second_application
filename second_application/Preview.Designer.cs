namespace second_application
{
  partial class Preview
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
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox2
      // 
      this.pictureBox2.Location = new System.Drawing.Point(0, 0);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(162, 129);
      this.pictureBox2.TabIndex = 0;
      this.pictureBox2.TabStop = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.pictureBox2);
      this.panel2.Location = new System.Drawing.Point(12, 12);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(461, 355);
      this.panel2.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(398, 375);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Close";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Preview
      // 
      this.ClientSize = new System.Drawing.Size(485, 410);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.panel2);
      this.Name = "Preview";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}