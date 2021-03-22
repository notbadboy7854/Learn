using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.Identity.Client;
using Newtonsoft.Json.Linq;
using System.Net.Http;



namespace m365contact
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnSigninOut(object sender, EventArgs e)
        {
            AuthenticationResult authResult = null;
            IEnumerable<IAccount> accounts = await App.PCA.GetAccountsAsync();
            try
            {
                if (btnSignInOut.Text == "Sign in")
                {
                    try
                    {
                        IAccount firstAccount = accounts.FirstOrDefault();
                        authResult = await App.PCA.AcquireTokenSilent(App.Scopes, firstAccount)
                                              .ExecuteAsync();
                    }
                    catch (MsalUiRequiredException ex)
                    {
                        try
                        {
                            authResult = await App.PCA.AcquireTokenInteractive(App.Scopes)
                                                      .WithParentActivityOrWindow(App.ParentWindow)
                                                      .ExecuteAsync();
                        }
                        catch (Exception ex2)
                        {
                            await DisplayAlert("Acquire token interactive failed. See exception message for details: ", ex2.Message, "Dismiss");
                        }
                    }

                    if (authResult != null)
                    {
                        var content = await GetHttpContentWithTokenAsync(authResult.AccessToken);
                        UpdateUserContent(content);
                        Device.BeginInvokeOnMainThread(() => { btnSignInOut.Text = "Sign out"; });
                    }
                }
                else
                {
                    while (accounts.Any())
                    {
                        await App.PCA.RemoveAsync(accounts.FirstOrDefault());
                        accounts = await App.PCA.GetAccountsAsync();
                    }

                    userInfo.IsVisible = false;
                    Device.BeginInvokeOnMainThread(() => { btnSignInOut.Text = "Sign in"; });
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Authentication failed. See exception message for details: ", ex.Message, "Dismiss");
            }

        }
        

        private void UpdateUserContent(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {

               
                JObject user = JObject.Parse(content);

               


                string tt = user["value"].ToString();

                
                string test = (string)user.SelectToken("value[0].displayName");
                
                test = user.ToString();

                userInfo.IsVisible = true;
                Device.BeginInvokeOnMainThread(() =>
                {
                    //lblDisplayName.Text += user["displayName"].ToString();
                    lblDisplayName.Text += (string)user.SelectToken("value[0].displayName");
                    lblMobile.Text += (string)user.SelectToken("value[0].mobilePhone");
                    lblData.Text += tt;



                    btnSignInOut.Text = "Sign out";
                });
            }
        }

        public async Task<string> GetHttpContentWithTokenAsync(string token)
        {
            try
            {
                //get data from API
                HttpClient client = new HttpClient();
                //HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/me"); //내 정보 출력 API 조회
                string search1 = "https://graph.microsoft.com/v1.0/users?$filter=startswith(displayName,";
                string serach2 = "'김영두')";
                string fsearch = search1 + serach2;

                //HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/users?$filter=startswith(displayName,'김영두')&$select=displayName,");
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/users?$filter=startswith(displayName,'김영두')");
                //HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get,fsearch);

                message.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await client.SendAsync(message);
                string responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
            catch (Exception ex)
            {
                await DisplayAlert("API call to graph failed: ", ex.Message, "Dismiss");
                return ex.ToString();
            }
        }
    }
}
