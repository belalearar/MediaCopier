
namespace MediaCopier
{
    partial class Form1
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
            this.fromPath = new System.Windows.Forms.TextBox();
            this.toPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromButton = new System.Windows.Forms.Button();
            this.toButton = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.currentFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.lable33 = new System.Windows.Forms.Label();
            this.copied = new System.Windows.Forms.TextBox();
            this.clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromPath
            // 
            this.fromPath.Location = new System.Drawing.Point(109, 45);
            this.fromPath.Name = "fromPath";
            this.fromPath.Size = new System.Drawing.Size(479, 27);
            this.fromPath.TabIndex = 0;
            // 
            // toPath
            // 
            this.toPath.Location = new System.Drawing.Point(109, 79);
            this.toPath.Name = "toPath";
            this.toPath.Size = new System.Drawing.Size(479, 27);
            this.toPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // fromButton
            // 
            this.fromButton.Location = new System.Drawing.Point(628, 45);
            this.fromButton.Name = "fromButton";
            this.fromButton.Size = new System.Drawing.Size(94, 29);
            this.fromButton.TabIndex = 4;
            this.fromButton.Text = "Brows";
            this.fromButton.UseVisualStyleBackColor = true;
            this.fromButton.Click += new System.EventHandler(this.fromButton_Click);
            // 
            // toButton
            // 
            this.toButton.Location = new System.Drawing.Point(628, 76);
            this.toButton.Name = "toButton";
            this.toButton.Size = new System.Drawing.Size(94, 29);
            this.toButton.TabIndex = 5;
            this.toButton.Text = "Brows";
            this.toButton.UseVisualStyleBackColor = true;
            this.toButton.Click += new System.EventHandler(this.toButton_Click);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(302, 112);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(121, 41);
            this.copy.TabIndex = 6;
            this.copy.Text = "Sync Now";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // currentFile
            // 
            this.currentFile.AutoSize = true;
            this.currentFile.Location = new System.Drawing.Point(445, 122);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(0, 20);
            this.currentFile.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Logs";
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(109, 160);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(613, 120);
            this.logs.TabIndex = 10;
            this.logs.Text = "";
            // 
            // lable33
            // 
            this.lable33.AutoSize = true;
            this.lable33.Location = new System.Drawing.Point(33, 298);
            this.lable33.Name = "lable33";
            this.lable33.Size = new System.Drawing.Size(57, 20);
            this.lable33.TabIndex = 11;
            this.lable33.Text = "Copied";
            // 
            // copied
            // 
            this.copied.Enabled = false;
            this.copied.Location = new System.Drawing.Point(109, 298);
            this.copied.Name = "copied";
            this.copied.Size = new System.Drawing.Size(60, 27);
            this.copied.TabIndex = 12;
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(628, 160);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(94, 29);
            this.clean.TabIndex = 13;
            this.clean.Text = "Clean Logs";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 347);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.copied);
            this.Controls.Add(this.lable33);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentFile);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.toButton);
            this.Controls.Add(this.fromButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toPath);
            this.Controls.Add(this.fromPath);
            this.Name = "Form1";
            this.Text = "File Copier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromPath;
        private System.Windows.Forms.TextBox toPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fromButton;
        private System.Windows.Forms.Button toButton;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Label currentFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Label lable33;
        private System.Windows.Forms.TextBox copied;
        private System.Windows.Forms.Button clean;
    }
}

