namespace Proyecto_cine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Pagar = new Button();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 409);
            label1.Name = "label1";
            label1.Size = new Size(230, 33);
            label1.TabIndex = 0;
            label1.Text = "Total(IVA incluido)";
            label1.Click += label1_Click;
            // 
            // Pagar
            // 
            Pagar.BackColor = Color.DeepSkyBlue;
            Pagar.Font = new Font("Times New Roman", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Pagar.ForeColor = SystemColors.ActiveCaptionText;
            Pagar.Location = new Point(467, 375);
            Pagar.Name = "Pagar";
            Pagar.Size = new Size(192, 90);
            Pagar.TabIndex = 1;
            Pagar.Text = "Pagar";
            Pagar.UseVisualStyleBackColor = false;
            Pagar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Fuchsia;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(269, 411);
            label2.Name = "label2";
            label2.Size = new Size(152, 35);
            label2.TabIndex = 2;
            label2.Text = "\"Cantidad\"";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(68, 256);
            button1.Name = "button1";
            button1.Size = new Size(159, 68);
            button1.TabIndex = 3;
            button1.Text = "Efectivo";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(370, 256);
            button2.Name = "button2";
            button2.Size = new Size(192, 68);
            button2.TabIndex = 4;
            button2.Text = "Tarjeta";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(885, 491);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Pagar);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Seleccione el metodo de pago";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Pagar;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
