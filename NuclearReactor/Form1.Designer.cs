namespace NuclearReactor
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReactorWarningLabel1 = new System.Windows.Forms.Label();
            this.ReactorWarningLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleBackground = new System.Windows.Forms.Label();
            this.Engage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "TitleLabel";
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuclear Reactor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReactorWarningLabel1
            // 
            this.ReactorWarningLabel1.AccessibleName = "ReactorWarningLabel1";
            this.ReactorWarningLabel1.BackColor = System.Drawing.Color.Black;
            this.ReactorWarningLabel1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorWarningLabel1.Location = new System.Drawing.Point(177, 90);
            this.ReactorWarningLabel1.Name = "ReactorWarningLabel1";
            this.ReactorWarningLabel1.Size = new System.Drawing.Size(122, 115);
            this.ReactorWarningLabel1.TabIndex = 1;
            this.ReactorWarningLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReactorWarningLabel2
            // 
            this.ReactorWarningLabel2.AccessibleName = "ReactorWarningLabel2";
            this.ReactorWarningLabel2.BackColor = System.Drawing.Color.Black;
            this.ReactorWarningLabel2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorWarningLabel2.Location = new System.Drawing.Point(527, 90);
            this.ReactorWarningLabel2.Name = "ReactorWarningLabel2";
            this.ReactorWarningLabel2.Size = new System.Drawing.Size(119, 115);
            this.ReactorWarningLabel2.TabIndex = 2;
            this.ReactorWarningLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReactorWarningLabel2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleName = "ReactorLabel1";
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reactor 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AccessibleName = "ReactorLabel2";
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reactor 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TitleBackground
            // 
            this.TitleBackground.AccessibleName = "TitleBackground";
            this.TitleBackground.BackColor = System.Drawing.Color.White;
            this.TitleBackground.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBackground.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleBackground.Location = new System.Drawing.Point(250, 338);
            this.TitleBackground.Name = "TitleBackground";
            this.TitleBackground.Size = new System.Drawing.Size(303, 50);
            this.TitleBackground.TabIndex = 5;
            this.TitleBackground.Text = "Reactor Stable";
            this.TitleBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleBackground.Click += new System.EventHandler(this.label6_Click);
            // 
            // Engage
            // 
            this.Engage.AccessibleName = "startButton";
            this.Engage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engage.Location = new System.Drawing.Point(364, 391);
            this.Engage.Name = "Engage";
            this.Engage.Size = new System.Drawing.Size(75, 34);
            this.Engage.TabIndex = 6;
            this.Engage.Text = "Engage";
            this.Engage.UseVisualStyleBackColor = true;
            this.Engage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Engage);
            this.Controls.Add(this.TitleBackground);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReactorWarningLabel2);
            this.Controls.Add(this.ReactorWarningLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "springfeild nuclear";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReactorWarningLabel1;
        private System.Windows.Forms.Label ReactorWarningLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TitleBackground;
        private System.Windows.Forms.Button Engage;
    }
}

