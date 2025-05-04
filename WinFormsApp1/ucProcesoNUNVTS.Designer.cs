namespace WinFormsApp1
{
    partial class ucProcesoNUNVTS
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
            emailTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(952, 46);
            label1.Name = "label1";
            label1.Size = new Size(307, 48);
            label1.TabIndex = 0;
            label1.Text = "Flujo NUNVTS";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(1027, 174);
            button1.Name = "button1";
            button1.Size = new Size(159, 41);
            button1.TabIndex = 1;
            button1.Text = "Iniciar Flujo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(964, 130);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(285, 27);
            emailTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(912, 133);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // ucProcesoNUNVTS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(emailTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ucProcesoNUNVTS";
            Size = new Size(1902, 1002);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox emailTextBox;
        private Label label2;
    }
}
