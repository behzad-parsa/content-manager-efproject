
namespace ContentManager
{
    partial class UserList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSub = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.pnlUserlist = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblSub);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.lblBirth);
            this.panel1.Controls.Add(this.lblBirthday);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblLast);
            this.panel1.Controls.Add(this.lblFirst);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtLast);
            this.panel1.Controls.Add(this.txtFirst);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 928);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSub
            // 
            this.lblSub.BackColor = System.Drawing.Color.Tomato;
            this.lblSub.FlatAppearance.BorderSize = 0;
            this.lblSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSub.Font = new System.Drawing.Font("Metropolis Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.MintCream;
            this.lblSub.Location = new System.Drawing.Point(41, 680);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(198, 61);
            this.lblSub.TabIndex = 5;
            this.lblSub.Text = "Submit";
            this.lblSub.UseVisualStyleBackColor = false;
            this.lblSub.Click += new System.EventHandler(this.lblSub_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 388);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.lblBirth.Location = new System.Drawing.Point(102, 340);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBirth.Size = new System.Drawing.Size(104, 40);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "BirthDay";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(3, 604);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(58, 25);
            this.lblBirthday.TabIndex = 4;
            this.lblBirthday.Text = "Choose";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.label1.Location = new System.Drawing.Point(45, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Role";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.lblPass.Location = new System.Drawing.Point(45, 231);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(62, 40);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Pass";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.lblUser.Location = new System.Drawing.Point(18, 172);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(116, 40);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.lblLast.Location = new System.Drawing.Point(21, 109);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(112, 40);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Lastname";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(21, 54);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(115, 40);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "Firstname";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(139, 241);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(139, 22);
            this.txtPass.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(139, 182);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(139, 119);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(139, 22);
            this.txtLast.TabIndex = 1;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(139, 64);
            this.txtFirst.Multiline = true;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(139, 22);
            this.txtFirst.TabIndex = 0;
            // 
            // pnlUserlist
            // 
            this.pnlUserlist.AutoScroll = true;
            this.pnlUserlist.BackColor = System.Drawing.Color.White;
            this.pnlUserlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserlist.Location = new System.Drawing.Point(287, 0);
            this.pnlUserlist.Name = "pnlUserlist";
            this.pnlUserlist.Size = new System.Drawing.Size(747, 928);
            this.pnlUserlist.TabIndex = 1;
            this.pnlUserlist.Leave += new System.EventHandler(this.pnlUserlist_Leave);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUserlist);
            this.Controls.Add(this.panel1);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(1034, 928);
            this.Load += new System.EventHandler(this.UserList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUserlist;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button lblSub;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
