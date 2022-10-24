using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace todolistAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            Console.WriteLine("Enter pressed");
            Label newTODO = new Label(); // creating a new label within the xaml
            newTODO.Text = InputField.Text; 
            newTODO.FontSize = 20;
            TodoList.Children.Add(newTODO); // add onto todolist stacklayout 
            InputField.Text = ""; // remove the input field 
        }
    }
}
