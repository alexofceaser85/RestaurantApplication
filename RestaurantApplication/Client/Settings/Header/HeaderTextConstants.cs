using RestaurantApplication.Client.Settings.App;

namespace RestaurantApplication.Client.Settings.Header
{
    /// <summary>
    /// Holds the text for the header
    /// </summary>
    public static class HeaderTextConstants
    {
        /// <summary>
        /// The title for the login page header
        /// </summary>
        public static string WelcomeTitle = "Welcome";
        /// <summary>
        /// The content for the login page header
        /// </summary>
        public static string WelcomeContent = $"Welcome to {AppConstants.Name}";
        /// <summary>
        /// The title for the login page header
        /// </summary>
        public static string LoginTitle = "Login";
        /// <summary>
        /// The content for the login page header
        /// </summary>
        public static string LoginContent = $"Login to {AppConstants.Name}";
    }
}
