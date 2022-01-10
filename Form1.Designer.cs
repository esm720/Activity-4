namespace Logic_Practice_CH4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.secOut = new System.Windows.Forms.Label();
            this.daysOut = new System.Windows.Forms.Label();
            this.minsOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hoursOut = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hoursOut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.secOut);
            this.groupBox1.Controls.Add(this.daysOut);
            this.groupBox1.Controls.Add(this.minsOut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.secIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seconds";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // secOut
            // 
            this.secOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secOut.Location = new System.Drawing.Point(235, 259);
            this.secOut.Name = "secOut";
            this.secOut.Size = new System.Drawing.Size(172, 32);
            this.secOut.TabIndex = 4;
            // 
            // daysOut
            // 
            this.daysOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysOut.Location = new System.Drawing.Point(235, 119);
            this.daysOut.Name = "daysOut";
            this.daysOut.Size = new System.Drawing.Size(172, 32);
            this.daysOut.TabIndex = 1;
            // 
            // minsOut
            // 
            this.minsOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minsOut.Location = new System.Drawing.Point(235, 215);
            this.minsOut.Name = "minsOut";
            this.minsOut.Size = new System.Drawing.Size(172, 32);
            this.minsOut.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seconds:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Days:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutes:";
            // 
            // secIn
            // 
            this.secIn.Location = new System.Drawing.Point(207, 57);
            this.secIn.Name = "secIn";
            this.secIn.Size = new System.Drawing.Size(200, 39);
            this.secIn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Seconds:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hours:";
            // 
            // hoursOut
            // 
            this.hoursOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOut.Location = new System.Drawing.Point(235, 165);
            this.hoursOut.Name = "hoursOut";
            this.hoursOut.Size = new System.Drawing.Size(172, 33);
            this.hoursOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(458, 479);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Converstions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label secOut;
        private Label daysOut;
        private Label minsOut;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox secIn;
        private Label label1;
        private Label hoursOut;
        private Label label5;
    }
}