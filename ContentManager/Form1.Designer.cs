
namespace ContentManager
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
            this.leftPnl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPro = new System.Windows.Forms.Panel();
            this.lblPro = new System.Windows.Forms.Label();
            this.homePnl = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.leftPnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPro.SuspendLayout();
            this.homePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPnl
            // 
            this.leftPnl.Controls.Add(this.panel3);
            this.leftPnl.Controls.Add(this.panel2);
            this.leftPnl.Controls.Add(this.pnlPro);
            this.leftPnl.Controls.Add(this.homePnl);
            this.leftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPnl.Location = new System.Drawing.Point(0, 0);
            this.leftPnl.Name = "leftPnl";
            this.leftPnl.Size = new System.Drawing.Size(184, 1025);
            this.leftPnl.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(0, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 148);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ONE DAY", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(0, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 151);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ONE DAY", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "User List";
            // 
            // pnlPro
            // 
            this.pnlPro.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlPro.Controls.Add(this.lblPro);
            this.pnlPro.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPro.ForeColor = System.Drawing.SystemColors.Window;
            this.pnlPro.Location = new System.Drawing.Point(0, 135);
            this.pnlPro.Name = "pnlPro";
            this.pnlPro.Size = new System.Drawing.Size(184, 148);
            this.pnlPro.TabIndex = 1;
            this.pnlPro.Click += new System.EventHandler(this.pnlPro_Click);
            this.pnlPro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPro_Paint);
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Font = new System.Drawing.Font("ONE DAY", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPro.Location = new System.Drawing.Point(41, 66);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(101, 24);
            this.lblPro.TabIndex = 0;
            this.lblPro.Text = "Profile";
            // 
            // homePnl
            // 
            this.homePnl.BackColor = System.Drawing.Color.BlueViolet;
            this.homePnl.Controls.Add(this.lblHome);
            this.homePnl.Cursor = System.Windows.Forms.Cursors.Default;
            this.homePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePnl.ForeColor = System.Drawing.SystemColors.Window;
            this.homePnl.Location = new System.Drawing.Point(0, 0);
            this.homePnl.Name = "homePnl";
            this.homePnl.Size = new System.Drawing.Size(184, 135);
            this.homePnl.TabIndex = 0;
            this.homePnl.Click += new System.EventHandler(this.homePnl_Click);
            this.homePnl.Paint += new System.Windows.Forms.PaintEventHandler(this.homePnl_Paint);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("ONE DAY", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(54, 53);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(72, 24);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(184, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1034, 77);
            this.pnlTop.TabIndex = 2;
            // 
            // mainPnl
            // 
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPnl.Location = new System.Drawing.Point(184, 77);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(1034, 948);
            this.mainPnl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 1025);
            this.ControlBox = false;
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.leftPnl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.leftPnl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPro.ResumeLayout(false);
            this.pnlPro.PerformLayout();
            this.homePnl.ResumeLayout(false);
            this.homePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPnl;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Panel homePnl;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPro;
        private System.Windows.Forms.Label lblPro;
    }
}

