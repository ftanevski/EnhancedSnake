
namespace EnhancedSnake
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblFood = new System.Windows.Forms.Label();
            this.lblShowGrids = new System.Windows.Forms.Label();
            this.chbGrids = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grbRadioButtons = new System.Windows.Forms.GroupBox();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbThree = new System.Windows.Forms.RadioButton();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.rbFive = new System.Windows.Forms.RadioButton();
            this.grbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.Transparent;
            this.lblFood.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.Black;
            this.lblFood.Location = new System.Drawing.Point(114, 219);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(134, 24);
            this.lblFood.TabIndex = 0;
            this.lblFood.Text = "Food Spawn:";
            // 
            // lblShowGrids
            // 
            this.lblShowGrids.AutoSize = true;
            this.lblShowGrids.BackColor = System.Drawing.Color.Transparent;
            this.lblShowGrids.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowGrids.Location = new System.Drawing.Point(121, 291);
            this.lblShowGrids.Name = "lblShowGrids";
            this.lblShowGrids.Size = new System.Drawing.Size(127, 24);
            this.lblShowGrids.TabIndex = 1;
            this.lblShowGrids.Text = "Show Grids:";
            // 
            // chbGrids
            // 
            this.chbGrids.AutoSize = true;
            this.chbGrids.Location = new System.Drawing.Point(263, 291);
            this.chbGrids.Name = "chbGrids";
            this.chbGrids.Size = new System.Drawing.Size(18, 17);
            this.chbGrids.TabIndex = 2;
            this.chbGrids.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Marlett", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(118, 486);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 58);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // grbRadioButtons
            // 
            this.grbRadioButtons.BackColor = System.Drawing.Color.Transparent;
            this.grbRadioButtons.Controls.Add(this.rbFive);
            this.grbRadioButtons.Controls.Add(this.rbFour);
            this.grbRadioButtons.Controls.Add(this.rbThree);
            this.grbRadioButtons.Controls.Add(this.rbTwo);
            this.grbRadioButtons.Controls.Add(this.rbOne);
            this.grbRadioButtons.Location = new System.Drawing.Point(263, 196);
            this.grbRadioButtons.Name = "grbRadioButtons";
            this.grbRadioButtons.Size = new System.Drawing.Size(315, 61);
            this.grbRadioButtons.TabIndex = 4;
            this.grbRadioButtons.TabStop = false;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(25, 23);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(39, 24);
            this.rbOne.TabIndex = 0;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "1";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Location = new System.Drawing.Point(85, 23);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(39, 24);
            this.rbTwo.TabIndex = 1;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "2";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // rbThree
            // 
            this.rbThree.AutoSize = true;
            this.rbThree.Location = new System.Drawing.Point(145, 23);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(39, 24);
            this.rbThree.TabIndex = 2;
            this.rbThree.TabStop = true;
            this.rbThree.Text = "3";
            this.rbThree.UseVisualStyleBackColor = true;
            // 
            // rbFour
            // 
            this.rbFour.AutoSize = true;
            this.rbFour.Location = new System.Drawing.Point(205, 23);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(39, 24);
            this.rbFour.TabIndex = 3;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "4";
            this.rbFour.UseVisualStyleBackColor = true;
            // 
            // rbFive
            // 
            this.rbFive.AutoSize = true;
            this.rbFive.Location = new System.Drawing.Point(265, 23);
            this.rbFive.Name = "rbFive";
            this.rbFive.Size = new System.Drawing.Size(39, 24);
            this.rbFive.TabIndex = 4;
            this.rbFive.TabStop = true;
            this.rbFive.Text = "5";
            this.rbFive.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 643);
            this.Controls.Add(this.grbRadioButtons);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chbGrids);
            this.Controls.Add(this.lblShowGrids);
            this.Controls.Add(this.lblFood);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Text = "Enhanced Snake";
            this.grbRadioButtons.ResumeLayout(false);
            this.grbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblShowGrids;
        private System.Windows.Forms.CheckBox chbGrids;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grbRadioButtons;
        private System.Windows.Forms.RadioButton rbThree;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.RadioButton rbFive;
        private System.Windows.Forms.RadioButton rbFour;
    }
}