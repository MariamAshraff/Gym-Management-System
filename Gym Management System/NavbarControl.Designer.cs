namespace Gym_Management_System
{
    partial class NavbarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Home = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(31, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Location = new Point(228, 41);
            Home.Name = "Home";
            Home.Size = new Size(55, 21);
            Home.TabIndex = 1;
            Home.Text = "Home";
            Home.Click += Home_Click;
            // 
            // NavbarControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(Home);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "NavbarControl";
            Size = new Size(1071, 116);
            Load += NavbarControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Home;
    }
}
