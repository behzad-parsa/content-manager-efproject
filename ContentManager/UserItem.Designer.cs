
namespace ContentManager
{
    partial class UserItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Titillium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(42, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Firatname + Lastname";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Titillium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(393, 15);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(53, 27);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "Birth";
            this.lblBirth.UseMnemonic = false;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Titillium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(583, 15);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(164, 27);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            this.lblRole.UseMnemonic = false;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(43, 60);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(55, 20);
            this.lblDelete.TabIndex = 1;
            this.lblDelete.TabStop = true;
            this.lblDelete.Text = "Delete";
            this.lblDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDelete_LinkClicked);
            // 
            // UserItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Name = "UserItem";
            this.Size = new System.Drawing.Size(747, 92);
            this.Load += new System.EventHandler(this.UserItem_Load);
            this.DoubleClick += new System.EventHandler(this.UserItem_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.UserItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserItem_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.LinkLabel lblDelete;
    }
}
