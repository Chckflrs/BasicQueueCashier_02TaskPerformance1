namespace BasicQueueCashier
{
    partial class ServingForm
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
            label1 = new Label();
            ServingNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 0;
            label1.Text = "* NOW SERVING";
            // 
            // ServingNumber
            // 
            ServingNumber.AutoSize = true;
            ServingNumber.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ServingNumber.Location = new Point(163, 180);
            ServingNumber.Margin = new Padding(4, 0, 4, 0);
            ServingNumber.Name = "ServingNumber";
            ServingNumber.Size = new Size(0, 34);
            ServingNumber.TabIndex = 1;
            ServingNumber.Click += ServingNumber_Click;
            // 
            // ServingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 280);
            Controls.Add(ServingNumber);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ServingForm";
            Text = "ServingForm";
            Load += ServingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ServingNumber;
    }
}