namespace PassLib
{
    partial class footer
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
            this.DiaHora = new System.Windows.Forms.Label();
            this.lblFoot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DiaHora
            // 
            this.DiaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DiaHora.AutoSize = true;
            this.DiaHora.BackColor = System.Drawing.Color.DarkRed;
            this.DiaHora.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaHora.ForeColor = System.Drawing.Color.White;
            this.DiaHora.Location = new System.Drawing.Point(3, 6);
            this.DiaHora.Name = "DiaHora";
            this.DiaHora.Size = new System.Drawing.Size(131, 11);
            this.DiaHora.TabIndex = 40;
            this.DiaHora.Text = "12/07/2015 - 13:27";
            // 
            // lblFoot
            // 
            this.lblFoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoot.AutoSize = true;
            this.lblFoot.BackColor = System.Drawing.Color.DarkRed;
            this.lblFoot.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoot.ForeColor = System.Drawing.Color.White;
            this.lblFoot.Location = new System.Drawing.Point(180, 6);
            this.lblFoot.Name = "lblFoot";
            this.lblFoot.Size = new System.Drawing.Size(103, 11);
            this.lblFoot.TabIndex = 39;
            this.lblFoot.Text = "NexTeck © 2015";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 11);
            this.label1.TabIndex = 41;
            this.label1.Text = "|";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiaHora);
            this.Controls.Add(this.lblFoot);
            this.Name = "footer";
            this.Size = new System.Drawing.Size(286, 23);
            this.Load += new System.EventHandler(this.footer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiaHora;
        private System.Windows.Forms.Label lblFoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
