namespace App_Promedio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            lblResult = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtResult = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(122, 53);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(92, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Primer Número:";
            lblNum1.Click += label1_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(122, 97);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(104, 15);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Segundo Número:";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(122, 140);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(91, 15);
            lblNum3.TabIndex = 2;
            lblNum3.Text = "Tercer Número: ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(131, 252);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(65, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Resultado: ";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(251, 45);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(251, 89);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 5;
            txtNum2.TextChanged += txtNum3_TextChanged;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(251, 132);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 6;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(260, 244);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(260, 183);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtResult);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblResult);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Calculadora de Promedio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblResult;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtResult;
        private Button btnCalcular;
    }
}