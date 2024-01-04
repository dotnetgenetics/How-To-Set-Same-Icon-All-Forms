namespace SetIconAllForms
{
    partial class FDemo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(237, 162);
            button1.Name = "button1";
            button1.Size = new Size(190, 50);
            button1.TabIndex = 0;
            button1.Text = "Second Form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 285);
            Controls.Add(button1);
            Name = "FDemo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "First Form";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
