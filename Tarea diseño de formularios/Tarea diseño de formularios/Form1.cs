namespace Tarea_diseño_de_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string valorobtenidotextBoxNombre = textBoxNombre.Text;
            string valorobtenidotextBoxTelefono = textBoxTelefono.Text;
            string valorobtenidotextBoxEmail = textBoxEmail.Text;
            String datofinalNombre = valorobtenidotextBoxNombre;
            listBoxContactos.Items.Add(datofinalNombre);
            String datofinalTelefono = valorobtenidotextBoxTelefono;
            listBoxContactos.Items.Add(datofinalTelefono);
            String datofinalEmail = valorobtenidotextBoxEmail;
            listBoxContactos.Items.Add(datofinalEmail);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
        }

    }
}