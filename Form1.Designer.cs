namespace ArduinoLED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGreenLigar = new System.Windows.Forms.Button();
            this.btnGreenDesligar = new System.Windows.Forms.Button();
            this.btnRedLigar = new System.Windows.Forms.Button();
            this.btnRedDesligar = new System.Windows.Forms.Button();
            this.btnBlueLigar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBlueDesligar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Arduino LED";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Acender LED";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // btnGreenLigar
            // 
            this.btnGreenLigar.Location = new System.Drawing.Point(41, 200);
            this.btnGreenLigar.Name = "btnGreenLigar";
            this.btnGreenLigar.Size = new System.Drawing.Size(75, 23);
            this.btnGreenLigar.TabIndex = 0;
            this.btnGreenLigar.Text = "Green ON";
            this.btnGreenLigar.UseVisualStyleBackColor = true;
            this.btnGreenLigar.Click += new System.EventHandler(this.btnGreenLigar_Click);
            // 
            // btnGreenDesligar
            // 
            this.btnGreenDesligar.Location = new System.Drawing.Point(41, 243);
            this.btnGreenDesligar.Name = "btnGreenDesligar";
            this.btnGreenDesligar.Size = new System.Drawing.Size(75, 23);
            this.btnGreenDesligar.TabIndex = 1;
            this.btnGreenDesligar.Text = "Green OFF";
            this.btnGreenDesligar.UseVisualStyleBackColor = true;
            this.btnGreenDesligar.Click += new System.EventHandler(this.btnGreenDesligar_Click);
            // 
            // btnRedLigar
            // 
            this.btnRedLigar.Location = new System.Drawing.Point(159, 200);
            this.btnRedLigar.Name = "btnRedLigar";
            this.btnRedLigar.Size = new System.Drawing.Size(75, 23);
            this.btnRedLigar.TabIndex = 2;
            this.btnRedLigar.Text = "Red ON";
            this.btnRedLigar.UseVisualStyleBackColor = true;
            this.btnRedLigar.Click += new System.EventHandler(this.btnRedLigar_Click);
            // 
            // btnRedDesligar
            // 
            this.btnRedDesligar.Location = new System.Drawing.Point(159, 243);
            this.btnRedDesligar.Name = "btnRedDesligar";
            this.btnRedDesligar.Size = new System.Drawing.Size(75, 23);
            this.btnRedDesligar.TabIndex = 2;
            this.btnRedDesligar.Text = "Red OFF";
            this.btnRedDesligar.UseVisualStyleBackColor = true;
            this.btnRedDesligar.Click += new System.EventHandler(this.btnRedDesligar_Click);
            // 
            // btnBlueLigar
            // 
            this.btnBlueLigar.Location = new System.Drawing.Point(276, 200);
            this.btnBlueLigar.Name = "btnBlueLigar";
            this.btnBlueLigar.Size = new System.Drawing.Size(75, 23);
            this.btnBlueLigar.TabIndex = 2;
            this.btnBlueLigar.Text = "Blue ON";
            this.btnBlueLigar.UseVisualStyleBackColor = true;
            this.btnBlueLigar.Click += new System.EventHandler(this.btnBlueLigar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arduino LED";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBlueDesligar
            // 
            this.btnBlueDesligar.Location = new System.Drawing.Point(276, 243);
            this.btnBlueDesligar.Name = "btnBlueDesligar";
            this.btnBlueDesligar.Size = new System.Drawing.Size(75, 23);
            this.btnBlueDesligar.TabIndex = 2;
            this.btnBlueDesligar.Text = "Blue OFF";
            this.btnBlueDesligar.UseVisualStyleBackColor = true;
            this.btnBlueDesligar.Click += new System.EventHandler(this.btnBlueDesligar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(436, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBlueDesligar);
            this.Controls.Add(this.btnBlueLigar);
            this.Controls.Add(this.btnRedDesligar);
            this.Controls.Add(this.btnRedLigar);
            this.Controls.Add(this.btnGreenDesligar);
            this.Controls.Add(this.btnGreenLigar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button btnGreenLigar;
        private Button btnGreenDesligar;
        private Button btnRedLigar;
        private Button btnRedDesligar;
        private Button btnBlueLigar;
        private Label label1;
        private Button btnBlueDesligar;
    }
}