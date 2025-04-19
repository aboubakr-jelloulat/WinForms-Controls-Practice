namespace WindowsForms_1
{
    partial class FrmMain
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
            this.btnShowPart1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMessgeBoxForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPart1
            // 
            this.btnShowPart1.Location = new System.Drawing.Point(58, 111);
            this.btnShowPart1.Name = "btnShowPart1";
            this.btnShowPart1.Size = new System.Drawing.Size(131, 61);
            this.btnShowPart1.TabIndex = 0;
            this.btnShowPart1.Text = "Show Form";
            this.btnShowPart1.UseVisualStyleBackColor = true;
            this.btnShowPart1.Click += new System.EventHandler(this.btnShowPart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Form as dialogue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMessgeBoxForm
            // 
            this.btnMessgeBoxForm.Location = new System.Drawing.Point(403, 120);
            this.btnMessgeBoxForm.Name = "btnMessgeBoxForm";
            this.btnMessgeBoxForm.Size = new System.Drawing.Size(131, 61);
            this.btnMessgeBoxForm.TabIndex = 2;
            this.btnMessgeBoxForm.Text = "Show Message Text box";
            this.btnMessgeBoxForm.UseVisualStyleBackColor = true;
            this.btnMessgeBoxForm.Click += new System.EventHandler(this.btnMessgeBoxForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "CheckBox/Radio/Group";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMessgeBoxForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowPart1);
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMessgeBoxForm;
        private System.Windows.Forms.Button button2;
    }
}