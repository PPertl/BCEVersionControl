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
            this.btnCar = new System.Windows.Forms.Button();
            this.btnBall = new System.Windows.Forms.Button();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnPresentRibbonColor = new System.Windows.Forms.Button();
            this.btnPresentBoxColor = new System.Windows.Forms.Button();
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
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(5, 65);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(75, 23);
            this.btnCar.TabIndex = 2;
            this.btnCar.Text = "CAR";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.Car_button_Click);
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(109, 65);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(75, 23);
            this.btnBall.TabIndex = 3;
            this.btnBall.Text = "BALL";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.Ball_button_Click);
            // 
            // btnBallColor
            // 
            this.btnBallColor.BackColor = System.Drawing.Color.Tomato;
            this.btnBallColor.Location = new System.Drawing.Point(109, 105);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(75, 23);
            this.btnBallColor.TabIndex = 4;
            this.btnBallColor.UseVisualStyleBackColor = false;
            this.btnBallColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(224, 64);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(75, 23);
            this.btnPresent.TabIndex = 5;
            this.btnPresent.Text = "PRESENT";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnPresentRibbonColor
            // 
            this.btnPresentRibbonColor.BackColor = System.Drawing.Color.Red;
            this.btnPresentRibbonColor.Location = new System.Drawing.Point(224, 105);
            this.btnPresentRibbonColor.Name = "btnPresentRibbonColor";
            this.btnPresentRibbonColor.Size = new System.Drawing.Size(75, 23);
            this.btnPresentRibbonColor.TabIndex = 6;
            this.btnPresentRibbonColor.UseVisualStyleBackColor = false;
            this.btnPresentRibbonColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // btnPresentBoxColor
            // 
            this.btnPresentBoxColor.BackColor = System.Drawing.Color.Gold;
            this.btnPresentBoxColor.Location = new System.Drawing.Point(224, 135);
            this.btnPresentBoxColor.Name = "btnPresentBoxColor";
            this.btnPresentBoxColor.Size = new System.Drawing.Size(75, 23);
            this.btnPresentBoxColor.TabIndex = 7;
            this.btnPresentBoxColor.UseVisualStyleBackColor = false;
            this.btnPresentBoxColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnPresentBoxColor);
            this.Controls.Add(this.btnPresentRibbonColor);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.btnBallColor);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.btnCar);
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
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Button btnBallColor;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnPresentRibbonColor;
        private System.Windows.Forms.Button btnPresentBoxColor;
    }
}

