
namespace ZeCode
{
    partial class barcodeonly
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Button1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlab = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.CheckedState.Parent = this.Button3;
            this.Button3.CustomImages.Parent = this.Button3;
            this.Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.Button3.HoverState.FillColor = System.Drawing.Color.Black;
            this.Button3.HoverState.Parent = this.Button3;
            this.Button3.Location = new System.Drawing.Point(470, 0);
            this.Button3.Name = "Button3";
            this.Button3.ShadowDecoration.Parent = this.Button3;
            this.Button3.Size = new System.Drawing.Size(130, 45);
            this.Button3.TabIndex = 34;
            this.Button3.Text = "CREATE BARCODE";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.CheckedState.Parent = this.Button1;
            this.Button1.CustomImages.Parent = this.Button1;
            this.Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(117)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.HoverState.Parent = this.Button1;
            this.Button1.Location = new System.Drawing.Point(550, 80);
            this.Button1.Name = "Button1";
            this.Button1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button1.ShadowDecoration.Parent = this.Button1;
            this.Button1.Size = new System.Drawing.Size(50, 50);
            this.Button1.TabIndex = 33;
            this.Button1.Text = "SAVE";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BorderColor = System.Drawing.Color.Black;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DefaultText = "";
            this.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.DisabledState.Parent = this.TextBox1;
            this.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.FocusedState.Parent = this.TextBox1;
            this.TextBox1.ForeColor = System.Drawing.Color.Black;
            this.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.HoverState.Parent = this.TextBox1;
            this.TextBox1.Location = new System.Drawing.Point(1, 1);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderText = "";
            this.TextBox1.SelectedText = "";
            this.TextBox1.ShadowDecoration.Parent = this.TextBox1;
            this.TextBox1.Size = new System.Drawing.Size(463, 129);
            this.TextBox1.TabIndex = 31;
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_qrcode.Location = new System.Drawing.Point(0, 136);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(597, 234);
            this.pic_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_qrcode.TabIndex = 32;
            this.pic_qrcode.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(43, 60);
            this.dataGridView1.TabIndex = 35;
            // 
            // idlab
            // 
            this.idlab.AutoSize = true;
            this.idlab.Location = new System.Drawing.Point(314, 19);
            this.idlab.Name = "idlab";
            this.idlab.Size = new System.Drawing.Size(35, 13);
            this.idlab.TabIndex = 36;
            this.idlab.Text = "label1";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.AutoSize = true;
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Location = new System.Drawing.Point(202, 53);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(24, 7);
            this.DateTimePicker1.TabIndex = 37;
            this.DateTimePicker1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barcodeonly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idlab);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.pic_qrcode);
            this.Name = "barcodeonly";
            this.Size = new System.Drawing.Size(600, 370);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Button3;
        private Guna.UI2.WinForms.Guna2CircleButton Button1;
        private System.Windows.Forms.PictureBox pic_qrcode;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label idlab;
        private System.Windows.Forms.Label DateTimePicker1;
        private System.Windows.Forms.Timer timer1;
    }
}
