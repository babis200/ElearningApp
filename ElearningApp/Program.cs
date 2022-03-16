
using RestSharp;

namespace ElearningApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Must have a running docker container with mongoDB bound to port 27888
            //docker run --name mongo-on-docker -d -p 27017:27017 -e MONGO_INITDB_ROOT_USERNAME=developer -e MONGO_INITDB_ROOT_PASSWORD=deve-1992 mongo
            var authClient = new RestClient("http://localhost/8000");

            Application.Run(new LoginView(authClient));
        }
    }
}