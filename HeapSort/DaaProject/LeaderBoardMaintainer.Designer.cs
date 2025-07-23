
namespace DaaProject
{
    partial class LeaderBoardMaintainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderBoardMaintainer));
            this.btnLoadCSV = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnMaxHeapTree = new System.Windows.Forms.Button();
            this.btnMinHeapTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadCSV
            // 
            this.btnLoadCSV.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadCSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLoadCSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLoadCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCSV.ForeColor = System.Drawing.Color.White;
            this.btnLoadCSV.Location = new System.Drawing.Point(353, 140);
            this.btnLoadCSV.Name = "btnLoadCSV";
            this.btnLoadCSV.Size = new System.Drawing.Size(95, 36);
            this.btnLoadCSV.TabIndex = 1;
            this.btnLoadCSV.Text = "Upload";
            this.btnLoadCSV.UseVisualStyleBackColor = false;
            this.btnLoadCSV.Click += new System.EventHandler(this.btnLoadCSV_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "FileDialog";
            // 
            // btnMaxHeapTree
            // 
            this.btnMaxHeapTree.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxHeapTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxHeapTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaxHeapTree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaxHeapTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxHeapTree.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxHeapTree.ForeColor = System.Drawing.Color.White;
            this.btnMaxHeapTree.Location = new System.Drawing.Point(235, 235);
            this.btnMaxHeapTree.Name = "btnMaxHeapTree";
            this.btnMaxHeapTree.Size = new System.Drawing.Size(138, 29);
            this.btnMaxHeapTree.TabIndex = 9;
            this.btnMaxHeapTree.Text = "MAX Heap";
            this.btnMaxHeapTree.UseVisualStyleBackColor = false;
            this.btnMaxHeapTree.Click += new System.EventHandler(this.btnMaxHeapTree_Click);
            // 
            // btnMinHeapTree
            // 
            this.btnMinHeapTree.BackColor = System.Drawing.Color.Transparent;
            this.btnMinHeapTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinHeapTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinHeapTree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinHeapTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinHeapTree.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinHeapTree.ForeColor = System.Drawing.Color.White;
            this.btnMinHeapTree.Location = new System.Drawing.Point(407, 235);
            this.btnMinHeapTree.Name = "btnMinHeapTree";
            this.btnMinHeapTree.Size = new System.Drawing.Size(138, 29);
            this.btnMinHeapTree.TabIndex = 10;
            this.btnMinHeapTree.Text = "MIN Heap";
            this.btnMinHeapTree.UseVisualStyleBackColor = false;
            this.btnMinHeapTree.Click += new System.EventHandler(this.btnMinHeapTree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Upload File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose any one";
            // 
            // LeaderBoardMaintainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(777, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinHeapTree);
            this.Controls.Add(this.btnMaxHeapTree);
            this.Controls.Add(this.btnLoadCSV);
            this.Name = "LeaderBoardMaintainer";
            this.Text = "LeaderBoardMaintainer";
            this.Load += new System.EventHandler(this.LeaderBoardMaintainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadCSV;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button btnMaxHeapTree;
        private System.Windows.Forms.Button btnMinHeapTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}