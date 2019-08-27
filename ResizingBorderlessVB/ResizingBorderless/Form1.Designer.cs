namespace ResizingBorderless
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.GunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.GunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.GunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.GunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaResize1
            // 
            this.GunaResize1.TargetForm = this;
            // 
            // GunaDragControl1
            // 
            this.GunaDragControl1.TargetControl = this;
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("GunaPictureBox1.Image")));
            this.GunaPictureBox1.Location = new System.Drawing.Point(120, 106);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GunaPictureBox1.TabIndex = 7;
            this.GunaPictureBox1.TabStop = false;
            // 
            // GunaControlBox3
            // 
            this.GunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaControlBox3.Animated = true;
            this.GunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.GunaControlBox3.AnimationSpeed = 0.03F;
            this.GunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.GunaControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(85)))), ((int)(((byte)(244)))));
            this.GunaControlBox3.IconSize = 12F;
            this.GunaControlBox3.Location = new System.Drawing.Point(255, 4);
            this.GunaControlBox3.Name = "GunaControlBox3";
            this.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.GunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.GunaControlBox3.Size = new System.Drawing.Size(30, 30);
            this.GunaControlBox3.TabIndex = 6;
            // 
            // GunaControlBox2
            // 
            this.GunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaControlBox2.Animated = true;
            this.GunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.GunaControlBox2.AnimationSpeed = 0.03F;
            this.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.GunaControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(85)))), ((int)(((byte)(244)))));
            this.GunaControlBox2.IconSize = 12F;
            this.GunaControlBox2.Location = new System.Drawing.Point(291, 4);
            this.GunaControlBox2.Name = "GunaControlBox2";
            this.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.GunaControlBox2.Size = new System.Drawing.Size(30, 30);
            this.GunaControlBox2.TabIndex = 5;
            // 
            // GunaControlBox1
            // 
            this.GunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaControlBox1.Animated = true;
            this.GunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.GunaControlBox1.AnimationSpeed = 0.03F;
            this.GunaControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(85)))), ((int)(((byte)(244)))));
            this.GunaControlBox1.IconSize = 12F;
            this.GunaControlBox1.Location = new System.Drawing.Point(327, 4);
            this.GunaControlBox1.Name = "GunaControlBox1";
            this.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.GunaControlBox1.Size = new System.Drawing.Size(30, 30);
            this.GunaControlBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(360, 329);
            this.Controls.Add(this.GunaPictureBox1);
            this.Controls.Add(this.GunaControlBox3);
            this.Controls.Add(this.GunaControlBox2);
            this.Controls.Add(this.GunaControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI.WinForms.GunaResize GunaResize1;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
        internal Guna.UI.WinForms.GunaControlBox GunaControlBox3;
        internal Guna.UI.WinForms.GunaControlBox GunaControlBox2;
        internal Guna.UI.WinForms.GunaControlBox GunaControlBox1;
        internal Guna.UI.WinForms.GunaDragControl GunaDragControl1;
    }
}

