namespace WinFormsApp1
{
    partial class ucProcesoNENV
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(952, 46);
            label1.Name = "label1";
            label1.Size = new Size(249, 48);
            label1.TabIndex = 0;
            label1.Text = "Flujo NENV";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(1002, 116);
            button1.Name = "button1";
            button1.Size = new Size(159, 41);
            button1.TabIndex = 1;
            button1.Text = "Iniciar Flujo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ucProcesoNENV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ucProcesoNENV";
            Size = new Size(1902, 1002);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}
