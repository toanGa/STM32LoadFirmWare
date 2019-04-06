namespace STM32LoadCode
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
            this.textBoxHexPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBaudrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadCode = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonConnectCOM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHexPath
            // 
            this.textBoxHexPath.Location = new System.Drawing.Point(24, 39);
            this.textBoxHexPath.Name = "textBoxHexPath";
            this.textBoxHexPath.Size = new System.Drawing.Size(459, 20);
            this.textBoxHexPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HEX file";
            // 
            // textBoxBaudrate
            // 
            this.textBoxBaudrate.Location = new System.Drawing.Point(87, 8);
            this.textBoxBaudrate.Name = "textBoxBaudrate";
            this.textBoxBaudrate.Size = new System.Drawing.Size(82, 20);
            this.textBoxBaudrate.TabIndex = 1;
            this.textBoxBaudrate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // buttonLoadCode
            // 
            this.buttonLoadCode.Location = new System.Drawing.Point(24, 228);
            this.buttonLoadCode.Name = "buttonLoadCode";
            this.buttonLoadCode.Size = new System.Drawing.Size(459, 59);
            this.buttonLoadCode.TabIndex = 4;
            this.buttonLoadCode.Text = "Load HEX file to STM32";
            this.buttonLoadCode.UseVisualStyleBackColor = true;
            this.buttonLoadCode.Click += new System.EventHandler(this.buttonLoadCode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConnectCOM);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxBaudrate);
            this.panel1.Location = new System.Drawing.Point(24, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 105);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "COM";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // buttonConnectCOM
            // 
            this.buttonConnectCOM.Location = new System.Drawing.Point(26, 67);
            this.buttonConnectCOM.Name = "buttonConnectCOM";
            this.buttonConnectCOM.Size = new System.Drawing.Size(143, 30);
            this.buttonConnectCOM.TabIndex = 7;
            this.buttonConnectCOM.Text = "Connect";
            this.buttonConnectCOM.UseVisualStyleBackColor = true;
            this.buttonConnectCOM.Click += new System.EventHandler(this.buttonConnectCOM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLoadCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHexPath);
            this.Name = "Form1";
            this.Text = "Mr. Dai Du";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHexPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadCode;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConnectCOM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

