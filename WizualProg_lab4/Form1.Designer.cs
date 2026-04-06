namespace WizualProg_lab4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butn_rotate = new System.Windows.Forms.Button();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.buttonUpside = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.butn_load = new System.Windows.Forms.Button();
            this.radioButton90 = new System.Windows.Forms.RadioButton();
            this.radioButton180 = new System.Windows.Forms.RadioButton();
            this.radioButton270 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(259, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butn_rotate
            // 
            this.butn_rotate.Location = new System.Drawing.Point(26, 168);
            this.butn_rotate.Name = "butn_rotate";
            this.butn_rotate.Size = new System.Drawing.Size(197, 44);
            this.butn_rotate.TabIndex = 1;
            this.butn_rotate.Text = "Rotate";
            this.butn_rotate.UseVisualStyleBackColor = true;
            this.butn_rotate.Click += new System.EventHandler(this.butn_rotate_Click);
            // 
            // buttonInvert
            // 
            this.buttonInvert.Location = new System.Drawing.Point(26, 218);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(197, 44);
            this.buttonInvert.TabIndex = 2;
            this.buttonInvert.Text = "Invert Colors";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // buttonUpside
            // 
            this.buttonUpside.Location = new System.Drawing.Point(26, 268);
            this.buttonUpside.Name = "buttonUpside";
            this.buttonUpside.Size = new System.Drawing.Size(197, 44);
            this.buttonUpside.TabIndex = 3;
            this.buttonUpside.Text = "Upside Down";
            this.buttonUpside.UseVisualStyleBackColor = true;
            this.buttonUpside.Click += new System.EventHandler(this.buttonUpside_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // butn_load
            // 
            this.butn_load.Location = new System.Drawing.Point(26, 368);
            this.butn_load.Name = "butn_load";
            this.butn_load.Size = new System.Drawing.Size(197, 44);
            this.butn_load.TabIndex = 5;
            this.butn_load.Text = "Load";
            this.butn_load.UseVisualStyleBackColor = true;
            this.butn_load.Click += new System.EventHandler(this.butn_load_Click);
            // 
            // radioButton90
            // 
            this.radioButton90.AutoSize = true;
            this.radioButton90.Location = new System.Drawing.Point(26, 38);
            this.radioButton90.Name = "radioButton90";
            this.radioButton90.Size = new System.Drawing.Size(46, 20);
            this.radioButton90.TabIndex = 6;
            this.radioButton90.Text = "90°";
            this.radioButton90.UseVisualStyleBackColor = true;
            this.radioButton90.CheckedChanged += new System.EventHandler(this.radioButton90_CheckedChanged);
            // 
            // radioButton180
            // 
            this.radioButton180.AutoSize = true;
            this.radioButton180.Location = new System.Drawing.Point(26, 81);
            this.radioButton180.Name = "radioButton180";
            this.radioButton180.Size = new System.Drawing.Size(53, 20);
            this.radioButton180.TabIndex = 7;
            this.radioButton180.Text = "180°";
            this.radioButton180.UseVisualStyleBackColor = true;
            this.radioButton180.CheckedChanged += new System.EventHandler(this.radioButton180_CheckedChanged);
            // 
            // radioButton270
            // 
            this.radioButton270.AutoSize = true;
            this.radioButton270.Location = new System.Drawing.Point(26, 124);
            this.radioButton270.Name = "radioButton270";
            this.radioButton270.Size = new System.Drawing.Size(53, 20);
            this.radioButton270.TabIndex = 8;
            this.radioButton270.Text = "270°";
            this.radioButton270.UseVisualStyleBackColor = true;
            this.radioButton270.CheckedChanged += new System.EventHandler(this.radioButton270_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 439);
            this.Controls.Add(this.radioButton270);
            this.Controls.Add(this.radioButton180);
            this.Controls.Add(this.radioButton90);
            this.Controls.Add(this.butn_load);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonUpside);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.butn_rotate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butn_rotate;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Button buttonUpside;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button butn_load;
        private System.Windows.Forms.RadioButton radioButton90;
        private System.Windows.Forms.RadioButton radioButton180;
        private System.Windows.Forms.RadioButton radioButton270;
    }
}

