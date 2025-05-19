using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Project4
{
    public partial class Lab4_Bai4 : Form
    {
        // Declare the WebBrowser control
        private WebBrowser webBrowser;
        private HttpClient httpClient;
        private string currentUrl;

        public Lab4_Bai4()
        {
            InitializeComponent();

            // Initialize the WebBrowser control with proper properties
            if (this.webBrowser == null)
            {
                // Create WebBrowser with correct properties
                webBrowser = new WebBrowser();
                webBrowser.Location = new Point(15, 126); // Set specific location
                webBrowser.Size = new Size(1302, 427);    // Set specific size
                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
                webBrowser.Dock = DockStyle.None;         // Remove dock to maintain specific size/location

                // Add directly to form instead of using a panel
                this.Controls.Add(webBrowser);
            }

            // Initialize HttpClient with better timeout and headers
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 Web Browser App");
            httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Update URL text box when page finishes loading
            if (tbInput != null && webBrowser.Url != null)
            {
                tbInput.Text = webBrowser.Url.ToString();
                currentUrl = webBrowser.Url.ToString();
            }
        }

        private void btAccess_Click(object sender, EventArgs e)
        {
            string url = tbInput.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure URL has proper format
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
                tbInput.Text = url;
            }

            try
            {
                // Show loading cursor
                this.Cursor = Cursors.WaitCursor;

                // Navigate to URL
                webBrowser.Navigate(new Uri(url));
                currentUrl = url;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể điều hướng đến URL: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btSeeSource_Click(object sender, EventArgs e)
        {
            // Validate URL input
            if (string.IsNullOrEmpty(tbInput.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập URL trước.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Format URL with https if needed
            string url = tbInput.Text;
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            try
            {
                // Change cursor to indicate processing
                this.Cursor = Cursors.WaitCursor;

                // Asynchronously fetch source code
                Task.Run(async () =>
                {
                    try
                    {
                        // Download the HTML source
                        HttpResponseMessage response = await httpClient.GetAsync(url);
                        string sourceCode = await response.Content.ReadAsStringAsync();

                        // Display source code in new form
                        this.Invoke(new Action(() =>
                        {
                            // Create and configure the form
                            Form sourceForm = new Form
                            {
                                Text = "Source Code: " + url,
                                Size = new Size(800, 600),
                                StartPosition = FormStartPosition.CenterScreen
                            };

                            // Create and configure source code text box
                            TextBox txtSource = new TextBox
                            {
                                Multiline = true,
                                ScrollBars = ScrollBars.Both,
                                Dock = DockStyle.Fill,
                                Text = sourceCode,
                                WordWrap = false,
                                Font = new Font("Consolas", 10),
                                ReadOnly = true  // Prevent editing
                            };

                            // Add text box to form and display
                            sourceForm.Controls.Add(txtSource);
                            sourceForm.Show();

                            // Restore cursor
                            this.Cursor = Cursors.Default;
                        }));
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show(
                                "Lỗi khi tải source code: " + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            // Restore cursor on error
                            this.Cursor = Cursors.Default;
                        }));
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Restore cursor
                this.Cursor = Cursors.Default;
            }
        }

        // Improved download functionality
        private void btDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbInput.Text))
            {
                MessageBox.Show("Vui lòng nhập URL trước.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string url = tbInput.Text.Trim();
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
                tbInput.Text = url;
            }

            // Generate a default filename based on the URL
            string suggestedFilename = GetSuggestedFilename(url);

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "HTML Files (*.html)|*.html|All Files (*.*)|*.*";
            saveDialog.FileName = suggestedFilename;
            saveDialog.Title = "Lưu trang web";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Show waiting cursor and disable buttons during download
                this.Cursor = Cursors.WaitCursor;
                EnableUIControls(false);

                // Start download
                DownloadWebPage(url, saveDialog.FileName);
            }
        }

        private string GetSuggestedFilename(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                string host = uri.Host;
                string path = uri.AbsolutePath.TrimEnd('/');

                // Use the last segment of the path if available
                string lastSegment = Path.GetFileNameWithoutExtension(path);

                if (!string.IsNullOrEmpty(lastSegment) && lastSegment != "/")
                    return lastSegment + ".html";

                // Otherwise use the hostname
                return host.Replace(".", "_") + ".html";
            }
            catch
            {
                return "webpage.html";
            }
        }

        private void EnableUIControls(bool enable)
        {
            if (btAccess != null) btAccess.Enabled = enable;
            if (btSeeSource != null) btSeeSource.Enabled = enable;
            if (btDownload != null) btDownload.Enabled = enable;
            if (tbInput != null) tbInput.Enabled = enable;
        }

        private void DownloadWebPage(string url, string filePath)
        {
            try
            {
                // Create directory structure for assets
                string directory = Path.GetDirectoryName(filePath);
                string assetsDir = Path.Combine(directory, "assets");
                Directory.CreateDirectory(assetsDir);

                // Download web page and resources asynchronously
                Task.Run(async () =>
                {
                    try
                    {
                        // Use HtmlAgilityPack to download and parse the page
                        HtmlWeb web = new HtmlWeb();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        HtmlAgilityPack.HtmlDocument doc = await Task.Run(() => web.Load(url));

                        // Save the main HTML file
                        File.WriteAllText(filePath, doc.DocumentNode.OuterHtml);

                        // Download resources (images, CSS, etc.)
                        await DownloadResources(doc, url, assetsDir);

                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show("Tải xuống thành công!\nHTML: " + filePath + "\nTài nguyên: " + assetsDir,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Re-enable UI controls
                            this.Cursor = Cursors.Default;
                            EnableUIControls(true);
                        }));
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show("Lỗi khi tải xuống: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Re-enable UI controls
                            this.Cursor = Cursors.Default;
                            EnableUIControls(true);
                        }));
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                EnableUIControls(true);
            }
        }

        private async Task DownloadResources(HtmlAgilityPack.HtmlDocument doc, string baseUrl, string outputDir)
        {
            // Create subdirectories for resource types
            string imagesDir = Path.Combine(outputDir, "images");
            string cssDir = Path.Combine(outputDir, "css");
            string jsDir = Path.Combine(outputDir, "js");
            string otherDir = Path.Combine(outputDir, "other");

            Directory.CreateDirectory(imagesDir);
            Directory.CreateDirectory(cssDir);
            Directory.CreateDirectory(jsDir);
            Directory.CreateDirectory(otherDir);

            // Track total resources and successful downloads
            int totalResources = 0;
            int successfulDownloads = 0;
            List<Task> downloadTasks = new List<Task>();

            // Download images
            var images = doc.DocumentNode.SelectNodes("//img[@src]");
            if (images != null)
            {
                foreach (var img in images)
                {
                    string src = img.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(src))
                    {
                        totalResources++;
                        string resolvedUrl = ResolveUrl(src, baseUrl);
                        string filePath = Path.Combine(imagesDir, GetFileName(src));
                        var task = DownloadFile(resolvedUrl, filePath).ContinueWith(t =>
                        {
                            if (t.IsCompletedSuccessfully) successfulDownloads++;
                        });
                        downloadTasks.Add(task);
                    }
                }
            }

            // Download CSS files
            var cssLinks = doc.DocumentNode.SelectNodes("//link[@rel='stylesheet']");
            if (cssLinks != null)
            {
                foreach (var link in cssLinks)
                {
                    string href = link.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(href))
                    {
                        totalResources++;
                        string resolvedUrl = ResolveUrl(href, baseUrl);
                        string filePath = Path.Combine(cssDir, GetFileName(href));
                        var task = DownloadFile(resolvedUrl, filePath).ContinueWith(t =>
                        {
                            if (t.IsCompletedSuccessfully) successfulDownloads++;
                        });
                        downloadTasks.Add(task);
                    }
                }
            }

            // Download JS files
            var scripts = doc.DocumentNode.SelectNodes("//script[@src]");
            if (scripts != null)
            {
                foreach (var script in scripts)
                {
                    string src = script.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(src))
                    {
                        totalResources++;
                        string resolvedUrl = ResolveUrl(src, baseUrl);
                        string filePath = Path.Combine(jsDir, GetFileName(src));
                        var task = DownloadFile(resolvedUrl, filePath).ContinueWith(t =>
                        {
                            if (t.IsCompletedSuccessfully) successfulDownloads++;
                        });
                        downloadTasks.Add(task);
                    }
                }
            }

            // Other resources (fonts, etc.)
            var otherLinks = doc.DocumentNode.SelectNodes("//link[@rel!='stylesheet'][@href]");
            if (otherLinks != null)
            {
                foreach (var link in otherLinks)
                {
                    string href = link.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(href))
                    {
                        totalResources++;
                        string resolvedUrl = ResolveUrl(href, baseUrl);
                        string filePath = Path.Combine(otherDir, GetFileName(href));
                        var task = DownloadFile(resolvedUrl, filePath).ContinueWith(t =>
                        {
                            if (t.IsCompletedSuccessfully) successfulDownloads++;
                        });
                        downloadTasks.Add(task);
                    }
                }
            }

            // Wait for all downloads to complete or timeout after 60 seconds
            await Task.WhenAll(downloadTasks).TimeoutAfter(TimeSpan.FromSeconds(60));
        }

        private string ResolveUrl(string url, string baseUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                    return null;

                // Handle data URLs
                if (url.StartsWith("data:"))
                    return url;

                if (url.StartsWith("http://") || url.StartsWith("https://"))
                    return url;
                else if (url.StartsWith("//"))
                    return new Uri(baseUrl).Scheme + ":" + url;
                else if (url.StartsWith("/"))
                    return new Uri(new Uri(baseUrl), url).ToString();
                else
                    return new Uri(new Uri(baseUrl), url).ToString();
            }
            catch
            {
                // Return original URL if resolution fails
                return url;
            }
        }

        private string GetFileName(string url)
        {
            try
            {
                // Handle data URLs
                if (url.StartsWith("data:"))
                {
                    return "data_" + Guid.NewGuid().ToString().Substring(0, 8);
                }

                string fileName = Path.GetFileName(new Uri(url).AbsolutePath);

                // Clean the filename
                if (string.IsNullOrEmpty(fileName))
                    return "resource_" + Guid.NewGuid().ToString().Substring(0, 8);

                // Remove query parameters if present
                int queryIndex = fileName.IndexOf('?');
                if (queryIndex > 0)
                    fileName = fileName.Substring(0, queryIndex);

                // Replace invalid characters
                foreach (var c in Path.GetInvalidFileNameChars())
                {
                    fileName = fileName.Replace(c, '_');
                }

                return fileName;
            }
            catch
            {
                return "resource_" + Guid.NewGuid().ToString().Substring(0, 8);
            }
        }

        private async Task DownloadFile(string url, string filePath)
        {
            try
            {
                // Skip null URLs and data URLs (they are handled separately)
                if (string.IsNullOrEmpty(url) || url.StartsWith("data:"))
                    return;

                // Create HttpRequestMessage with timeout and headers
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Add("User-Agent", "Mozilla/5.0 Web Browser App");

                // Download with 10 second timeout
                using (var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(10)))
                {
                    var response = await httpClient.SendAsync(request, cts.Token);
                    if (response.IsSuccessStatusCode)
                    {
                        byte[] data = await response.Content.ReadAsByteArrayAsync();
                        File.WriteAllBytes(filePath, data);
                    }
                }
            }
            catch
            {
                // Silently ignore errors for individual resource downloads
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            // Cleanup resources before exit
            if (httpClient != null)
            {
                httpClient.Dispose();
            }
            this.Close();
        }
    }

    // Extension methods
    public static class Extensions
    {
        public static async Task TimeoutAfter(this Task task, TimeSpan timeout)
        {
            if (task == await Task.WhenAny(task, Task.Delay(timeout)))
                await task;
        }
    }
}