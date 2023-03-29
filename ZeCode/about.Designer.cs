
namespace ZeCode
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Button1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(406, 368);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Black;
            this.Button1.CheckedState.Parent = this.Button1;
            this.Button1.CustomImages.Parent = this.Button1;
            this.Button1.FillColor = System.Drawing.Color.Red;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.HoverState.Parent = this.Button1;
            this.Button1.Location = new System.Drawing.Point(373, 3);
            this.Button1.Name = "Button1";
            this.Button1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button1.ShadowDecoration.Parent = this.Button1;
            this.Button1.Size = new System.Drawing.Size(30, 30);
            this.Button1.TabIndex = 1;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 364);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About_Me";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2CircleButton Button1;
    }
}