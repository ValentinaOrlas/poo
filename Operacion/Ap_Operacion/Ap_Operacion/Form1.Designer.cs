namespace Ap_Operacion
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
            LBL_NUM1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TXT_NUM1 = new TextBox();
            TXT_RESULTADO = new TextBox();
            TXT_NUM2 = new TextBox();
            BTN_CALCULAR = new Button();
            SuspendLayout();
            // 
            // LBL_NUM1
            // 
            LBL_NUM1.AutoSize = true;
            LBL_NUM1.Location = new Point(137, 70);
            LBL_NUM1.Name = "LBL_NUM1";
            LBL_NUM1.Size = new Size(107, 15);
            LBL_NUM1.TabIndex = 0;
            LBL_NUM1.Text = "PRIMER NÚMERO: ";
            LBL_NUM1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 120);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 1;
            label2.Text = "SEGUNDO NÚMERO: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 273);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "RESULTADO: ";
            label3.Click += label3_Click;
            // 
            // TXT_NUM1
            // 
            TXT_NUM1.Location = new Point(306, 62);
            TXT_NUM1.Name = "TXT_NUM1";
            TXT_NUM1.Size = new Size(100, 23);
            TXT_NUM1.TabIndex = 3;
            // 
            // TXT_RESULTADO
            // 
            TXT_RESULTADO.Location = new Point(286, 265);
            TXT_RESULTADO.Name = "TXT_RESULTADO";
            TXT_RESULTADO.Size = new Size(100, 23);
            TXT_RESULTADO.TabIndex = 4;
            // 
            // TXT_NUM2
            // 
            TXT_NUM2.Location = new Point(306, 112);
            TXT_NUM2.Name = "TXT_NUM2";
            TXT_NUM2.Size = new Size(100, 23);
            TXT_NUM2.TabIndex = 5;
            // 
            // BTN_CALCULAR
            // 
            BTN_CALCULAR.Location = new Point(231, 180);
            BTN_CALCULAR.Name = "BTN_CALCULAR";
            BTN_CALCULAR.Size = new Size(100, 23);
            BTN_CALCULAR.TabIndex = 6;
            BTN_CALCULAR.Text = "CALCULAR";
            BTN_CALCULAR.UseVisualStyleBackColor = true;
            BTN_CALCULAR.Click += BTN_CALCULAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_CALCULAR);
            Controls.Add(TXT_NUM2);
            Controls.Add(TXT_RESULTADO);
            Controls.Add(TXT_NUM1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LBL_NUM1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_NUM1;
        private Label label2;
        private Label label3;
        private TextBox TXT_NUM1;
        private TextBox TXT_RESULTADO;
        private TextBox TXT_NUM2;
        private Button BTN_CALCULAR;
    }
}