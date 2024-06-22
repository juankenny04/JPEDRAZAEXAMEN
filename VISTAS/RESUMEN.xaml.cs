namespace JPEDRAZAEXAMEN.VISTAS;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class RESUMEN : ContentPage
{
   
    
        public RESUMEN()
        {
            InitializeComponent();

            // Datos de ejemplo para demostración
            string nombre = "Juan";
            string apellido = "Pérez";
            int edad = 25;
            string fecha = "21/06/2024";
            string ciudad = "Ciudad de México";
            string pais = "México";
            double montoInicial = 300;
            double costoCurso = 1500;
            double pagoMensual = ((costoCurso - montoInicial) / 4) * 1.04; // Incluyendo 4% de interés
            double pagoTotal = montoInicial + (pagoMensual * 4);

            // Asignar valores a las etiquetas
            ((Label)this.FindByName("lblNombre")).Text = nombre;
            ((Label)this.FindByName("lblApellido")).Text = apellido;
            ((Label)this.FindByName("lblEdad")).Text = edad.ToString();
            ((Label)this.FindByName("lblFecha")).Text = fecha;
            ((Label)this.FindByName("lblCiudad")).Text = ciudad;
            ((Label)this.FindByName("lblPais")).Text = pais;
            ((Label)this.FindByName("lblMontoInicial")).Text = montoInicial.ToString("C");
            ((Label)this.FindByName("lblPagoMensual")).Text = pagoMensual.ToString("C");
            ((Label)this.FindByName("lblPagoTotal")).Text = pagoTotal.ToString("C");
        }
    }
