namespace VideoToGifConverter
{
    partial class MainForm
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
            this.selectVideoButton = new System.Windows.Forms.Button();
            this.inputVideoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputGifTextBox = new System.Windows.Forms.TextBox();
            this.selectOutputButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.fpsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // selectVideoButton
            // 
            this.selectVideoButton.Location = new System.Drawing.Point(31, 42);
            this.selectVideoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectVideoButton.Name = "selectVideoButton";
            this.selectVideoButton.Size = new System.Drawing.Size(161, 28);
            this.selectVideoButton.TabIndex = 0;
            this.selectVideoButton.Text = "Select Video";
            this.selectVideoButton.UseVisualStyleBackColor = true;
            this.selectVideoButton.Click += new System.EventHandler(this.selectVideoButton_Click);
            // 
            // inputVideoTextBox
            // 
            this.inputVideoTextBox.Location = new System.Drawing.Point(201, 42);
            this.inputVideoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputVideoTextBox.Name = "inputVideoTextBox";
            this.inputVideoTextBox.ReadOnly = true;
            this.inputVideoTextBox.Size = new System.Drawing.Size(327, 22);
            this.inputVideoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Video:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output GIF file:";
            // 
            // outputGifTextBox
            // 
            this.outputGifTextBox.Location = new System.Drawing.Point(201, 109);
            this.outputGifTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputGifTextBox.Name = "outputGifTextBox";
            this.outputGifTextBox.ReadOnly = true;
            this.outputGifTextBox.Size = new System.Drawing.Size(327, 22);
            this.outputGifTextBox.TabIndex = 4;
            // 
            // selectOutputButton
            // 
            this.selectOutputButton.Location = new System.Drawing.Point(31, 103);
            this.selectOutputButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectOutputButton.Name = "selectOutputButton";
            this.selectOutputButton.Size = new System.Drawing.Size(161, 28);
            this.selectOutputButton.TabIndex = 3;
            this.selectOutputButton.Text = "Select Output GIF";
            this.selectOutputButton.UseVisualStyleBackColor = true;
            this.selectOutputButton.Click += new System.EventHandler(this.selectOutputButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(201, 225);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(327, 28);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(32, 167);
            this.widthNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(74, 22);
            this.widthNumericUpDown.TabIndex = 8;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height:";
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(119, 167);
            this.heightNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(73, 22);
            this.heightNumericUpDown.TabIndex = 10;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "FPS:";
            // 
            // fpsNumericUpDown
            // 
            this.fpsNumericUpDown.Location = new System.Drawing.Point(31, 218);
            this.fpsNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fpsNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.fpsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fpsNumericUpDown.Name = "fpsNumericUpDown";
            this.fpsNumericUpDown.Size = new System.Drawing.Size(161, 22);
            this.fpsNumericUpDown.TabIndex = 12;
            this.fpsNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 16;
            this.logListBox.Location = new System.Drawing.Point(31, 261);
            this.logListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(497, 228);
            this.logListBox.TabIndex = 13;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(31, 497);
            this.clearLogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(497, 28);
            this.clearLogButton.TabIndex = 14;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "FPS:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 530);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.fpsNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heightNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.widthNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputGifTextBox);
            this.Controls.Add(this.selectOutputButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputVideoTextBox);
            this.Controls.Add(this.selectVideoButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "gifkon";
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectVideoButton;
        private System.Windows.Forms.TextBox inputVideoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputGifTextBox;
        private System.Windows.Forms.Button selectOutputButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown fpsNumericUpDown;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Label label6;
    }
}