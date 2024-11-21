namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNegacion_Click(object sender, EventArgs e)
        {
            lblExplicacion.Text = "Negación (~A): La negación invierte el valor de verdad de A.";
            lblTabla.Text = "A | ~A\n" +
                            "V | F\n" +
                            "F | V";
        }

        private void btnConjuncion_Click(object sender, EventArgs e)
        {
            lblExplicacion.Text = "Conjunción (A ∧ B): Solo es verdadera cuando ambos A y B son verdaderos.";
            lblTabla.Text = "A | B | A ∧ B\n" +
                            "V | V | V\n" +
                            "V | F | F\n" +
                            "F | V | F\n" +
                            "F | F | F";
        }

        private void btnDisyuncion_Click(object sender, EventArgs e)
        {
            lblExplicacion.Text = "Disyunción (A ∨ B): Es verdadera si al menos uno de los dos (A o B) es verdadero.";
            lblTabla.Text = "A | B | A ∨ B\n" +
                            "V | V | V\n" +
                            "V | F | V\n" +
                            "F | V | V\n" +
                            "F | F | F";
        }

        private void btnCondicionalidad_Click(object sender, EventArgs e)
        {
            lblExplicacion.Text = "Condicionalidad (A → B): Es falsa solo cuando A es verdadero y B es falso.";
            lblTabla.Text = "A | B | A → B\n" +
                            "V | V | V\n" +
                            "V | F | F\n" +
                            "F | V | V\n" +
                            "F | F | V";
        }

        private void btnBicondicionalidad_Click(object sender, EventArgs e)
        {
            lblExplicacion.Text = "Bicondicionalidad (A ↔ B): Es verdadera si A y B tienen el mismo valor.";
            lblTabla.Text = "A | B | A ↔ B\n" +
                            "V | V | V\n" +
                            "V | F | F\n" +
                            "F | V | F\n" +
                            "F | F | V";
        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            FormEjercicios formEjercicios = new FormEjercicios();
            formEjercicios.ShowDialog(); // Muestra el formulario de ejercicios como un cuadro de diálogo modal.
        }

        private void btnProductoCartesiano_Click(object sender, EventArgs e)
        {
            FormProductoCartesiano formProductoCartesiano = new FormProductoCartesiano();
            formProductoCartesiano.ShowDialog(); // Abre el formulario de Producto Cartesiano.
        }
    }
}
