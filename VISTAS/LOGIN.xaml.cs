namespace JPEDRAZAEXAMEN.VISTAS;

public partial class LOGIN : ContentPage
{
	public LOGIN()
	{
		InitializeComponent();
	}
    public partial class LoginPage : ContentPage
    {
        private string[,] usuarios = new string[,]
        {
            { "estudiante", "moviles" },
            { "uisrael", "2024" }
        };

      
        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;
            bool loginSuccessful = false;
            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                if (usuarios[i, 0] == username && usuarios[i, 1] == password)
                {
                    loginSuccessful = true;
                    break;
                }
            }

            if (loginSuccessful)
            {
                Navigation.PushAsync(new REGISTRO(username));
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
            }
        }
    }
}


