using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Fitnezze.DAL;

namespace Fitnezze.App
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var ctx = new FitnezzeDataContext();

            if (!ctx.DatabaseExists())
            {
                ctx.CreateDatabase();
            }

            /*var muscle = new Muscle();
            muscle.Name = "Test";
            ctx.Muscles.InsertOnSubmit(muscle);
            ctx.SubmitChanges();*/

            if (ctx.Muscles.Any(m => m.Name == "Test"))
            {
                MessageBox.Show(ctx.Muscles.Single(m => m.Name == "Test").Id.ToString());
            }
            
        }
    }
}