namespace Simple_Crud
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST NAME";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(146, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(90, 64);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(146, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LAST NAME";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EMAIL";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(90, 116);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(146, 20);
            this.txtNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NUMBER";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 158);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 27);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(111, 158);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 27);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(210, 158);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(93, 27);
            this.btnConsult.TabIndex = 10;
            this.btnConsult.Text = "CONSULT";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(309, 158);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 27);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(407, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 27);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 202);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(488, 123);
            this.dgvData.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 20);
            this.txtId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
    }
}

