
namespace SU21_Final_Project
{
    partial class frmVIewRecieptReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVIewRecieptReport));
            this.dgvReciept = new System.Windows.Forms.DataGridView();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.mnsHelp = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReciept)).BeginInit();
            this.mnsHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReciept
            // 
            this.dgvReciept.AllowUserToAddRows = false;
            this.dgvReciept.AllowUserToDeleteRows = false;
            this.dgvReciept.AllowUserToOrderColumns = true;
            this.dgvReciept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReciept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvReciept.BackgroundColor = System.Drawing.Color.White;
            this.dgvReciept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReciept.Location = new System.Drawing.Point(12, 35);
            this.dgvReciept.MultiSelect = false;
            this.dgvReciept.Name = "dgvReciept";
            this.dgvReciept.ReadOnly = true;
            this.dgvReciept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReciept.Size = new System.Drawing.Size(776, 214);
            this.dgvReciept.TabIndex = 0;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(251, 319);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(100, 34);
            this.btnPrintReport.TabIndex = 1;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(431, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Return";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mnsHelp
            // 
            this.mnsHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.mnsHelp.Location = new System.Drawing.Point(0, 0);
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(800, 24);
            this.mnsHelp.TabIndex = 92;
            this.mnsHelp.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // frmVIewRecieptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.mnsHelp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.dgvReciept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVIewRecieptReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Reciept Report";
            this.Load += new System.EventHandler(this.frmVIewRecieptReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReciept)).EndInit();
            this.mnsHelp.ResumeLayout(false);
            this.mnsHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReciept;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip mnsHelp;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}