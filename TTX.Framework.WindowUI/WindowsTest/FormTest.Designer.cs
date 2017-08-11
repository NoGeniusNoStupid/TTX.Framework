namespace WindowsTest
{
    partial class FormTest
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
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.hjTextBox1 = new TX.Framework.WindowUI.Controls.HJTextBox.HJTextBox();
            this.SuspendLayout();
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(97, 61);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(100, 28);
            this.txButton1.TabIndex = 0;
            this.txButton1.Text = "txButton1";
            this.txButton1.UseVisualStyleBackColor = true;
            // 
            // hjTextBox1
            // 
            this.hjTextBox1.Location = new System.Drawing.Point(97, 128);
            this.hjTextBox1.Name = "hjTextBox1";
            this.hjTextBox1.Size = new System.Drawing.Size(100, 21);
            this.hjTextBox1.TabIndex = 1;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.hjTextBox1);
            this.Controls.Add(this.txButton1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXButton txButton1;
        private TX.Framework.WindowUI.Controls.HJTextBox.HJTextBox hjTextBox1;
    }
}