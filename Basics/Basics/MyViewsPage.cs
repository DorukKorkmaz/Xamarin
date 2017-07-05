using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Basics
{
    public class MyViewsPage : ContentPage
    {
        public MyViewsPage()
        {
            Title = "Views";

            Image image = new Image
            {
                Source = "logo.png"
            };

            Label label = new Label
            {
                Text = "Hello Xamarin",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 30,
                TextColor = Color.Red
            };

            Entry usernameEntry = new Entry
            {
                Placeholder = "Username"
            };

            Entry passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };

            Button button = new Button
            {
                Text = "Login"
            };

            int numberOfClicks = 1;
            button.Clicked += (object sender, System.EventArgs e) =>
            {
                DisplayAlert("Number of Clicks", "You clicked " + numberOfClicks.ToString() + " times", "OK");
                numberOfClicks++;
            };

            Editor editor = new Editor
            {
                Text = "This is Editor! You can write multiple lines into the Editor just like in this example :)"
            };

            StackLayout boxViewLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new StackLayout{
                        Orientation=StackOrientation.Horizontal,
                        Children = {
                            new BoxView{
                            Color = Color.Red,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center
                            },
                            new BoxView{
                            Color = Color.Green,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center
                            }
                        }
                    },
                    new StackLayout{
                        Orientation=StackOrientation.Horizontal,
                        Children = {
                            new BoxView{
                            Color = Color.Blue,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center
                            },
                            new BoxView{
                            Color = Color.Yellow,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center
                            }
                        }
                    }
                }
            };

            Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
            {
                { "Aqua", Color.Aqua }, { "Black", Color.Black },
                { "Blue", Color.Blue }, { "Fuchsia", Color.Fuchsia },
                { "Gray", Color.Gray }, { "Green", Color.Green },
                { "Lime", Color.Lime }, { "Maroon", Color.Maroon },
                { "Navy", Color.Navy }, { "Olive", Color.Olive },
                { "Purple", Color.Purple }, { "Red", Color.Red },
                { "Silver", Color.Silver }, { "Teal", Color.Teal },
                { "White", Color.White }, { "Yellow", Color.Yellow }
            };

            Picker picker = new Picker
            {
                Title = "Select Background Color"
            };

            foreach (string colorName in nameToColor.Keys)
            {
                picker.Items.Add(colorName);
            }

            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                MinimumDate = DateTime.Today.AddYears(-1),
                MaximumDate = DateTime.Today.AddYears(1)
            };

            TimePicker timePicker = new TimePicker
            {
                TextColor = Color.Red
            };

            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 1,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };

            Label stepperLabel = new Label
            {
                Text = stepper.Value.ToString(),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 20
            };

            stepper.ValueChanged += (object sender, ValueChangedEventArgs e) =>
            {
                stepperLabel.Text = stepper.Value.ToString();
            };

            StackLayout stepperLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,

                Children = {
                    stepper,
                    stepperLabel
                }
            };

            Slider slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 50,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 200

            };

            Label sliderLabel = new Label
            {
                Text = slider.Value.ToString(),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 20

            };

            slider.ValueChanged += (object sender, ValueChangedEventArgs e) =>
            {
                sliderLabel.Text = slider.Value.ToString();
            };

            StackLayout sliderLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,

                Children = {
                    slider,
                    sliderLabel
                }
            };

            Switch switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            Label switchLabel = new Label
            {
                Text = "False",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 20

            };

            StackLayout switchLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,

                Children = {
                    switcher,
                    switchLabel
                }
            };

            switcher.Toggled += (object sender, ToggledEventArgs e) =>
            {
                switchLabel.Text = e.Value.ToString();
            };

            ActivityIndicator indicator = new ActivityIndicator();

            ProgressBar progressBar = new ProgressBar();

            ListView listView = new ListView();

            StackLayout stackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    image,
                    boxViewLayout,
                    label,
                    usernameEntry,
                    passwordEntry,
                    button,
                    editor,
                    picker,
                    datePicker,
                    timePicker,
                    stepperLayout,
                    sliderLayout,
                    switchLayout
                }
            };

            picker.SelectedIndexChanged += (object sender, System.EventArgs e) =>
            {
                if (picker.SelectedIndex != -1)
                {
                    this.BackgroundColor = nameToColor[picker.Items[picker.SelectedIndex]];

                }
                else
                {
                    this.BackgroundColor = Color.White;
                }
            };

            Content = new ScrollView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout
            };

            Padding = new Thickness(20, 20, 20, 20);
        }
    }
}

