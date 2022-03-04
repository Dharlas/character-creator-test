namespace character_creator_test
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSTR = new System.Windows.Forms.TextBox();
            this.txtDEX = new System.Windows.Forms.TextBox();
            this.txtINT = new System.Windows.Forms.TextBox();
            this.txtCON = new System.Windows.Forms.TextBox();
            this.txtCHA = new System.Windows.Forms.TextBox();
            this.txtWIS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lsbCharacters = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBasic = new System.Windows.Forms.GroupBox();
            this.grpBasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Standard Array",
            "Point Buy",
            "Random roll"});
            this.cmbType.Location = new System.Drawing.Point(118, 30);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select stat setup";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(279, 27);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll stats";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(26, 73);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 3;
            this.lblTest.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "STR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DEX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "INT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CHA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "WIS";
            // 
            // txtSTR
            // 
            this.txtSTR.Location = new System.Drawing.Point(43, 29);
            this.txtSTR.Name = "txtSTR";
            this.txtSTR.ReadOnly = true;
            this.txtSTR.Size = new System.Drawing.Size(100, 20);
            this.txtSTR.TabIndex = 10;
            // 
            // txtDEX
            // 
            this.txtDEX.Location = new System.Drawing.Point(43, 58);
            this.txtDEX.Name = "txtDEX";
            this.txtDEX.ReadOnly = true;
            this.txtDEX.Size = new System.Drawing.Size(100, 20);
            this.txtDEX.TabIndex = 11;
            // 
            // txtINT
            // 
            this.txtINT.Location = new System.Drawing.Point(43, 117);
            this.txtINT.Name = "txtINT";
            this.txtINT.ReadOnly = true;
            this.txtINT.Size = new System.Drawing.Size(100, 20);
            this.txtINT.TabIndex = 13;
            // 
            // txtCON
            // 
            this.txtCON.Location = new System.Drawing.Point(43, 88);
            this.txtCON.Name = "txtCON";
            this.txtCON.ReadOnly = true;
            this.txtCON.Size = new System.Drawing.Size(100, 20);
            this.txtCON.TabIndex = 12;
            // 
            // txtCHA
            // 
            this.txtCHA.Location = new System.Drawing.Point(43, 175);
            this.txtCHA.Name = "txtCHA";
            this.txtCHA.ReadOnly = true;
            this.txtCHA.Size = new System.Drawing.Size(100, 20);
            this.txtCHA.TabIndex = 15;
            // 
            // txtWIS
            // 
            this.txtWIS.Location = new System.Drawing.Point(43, 145);
            this.txtWIS.Name = "txtWIS";
            this.txtWIS.ReadOnly = true;
            this.txtWIS.Size = new System.Drawing.Size(100, 20);
            this.txtWIS.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(49, 224);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 17;
            // 
            // lsbCharacters
            // 
            this.lsbCharacters.FormattingEnabled = true;
            this.lsbCharacters.Location = new System.Drawing.Point(451, 124);
            this.lsbCharacters.Name = "lsbCharacters";
            this.lsbCharacters.Size = new System.Drawing.Size(255, 186);
            this.lsbCharacters.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(360, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpBasic
            // 
            this.grpBasic.Controls.Add(this.txtName);
            this.grpBasic.Controls.Add(this.label8);
            this.grpBasic.Controls.Add(this.txtCHA);
            this.grpBasic.Controls.Add(this.txtWIS);
            this.grpBasic.Controls.Add(this.txtINT);
            this.grpBasic.Controls.Add(this.txtCON);
            this.grpBasic.Controls.Add(this.txtDEX);
            this.grpBasic.Controls.Add(this.txtSTR);
            this.grpBasic.Controls.Add(this.label6);
            this.grpBasic.Controls.Add(this.label7);
            this.grpBasic.Controls.Add(this.label4);
            this.grpBasic.Controls.Add(this.label5);
            this.grpBasic.Controls.Add(this.label3);
            this.grpBasic.Controls.Add(this.label2);
            this.grpBasic.Location = new System.Drawing.Point(26, 105);
            this.grpBasic.Name = "grpBasic";
            this.grpBasic.Size = new System.Drawing.Size(212, 257);
            this.grpBasic.TabIndex = 20;
            this.grpBasic.TabStop = false;
            this.grpBasic.Text = "Basic info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBasic);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lsbCharacters);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBasic.ResumeLayout(false);
            this.grpBasic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSTR;
        private System.Windows.Forms.TextBox txtDEX;
        private System.Windows.Forms.TextBox txtINT;
        private System.Windows.Forms.TextBox txtCON;
        private System.Windows.Forms.TextBox txtCHA;
        private System.Windows.Forms.TextBox txtWIS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lsbCharacters;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpBasic;
    }
}

