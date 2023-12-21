namespace Exercício_For_ou_While
{
    partial class Form2
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
            btnPag1 = new Button();
            btncalculowhile = new Button();
            txtnum = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPag1
            // 
            btnPag1.Location = new Point(643, 336);
            btnPag1.Name = "btnPag1";
            btnPag1.Size = new Size(127, 91);
            btnPag1.TabIndex = 0;
            btnPag1.Text = "Pág.1";
            btnPag1.UseVisualStyleBackColor = true;
            btnPag1.Click += btnPag1_Click;
            // 
            // btncalculowhile
            // 
            btncalculowhile.Location = new Point(318, 191);
            btncalculowhile.Name = "btncalculowhile";
            btncalculowhile.Size = new Size(131, 88);
            btncalculowhile.TabIndex = 1;
            btncalculowhile.Text = "Calcular a soma com While";
            btncalculowhile.UseVisualStyleBackColor = true;
            btncalculowhile.Click += btncalculowhile_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(301, 148);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(216, 23);
            txtnum.TabIndex = 2;
            txtnum.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 105);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 3;
            label1.Text = "Resultado:";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtnum);
            Controls.Add(btncalculowhile);
            Controls.Add(btnPag1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPag1;
        private Button btncalculowhile;
        private TextBox txtnum;
        private Label label1;
    }
}