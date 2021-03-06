﻿namespace CharacterSheet.Edit
{
    partial class AddRace
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtStr = new System.Windows.Forms.NumericUpDown();
            this.txtDex = new System.Windows.Forms.NumericUpDown();
            this.txtInt = new System.Windows.Forms.NumericUpDown();
            this.txtCon = new System.Windows.Forms.NumericUpDown();
            this.txtCha = new System.Windows.Forms.NumericUpDown();
            this.txtWis = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Race Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 26);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Charisma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wisdom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Intelligence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Constitution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dexterity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Strength";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Apply any racial bonuses below";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAccept, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 342);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 62);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(163, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 56);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnAccept
            // 
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Location = new System.Drawing.Point(3, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(154, 56);
            this.btnAccept.TabIndex = 36;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(157, 107);
            this.txtStr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtStr.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(120, 26);
            this.txtStr.TabIndex = 2;
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(157, 144);
            this.txtDex.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtDex.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(120, 26);
            this.txtDex.TabIndex = 3;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(157, 220);
            this.txtInt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtInt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(120, 26);
            this.txtInt.TabIndex = 5;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(157, 183);
            this.txtCon.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtCon.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(120, 26);
            this.txtCon.TabIndex = 4;
            // 
            // txtCha
            // 
            this.txtCha.Location = new System.Drawing.Point(157, 294);
            this.txtCha.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtCha.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.txtCha.Name = "txtCha";
            this.txtCha.Size = new System.Drawing.Size(120, 26);
            this.txtCha.TabIndex = 7;
            // 
            // txtWis
            // 
            this.txtWis.Location = new System.Drawing.Point(157, 257);
            this.txtWis.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtWis.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.txtWis.Name = "txtWis";
            this.txtWis.Size = new System.Drawing.Size(120, 26);
            this.txtWis.TabIndex = 6;
            // 
            // AddRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 404);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.txtWis);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddRace";
            this.Text = "AddRace";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown txtStr;
        private System.Windows.Forms.NumericUpDown txtDex;
        private System.Windows.Forms.NumericUpDown txtInt;
        private System.Windows.Forms.NumericUpDown txtCon;
        private System.Windows.Forms.NumericUpDown txtCha;
        private System.Windows.Forms.NumericUpDown txtWis;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}