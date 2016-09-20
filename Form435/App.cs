using Form435.Database;
using Form435.View;
using Xamarin.Forms;

namespace Form435
{
    public class App : Application
    {
        public App()
        {
            try
            {
                MainPage = new NavigationPage(new Principal());//(new RegistrarUsuario());//

                //MainPage = new NavigationPage(new CategoriasListView());

                // The root page of your application
                //MainPage = new ContentPage
                //{
                //    Content = new StackLayout
                //    {
                //        VerticalOptions = LayoutOptions.Center,
                //        Children = {
                //                new Label {
                //                    XAlign = TextAlignment.Center,
                //                    Text = "Welcome to Xamarin Forms!"
                //                }
                //            }
                //    }
                //};
            }
            catch (System.Exception ex)
            {
                throw ex;
            }            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
