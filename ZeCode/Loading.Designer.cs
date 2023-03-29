
namespace ZeCode
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shopname = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.IDAC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.k_Poter1 = new olivia_exambles.K_Poter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZeCode.Properties.Resources.Cute_Koala_with_Laptop_Cartoon_Logo_2_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "ZECODE";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Navy;
            this.progressBar1.Location = new System.Drawing.Point(-1, 302);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(582, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shopname
            // 
            this.shopname.AutoSize = true;
            this.shopname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.shopname.Location = new System.Drawing.Point(306, 9);
            this.shopname.Name = "shopname";
            this.shopname.Size = new System.Drawing.Size(0, 17);
            this.shopname.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // IDAC
            // 
            this.IDAC.AutoSize = true;
            this.IDAC.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDAC.Location = new System.Drawing.Point(80, 117);
            this.IDAC.Name = "IDAC";
            this.IDAC.Size = new System.Drawing.Size(20, 22);
            this.IDAC.TabIndex = 5;
            this.IDAC.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "This software was developed by : M.A.Mohamed Ali Razah";
            // 
            // k_Poter1
            // 
            this.k_Poter1.CornerRadius = 30;
            this.k_Poter1.TargetControl = this;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shopname);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IDAC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label shopname;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label IDAC;
        private System.Windows.Forms.Label label2;
        private olivia_exambles.K_Poter k_Poter1;
    }
}