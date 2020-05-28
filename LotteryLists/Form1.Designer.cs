namespace LotteryLists
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(187)))));
            this.titleLabel.Location = new System.Drawing.Point(-5, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(626, 69);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Lottery Picker w/ Lists!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(125, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press the button below to generate your numbers!";
            // 
            // numButton
            // 
            this.numButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(187)))));
            this.numButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.numButton.Location = new System.Drawing.Point(264, 216);
            this.numButton.Name = "numButton";
            this.numButton.Size = new System.Drawing.Size(107, 35);
            this.numButton.TabIndex = 2;
            this.numButton.Text = "Generate!";
            this.numButton.UseVisualStyleBackColor = false;
            this.numButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(187)))));
            this.outputLabel.Location = new System.Drawing.Point(124, 272);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(371, 42);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(181, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "How many numbers would you like?";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(264, 122);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(107, 20);
            this.inputBox.TabIndex = 5;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(618, 332);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.numButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button numButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBox;
    }
}

