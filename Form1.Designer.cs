namespace LSB_NguyenVanHai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToEncodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.encodeImage1 = new System.Windows.Forms.PictureBox();
            this.encodeImage2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encodeMessage = new System.Windows.Forms.TextBox();
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.decodeMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.decodeImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodeImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodeImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(655, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToEncodeToolStripMenuItem,
            this.openImageToDecodeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToEncodeToolStripMenuItem
            // 
            this.openImageToEncodeToolStripMenuItem.Name = "openImageToEncodeToolStripMenuItem";
            this.openImageToEncodeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openImageToEncodeToolStripMenuItem.Text = "Open Image To Encode";
            this.openImageToEncodeToolStripMenuItem.Click += new System.EventHandler(this.openImageToEncodeToolStripMenuItem_Click);
            // 
            // openImageToDecodeToolStripMenuItem
            // 
            this.openImageToDecodeToolStripMenuItem.Name = "openImageToDecodeToolStripMenuItem";
            this.openImageToDecodeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openImageToDecodeToolStripMenuItem.Text = "Open Image To Decode";
            this.openImageToDecodeToolStripMenuItem.Click += new System.EventHandler(this.openImageToDecodeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 451);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.encode);
            this.tabPage1.Controls.Add(this.encodeMessage);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.encodeImage2);
            this.tabPage1.Controls.Add(this.encodeImage1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.decodeImage);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.decodeMessage);
            this.tabPage2.Controls.Add(this.decode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // encodeImage1
            // 
            this.encodeImage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("encodeImage1.BackgroundImage")));
            this.encodeImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.encodeImage1.Location = new System.Drawing.Point(19, 43);
            this.encodeImage1.Name = "encodeImage1";
            this.encodeImage1.Size = new System.Drawing.Size(295, 317);
            this.encodeImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.encodeImage1.TabIndex = 0;
            this.encodeImage1.TabStop = false;
            // 
            // encodeImage2
            // 
            this.encodeImage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("encodeImage2.BackgroundImage")));
            this.encodeImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.encodeImage2.Location = new System.Drawing.Point(333, 43);
            this.encodeImage2.Name = "encodeImage2";
            this.encodeImage2.Size = new System.Drawing.Size(295, 317);
            this.encodeImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.encodeImage2.TabIndex = 1;
            this.encodeImage2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Before To Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "After To Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message To Hiding";
            // 
            // encodeMessage
            // 
            this.encodeMessage.Location = new System.Drawing.Point(156, 384);
            this.encodeMessage.Name = "encodeMessage";
            this.encodeMessage.Size = new System.Drawing.Size(359, 20);
            this.encodeMessage.TabIndex = 5;
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(532, 379);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(96, 32);
            this.encode.TabIndex = 6;
            this.encode.Text = "Encode";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decode
            // 
            this.decode.Location = new System.Drawing.Point(515, 378);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(96, 32);
            this.decode.TabIndex = 0;
            this.decode.Text = "Decode";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // decodeMessage
            // 
            this.decodeMessage.Location = new System.Drawing.Point(155, 384);
            this.decodeMessage.Name = "decodeMessage";
            this.decodeMessage.Size = new System.Drawing.Size(327, 20);
            this.decodeMessage.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Image To Decode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hidden Message";
            // 
            // decodeImage
            // 
            this.decodeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("decodeImage.BackgroundImage")));
            this.decodeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decodeImage.Location = new System.Drawing.Point(155, 45);
            this.decodeImage.Name = "decodeImage";
            this.decodeImage.Size = new System.Drawing.Size(327, 316);
            this.decodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.decodeImage.TabIndex = 4;
            this.decodeImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodeImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodeImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToEncodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToDecodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.TextBox encodeMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox encodeImage2;
        private System.Windows.Forms.PictureBox encodeImage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox decodeImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decodeMessage;
        private System.Windows.Forms.Button decode;
    }
}

