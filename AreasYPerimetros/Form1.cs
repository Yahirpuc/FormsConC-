using WinFormsApp1.Figuras;

namespace AreasYPerimetros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1(); // Llama al método que agrega las opciones
        }

        private void comboBox1()
        {
            // Agregar las opciones al ComboBox
            MenuDeFormas.Items.Add("Círculo");
            MenuDeFormas.Items.Add("Cuadrado");
            MenuDeFormas.Items.Add("Rectángulo");
            MenuDeFormas.Items.Add("Triángulo");

            // Establecer un valor predeterminado, si es necesario
            MenuDeFormas.SelectedIndex = 0; // Selecciona la primera opción por defecto (Círculo)
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado
            string seleccion = MenuDeFormas.SelectedItem.ToString();

            // Limpiar los campos de valores previos
            //txtValor1.Text = "";
            //txtValor2.Text = "";

            // Condiciones para cada opción seleccionada
            switch (seleccion)
            {
                case "Círculo":
                    // Mostrar solo un valor para radio
                    lblValor1.Text = "Radio:";
                    lblValor2.Visible = false;
                    txtValor2.Visible = false;
                    lblValor3.Visible = false;
                    txtValor3.Visible = false;
                    Resultado.Visible = false;
                    break;

                case "Cuadrado":
                    // Mostrar un valor para el lado
                    lblValor1.Text = "Lado:";
                    lblValor2.Visible = false;
                    txtValor2.Visible = false;
                    lblValor3.Visible = false;
                    txtValor3.Visible = false;
                    Resultado.Visible = false;
                    break;

                case "Rectángulo":
                    // Mostrar dos valores para ancho y alto
                    lblValor1.Text = "Ancho:";
                    lblValor2.Text = "Alto:";
                    lblValor2.Visible = true;
                    txtValor2.Visible = true;
                    lblValor3.Visible = false;
                    txtValor3.Visible = false;
                    Resultado.Visible = false;
                    break;

                case "Triángulo":
                    // Mostrar tres valores para los tres lados del triángulo
                    lblValor1.Text = "Lado A:";
                    lblValor2.Text = "Lado B:";
                    lblValor3.Text = "Lado C:";
                    lblValor2.Visible = true;
                    txtValor2.Visible = true;
                    lblValor3.Visible = true;
                    txtValor3.Visible = true;
                    Resultado.Visible = false;
                    break;

                default:
                    lblValor1.Text = "Valor 1:";
                    lblValor2.Text = "Valor 2:";
                    lblValor2.Visible = true;
                    txtValor2.Visible = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event handler for form load event, if needed
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = MenuDeFormas.SelectedItem.ToString();
                double resultadoArea = 0;
                double resultadoPerimetro = 0;
                string resultadoTipoTriangulo = string.Empty; // Inicializar la variable

                switch (seleccion)
                {
                    case "Círculo":
                        double radio = double.Parse(txtValor1.Text);
                        Circulo miCirculo = new Circulo(radio);
                        resultadoArea = miCirculo.CalcularAreaCirculo();
                        resultadoPerimetro = miCirculo.CalcularPerimetroCirculo();
                        break;

                    case "Cuadrado":
                        double lado = double.Parse(txtValor1.Text);
                        Cuadrado miCuadrado = new Cuadrado(lado);
                        resultadoArea = miCuadrado.CalcularAreaCuadrado();
                        resultadoPerimetro = miCuadrado.CalcularPerimetroCuadrado();
                        break;

                    case "Rectángulo":
                        double ancho = double.Parse(txtValor1.Text);
                        double alto = double.Parse(txtValor2.Text);
                        Rectangulo miRectangulo = new Rectangulo(ancho, alto);
                        resultadoArea = miRectangulo.CalcularAreaRectangulo();
                        resultadoPerimetro = miRectangulo.CalcularPerimetroRectangulo();
                        break;

                    case "Triángulo":
                        double ladoA = double.Parse(txtValor1.Text);
                        double ladoB = double.Parse(txtValor2.Text);
                        double ladoC = double.Parse(txtValor3.Text);
                        Triangulo miTriangulo = new Triangulo(ladoA, ladoB, ladoC);
                        resultadoArea = miTriangulo.CalcularAreaTriangulo();
                        resultadoPerimetro = miTriangulo.CalcularPerimetroTriangulo();
                        resultadoTipoTriangulo = miTriangulo.DeterminarTipoTriangulo(ladoA, ladoB, ladoC);
                        break;
                }

                // Mostrar los resultados
                Resultado.Visible = true;
                if (seleccion == "Triángulo")
                {
                    Resultado.Text = $"Área: {resultadoArea} \nPerímetro: {resultadoPerimetro} \nTipo de Triángulo: {resultadoTipoTriangulo}";
                }
                else
                {
                    Resultado.Text = $"Área: {resultadoArea} \nPerímetro: {resultadoPerimetro}";
                }
            }
            catch (Exception ex) //Mensaje determinado de error
            {

                MessageBox.Show("Error, ingresa un número válido. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
