using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TAFReviewCleanupWindowsForms
{
    public partial class CleanupReviews : Form
    {
        private class HardDeleteEntity
        {
            public string PartialReviewTitle { get; set; }
        }

        static HttpClient client = new HttpClient();

        public CleanupReviews()
        {
            InitializeComponent();
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            var titleText = TitleText.Text;
            if (!titleText.ToUpper().Contains("TAF"))
            {
                if (AreYouSureYouWantToDelete() != DialogResult.Yes)
                {
                    ResultText.Text = "Back to safety! Nothing was deleted :-) ";
                    return;
                }
            }

            await SendDeleteRequest(LDAPText.Text, PasswordText.Text, CaidsText.Text, titleText, EnvCombo.Text);
        }

        private async Task<bool> SendDeleteRequest(string username, string password, string caids, string title, string environment)
        {
            ResultText.Text = string.Empty;
            var body = new HardDeleteEntity
            {
                PartialReviewTitle = title
            };

            var authHash = Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password));
            foreach (string caid in caids.Trim().Split(','))
            {
                var request = new HttpRequestMessage(HttpMethod.Delete, $"https://flex-ose-perfmgmt-svc-pyx.{environment}-lb.paychex.com/reviews/hardDelete/{caid}");

                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authHash);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var serializedObject = JsonConvert.SerializeObject(body);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                request.Content = content;

                var response = await client.SendAsync(request, CancellationToken.None);
                var responseJsonString = response.Content.ReadAsStringAsync().Result;
                ResultText.Text += $"caid={caid} StatusCode={response.StatusCode} response={responseJsonString}{Environment.NewLine}";
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return false;
                }
            }

            return true;
        }

        private void TitleText_TextChanged(object sender, EventArgs e)
        {
            Delete.Enabled = IsDeleteEnabled();
        }

        private void CaidsText_TextChanged(object sender, EventArgs e)
        {
            Delete.Enabled = IsDeleteEnabled();
        }

        private bool IsDeleteEnabled()
        {
            return TitleText.Text != string.Empty &&
                   CaidsText.Text != string.Empty;
        }

        private static DialogResult AreYouSureYouWantToDelete()
        {
            string messageBoxText = "Are you sure you want to delete reviews that are not related to TAF?";
            string caption = "Are you sure?";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            var result = MessageBox.Show(messageBoxText, caption, button, icon);
            return result;
        }
    }
}
