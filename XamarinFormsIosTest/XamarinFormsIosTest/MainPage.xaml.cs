using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsIosTest
{
    public partial class MainPage : ContentPage
    {
        private List<CalendarDay> _days = new List<CalendarDay>();
        
        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    var calendarDay = new CalendarDay();
                    calendarDay.ControlTemplate = Resources["CalendarDayControlTemplate"] as ControlTemplate;
                    
                    Grid.SetColumn(calendarDay, i);
                    Grid.SetRow(calendarDay, j);
                    
                    GridDays.Children.Add(calendarDay);
                    
                    _days.Add(calendarDay);
                }
            }
        }

        private void ButtonOpacityToZero_OnClicked(object sender, EventArgs e)
        {
            foreach (var calendarDay in _days)
            {
                calendarDay.Opacity = 0;
            }
        }
        
        private void ButtonOpacityToOneBroken_OnClicked(object sender, EventArgs e)
        {
            var random = new Random();
            
            foreach (var calendarDay in _days)
            {
                calendarDay.Date = DateTimeOffset.Now.AddDays(random.Next(0, 10));
                calendarDay.Opacity = 1;
            }
        }
        
        private async void ButtonOpacityFadeToZero_OnClicked(object sender, EventArgs e)
        {
            var tasks = new List<Task>();

            foreach (var calendarDay in _days)
            {
                tasks.Add(calendarDay.FadeTo(0, length: 0));
            }

            await Task.WhenAll(tasks);
        }

        private async void ButtonOpacityFadeToOne_OnClicked(object sender, EventArgs e)
        {
            var random = new Random();
            var tasks = new List<Task>();

            foreach (var calendarDay in _days)
            {
                calendarDay.Date = DateTimeOffset.Now.AddDays(random.Next(0, 10));
                tasks.Add(calendarDay.FadeTo(1, length: 0));
            }

            await Task.WhenAll(tasks);
        }
    }
}