﻿namespace NClass.DiagramEditor.Diagrams.Editors
{
    partial class CommentEditor
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(0, 0);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(150, 150);
            this.txtComment.TabIndex = 0;
            this.txtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment_KeyDown);
            // 
            // CommentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtComment);
            this.Name = "CommentEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComment;
    }
}
