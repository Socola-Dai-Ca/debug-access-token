namespace Debug_access_token
{
    partial class Main
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Destroy = new System.Windows.Forms.Button();
            this.Debug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(735, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "access_token";
            // 
            // Destroy
            // 
            this.Destroy.Location = new System.Drawing.Point(676, 69);
            this.Destroy.Name = "Destroy";
            this.Destroy.Size = new System.Drawing.Size(75, 30);
            this.Destroy.TabIndex = 2;
            this.Destroy.Text = "Destroy\r\n";
            this.Destroy.UseVisualStyleBackColor = true;
            this.Destroy.Click += new System.EventHandler(this.Destroy_Click);
            // 
            // Debug
            // 
            this.Debug.Location = new System.Drawing.Point(595, 69);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(75, 30);
            this.Debug.TabIndex = 3;
            this.Debug.Text = "Debug";
            this.Debug.UseVisualStyleBackColor = true;
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 109);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.Destroy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Debug access_token";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Destroy;
        private System.Windows.Forms.Button Debug;
    }
}

