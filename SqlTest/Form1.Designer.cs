namespace SqlTest
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
            this.sqlText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.selectwrite = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sqlText
            // 
            this.sqlText.Location = new System.Drawing.Point(117, 129);
            this.sqlText.Name = "sqlText";
            this.sqlText.Size = new System.Drawing.Size(557, 22);
            this.sqlText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SQL TESTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectwrite
            // 
            this.selectwrite.FormattingEnabled = true;
            this.selectwrite.ItemHeight = 16;
            this.selectwrite.Location = new System.Drawing.Point(117, 257);
            this.selectwrite.Name = "selectwrite";
            this.selectwrite.Size = new System.Drawing.Size(557, 148);
            this.selectwrite.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SqlTest.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectwrite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sqlText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqlText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox selectwrite;
    }
}

