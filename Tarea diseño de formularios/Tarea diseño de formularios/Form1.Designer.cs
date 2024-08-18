namespace Tarea_diseño_de_formularios
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
            EtiquetaNombre = new Label();
            etiquetaTelefono = new Label();
            etiquetaEmail = new Label();
            textBoxNombre = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxEmail = new TextBox();
            buttonAgregar = new Button();
            listBoxContactos = new ListBox();
            buttonLimpiar = new Button();
            labelEstado = new Label();
            SuspendLayout();
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Location = new Point(58, 25);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(51, 15);
            EtiquetaNombre.TabIndex = 0;
            EtiquetaNombre.Text = "Nombre";
            // 
            // etiquetaTelefono
            // 
            etiquetaTelefono.AutoSize = true;
            etiquetaTelefono.Location = new Point(58, 64);
            etiquetaTelefono.Name = "etiquetaTelefono";
            etiquetaTelefono.Size = new Size(52, 15);
            etiquetaTelefono.TabIndex = 1;
            etiquetaTelefono.Text = "Telefono";
            // 
            // etiquetaEmail
            // 
            etiquetaEmail.AutoSize = true;
            etiquetaEmail.Location = new Point(58, 106);
            etiquetaEmail.Name = "etiquetaEmail";
            etiquetaEmail.Size = new Size(105, 15);
            etiquetaEmail.TabIndex = 2;
            etiquetaEmail.Text = "Correo Electronico";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(188, 17);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(220, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(188, 64);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(220, 23);
            textBoxTelefono.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(188, 106);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(220, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(58, 193);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(134, 33);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar contacto";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // listBoxContactos
            // 
            listBoxContactos.FormattingEnabled = true;
            listBoxContactos.ItemHeight = 15;
            listBoxContactos.Location = new Point(491, 17);
            listBoxContactos.Name = "listBoxContactos";
            listBoxContactos.Size = new Size(261, 319);
            listBoxContactos.TabIndex = 8;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(248, 193);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.RightToLeft = RightToLeft.No;
            buttonLimpiar.Size = new Size(127, 33);
            buttonLimpiar.TabIndex = 9;
            buttonLimpiar.Text = "Limpiar Campos ";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(188, 152);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(38, 15);
            labelEstado.TabIndex = 10;
            labelEstado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEstado);
            Controls.Add(buttonLimpiar);
            Controls.Add(listBoxContactos);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxNombre);
            Controls.Add(etiquetaEmail);
            Controls.Add(etiquetaTelefono);
            Controls.Add(EtiquetaNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaNombre;
        private Label etiquetaTelefono;
        private Label etiquetaEmail;
        private TextBox textBoxNombre;
        private TextBox textBoxTelefono;
        private TextBox textBoxEmail;
        private Button buttonAgregar;
        private ListBox listBoxContactos;
        private Button buttonLimpiar;
        private Label labelEstado;
    }
}
