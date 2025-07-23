
namespace DaaProject
{
    partial class InitialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.btnOpenLeaderboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenLeaderboard
            // 
            this.btnOpenLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenLeaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpenLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLeaderboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnOpenLeaderboard.Location = new System.Drawing.Point(339, 260);
            this.btnOpenLeaderboard.Name = "btnOpenLeaderboard";
            this.btnOpenLeaderboard.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnOpenLeaderboard.Size = new System.Drawing.Size(165, 43);
            this.btnOpenLeaderboard.TabIndex = 0;
            this.btnOpenLeaderboard.Text = "Leaderboard";
            this.btnOpenLeaderboard.UseVisualStyleBackColor = false;
            this.btnOpenLeaderboard.Click += new System.EventHandler(this.btnOpenLeaderboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(308, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click here to open Leaderboard";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenLeaderboard);
            this.Name = "InitialForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenLeaderboard;
        private System.Windows.Forms.Label label1;
    }
}

