namespace RoboticsProjectGUI
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
            this.dispenseButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.greenButtonBack = new System.Windows.Forms.TextBox();
            this.redButtonBack = new System.Windows.Forms.TextBox();
            this.orangeButtonBack = new System.Windows.Forms.TextBox();
            this.blueButtonBack = new System.Windows.Forms.TextBox();
            this.yellowButtonBack = new System.Windows.Forms.TextBox();
            this.whiteButtonBack = new System.Windows.Forms.TextBox();
            this.maintenanceButton = new System.Windows.Forms.Button();
            this.readyDispense = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dispenseButton
            // 
            this.dispenseButton.BackColor = System.Drawing.Color.SteelBlue;
            this.dispenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispenseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dispenseButton.Location = new System.Drawing.Point(369, 207);
            this.dispenseButton.Name = "dispenseButton";
            this.dispenseButton.Size = new System.Drawing.Size(553, 289);
            this.dispenseButton.TabIndex = 0;
            this.dispenseButton.Text = "Dispense";
            this.dispenseButton.UseVisualStyleBackColor = false;
            this.dispenseButton.Click += new System.EventHandler(this.dispenseButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.LimeGreen;
            this.greenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenButton.Location = new System.Drawing.Point(1148, 662);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(168, 68);
            this.greenButton.TabIndex = 1;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(975, 662);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(168, 68);
            this.redButton.TabIndex = 2;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.orangeButton.Location = new System.Drawing.Point(975, 588);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(168, 68);
            this.orangeButton.TabIndex = 3;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(1148, 588);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(168, 68);
            this.blueButton.TabIndex = 4;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(1148, 514);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(168, 68);
            this.whiteButton.TabIndex = 5;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(975, 514);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(168, 68);
            this.yellowButton.TabIndex = 6;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(946, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Medicine to Dispense";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // greenButtonBack
            // 
            this.greenButtonBack.BackColor = System.Drawing.Color.DarkGreen;
            this.greenButtonBack.Location = new System.Drawing.Point(1140, 654);
            this.greenButtonBack.Multiline = true;
            this.greenButtonBack.Name = "greenButtonBack";
            this.greenButtonBack.Size = new System.Drawing.Size(183, 81);
            this.greenButtonBack.TabIndex = 8;
            // 
            // redButtonBack
            // 
            this.redButtonBack.BackColor = System.Drawing.Color.DarkRed;
            this.redButtonBack.Location = new System.Drawing.Point(967, 654);
            this.redButtonBack.Multiline = true;
            this.redButtonBack.Name = "redButtonBack";
            this.redButtonBack.Size = new System.Drawing.Size(183, 81);
            this.redButtonBack.TabIndex = 9;
            // 
            // orangeButtonBack
            // 
            this.orangeButtonBack.BackColor = System.Drawing.Color.OrangeRed;
            this.orangeButtonBack.Location = new System.Drawing.Point(967, 580);
            this.orangeButtonBack.Multiline = true;
            this.orangeButtonBack.Name = "orangeButtonBack";
            this.orangeButtonBack.Size = new System.Drawing.Size(183, 81);
            this.orangeButtonBack.TabIndex = 10;
            // 
            // blueButtonBack
            // 
            this.blueButtonBack.BackColor = System.Drawing.Color.DarkBlue;
            this.blueButtonBack.Location = new System.Drawing.Point(1140, 580);
            this.blueButtonBack.Multiline = true;
            this.blueButtonBack.Name = "blueButtonBack";
            this.blueButtonBack.Size = new System.Drawing.Size(183, 81);
            this.blueButtonBack.TabIndex = 11;
            // 
            // yellowButtonBack
            // 
            this.yellowButtonBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowButtonBack.Location = new System.Drawing.Point(967, 506);
            this.yellowButtonBack.Multiline = true;
            this.yellowButtonBack.Name = "yellowButtonBack";
            this.yellowButtonBack.Size = new System.Drawing.Size(183, 81);
            this.yellowButtonBack.TabIndex = 12;
            this.yellowButtonBack.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // whiteButtonBack
            // 
            this.whiteButtonBack.BackColor = System.Drawing.Color.Silver;
            this.whiteButtonBack.Location = new System.Drawing.Point(1140, 506);
            this.whiteButtonBack.Multiline = true;
            this.whiteButtonBack.Name = "whiteButtonBack";
            this.whiteButtonBack.Size = new System.Drawing.Size(183, 81);
            this.whiteButtonBack.TabIndex = 13;
            // 
            // maintenanceButton
            // 
            this.maintenanceButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.maintenanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maintenanceButton.Location = new System.Drawing.Point(12, 453);
            this.maintenanceButton.Name = "maintenanceButton";
            this.maintenanceButton.Size = new System.Drawing.Size(334, 294);
            this.maintenanceButton.TabIndex = 14;
            this.maintenanceButton.Text = "Maintenance Mode";
            this.maintenanceButton.UseVisualStyleBackColor = false;
            this.maintenanceButton.Click += new System.EventHandler(this.maintenanceButton_Click);
            // 
            // readyDispense
            // 
            this.readyDispense.BackColor = System.Drawing.SystemColors.GrayText;
            this.readyDispense.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyDispense.ForeColor = System.Drawing.SystemColors.Window;
            this.readyDispense.Location = new System.Drawing.Point(931, 209);
            this.readyDispense.Multiline = true;
            this.readyDispense.Name = "readyDispense";
            this.readyDispense.Size = new System.Drawing.Size(417, 238);
            this.readyDispense.TabIndex = 15;
            this.readyDispense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(931, 453);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 291);
            this.textBox1.TabIndex = 16;
            // 
            // port
            // 
            this.port.PortName = "COM5";
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialDataIn);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 191);
            this.button1.TabIndex = 17;
            this.button1.Text = "Start Arduino";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.startButton_Click);
            // 
            // portSelect
            // 
            this.portSelect.FormattingEnabled = true;
            this.portSelect.Location = new System.Drawing.Point(246, 209);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(110, 24);
            this.portSelect.TabIndex = 18;
            this.portSelect.SelectedIndexChanged += new System.EventHandler(this.portSelect_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(12, 209);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 41);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Select Port";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(183, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 191);
            this.button2.TabIndex = 20;
            this.button2.Text = "Close Arduino";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.closeArduino_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 751);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.portSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.readyDispense);
            this.Controls.Add(this.maintenanceButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.dispenseButton);
            this.Controls.Add(this.greenButtonBack);
            this.Controls.Add(this.redButtonBack);
            this.Controls.Add(this.orangeButtonBack);
            this.Controls.Add(this.blueButtonBack);
            this.Controls.Add(this.yellowButtonBack);
            this.Controls.Add(this.whiteButtonBack);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dispenseButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox greenButtonBack;
        private System.Windows.Forms.TextBox redButtonBack;
        private System.Windows.Forms.TextBox orangeButtonBack;
        private System.Windows.Forms.TextBox blueButtonBack;
        private System.Windows.Forms.TextBox yellowButtonBack;
        private System.Windows.Forms.TextBox whiteButtonBack;
        private System.Windows.Forms.Button maintenanceButton;
        private System.Windows.Forms.TextBox readyDispense;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox portSelect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}

