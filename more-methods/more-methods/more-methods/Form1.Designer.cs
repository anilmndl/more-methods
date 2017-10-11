namespace more_methods
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.radioBtnBicycle = new System.Windows.Forms.RadioButton();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnBicycle);
            this.groupBox1.Controls.Add(this.radioButtonBus);
            this.groupBox1.Location = new System.Drawing.Point(43, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonBus
            // 
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(36, 19);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBus.TabIndex = 0;
            this.radioButtonBus.TabStop = true;
            this.radioButtonBus.Text = "Bus";
            this.radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // radioBtnBicycle
            // 
            this.radioBtnBicycle.AutoSize = true;
            this.radioBtnBicycle.Location = new System.Drawing.Point(36, 42);
            this.radioBtnBicycle.Name = "radioBtnBicycle";
            this.radioBtnBicycle.Size = new System.Drawing.Size(59, 17);
            this.radioBtnBicycle.TabIndex = 1;
            this.radioBtnBicycle.TabStop = true;
            this.radioBtnBicycle.Text = "Bicycle";
            this.radioBtnBicycle.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(43, 153);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(177, 45);
            this.trackBar.TabIndex = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnBicycle;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

