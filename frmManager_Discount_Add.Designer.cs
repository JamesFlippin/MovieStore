﻿
namespace SU21_Final_Project
{
    partial class frmManager_Discount_Add
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager_Discount_Add));
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscountID = new System.Windows.Forms.Label();
            this.cmxDiscountType = new System.Windows.Forms.ComboBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.tbxDiscountPercent = new System.Windows.Forms.TextBox();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblIsValid = new System.Windows.Forms.Label();
            this.cbxIsValid = new System.Windows.Forms.CheckBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnShowDiscount = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDiscountIDText = new System.Windows.Forms.Label();
            this.ttValid = new System.Windows.Forms.ToolTip(this.components);
            this.lblDiscountPercentValid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.AllowUserToDeleteRows = false;
            this.dgvDiscount.AllowUserToOrderColumns = true;
            this.dgvDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDiscount.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Location = new System.Drawing.Point(527, 13);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(456, 492);
            this.dgvDiscount.TabIndex = 0;
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(30, 57);
            this.tbxDiscount.MaxLength = 9;
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(116, 21);
            this.tbxDiscount.TabIndex = 1;
            this.tbxDiscount.TextChanged += new System.EventHandler(this.tbxDiscount_TextChanged);
            // 
            // lblDiscountID
            // 
            this.lblDiscountID.AutoSize = true;
            this.lblDiscountID.Location = new System.Drawing.Point(27, 38);
            this.lblDiscountID.Name = "lblDiscountID";
            this.lblDiscountID.Size = new System.Drawing.Size(76, 15);
            this.lblDiscountID.TabIndex = 2;
            this.lblDiscountID.Text = "Discount ID :";
            // 
            // cmxDiscountType
            // 
            this.cmxDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxDiscountType.FormattingEnabled = true;
            this.cmxDiscountType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmxDiscountType.Location = new System.Drawing.Point(30, 138);
            this.cmxDiscountType.Name = "cmxDiscountType";
            this.cmxDiscountType.Size = new System.Drawing.Size(116, 23);
            this.cmxDiscountType.TabIndex = 3;
            this.cmxDiscountType.SelectedIndexChanged += new System.EventHandler(this.cmxDiscountType_SelectedIndexChanged);
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(27, 119);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(76, 15);
            this.lblDiscountType.TabIndex = 4;
            this.lblDiscountType.Text = "Discount ID :";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(27, 200);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 15);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "ProductID";
            // 
            // tbxProductID
            // 
            this.tbxProductID.Enabled = false;
            this.tbxProductID.Location = new System.Drawing.Point(30, 222);
            this.tbxProductID.MaxLength = 9;
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.Size = new System.Drawing.Size(116, 21);
            this.tbxProductID.TabIndex = 7;
            // 
            // tbxDiscountPercent
            // 
            this.tbxDiscountPercent.Location = new System.Drawing.Point(30, 302);
            this.tbxDiscountPercent.MaxLength = 2;
            this.tbxDiscountPercent.Name = "tbxDiscountPercent";
            this.tbxDiscountPercent.Size = new System.Drawing.Size(116, 21);
            this.tbxDiscountPercent.TabIndex = 9;
            this.tbxDiscountPercent.TextChanged += new System.EventHandler(this.tbxDiscountPercent_TextChanged);
            this.tbxDiscountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiscountPercent_KeyPress);
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(27, 282);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(109, 15);
            this.lblDiscountPercent.TabIndex = 8;
            this.lblDiscountPercent.Text = "Discount Percent : ";
            // 
            // lblIsValid
            // 
            this.lblIsValid.AutoSize = true;
            this.lblIsValid.Location = new System.Drawing.Point(27, 362);
            this.lblIsValid.Name = "lblIsValid";
            this.lblIsValid.Size = new System.Drawing.Size(46, 15);
            this.lblIsValid.TabIndex = 10;
            this.lblIsValid.Text = "Is Valid";
            // 
            // cbxIsValid
            // 
            this.cbxIsValid.AutoSize = true;
            this.cbxIsValid.Location = new System.Drawing.Point(30, 380);
            this.cbxIsValid.Name = "cbxIsValid";
            this.cbxIsValid.Size = new System.Drawing.Size(15, 14);
            this.cbxIsValid.TabIndex = 11;
            this.cbxIsValid.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(421, 399);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(100, 50);
            this.btnProduct.TabIndex = 12;
            this.btnProduct.Text = "Show &Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnShowDiscount
            // 
            this.btnShowDiscount.Location = new System.Drawing.Point(421, 455);
            this.btnShowDiscount.Name = "btnShowDiscount";
            this.btnShowDiscount.Size = new System.Drawing.Size(100, 50);
            this.btnShowDiscount.TabIndex = 13;
            this.btnShowDiscount.Text = "Show &Discount";
            this.btnShowDiscount.UseVisualStyleBackColor = true;
            this.btnShowDiscount.Click += new System.EventHandler(this.btnShowDiscount_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add Discount";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDiscountIDText
            // 
            this.lblDiscountIDText.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountIDText.Location = new System.Drawing.Point(152, 57);
            this.lblDiscountIDText.Name = "lblDiscountIDText";
            this.lblDiscountIDText.Size = new System.Drawing.Size(20, 21);
            this.lblDiscountIDText.TabIndex = 15;
            this.lblDiscountIDText.Text = "X";
            this.ttValid.SetToolTip(this.lblDiscountIDText, "Discount ID Must Be 9 Numbers");
            // 
            // lblDiscountPercentValid
            // 
            this.lblDiscountPercentValid.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountPercentValid.Location = new System.Drawing.Point(150, 304);
            this.lblDiscountPercentValid.Name = "lblDiscountPercentValid";
            this.lblDiscountPercentValid.Size = new System.Drawing.Size(20, 21);
            this.lblDiscountPercentValid.TabIndex = 16;
            this.lblDiscountPercentValid.Text = "X";
            this.ttValid.SetToolTip(this.lblDiscountPercentValid, "Discount Percent Can Be A Number Between 0-95");
            // 
            // frmManager_Discount_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 522);
            this.Controls.Add(this.lblDiscountPercentValid);
            this.Controls.Add(this.lblDiscountIDText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowDiscount);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.cbxIsValid);
            this.Controls.Add(this.lblIsValid);
            this.Controls.Add(this.tbxDiscountPercent);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.tbxProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblDiscountType);
            this.Controls.Add(this.cmxDiscountType);
            this.Controls.Add(this.lblDiscountID);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.dgvDiscount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManager_Discount_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount Editor";
            this.Load += new System.EventHandler(this.frmManager_Discount_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label lblDiscountID;
        private System.Windows.Forms.ComboBox cmxDiscountType;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.TextBox tbxDiscountPercent;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblIsValid;
        private System.Windows.Forms.CheckBox cbxIsValid;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnShowDiscount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDiscountIDText;
        private System.Windows.Forms.ToolTip ttValid;
        private System.Windows.Forms.Label lblDiscountPercentValid;
    }
}