namespace School
{
    partial class Form1
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
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 25;
            this.lbxStudents.Location = new System.Drawing.Point(0, 26);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(181, 179);
            this.lbxStudents.TabIndex = 0;
            this.lbxStudents.SelectedIndexChanged += new System.EventHandler(this.lbxStudents_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(124, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtPoint);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(187, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 231);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumber.ForeColor = System.Drawing.Color.Red;
            this.txtNumber.Location = new System.Drawing.Point(98, 16);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(126, 30);
            this.txtNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.Location = new System.Drawing.Point(98, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 30);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.ForeColor = System.Drawing.Color.Red;
            this.txtSurname.Location = new System.Drawing.Point(98, 108);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(126, 30);
            this.txtSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPoint.ForeColor = System.Drawing.Color.Red;
            this.txtPoint.Location = new System.Drawing.Point(98, 154);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(126, 30);
            this.txtPoint.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Point:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(20, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(12, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(436, 284);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbxStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
    }
}

