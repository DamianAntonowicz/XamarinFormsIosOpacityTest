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
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonOpacityToZero_OnClicked(object sender, EventArgs e)
        {
            CalendarDay1.Opacity = 0;
            CalendarDay2.Opacity = 0;
            CalendarDay3.Opacity = 0;
            CalendarDay4.Opacity = 0;
            CalendarDay5.Opacity = 0;
            CalendarDay6.Opacity = 0;
        }
        
        private void ButtonOpacityToOne_OnClicked(object sender, EventArgs e)
        {
            var random = new Random();
            
            CalendarDay1.Date = DateTimeOffset.Now.AddDays(random.Next(0, 10));
            CalendarDay1.Opacity = 1;
            
            CalendarDay2.Date = DateTimeOffset.Now.AddDays(random.Next(0, 10));
            CalendarDay2.Opacity = 1;
            
            CalendarDay3.Date = DateTimeOffset.Now.AddDays(random.Next(0, 10));
            CalendarDay3.Opacity = 1;
            
            CalendarDay4.Date = DateTimeOffset.Now.AddDays(random.Next(0, 10));
            CalendarDay4.Opacity = 1;
            
            CalendarDay5.Date = DateTimeOffset.Now.AddDays(random.Next(0, 10));
            CalendarDay5.Opacity = 1;
            
            CalendarDay6.Date = DateTimeOffset.Now.AddDays(random.Next(0, 10));
            CalendarDay6.Opacity = 1;
        }
    }
}