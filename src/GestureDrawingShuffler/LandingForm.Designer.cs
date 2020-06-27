namespace GestureDrawingShuffler
{
    partial class LandingForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb30Seconds = new System.Windows.Forms.RadioButton();
            this.rb45Seconds = new System.Windows.Forms.RadioButton();
            this.rb1Minute = new System.Windows.Forms.RadioButton();
            this.rb2Minutes = new System.Windows.Forms.RadioButton();
            this.rb5Minutes = new System.Windows.Forms.RadioButton();
            this.rb10Minutes = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbFolderLocation = new System.Windows.Forms.TextBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.cbBreaks = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Gesture Drawing Shuffler title card";
            this.textBox1.AccessibleName = "GestureDrawingShufflerTitleCard";
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(612, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Gesture Drawing Shuffler";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb30Seconds
            // 
            this.rb30Seconds.AccessibleDescription = "30 seconds option";
            this.rb30Seconds.AutoSize = true;
            this.rb30Seconds.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb30Seconds.Location = new System.Drawing.Point(39, 158);
            this.rb30Seconds.Margin = new System.Windows.Forms.Padding(5);
            this.rb30Seconds.Name = "rb30Seconds";
            this.rb30Seconds.Size = new System.Drawing.Size(119, 24);
            this.rb30Seconds.TabIndex = 1;
            this.rb30Seconds.TabStop = true;
            this.rb30Seconds.Text = "30 seconds";
            this.rb30Seconds.UseVisualStyleBackColor = true;
            // 
            // rb45Seconds
            // 
            this.rb45Seconds.AutoSize = true;
            this.rb45Seconds.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb45Seconds.Location = new System.Drawing.Point(168, 158);
            this.rb45Seconds.Margin = new System.Windows.Forms.Padding(5);
            this.rb45Seconds.Name = "rb45Seconds";
            this.rb45Seconds.Size = new System.Drawing.Size(119, 24);
            this.rb45Seconds.TabIndex = 2;
            this.rb45Seconds.TabStop = true;
            this.rb45Seconds.Text = "45 seconds";
            this.rb45Seconds.UseVisualStyleBackColor = true;
            // 
            // rb1Minute
            // 
            this.rb1Minute.AutoSize = true;
            this.rb1Minute.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1Minute.Location = new System.Drawing.Point(297, 158);
            this.rb1Minute.Margin = new System.Windows.Forms.Padding(5);
            this.rb1Minute.Name = "rb1Minute";
            this.rb1Minute.Size = new System.Drawing.Size(100, 24);
            this.rb1Minute.TabIndex = 3;
            this.rb1Minute.TabStop = true;
            this.rb1Minute.Text = "1 minute";
            this.rb1Minute.UseVisualStyleBackColor = true;
            // 
            // rb2Minutes
            // 
            this.rb2Minutes.AutoSize = true;
            this.rb2Minutes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2Minutes.Location = new System.Drawing.Point(407, 158);
            this.rb2Minutes.Margin = new System.Windows.Forms.Padding(5);
            this.rb2Minutes.Name = "rb2Minutes";
            this.rb2Minutes.Size = new System.Drawing.Size(109, 24);
            this.rb2Minutes.TabIndex = 4;
            this.rb2Minutes.TabStop = true;
            this.rb2Minutes.Text = "2 minutes";
            this.rb2Minutes.UseVisualStyleBackColor = true;
            // 
            // rb5Minutes
            // 
            this.rb5Minutes.AutoSize = true;
            this.rb5Minutes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5Minutes.Location = new System.Drawing.Point(39, 192);
            this.rb5Minutes.Margin = new System.Windows.Forms.Padding(5);
            this.rb5Minutes.Name = "rb5Minutes";
            this.rb5Minutes.Size = new System.Drawing.Size(109, 24);
            this.rb5Minutes.TabIndex = 5;
            this.rb5Minutes.TabStop = true;
            this.rb5Minutes.Text = "5 minutes";
            this.rb5Minutes.UseVisualStyleBackColor = true;
            // 
            // rb10Minutes
            // 
            this.rb10Minutes.AutoSize = true;
            this.rb10Minutes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb10Minutes.Location = new System.Drawing.Point(168, 192);
            this.rb10Minutes.Margin = new System.Windows.Forms.Padding(5);
            this.rb10Minutes.Name = "rb10Minutes";
            this.rb10Minutes.Size = new System.Drawing.Size(119, 24);
            this.rb10Minutes.TabIndex = 6;
            this.rb10Minutes.TabStop = true;
            this.rb10Minutes.Text = "10 minutes";
            this.rb10Minutes.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "Gesture Drawing Shuffler title card";
            this.textBox2.AccessibleName = "GestureDrawingShufflerTitleCard";
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.Azure;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 122);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(628, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Rotate every";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = "Gesture Drawing Shuffler title card";
            this.textBox3.AccessibleName = "GestureDrawingShufflerTitleCard";
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.Azure;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(14, 327);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(628, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Extras";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.AccessibleDescription = "Gesture Drawing Shuffler title card";
            this.textBox4.AccessibleName = "GestureDrawingShufflerTitleCard";
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.Azure;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(14, 241);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(628, 26);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Folder Location";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFolderLocation
            // 
            this.tbFolderLocation.AccessibleDescription = "Gesture Drawing Shuffler title card";
            this.tbFolderLocation.AccessibleName = "GestureDrawingShufflerTitleCard";
            this.tbFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolderLocation.BackColor = System.Drawing.Color.Azure;
            this.tbFolderLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFolderLocation.Enabled = false;
            this.tbFolderLocation.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFolderLocation.Location = new System.Drawing.Point(20, 277);
            this.tbFolderLocation.Margin = new System.Windows.Forms.Padding(5);
            this.tbFolderLocation.Name = "tbFolderLocation";
            this.tbFolderLocation.ReadOnly = true;
            this.tbFolderLocation.Size = new System.Drawing.Size(434, 20);
            this.tbFolderLocation.TabIndex = 10;
            this.tbFolderLocation.Text = "Folder Location";
            this.tbFolderLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.BackColor = System.Drawing.Color.Black;
            this.btnChoosePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChoosePath.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChoosePath.FlatAppearance.BorderSize = 0;
            this.btnChoosePath.ForeColor = System.Drawing.Color.White;
            this.btnChoosePath.Location = new System.Drawing.Point(462, 273);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(182, 29);
            this.btnChoosePath.TabIndex = 11;
            this.btnChoosePath.Text = "Choose folder...";
            this.btnChoosePath.UseVisualStyleBackColor = false;
            // 
            // cbBreaks
            // 
            this.cbBreaks.AutoSize = true;
            this.cbBreaks.Location = new System.Drawing.Point(39, 362);
            this.cbBreaks.Name = "cbBreaks";
            this.cbBreaks.Size = new System.Drawing.Size(127, 24);
            this.cbBreaks.TabIndex = 12;
            this.cbBreaks.Text = "With breaks";
            this.cbBreaks.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(14, 450);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(630, 32);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(656, 509);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbBreaks);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.tbFolderLocation);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rb10Minutes);
            this.Controls.Add(this.rb5Minutes);
            this.Controls.Add(this.rb2Minutes);
            this.Controls.Add(this.rb1Minute);
            this.Controls.Add(this.rb45Seconds);
            this.Controls.Add(this.rb30Seconds);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LandingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb30Seconds;
        private System.Windows.Forms.RadioButton rb45Seconds;
        private System.Windows.Forms.RadioButton rb1Minute;
        private System.Windows.Forms.RadioButton rb2Minutes;
        private System.Windows.Forms.RadioButton rb5Minutes;
        private System.Windows.Forms.RadioButton rb10Minutes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbFolderLocation;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.CheckBox cbBreaks;
        private System.Windows.Forms.Button btnStart;
    }
}

