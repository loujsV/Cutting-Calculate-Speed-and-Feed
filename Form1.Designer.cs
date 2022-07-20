
namespace Cutting_Calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_ToolDia = new System.Windows.Forms.TextBox();
            this.txt_NoofTeeth = new System.Windows.Forms.TextBox();
            this.txt_FeedperTooth = new System.Windows.Forms.TextBox();
            this.txt_CuttingFeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_NoofTeeth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_ToolDia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_SpindleSpeed = new System.Windows.Forms.TextBox();
            this.txt_CuttingSpeed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_CuttingFeed = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_SpindleSpeed = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_FeedRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ToolDia
            // 
            this.txt_ToolDia.BackColor = System.Drawing.Color.Sienna;
            this.txt_ToolDia.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ToolDia.ForeColor = System.Drawing.Color.White;
            this.txt_ToolDia.Location = new System.Drawing.Point(256, 46);
            this.txt_ToolDia.Name = "txt_ToolDia";
            this.txt_ToolDia.Size = new System.Drawing.Size(125, 35);
            this.txt_ToolDia.TabIndex = 0;
            this.txt_ToolDia.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // txt_NoofTeeth
            // 
            this.txt_NoofTeeth.BackColor = System.Drawing.Color.Sienna;
            this.txt_NoofTeeth.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoofTeeth.ForeColor = System.Drawing.Color.White;
            this.txt_NoofTeeth.Location = new System.Drawing.Point(701, 46);
            this.txt_NoofTeeth.Name = "txt_NoofTeeth";
            this.txt_NoofTeeth.Size = new System.Drawing.Size(125, 35);
            this.txt_NoofTeeth.TabIndex = 1;
            this.txt_NoofTeeth.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // txt_FeedperTooth
            // 
            this.txt_FeedperTooth.BackColor = System.Drawing.Color.Sienna;
            this.txt_FeedperTooth.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FeedperTooth.ForeColor = System.Drawing.Color.White;
            this.txt_FeedperTooth.Location = new System.Drawing.Point(41, 225);
            this.txt_FeedperTooth.Name = "txt_FeedperTooth";
            this.txt_FeedperTooth.Size = new System.Drawing.Size(125, 35);
            this.txt_FeedperTooth.TabIndex = 2;
            this.txt_FeedperTooth.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // txt_CuttingFeed
            // 
            this.txt_CuttingFeed.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuttingFeed.ForeColor = System.Drawing.Color.Black;
            this.txt_CuttingFeed.Location = new System.Drawing.Point(783, 225);
            this.txt_CuttingFeed.Name = "txt_CuttingFeed";
            this.txt_CuttingFeed.Size = new System.Drawing.Size(125, 35);
            this.txt_CuttingFeed.TabIndex = 3;
            this.txt_CuttingFeed.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tool Diameter (in)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of Teeth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Feed per tooth (IPT)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Teeth";
            // 
            // label_NoofTeeth
            // 
            this.label_NoofTeeth.AutoSize = true;
            this.label_NoofTeeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoofTeeth.Location = new System.Drawing.Point(430, 228);
            this.label_NoofTeeth.Name = "label_NoofTeeth";
            this.label_NoofTeeth.Size = new System.Drawing.Size(26, 29);
            this.label_NoofTeeth.TabIndex = 12;
            this.label_NoofTeeth.Text = "0";
            this.label_NoofTeeth.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(783, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cutting feed (IPR)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(783, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Spindle speed (RPM)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "/";
            // 
            // label_ToolDia
            // 
            this.label_ToolDia.AutoSize = true;
            this.label_ToolDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ToolDia.Location = new System.Drawing.Point(430, 364);
            this.label_ToolDia.Name = "label_ToolDia";
            this.label_ToolDia.Size = new System.Drawing.Size(110, 29);
            this.label_ToolDia.TabIndex = 19;
            this.label_ToolDia.Text = "0.500 × π";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(430, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tool diameter (in)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cutting speed (SFM)";
            // 
            // txt_SpindleSpeed
            // 
            this.txt_SpindleSpeed.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SpindleSpeed.ForeColor = System.Drawing.Color.Black;
            this.txt_SpindleSpeed.Location = new System.Drawing.Point(783, 361);
            this.txt_SpindleSpeed.Name = "txt_SpindleSpeed";
            this.txt_SpindleSpeed.Size = new System.Drawing.Size(125, 35);
            this.txt_SpindleSpeed.TabIndex = 16;
            this.txt_SpindleSpeed.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // txt_CuttingSpeed
            // 
            this.txt_CuttingSpeed.BackColor = System.Drawing.Color.Sienna;
            this.txt_CuttingSpeed.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuttingSpeed.ForeColor = System.Drawing.Color.White;
            this.txt_CuttingSpeed.Location = new System.Drawing.Point(41, 361);
            this.txt_CuttingSpeed.Name = "txt_CuttingSpeed";
            this.txt_CuttingSpeed.Size = new System.Drawing.Size(125, 35);
            this.txt_CuttingSpeed.TabIndex = 15;
            this.txt_CuttingSpeed.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(180, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 29);
            this.label13.TabIndex = 23;
            this.label13.Text = "x";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(202, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 29);
            this.label14.TabIndex = 22;
            this.label14.Text = "12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(714, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 29);
            this.label15.TabIndex = 24;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(714, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 29);
            this.label16.TabIndex = 25;
            this.label16.Text = "=";
            // 
            // label_CuttingFeed
            // 
            this.label_CuttingFeed.AutoSize = true;
            this.label_CuttingFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CuttingFeed.ForeColor = System.Drawing.Color.Black;
            this.label_CuttingFeed.Location = new System.Drawing.Point(41, 511);
            this.label_CuttingFeed.Name = "label_CuttingFeed";
            this.label_CuttingFeed.Size = new System.Drawing.Size(26, 29);
            this.label_CuttingFeed.TabIndex = 27;
            this.label_CuttingFeed.Text = "0";
            this.label_CuttingFeed.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(41, 476);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(203, 29);
            this.label18.TabIndex = 26;
            this.label18.Text = "Cutting feed (IPR)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(386, 511);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 29);
            this.label19.TabIndex = 30;
            this.label19.Text = "x";
            // 
            // label_SpindleSpeed
            // 
            this.label_SpindleSpeed.AutoSize = true;
            this.label_SpindleSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SpindleSpeed.ForeColor = System.Drawing.Color.Black;
            this.label_SpindleSpeed.Location = new System.Drawing.Point(430, 511);
            this.label_SpindleSpeed.Name = "label_SpindleSpeed";
            this.label_SpindleSpeed.Size = new System.Drawing.Size(26, 29);
            this.label_SpindleSpeed.TabIndex = 29;
            this.label_SpindleSpeed.Text = "0";
            this.label_SpindleSpeed.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(430, 476);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(245, 29);
            this.label21.TabIndex = 28;
            this.label21.Text = "Spindle speed (RPM)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(714, 511);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 29);
            this.label22.TabIndex = 33;
            this.label22.Text = "=";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(783, 476);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(181, 29);
            this.label23.TabIndex = 32;
            this.label23.Text = "Feed rate (IPM)";
            // 
            // txt_FeedRate
            // 
            this.txt_FeedRate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FeedRate.ForeColor = System.Drawing.Color.Black;
            this.txt_FeedRate.Location = new System.Drawing.Point(783, 508);
            this.txt_FeedRate.Name = "txt_FeedRate";
            this.txt_FeedRate.Size = new System.Drawing.Size(125, 35);
            this.txt_FeedRate.TabIndex = 31;
            this.txt_FeedRate.TextChanged += new System.EventHandler(this.Calculator);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(893, 701);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Product of SCPM 2022";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txt_FeedRate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label_SpindleSpeed);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label_CuttingFeed);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_ToolDia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_SpindleSpeed);
            this.Controls.Add(this.txt_CuttingSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_NoofTeeth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CuttingFeed);
            this.Controls.Add(this.txt_FeedperTooth);
            this.Controls.Add(this.txt_NoofTeeth);
            this.Controls.Add(this.txt_ToolDia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Milling Speed and Feed Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ToolDia;
        private System.Windows.Forms.TextBox txt_NoofTeeth;
        private System.Windows.Forms.TextBox txt_FeedperTooth;
        private System.Windows.Forms.TextBox txt_CuttingFeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_NoofTeeth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_ToolDia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_SpindleSpeed;
        private System.Windows.Forms.TextBox txt_CuttingSpeed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_CuttingFeed;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_SpindleSpeed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_FeedRate;
        private System.Windows.Forms.Label label6;
    }
}

