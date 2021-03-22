using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Graph;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;

namespace m365contact
{
    public partial class App : Xamarin.Forms.Application
    {

        public static IPublicClientApplication PCA = null;

        //iOS 키체인
        public static string iOSKeychainSecurityGroup = null;

        //MS GraphAPI 사용 App 정보
        public const string ApplicationId = "b7c2093b-f46f-4b89-8584-ff2b3458dce9";

        public static string[] Scopes = { "User.Read.All" };
        //User.ReadBasic.All
        public static string Username = string.Empty;

        public static object ParentWindow { get; set; }

        public const string RedirectUri = "msauth://com.king.TestingAPI2";

       


        //public static string[] APIPermissions = { "User.Read" };
        //// Microsoft Graph permissions used by app
        //public const string APIPermission = "User.Read";
        ////private readonly string[] Scopes = APIPermission.Split(' ');

        //// UIParent used by Android version of the app
        //public static object AuthUIParent = null;

        ////MS GraphAPI - 인증 부분
        //public static IPublicClientApplication PCA = null;

        //private bool isSignedIn;
        //public bool IsSignedIn
        //{
        //    get { return isSignedIn; }
        //    set
        //    {
        //        isSignedIn = value;
        //        OnPropertyChanged("IsSignedIn");
        //        OnPropertyChanged("IsSignedOut");
        //    }
        //}

        public App(string specialRedirectUri = null)
        {
            //InitializeComponent();

            //MS GraphAPI - 인증 부분
            //var builder = PublicClientApplicationBuilder
            //                .Create(ApplicationId)
            //                .WithRedirectUri(RedirectUri)
            //                .WithIosKeychainSecurityGroup("com.microsoft.adalcache");
            //                //.WithRedirectUri(specialRedirectUri?? $"msal{ApplicationId}://auth")

            //if (!string.IsNullOrEmpty(iOSKeychainSecurityGroup))
            //{
            //    builder = builder.WithIosKeychainSecurityGroup(iOSKeychainSecurityGroup);
            //}

            //PCA = builder.Build();

            PCA = PublicClientApplicationBuilder.Create(ApplicationId)
                  //.WithRedirectUri(specialRedirectUri ?? $"msal{ApplicationId}://auth") //초기값
                  .WithRedirectUri(RedirectUri)
                //msala3b5209c-a36e-4f75-8fd7-cc0b57431c1a://auth
                .WithIosKeychainSecurityGroup("com.microsoft.adalcache")
                .Build();

            MainPage = new NavigationPage(new m365contact.MainPage());

        }

        //public async Task SignIn()
        //{

        //    try
        //    {
        //        var accounts = await PCA.GetAccountsAsync();

        //        var silentAuthResult = await PCA
        //            .AcquireTokenSilent(Scopes, accounts.FirstOrDefault())
        //            .ExecuteAsync();

        //        Debug.WriteLine("User already signed in.");
        //        Debug.WriteLine($"Successful silent authentication for: {silentAuthResult.Account.Username}");
        //        Debug.WriteLine($"Access token: {silentAuthResult.AccessToken}");
        //    }
        //    catch (MsalUiRequiredException msalEx)
        //    {
        //        // This exception is thrown when an interactive sign-in is required.
        //        Debug.WriteLine("Silent token request failed, user needs to sign-in: " + msalEx.Message);
        //        // Prompt the user to sign-in
        //        var interactiveRequest = PCA.AcquireTokenInteractive(Scopes);

        //        if (AuthUIParent != null)
        //        {
        //            interactiveRequest = interactiveRequest
        //                .WithParentActivityOrWindow(AuthUIParent);
        //        }

        //        var interactiveAuthResult = await interactiveRequest.ExecuteAsync();
        //        Debug.WriteLine($"Successful interactive authentication for: {interactiveAuthResult.Account.Username}");
        //        Debug.WriteLine($"Access token: {interactiveAuthResult.AccessToken}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("Authentication failed. See exception messsage for more details: " + ex.Message);
        //    }

        //    IsSignedIn = true;
        //}




        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
