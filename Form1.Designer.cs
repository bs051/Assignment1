namespace Assignment1
{
    partial class Form1
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
            this.Load_Bullet = new System.Windows.Forms.Button();
            this.Spin_Chamber = new System.Windows.Forms.Button();
            this.Shoot_Bullet = new System.Windows.Forms.Button();
            this.Play_Again = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_Bullet
            // 
            this.Load_Bullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Bullet.Location = new System.Drawing.Point(440, 115);
            this.Load_Bullet.Name = "Load_Bullet";
            this.Load_Bullet.Size = new System.Drawing.Size(266, 75);
            this.Load_Bullet.TabIndex = 0;
            this.Load_Bullet.Text = "Load Bullet";
            this.Load_Bullet.UseVisualStyleBackColor = true;
            this.Load_Bullet.Click += new System.EventHandler(this.loadButton);
            // 
            // Spin_Chamber
            // 
            this.Spin_Chamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin_Chamber.Location = new System.Drawing.Point(440, 229);
            this.Spin_Chamber.Name = "Spin_Chamber";
            this.Spin_Chamber.Size = new System.Drawing.Size(278, 64);
            this.Spin_Chamber.TabIndex = 2;
            this.Spin_Chamber.Text = "Spin Chamber";
            this.Spin_Chamber.UseVisualStyleBackColor = true;
            this.Spin_Chamber.Click += new System.EventHandler(this.SpinChamber);
            // 
            // Shoot_Bullet
            // 
            this.Shoot_Bullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot_Bullet.Location = new System.Drawing.Point(123, 423);
            this.Shoot_Bullet.Name = "Shoot_Bullet";
            this.Shoot_Bullet.Size = new System.Drawing.Size(627, 97);
            this.Shoot_Bullet.TabIndex = 3;
            this.Shoot_Bullet.Text = "Fire";
            this.Shoot_Bullet.UseVisualStyleBackColor = true;
            this.Shoot_Bullet.Click += new System.EventHandler(this.ShootBullet);
            // 
            // Play_Again
            // 
            this.Play_Again.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Again.Location = new System.Drawing.Point(440, 332);
            this.Play_Again.Name = "Play_Again";
            this.Play_Again.Size = new System.Drawing.Size(265, 59);
            this.Play_Again.TabIndex = 4;
            this.Play_Again.Text = "Play Again";
            this.Play_Again.UseVisualStyleBackColor = true;
            this.Play_Again.Click += new System.EventHandler(this.Play_Again_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment1.Properties.Resources.chamber;
            this.pictureBox1.Location = new System.Drawing.Point(75, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 276);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Russian roulette";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "You Win If You Get 100 Score";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play_Again);
            this.Controls.Add(this.Shoot_Bullet);
            this.Controls.Add(this.Spin_Chamber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Load_Bullet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_Bullet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Spin_Chamber;
        private System.Windows.Forms.Button Shoot_Bullet;
        private System.Windows.Forms.Button Play_Again;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

