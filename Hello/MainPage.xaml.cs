//Class:      ISTA 220 Programming Fundamentals
//Student:    Francisco Velazquez
//Instructor: Christine E Lee, Instructor
//Date:       07/20/2020

/*********************************************************

This project contains the code to create "Hello GUI"
It is a GUI application that allows user to enter their name and returns Hello (name).

Revisions:


Revision Date:


Revised By:


********************************************************/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hello
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void okClick(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("Hello " + userName.Text);
            msg.ShowAsync();
        }
    }
}
