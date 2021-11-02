
namespace ContentManager
{
    partial class SignedUser
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
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPostCount = new System.Windows.Forms.Label();
            this.lblCommentCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Advent Pro", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(51, 21);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(112, 40);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Behzad";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Advent Pro", 19.8F);
            this.lblLastname.Location = new System.Drawing.Point(169, 21);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(87, 40);
            this.lblLastname.TabIndex = 0;
            this.lblLastname.Text = "Parsa";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Advent Pro", 19.8F);
            this.lblAge.Location = new System.Drawing.Point(314, 21);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(60, 40);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "age";
            this.lblAge.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPostCount
            // 
            this.lblPostCount.AutoSize = true;
            this.lblPostCount.Font = new System.Drawing.Font("Advent Pro", 19.8F);
            this.lblPostCount.Location = new System.Drawing.Point(848, 21);
            this.lblPostCount.Name = "lblPostCount";
            this.lblPostCount.Size = new System.Drawing.Size(142, 40);
            this.lblPostCount.TabIndex = 0;
            this.lblPostCount.Text = "PostCount";
            this.lblPostCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCommentCount
            // 
            this.lblCommentCount.AutoSize = true;
            this.lblCommentCount.Font = new System.Drawing.Font("Advent Pro", 19.8F);
            this.lblCommentCount.Location = new System.Drawing.Point(617, 21);
            this.lblCommentCount.Name = "lblCommentCount";
            this.lblCommentCount.Size = new System.Drawing.Size(204, 40);
            this.lblCommentCount.TabIndex = 0;
            this.lblCommentCount.Text = "CommentCount";
            this.lblCommentCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 97);
            this.panel1.TabIndex = 1;
            // 
            // SignedUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCommentCount);
            this.Controls.Add(this.lblPostCount);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Name = "SignedUser";
            this.Size = new System.Drawing.Size(1038, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPostCount;
        private System.Windows.Forms.Label lblCommentCount;
        private System.Windows.Forms.Panel panel1;
    }
}
