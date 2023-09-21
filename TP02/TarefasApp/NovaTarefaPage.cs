using System;
using Microsoft.Maui.Controls;

namespace TarefasApp
{
    public partial class NovaTarefaPage : ContentPage
    {
        public NovaTarefaPage()
        {
            InitializeComponent();
        }

        private void AdicionarTarefa(object sender, EventArgs e)
        {
            // Obtendo  os valores dos campos de entrada
            string title = txtTitle.Text;
            string description = txtDescription.Text;

            // Validação para a entrada de prioridade 
            if (int.TryParse(txtPriority.Text, out int priority))
            {
                // Criando uma nova tarefa com os valores inseridos
                Models.Task novaTarefa = new Models.Task(4, title, description, DateTime.Now, priority);

               
                MessagingCenter.Send(this, "AdicionarTarefa", novaTarefa);

                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Erro", "A prioridade deve ser um número válido.", "OK");
            }
        }
    }
}


