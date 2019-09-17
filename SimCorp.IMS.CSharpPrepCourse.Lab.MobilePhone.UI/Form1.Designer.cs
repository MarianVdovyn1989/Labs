namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone.UI
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
            this.bApply = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.rbIPhoneHeadset = new System.Windows.Forms.RadioButton();
            this.rbPhoneSpeaker = new System.Windows.Forms.RadioButton();
            this.rbSamsungHeadset = new System.Windows.Forms.RadioButton();
            this.rbUnofficialHeadset = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(275, 130);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 159);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(338, 170);
            this.tbOutput.TabIndex = 3;
            this.tbOutput.TextChanged += new System.EventHandler(this.tbOutput_TextChanged);
            // 
            // rbIPhoneHeadset
            // 
            this.rbIPhoneHeadset.AutoSize = true;
            this.rbIPhoneHeadset.Location = new System.Drawing.Point(12, 57);
            this.rbIPhoneHeadset.Name = "rbIPhoneHeadset";
            this.rbIPhoneHeadset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbIPhoneHeadset.Size = new System.Drawing.Size(99, 17);
            this.rbIPhoneHeadset.TabIndex = 4;
            this.rbIPhoneHeadset.TabStop = true;
            this.rbIPhoneHeadset.Text = "IPhoneHeadset";
            this.rbIPhoneHeadset.UseVisualStyleBackColor = true;
            // 
            // rbPhoneSpeaker
            // 
            this.rbPhoneSpeaker.AutoSize = true;
            this.rbPhoneSpeaker.Location = new System.Drawing.Point(12, 80);
            this.rbPhoneSpeaker.Name = "rbPhoneSpeaker";
            this.rbPhoneSpeaker.Size = new System.Drawing.Size(96, 17);
            this.rbPhoneSpeaker.TabIndex = 5;
            this.rbPhoneSpeaker.TabStop = true;
            this.rbPhoneSpeaker.Text = "PhoneSpeaker";
            this.rbPhoneSpeaker.UseVisualStyleBackColor = true;
            // 
            // rbSamsungHeadset
            // 
            this.rbSamsungHeadset.AutoSize = true;
            this.rbSamsungHeadset.Location = new System.Drawing.Point(12, 103);
            this.rbSamsungHeadset.Name = "rbSamsungHeadset";
            this.rbSamsungHeadset.Size = new System.Drawing.Size(109, 17);
            this.rbSamsungHeadset.TabIndex = 6;
            this.rbSamsungHeadset.TabStop = true;
            this.rbSamsungHeadset.Text = "SamsungHeadset";
            this.rbSamsungHeadset.UseVisualStyleBackColor = true;
            // 
            // rbUnofficialHeadset
            // 
            this.rbUnofficialHeadset.AutoSize = true;
            this.rbUnofficialHeadset.Location = new System.Drawing.Point(12, 127);
            this.rbUnofficialHeadset.Name = "rbUnofficialHeadset";
            this.rbUnofficialHeadset.Size = new System.Drawing.Size(109, 17);
            this.rbUnofficialHeadset.TabIndex = 7;
            this.rbUnofficialHeadset.TabStop = true;
            this.rbUnofficialHeadset.Text = "UnofficialHeadset";
            this.rbUnofficialHeadset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(362, 341);
            this.Controls.Add(this.rbUnofficialHeadset);
            this.Controls.Add(this.rbSamsungHeadset);
            this.Controls.Add(this.rbPhoneSpeaker);
            this.Controls.Add(this.rbIPhoneHeadset);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.bApply);
            this.Name = "Form1";
            this.Text = "WinForm Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.RadioButton rbIPhoneHeadset;
        private System.Windows.Forms.RadioButton rbPhoneSpeaker;
        private System.Windows.Forms.RadioButton rbSamsungHeadset;
        private System.Windows.Forms.RadioButton rbUnofficialHeadset;
    }
}

