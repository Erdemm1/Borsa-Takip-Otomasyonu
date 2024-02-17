using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace HalkaArzTakip7
{
    public partial class Borsa : Form
    {
        private const string baseUrl = "https://uzmanpara.milliyet.com.tr/borsa/hisse-fiyatlari/";
        private List<HisseFiyati> allHisseFiyatlari = new List<HisseFiyati>();
        private HashSet<string> displayedSymbols = new HashSet<string>();

        public Borsa()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 15 * 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await FetchAndDisplayDataAsync(ListNews);
        }

        private async void BtnVeriCek_Click(object sender, EventArgs e)
        {
            await FetchAndDisplayDataAsync(ListNews);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchedSymbol = txtSearch.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(searchedSymbol))
            {
                MessageBox.Show("Lütfen bir sembol girin.", "Uyarı");
                return;
            }

            ListNews2.Items.Clear();
            displayedSymbols.Clear(); // Yeni arama için displayedSymbols setini temizle
            DisplaySearchedSymbol(searchedSymbol);
        }

        private async Task FetchAndDisplayDataAsync(ListBox listBox)
        {
            listBox.Items.Clear();

            int pageCount = await GetPageCount();

            for (int pageNum = 1; pageNum <= pageCount; pageNum++)
            {
                string pageUrl = $"{baseUrl}?Pagenum={pageNum}&hisse=-1&seans=gun&sektor=-1&Harf=-1";
                List<HisseFiyati> currentPageData = await GetHisseFiyatlariAsync(pageUrl);

                foreach (var hisse in currentPageData)
                {
                    if (displayedSymbols.Add(hisse.HisseKodu))
                    {
                        allHisseFiyatlari.Add(hisse);
                        listBox.Items.Add($"{hisse.HisseKodu}: {hisse.SonFiyat} TL");
                    }
                }
            }
        }

        private async Task<List<HisseFiyati>> GetHisseFiyatlariAsync(string url)
        {
            List<HisseFiyati> hisseFiyatlari = new List<HisseFiyati>();

            string htmlContent = await GetHtmlContentAsync(url);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);

            HtmlNode tableNode = doc.DocumentNode.SelectSingleNode("//div[@class='box box7']//table[@class='table3 table4']");

            if (tableNode != null)
            {
                foreach (HtmlNode row in tableNode.SelectNodes("tbody/tr"))
                {
                    HtmlNodeCollection columns = row.SelectNodes("td");

                    if (columns != null && columns.Count >= 9)
                    {
                        string hisseKodu = columns[0].InnerText.Trim();
                        string sonFiyat = columns[1].InnerText.Trim();

                        hisseFiyatlari.Add(new HisseFiyati
                        {
                            HisseKodu = hisseKodu,
                            SonFiyat = sonFiyat
                        });
                    }
                }
            }

            return hisseFiyatlari;
        }

        private async Task<int> GetPageCount()
        {
            string htmlContent = await GetHtmlContentAsync(baseUrl);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);

            HtmlNodeCollection pageNodes = doc.DocumentNode.SelectNodes("//div[@class='pager']//li/a");

            int lastPageNum = 1;
            foreach (var pageNode in pageNodes)
            {
                if (int.TryParse(pageNode.InnerText.Trim(), out int pageNum))
                {
                    lastPageNum = Math.Max(lastPageNum, pageNum);
                }
            }

            return lastPageNum;
        }

        private async Task<string> GetHtmlContentAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        private void DisplayHisseFiyatlari(ListBox listBox, List<HisseFiyati> hisseFiyatlari)
        {
            listBox.Items.Clear();

            foreach (var hisse in hisseFiyatlari)
            {
                listBox.Items.Add($"{hisse.HisseKodu}: {hisse.SonFiyat} TL");
            }
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            HalkaArzForm form = new HalkaArzForm();
            this.Hide();
            form.Show();
        }

        private void TxtUri_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplaySearchedSymbol(string searchedSymbol)
        {
            var searchResults = allHisseFiyatlari
                .FindAll(hisse => hisse.HisseKodu.Contains(searchedSymbol));

            DisplayHisseFiyatlari(ListNews2, searchResults);
        }
    }

    public class HisseFiyati
    {
        public string HisseKodu { get; set; }
        public string SonFiyat { get; set; }
    }
}
