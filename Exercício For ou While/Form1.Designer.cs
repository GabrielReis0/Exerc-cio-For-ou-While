namespace Exercício_For_ou_While
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
            txtnum = new TextBox();
            btncalcular = new Button();
            label1 = new Label();
            btnpag2 = new Button();
            SuspendLayout();
            // 
            // txtnum
            // 
            txtnum.Location = new Point(281, 140);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(231, 23);
            txtnum.TabIndex = 0;
            txtnum.TextChanged += txtnum_TextChanged;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(326, 187);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(137, 88);
            btncalcular.TabIndex = 1;
            btncalcular.Text = "Calcular com o For";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(281, 101);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 2;
            label1.Text = "Resultado:";
            // 
            // btnpag2
            // 
            btnpag2.Location = new Point(654, 355);
            btnpag2.Name = "btnpag2";
            btnpag2.Size = new Size(117, 72);
            btnpag2.TabIndex = 3;
            btnpag2.Text = "Pág.2";
            btnpag2.UseVisualStyleBackColor = true;
            btnpag2.Click += btnpag2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnpag2);
            Controls.Add(label1);
            Controls.Add(btncalcular);
            Controls.Add(txtnum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum;
        private Button btncalcular;
        private Label label1;
        private Button btnpag2;
    }
}