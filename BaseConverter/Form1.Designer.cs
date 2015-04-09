namespace BaseConverter
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
            this.TxtDecimal = new System.Windows.Forms.TextBox();
            this.TxtBase = new System.Windows.Forms.TextBox();
            this.LblDecimal = new System.Windows.Forms.Label();
            this.LblBase = new System.Windows.Forms.Label();
            this.NumBase = new System.Windows.Forms.NumericUpDown();
            this.NumPlaces = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnToBase = new System.Windows.Forms.Button();
            this.BtnToDecimal = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDecimal
            // 
            this.TxtDecimal.Location = new System.Drawing.Point(12, 39);
            this.TxtDecimal.Name = "TxtDecimal";
            this.TxtDecimal.Size = new System.Drawing.Size(189, 20);
            this.TxtDecimal.TabIndex = 0;
            // 
            // TxtBase
            // 
            this.TxtBase.Location = new System.Drawing.Point(276, 39);
            this.TxtBase.Name = "TxtBase";
            this.TxtBase.Size = new System.Drawing.Size(292, 20);
            this.TxtBase.TabIndex = 1;
            // 
            // LblDecimal
            // 
            this.LblDecimal.AutoSize = true;
            this.LblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDecimal.Location = new System.Drawing.Point(12, 23);
            this.LblDecimal.Name = "LblDecimal";
            this.LblDecimal.Size = new System.Drawing.Size(132, 13);
            this.LblDecimal.TabIndex = 2;
            this.LblDecimal.Text = "Decimal Integer Value";
            // 
            // LblBase
            // 
            this.LblBase.AutoSize = true;
            this.LblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBase.Location = new System.Drawing.Point(273, 23);
            this.LblBase.Name = "LblBase";
            this.LblBase.Size = new System.Drawing.Size(140, 13);
            this.LblBase.TabIndex = 3;
            this.LblBase.Text = "Integer Value in Base 2";
            // 
            // NumBase
            // 
            this.NumBase.Location = new System.Drawing.Point(313, 65);
            this.NumBase.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumBase.Name = "NumBase";
            this.NumBase.Size = new System.Drawing.Size(66, 20);
            this.NumBase.TabIndex = 4;
            this.NumBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NumPlaces
            // 
            this.NumPlaces.Location = new System.Drawing.Point(515, 65);
            this.NumPlaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPlaces.Name = "NumPlaces";
            this.NumPlaces.Size = new System.Drawing.Size(53, 20);
            this.NumPlaces.TabIndex = 5;
            this.NumPlaces.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum Places in Result:";
            // 
            // BtnToBase
            // 
            this.BtnToBase.Location = new System.Drawing.Point(12, 146);
            this.BtnToBase.Name = "BtnToBase";
            this.BtnToBase.Size = new System.Drawing.Size(145, 23);
            this.BtnToBase.TabIndex = 8;
            this.BtnToBase.Text = "Convert From Decimal";
            this.BtnToBase.UseVisualStyleBackColor = true;
            this.BtnToBase.Click += new System.EventHandler(this.BtnToBase_Click);
            // 
            // BtnToDecimal
            // 
            this.BtnToDecimal.Location = new System.Drawing.Point(170, 146);
            this.BtnToDecimal.Name = "BtnToDecimal";
            this.BtnToDecimal.Size = new System.Drawing.Size(145, 23);
            this.BtnToDecimal.TabIndex = 9;
            this.BtnToDecimal.Text = "Convert to Decimal";
            this.BtnToDecimal.UseVisualStyleBackColor = true;
            this.BtnToDecimal.Click += new System.EventHandler(this.BtnToDecimal_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(321, 146);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(78, 23);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(226, 42);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 13);
            this.lblDirection.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 185);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnToDecimal);
            this.Controls.Add(this.BtnToBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumPlaces);
            this.Controls.Add(this.NumBase);
            this.Controls.Add(this.LblBase);
            this.Controls.Add(this.LblDecimal);
            this.Controls.Add(this.TxtBase);
            this.Controls.Add(this.TxtDecimal);
            this.Name = "Form1";
            this.Text = "BaseConverter";
            ((System.ComponentModel.ISupportInitialize)(this.NumBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDecimal;
        private System.Windows.Forms.TextBox TxtBase;
        private System.Windows.Forms.Label LblDecimal;
        private System.Windows.Forms.Label LblBase;
        private System.Windows.Forms.NumericUpDown NumBase;
        private System.Windows.Forms.NumericUpDown NumPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnToBase;
        private System.Windows.Forms.Button BtnToDecimal;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label lblDirection;
    }
}

