namespace JPEDRAZAEXAMEN.VISTAS;

public partial class REGISTRO : ContentPage
{
	 
        private const decimal CursoCosto = 1500m;
    private const decimal Interes = 0.04m;

    public REGISTRO()
    {
        InitializeComponent();
    }

    public REGISTRO(string username)
    {
        Username = username;
    }

    public string Username { get; }

    private void OnVerResumenClicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(MontoInicialEntry.Text, out decimal montoInicial))
        {
            decimal saldoRestante = CursoCosto - montoInicial;
            decimal cuotaMensual = (saldoRestante / 4) * (1 + Interes);

            PagoMensualEntry.Text = cuotaMensual.ToString("F2");
            DisplayAlert("Resumen de Pago", $"El pago mensual será: {cuotaMensual:F2}", "OK");
        }
        else
        {
            DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "OK");
        }
    }
}
