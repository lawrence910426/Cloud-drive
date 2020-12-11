namespace LKM
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.charater = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.missle = new System.Windows.Forms.PictureBox();
            this.missle2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.charater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missle2)).BeginInit();
            this.SuspendLayout();
            // 
            // charater
            // 
            this.charater.Image = ((System.Drawing.Image)(resources.GetObject("charater.Image")));
            this.charater.Location = new System.Drawing.Point(64, 58);
            this.charater.Name = "charater";
            this.charater.Size = new System.Drawing.Size(132, 76);
            this.charater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.charater.TabIndex = 0;
            this.charater.TabStop = false;
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1364, 749);
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = ((System.Drawing.Image)(resources.GetObject("bullet.Image")));
            this.bullet.Location = new System.Drawing.Point(174, 191);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(100, 50);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bullet.TabIndex = 2;
            this.bullet.TabStop = false;
            this.bullet.Visible = false;
            // 
            // missle
            // 
            this.missle.Image = ((System.Drawing.Image)(resources.GetObject("missle.Image")));
            this.missle.Location = new System.Drawing.Point(27, 153);
            this.missle.Name = "missle";
            this.missle.Size = new System.Drawing.Size(100, 25);
            this.missle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.missle.TabIndex = 3;
            this.missle.TabStop = false;
            this.missle.Visible = false;
            // 
            // missle2
            // 
            this.missle2.Image = ((System.Drawing.Image)(resources.GetObject("missle2.Image")));
            this.missle2.Location = new System.Drawing.Point(27, 126);
            this.missle2.Name = "missle2";
            this.missle2.Size = new System.Drawing.Size(100, 25);
            this.missle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.missle2.TabIndex = 4;
            this.missle2.TabStop = false;
            this.missle2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.missle2);
            this.Controls.Add(this.missle);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.background);
            this.Controls.Add(this.charater);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missle2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox charater;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox missle;
        private System.Windows.Forms.PictureBox missle2;

    }
}

