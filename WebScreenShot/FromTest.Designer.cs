namespace WebScreenShot
{
    partial class FromTest
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
            this.tbnSaveWithAlx = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxResourceURL = new System.Windows.Forms.TextBox();
            this.tbxSavePath = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSaveWithFreezer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnSaveWithAlx
            // 
            this.tbnSaveWithAlx.Location = new System.Drawing.Point(12, 67);
            this.tbnSaveWithAlx.Name = "tbnSaveWithAlx";
            this.tbnSaveWithAlx.Size = new System.Drawing.Size(142, 59);
            this.tbnSaveWithAlx.TabIndex = 0;
            this.tbnSaveWithAlx.Text = "Save with ALX";
            this.tbnSaveWithAlx.UseVisualStyleBackColor = true;
            this.tbnSaveWithAlx.Click += new System.EventHandler(this.TbnSaveWithAlx_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 9);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(142, 20);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "RESOURCE URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SAVE PATH:";
            // 
            // tbxResourceURL
            // 
            this.tbxResourceURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResourceURL.Location = new System.Drawing.Point(160, 6);
            this.tbxResourceURL.Name = "tbxResourceURL";
            this.tbxResourceURL.Size = new System.Drawing.Size(636, 26);
            this.tbxResourceURL.TabIndex = 3;
            this.tbxResourceURL.Text = "https://www.python.org";
            // 
            // tbxSavePath
            // 
            this.tbxSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSavePath.Location = new System.Drawing.Point(160, 35);
            this.tbxSavePath.Name = "tbxSavePath";
            this.tbxSavePath.Size = new System.Drawing.Size(636, 26);
            this.tbxSavePath.TabIndex = 4;
            this.tbxSavePath.Text = "C:\\DATA\\DEV\\WebScreenShot\\WebScreenShot\\WebScreenShot\\bin\\Debug\\1.png";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 430);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(800, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "STATUS";
            // 
            // btnSaveWithFreezer
            // 
            this.btnSaveWithFreezer.Location = new System.Drawing.Point(160, 67);
            this.btnSaveWithFreezer.Name = "btnSaveWithFreezer";
            this.btnSaveWithFreezer.Size = new System.Drawing.Size(149, 59);
            this.btnSaveWithFreezer.TabIndex = 6;
            this.btnSaveWithFreezer.Text = "Save with Freezer";
            this.btnSaveWithFreezer.UseVisualStyleBackColor = true;
            this.btnSaveWithFreezer.Click += new System.EventHandler(this.BtnSaveWithFreezer_Click);
            // 
            // FromTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveWithFreezer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxSavePath);
            this.Controls.Add(this.tbxResourceURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.tbnSaveWithAlx);
            this.Name = "FromTest";
            this.Text = "Form Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbnSaveWithAlx;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxResourceURL;
        private System.Windows.Forms.TextBox tbxSavePath;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSaveWithFreezer;
    }
}

