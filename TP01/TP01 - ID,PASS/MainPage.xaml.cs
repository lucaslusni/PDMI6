namespace TP01___ID_PASS;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}


	private void Login(object sender, EventArgs e)
	{ 
		if (txtId.Text == "admin" && txtPass.Text == "senha@dmin") 
		{
			lblMsg.Text = "Logou com sucesso!";
		} 
		else 
		{
			lblMsg.Text = "Pass ou ID invalido\n Digite novamente";
		}
	}
	private void Limpar(object sender, EventArgs e) 
	{
		txtId.Text = "";
		lblMsg.Text = "";
		txtPass.Text = "";
		

    }

	private void Creditos(object sender, EventArgs e) 
	{
		lblMsg.Text = "DOUGLAS REIS   ^_^ \n LUCAS LUSNI   ^_^ ";
	}
}


