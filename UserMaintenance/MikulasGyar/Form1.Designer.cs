namespace MikulasGyar
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.lblNext = new System.Windows.Forms.Label();
            this.Car_button = new System.Windows.Forms.Button();
            this.Ball_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 363);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(13, 199);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(68, 13);
            this.lblNext.TabIndex = 1;
            this.lblNext.Text = "Coming next:";
            // 
            // Car_button
            // 
            this.Car_button.Location = new System.Drawing.Point(5, 65);
            this.Car_button.Name = "Car_button";
            this.Car_button.Size = new System.Drawing.Size(75, 23);
            this.Car_button.TabIndex = 2;
            this.Car_button.Text = "CAR";
            this.Car_button.UseVisualStyleBackColor = true;
            this.Car_button.Click += new System.EventHandler(this.Car_button_Click);
            // 
            // Ball_button
            // 
            this.Ball_button.Location = new System.Drawing.Point(109, 65);
            this.Ball_button.Name = "Ball_button";
            this.Ball_button.Size = new System.Drawing.Size(75, 23);
            this.Ball_button.TabIndex = 3;
            this.Ball_button.Text = "BALL";
            this.Ball_button.UseVisualStyleBackColor = true;
            this.Ball_button.Click += new System.EventHandler(this.Ball_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Ball_button);
            this.Controls.Add(this.Car_button);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button Car_button;
        private System.Windows.Forms.Button Ball_button;
    }
}

