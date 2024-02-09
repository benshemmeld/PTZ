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
            this.btnPreset1 = new System.Windows.Forms.Button();
            this.btnPreset2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPreset4 = new System.Windows.Forms.Button();
            this.btnPreset5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPreset1
            // 
            this.btnPreset1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset1.Location = new System.Drawing.Point(13, 13);
            this.btnPreset1.Name = "btnPreset1";
            this.btnPreset1.Size = new System.Drawing.Size(447, 93);
            this.btnPreset1.TabIndex = 0;
            this.btnPreset1.Text = "Wide";
            this.btnPreset1.UseVisualStyleBackColor = true;
            this.btnPreset1.Click += new System.EventHandler(this.btnPreset1_Click);
            // 
            // btnPreset2
            // 
            this.btnPreset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset2.Location = new System.Drawing.Point(12, 112);
            this.btnPreset2.Name = "btnPreset2";
            this.btnPreset2.Size = new System.Drawing.Size(447, 93);
            this.btnPreset2.TabIndex = 1;
            this.btnPreset2.Text = "Centre Microphone";
            this.btnPreset2.UseVisualStyleBackColor = true;
            this.btnPreset2.Click += new System.EventHandler(this.btnPreset2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(447, 93);
            this.button3.TabIndex = 2;
            this.button3.Text = "Standing Microphone";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPreset4
            // 
            this.btnPreset4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset4.Location = new System.Drawing.Point(13, 310);
            this.btnPreset4.Name = "btnPreset4";
            this.btnPreset4.Size = new System.Drawing.Size(447, 93);
            this.btnPreset4.TabIndex = 3;
            this.btnPreset4.Text = "Table";
            this.btnPreset4.UseVisualStyleBackColor = true;
            this.btnPreset4.Click += new System.EventHandler(this.btnPreset4_Click);
            // 
            // btnPreset5
            // 
            this.btnPreset5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreset5.Location = new System.Drawing.Point(11, 409);
            this.btnPreset5.Name = "btnPreset5";
            this.btnPreset5.Size = new System.Drawing.Size(447, 93);
            this.btnPreset5.TabIndex = 4;
            this.btnPreset5.Text = "Centre && Standing Mic";
            this.btnPreset5.UseVisualStyleBackColor = true;
            this.btnPreset5.Click += new System.EventHandler(this.btnPreset5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 511);
            this.Controls.Add(this.btnPreset5);
            this.Controls.Add(this.btnPreset4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPreset2);
            this.Controls.Add(this.btnPreset1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PTZ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreset1;
        private System.Windows.Forms.Button btnPreset2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPreset4;
        private System.Windows.Forms.Button btnPreset5;
    }
}

