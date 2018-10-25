namespace GADEPOE_FINALNEW
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
            this.lblMapDisplay = new System.Windows.Forms.Label();
            this.cmbUnitsDisplay = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.lblTimerDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMapDisplay
            // 
            this.lblMapDisplay.AutoSize = true;
            this.lblMapDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMapDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapDisplay.Location = new System.Drawing.Point(112, 75);
            this.lblMapDisplay.Name = "lblMapDisplay";
            this.lblMapDisplay.Size = new System.Drawing.Size(70, 20);
            this.lblMapDisplay.TabIndex = 0;
            this.lblMapDisplay.Text = "label1";
            // 
            // cmbUnitsDisplay
            // 
            this.cmbUnitsDisplay.Font = new System.Drawing.Font("Pill Gothic 600mg Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitsDisplay.FormattingEnabled = true;
            this.cmbUnitsDisplay.Location = new System.Drawing.Point(481, 166);
            this.cmbUnitsDisplay.Name = "cmbUnitsDisplay";
            this.cmbUnitsDisplay.Size = new System.Drawing.Size(252, 20);
            this.cmbUnitsDisplay.TabIndex = 1;
            this.cmbUnitsDisplay.SelectedIndexChanged += new System.EventHandler(this.cmbUnitsDisplay_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(426, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(658, 106);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(658, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 1000;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // lblTimerDisplay
            // 
            this.lblTimerDisplay.AutoSize = true;
            this.lblTimerDisplay.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerDisplay.Location = new System.Drawing.Point(541, 55);
            this.lblTimerDisplay.Name = "lblTimerDisplay";
            this.lblTimerDisplay.Size = new System.Drawing.Size(38, 17);
            this.lblTimerDisplay.TabIndex = 6;
            this.lblTimerDisplay.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimerDisplay);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbUnitsDisplay);
            this.Controls.Add(this.lblMapDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMapDisplay;
        private System.Windows.Forms.ComboBox cmbUnitsDisplay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.Label lblTimerDisplay;
    }
}

