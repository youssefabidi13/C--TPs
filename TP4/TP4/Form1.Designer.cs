namespace TP4
{
    partial class MyForm
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
            HelloButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // HelloButton
            // 
            HelloButton.BackColor = Color.PaleGreen;
            HelloButton.Location = new Point(277, 184);
            HelloButton.Name = "HelloButton";
            HelloButton.Size = new Size(160, 68);
            HelloButton.TabIndex = 0;
            HelloButton.Text = "HelloButton";
            HelloButton.UseVisualStyleBackColor = false;
            HelloButton.Click += HelloButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(250, 289);
            button1.Name = "button1";
            button1.Size = new Size(234, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(HelloButton);
            Cursor = Cursors.Hand;
            Name = "MyForm";
            Text = "Formulaire 01";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button HelloButton;
        private Button button1;
    }
}