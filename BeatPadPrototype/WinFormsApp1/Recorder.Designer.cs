namespace WinFormsApp1
{
    partial class Recorder
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
            recordButton = new Button();
            label1 = new Label();
            devices = new ComboBox();
            deviceLabel = new Label();
            SuspendLayout();
            // 
            // recordButton
            // 
            recordButton.Location = new Point(74, 110);
            recordButton.Name = "recordButton";
            recordButton.Size = new Size(75, 23);
            recordButton.TabIndex = 0;
            recordButton.Text = "Record";
            recordButton.UseVisualStyleBackColor = true;
            recordButton.Click += recordButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 92);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "00:00:00";
            // 
            // devices
            // 
            devices.FormattingEnabled = true;
            devices.Location = new Point(35, 52);
            devices.Name = "devices";
            devices.Size = new Size(162, 23);
            devices.TabIndex = 2;
            // 
            // deviceLabel
            // 
            deviceLabel.AutoSize = true;
            deviceLabel.Location = new Point(71, 34);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new Size(84, 15);
            deviceLabel.TabIndex = 3;
            deviceLabel.Text = "Select a device";
            // 
            // Recorder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 184);
            Controls.Add(deviceLabel);
            Controls.Add(devices);
            Controls.Add(label1);
            Controls.Add(recordButton);
            Name = "Recorder";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button recordButton;
        private Label label1;
        private ComboBox devices;
        private Label deviceLabel;
    }
}