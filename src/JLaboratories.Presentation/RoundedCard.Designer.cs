﻿namespace JLaboratories.Presentation
{
    public partial class RoundedCard : UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
            this.SuspendLayout();
            // 
            // RoundedPicture
            // 
            this.Name = "RoundedPicture";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.RoundedPicture_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
