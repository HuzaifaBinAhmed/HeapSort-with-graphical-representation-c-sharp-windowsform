
namespace DaaProject
{
    partial class FrmHeapTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHeapTree));
            this.scrollContainer = new System.Windows.Forms.Panel();
            this.buttonContainer = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbscores = new System.Windows.Forms.ComboBox();
            this.cmbplayers = new System.Windows.Forms.ComboBox();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.HeapTreeBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrollContainer.SuspendLayout();
            this.buttonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeapTreeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollContainer
            // 
            this.scrollContainer.AutoScroll = true;
            this.scrollContainer.Controls.Add(this.buttonContainer);
            this.scrollContainer.Controls.Add(this.HeapTreeBox);
            this.scrollContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollContainer.Location = new System.Drawing.Point(0, 0);
            this.scrollContainer.Name = "scrollContainer";
            this.scrollContainer.Size = new System.Drawing.Size(1056, 592);
            this.scrollContainer.TabIndex = 0;
            // 
            // buttonContainer
            // 
            this.buttonContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonContainer.BackgroundImage")));
            this.buttonContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonContainer.Controls.Add(this.label2);
            this.buttonContainer.Controls.Add(this.label1);
            this.buttonContainer.Controls.Add(this.btnClear);
            this.buttonContainer.Controls.Add(this.cmbscores);
            this.buttonContainer.Controls.Add(this.cmbplayers);
            this.buttonContainer.Controls.Add(this.btnZoomOut);
            this.buttonContainer.Controls.Add(this.btnZoomIn);
            this.buttonContainer.Controls.Add(this.btnUpdate);
            this.buttonContainer.Controls.Add(this.btnRemove);
            this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonContainer.Location = new System.Drawing.Point(0, 0);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(256, 592);
            this.buttonContainer.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(77, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbscores
            // 
            this.cmbscores.FormattingEnabled = true;
            this.cmbscores.Location = new System.Drawing.Point(135, 63);
            this.cmbscores.Name = "cmbscores";
            this.cmbscores.Size = new System.Drawing.Size(111, 21);
            this.cmbscores.TabIndex = 4;
            this.cmbscores.SelectedIndexChanged += new System.EventHandler(this.cmbscores_SelectedIndexChanged);
            // 
            // cmbplayers
            // 
            this.cmbplayers.FormattingEnabled = true;
            this.cmbplayers.Location = new System.Drawing.Point(7, 63);
            this.cmbplayers.Name = "cmbplayers";
            this.cmbplayers.Size = new System.Drawing.Size(111, 21);
            this.cmbplayers.TabIndex = 3;
            this.cmbplayers.SelectedIndexChanged += new System.EventHandler(this.cmbplayers_SelectedIndexChanged);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.ForeColor = System.Drawing.Color.White;
            this.btnZoomOut.Location = new System.Drawing.Point(24, 263);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(90, 30);
            this.btnZoomOut.TabIndex = 2;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.ForeColor = System.Drawing.Color.White;
            this.btnZoomIn.Location = new System.Drawing.Point(142, 263);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(90, 30);
            this.btnZoomIn.TabIndex = 2;
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(142, 376);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Add";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(24, 376);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 30);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // HeapTreeBox
            // 
            this.HeapTreeBox.BackColor = System.Drawing.Color.White;
            this.HeapTreeBox.Location = new System.Drawing.Point(223, 0);
            this.HeapTreeBox.Name = "HeapTreeBox";
            this.HeapTreeBox.Size = new System.Drawing.Size(833, 592);
            this.HeapTreeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeapTreeBox.TabIndex = 0;
            this.HeapTreeBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Players Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Players Scores";
            // 
            // FrmHeapTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 592);
            this.Controls.Add(this.scrollContainer);
            this.Name = "FrmHeapTree";
            this.Text = "FrmHeapTree";
            this.Load += new System.EventHandler(this.FrmHeapTree_Load);
            this.scrollContainer.ResumeLayout(false);
            this.scrollContainer.PerformLayout();
            this.buttonContainer.ResumeLayout(false);
            this.buttonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeapTreeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scrollContainer;
        private System.Windows.Forms.Panel buttonContainer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox HeapTreeBox;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.ComboBox cmbscores;
        private System.Windows.Forms.ComboBox cmbplayers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}