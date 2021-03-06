
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
            this.lblDiscountIDTextValid = new System.Windows.Forms.Label();
            this.ttValid = new System.Windows.Forms.ToolTip(this.components);
            this.lblDiscountPercentValid = new System.Windows.Forms.Label();
            this.lblProductIDValid = new System.Windows.Forms.Label();
            this.btnEditDiscount = new System.Windows.Forms.Button();
            this.btnCompleteEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnShowInactive = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsHelp = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dgvDiscount.Location = new System.Drawing.Point(486, 44);
            this.dgvDiscount.MultiSelect = false;
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(456, 492);
            this.dgvDiscount.TabIndex = 0;
            this.dgvDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscount_CellClick);
            this.dgvDiscount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscount_CellContentClick);
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(17, 90);
            this.tbxDiscount.MaxLength = 9;
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.ShortcutsEnabled = false;
            this.tbxDiscount.Size = new System.Drawing.Size(197, 21);
            this.tbxDiscount.TabIndex = 0;
            this.tbxDiscount.TextChanged += new System.EventHandler(this.tbxDiscount_TextChanged);
            this.tbxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiscount_KeyPress);
            // 
            // lblDiscountID
            // 
            this.lblDiscountID.AutoSize = true;
            this.lblDiscountID.Location = new System.Drawing.Point(14, 71);
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
            this.cmxDiscountType.Location = new System.Drawing.Point(17, 171);
            this.cmxDiscountType.Name = "cmxDiscountType";
            this.cmxDiscountType.Size = new System.Drawing.Size(197, 23);
            this.cmxDiscountType.TabIndex = 1;
            this.cmxDiscountType.SelectedIndexChanged += new System.EventHandler(this.cmxDiscountType_SelectedIndexChanged);
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(14, 152);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(90, 15);
            this.lblDiscountType.TabIndex = 4;
            this.lblDiscountType.Text = "Discount Type :";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(14, 233);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 15);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "ProductID";
            // 
            // tbxProductID
            // 
            this.tbxProductID.Enabled = false;
            this.tbxProductID.Location = new System.Drawing.Point(17, 255);
            this.tbxProductID.MaxLength = 5;
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.ShortcutsEnabled = false;
            this.tbxProductID.Size = new System.Drawing.Size(197, 21);
            this.tbxProductID.TabIndex = 2;
            this.tbxProductID.TextChanged += new System.EventHandler(this.tbxProductID_TextChanged);
            this.tbxProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProductID_KeyPress);
            // 
            // tbxDiscountPercent
            // 
            this.tbxDiscountPercent.Location = new System.Drawing.Point(17, 335);
            this.tbxDiscountPercent.MaxLength = 2;
            this.tbxDiscountPercent.Name = "tbxDiscountPercent";
            this.tbxDiscountPercent.ShortcutsEnabled = false;
            this.tbxDiscountPercent.Size = new System.Drawing.Size(197, 21);
            this.tbxDiscountPercent.TabIndex = 3;
            this.tbxDiscountPercent.TextChanged += new System.EventHandler(this.tbxDiscountPercent_TextChanged);
            this.tbxDiscountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiscountPercent_KeyPress);
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(14, 315);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(109, 15);
            this.lblDiscountPercent.TabIndex = 8;
            this.lblDiscountPercent.Text = "Discount Percent : ";
            // 
            // lblIsValid
            // 
            this.lblIsValid.AutoSize = true;
            this.lblIsValid.Location = new System.Drawing.Point(14, 384);
            this.lblIsValid.Name = "lblIsValid";
            this.lblIsValid.Size = new System.Drawing.Size(46, 15);
            this.lblIsValid.TabIndex = 4;
            this.lblIsValid.Text = "Is Valid";
            // 
            // cbxIsValid
            // 
            this.cbxIsValid.AutoSize = true;
            this.cbxIsValid.Location = new System.Drawing.Point(17, 369);
            this.cbxIsValid.Name = "cbxIsValid";
            this.cbxIsValid.Size = new System.Drawing.Size(15, 14);
            this.cbxIsValid.TabIndex = 11;
            this.cbxIsValid.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(390, 154);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(90, 49);
            this.btnProduct.TabIndex = 12;
            this.btnProduct.Text = "Show &Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnShowDiscount
            // 
            this.btnShowDiscount.Location = new System.Drawing.Point(390, 44);
            this.btnShowDiscount.Name = "btnShowDiscount";
            this.btnShowDiscount.Size = new System.Drawing.Size(90, 49);
            this.btnShowDiscount.TabIndex = 10;
            this.btnShowDiscount.Text = "Show &Active Discount";
            this.btnShowDiscount.UseVisualStyleBackColor = true;
            this.btnShowDiscount.Click += new System.EventHandler(this.btnShowDiscount_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add Discount";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDiscountIDTextValid
            // 
            this.lblDiscountIDTextValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountIDTextValid.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountIDTextValid.Location = new System.Drawing.Point(222, 90);
            this.lblDiscountIDTextValid.Name = "lblDiscountIDTextValid";
            this.lblDiscountIDTextValid.Size = new System.Drawing.Size(18, 21);
            this.lblDiscountIDTextValid.TabIndex = 15;
            this.lblDiscountIDTextValid.Text = "X";
            this.ttValid.SetToolTip(this.lblDiscountIDTextValid, "Discount ID Must Be 9 Numbers");
            // 
            // lblDiscountPercentValid
            // 
            this.lblDiscountPercentValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercentValid.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountPercentValid.Location = new System.Drawing.Point(220, 335);
            this.lblDiscountPercentValid.Name = "lblDiscountPercentValid";
            this.lblDiscountPercentValid.Size = new System.Drawing.Size(20, 21);
            this.lblDiscountPercentValid.TabIndex = 16;
            this.lblDiscountPercentValid.Text = "X";
            this.ttValid.SetToolTip(this.lblDiscountPercentValid, "Discount Percent Can Be A Number Between 0-95");
            // 
            // lblProductIDValid
            // 
            this.lblProductIDValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIDValid.ForeColor = System.Drawing.Color.Red;
            this.lblProductIDValid.Location = new System.Drawing.Point(220, 255);
            this.lblProductIDValid.Name = "lblProductIDValid";
            this.lblProductIDValid.Size = new System.Drawing.Size(20, 21);
            this.lblProductIDValid.TabIndex = 17;
            this.lblProductIDValid.Text = "X";
            this.ttValid.SetToolTip(this.lblProductIDValid, "ProductID must be a valid product");
            this.lblProductIDValid.Visible = false;
            // 
            // btnEditDiscount
            // 
            this.btnEditDiscount.Location = new System.Drawing.Point(109, 431);
            this.btnEditDiscount.Name = "btnEditDiscount";
            this.btnEditDiscount.Size = new System.Drawing.Size(74, 50);
            this.btnEditDiscount.TabIndex = 6;
            this.btnEditDiscount.Text = "&Edit Discount";
            this.btnEditDiscount.UseVisualStyleBackColor = true;
            this.btnEditDiscount.Click += new System.EventHandler(this.btnEditDiscount_Click);
            // 
            // btnCompleteEdit
            // 
            this.btnCompleteEdit.Location = new System.Drawing.Point(109, 487);
            this.btnCompleteEdit.Name = "btnCompleteEdit";
            this.btnCompleteEdit.Size = new System.Drawing.Size(75, 50);
            this.btnCompleteEdit.TabIndex = 7;
            this.btnCompleteEdit.Text = "C&omplete Edit";
            this.btnCompleteEdit.UseVisualStyleBackColor = true;
            this.btnCompleteEdit.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(189, 431);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 50);
            this.btnCancelEdit.TabIndex = 8;
            this.btnCancelEdit.Text = "&Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(486, 44);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(470, 493);
            this.dgvProduct.TabIndex = 13;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(270, 484);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnShowInactive
            // 
            this.btnShowInactive.Location = new System.Drawing.Point(390, 99);
            this.btnShowInactive.Name = "btnShowInactive";
            this.btnShowInactive.Size = new System.Drawing.Size(90, 49);
            this.btnShowInactive.TabIndex = 11;
            this.btnShowInactive.Text = "Show &Inactive Discount";
            this.btnShowInactive.UseVisualStyleBackColor = true;
            this.btnShowInactive.Click += new System.EventHandler(this.btnShowInactive_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 118;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsHelp
            // 
            this.mnsHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(44, 20);
            this.mnsHelp.Text = "Help";
            this.mnsHelp.Click += new System.EventHandler(this.mnsHelp_Click);
            // 
            // frmManager_Discount_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 549);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnShowInactive);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnCompleteEdit);
            this.Controls.Add(this.btnEditDiscount);
            this.Controls.Add(this.lblProductIDValid);
            this.Controls.Add(this.lblDiscountPercentValid);
            this.Controls.Add(this.lblDiscountIDTextValid);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblDiscountIDTextValid;
        private System.Windows.Forms.ToolTip ttValid;
        private System.Windows.Forms.Label lblDiscountPercentValid;
        private System.Windows.Forms.Label lblProductIDValid;
        private System.Windows.Forms.Button btnEditDiscount;
        private System.Windows.Forms.Button btnCompleteEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnShowInactive;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsHelp;
    }
}