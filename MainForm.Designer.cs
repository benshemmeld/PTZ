namespace PTZ
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnPreset1 = new System.Windows.Forms.Button();
            btnPreset2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            btnPreset4 = new System.Windows.Forms.Button();
            btnPreset5 = new System.Windows.Forms.Button();
            btnPreset6 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnPreset1
            // 
            btnPreset1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPreset1.Location = new System.Drawing.Point(14, 16);
            btnPreset1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPreset1.Name = "btnPreset1";
            btnPreset1.Size = new System.Drawing.Size(497, 116);
            btnPreset1.TabIndex = 0;
            btnPreset1.Text = "Wide";
            btnPreset1.UseVisualStyleBackColor = true;
            btnPreset1.Click += btnPreset1_Click;
            // 
            // btnPreset2
            // 
            btnPreset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPreset2.Location = new System.Drawing.Point(13, 140);
            btnPreset2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPreset2.Name = "btnPreset2";
            btnPreset2.Size = new System.Drawing.Size(497, 116);
            btnPreset2.TabIndex = 1;
            btnPreset2.Text = "Centre Microphone";
            btnPreset2.UseVisualStyleBackColor = true;
            btnPreset2.Click += btnPreset2_Click;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button3.Location = new System.Drawing.Point(14, 264);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(497, 116);
            button3.TabIndex = 2;
            button3.Text = "Standing Microphone";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnPreset4
            // 
            btnPreset4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPreset4.Location = new System.Drawing.Point(14, 388);
            btnPreset4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPreset4.Name = "btnPreset4";
            btnPreset4.Size = new System.Drawing.Size(497, 116);
            btnPreset4.TabIndex = 3;
            btnPreset4.Text = "Table";
            btnPreset4.UseVisualStyleBackColor = true;
            btnPreset4.Click += btnPreset4_Click;
            // 
            // btnPreset5
            // 
            btnPreset5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPreset5.Location = new System.Drawing.Point(12, 511);
            btnPreset5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPreset5.Name = "btnPreset5";
            btnPreset5.Size = new System.Drawing.Size(497, 116);
            btnPreset5.TabIndex = 4;
            btnPreset5.Text = "Centre && Standing Mic";
            btnPreset5.UseVisualStyleBackColor = true;
            btnPreset5.Click += btnPreset5_Click;
            // 
            // btnPreset6
            // 
            btnPreset6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPreset6.Location = new System.Drawing.Point(12, 635);
            btnPreset6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPreset6.Name = "btnPreset6";
            btnPreset6.Size = new System.Drawing.Size(497, 116);
            btnPreset6.TabIndex = 5;
            btnPreset6.Text = "Centre && Table";
            btnPreset6.UseVisualStyleBackColor = true;
            btnPreset6.Click += btnPreset6_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(522, 763);
            Controls.Add(btnPreset6);
            Controls.Add(btnPreset5);
            Controls.Add(btnPreset4);
            Controls.Add(button3);
            Controls.Add(btnPreset2);
            Controls.Add(btnPreset1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "PTZ";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnPreset1;
        private System.Windows.Forms.Button btnPreset2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPreset4;
        private System.Windows.Forms.Button btnPreset5;
        private System.Windows.Forms.Button btnPreset6;
    }
}

