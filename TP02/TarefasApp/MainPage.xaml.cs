using Microsoft.Maui.Controls.Xaml;
using System.Collections.ObjectModel;
using TarefasApp.Models;

namespace TarefasApp;

public partial class MainPage : ContentPage
{
    int cout = 0;
    ObservableCollection<Models.Task> tasks = new ObservableCollection<Models.Task>
    {
        new Models.Task(1, "My First Task", "Description Task 1", DateTime.Now, 1),
        new Models.Task(2, "My Second Task", "Description Task 2", DateTime.Now, 2),
        new Models.Task(3, "My Third Task", "Description Task 3", DateTime.Now, 3)
    };
    private void NovaTarefa(object sender, EventArgs e)
    {
        Models.Task novaTarefa = new Models.Task(3, "Nova Tarefa ", "Descrição da Nova Tarefa", DateTime.Now, 0);

        tasks.Add(novaTarefa);
    }
    public MainPage()
	{
        InitializeComponent();

        MessagingCenter.Subscribe<DetailTask, Models.Task>(this, "RemoveTask", (sender, task) =>
        {
            // Remove the task from the list
            tasks.Remove(task);
        });

        MessagingCenter.Subscribe<DetailTask, Models.Task>(this, "EditTask", (sender, task) =>
        {
            tasks.Where(x => x.Id == task.Id).First().Title = task.Title;
            tasks.Where(x => x.Id == task.Id).First().Description = task.Description;
            tasks.Where(x => x.Id == task.Id).First().Created = task.Created;
            tasks.Where(x => x.Id == task.Id).First().Priority = task.Priority;
            
        });

        lstTasks.ItemsSource = tasks;
    }

    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
        if (e.SelectedItem != null)
        {
            var selectedItem = (Models.Task)e.SelectedItem;

            await Navigation.PushAsync(new DetailTask(selectedItem));

            ((ListView)sender).SelectedItem = null;
        }
    }
}

