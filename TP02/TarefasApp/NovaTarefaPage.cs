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

        private void AddTask(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                DisplayAlert("Erro", "Enter a title.", "OK");
                return;
            }

            if (String.IsNullOrEmpty(txtDescription.Text))
            {
                DisplayAlert("Erro", "Enter a description.", "OK");
                return;
            }

            if (int.TryParse(txtPriority.Text, out int priority))
            {
                Models.Task novaTarefa = new Models.Task(txtTitle.Text, txtDescription.Text, txtDate.Date, priority);

                MessagingCenter.Send(this, "AddTask", novaTarefa);

                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Erro", "The priority must be a valid number.", "OK");
                return;
            }
        }
    }
}


