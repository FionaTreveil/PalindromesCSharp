namespace WindowsFormsApplication1
{
    partial class Palindromes
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPalindrome1 = new System.Windows.Forms.Label();
            this.lblPalindrome2 = new System.Windows.Forms.Label();
            this.lblPalindrome3 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(27, 51);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(368, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find the longest 3 palindromes from: ";
            // 
            // lblPalindrome1
            // 
            this.lblPalindrome1.AutoSize = true;
            this.lblPalindrome1.Location = new System.Drawing.Point(25, 147);
            this.lblPalindrome1.Name = "lblPalindrome1";
            this.lblPalindrome1.Size = new System.Drawing.Size(0, 13);
            this.lblPalindrome1.TabIndex = 2;
            // 
            // lblPalindrome2
            // 
            this.lblPalindrome2.AutoSize = true;
            this.lblPalindrome2.Location = new System.Drawing.Point(25, 175);
            this.lblPalindrome2.Name = "lblPalindrome2";
            this.lblPalindrome2.Size = new System.Drawing.Size(0, 13);
            this.lblPalindrome2.TabIndex = 3;
            // 
            // lblPalindrome3
            // 
            this.lblPalindrome3.AutoSize = true;
            this.lblPalindrome3.Location = new System.Drawing.Point(25, 207);
            this.lblPalindrome3.Name = "lblPalindrome3";
            this.lblPalindrome3.Size = new System.Drawing.Size(0, 13);
            this.lblPalindrome3.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(85, 88);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(212, 27);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find Palindromes";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(32, 122);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(30, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Palindromes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 438);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblPalindrome3);
            this.Controls.Add(this.lblPalindrome2);
            this.Controls.Add(this.lblPalindrome1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "Palindromes";
            this.Text = "Palindromes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPalindrome1;
        private System.Windows.Forms.Label lblPalindrome2;
        private System.Windows.Forms.Label lblPalindrome3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnExit;
    }
}

