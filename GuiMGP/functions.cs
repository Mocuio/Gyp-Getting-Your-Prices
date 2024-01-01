using classes;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using GuiMGP;
using System.Windows.Markup;
using System.Net.NetworkInformation;
using System.Text;
using System.Security.AccessControl;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace ProjectFunctions
{

    internal class Functions
    {
        public Dictionary<string, string> InfoGotByOldDocument = new Dictionary<string, string>();
        public Dictionary<string, string> NewUrlsGetByTextBox = new Dictionary<string, string>();
        public List<string> Dados = new List<string>();
        public string op = "";

        public void GetDocInfo()
        {
            string[] all = File.ReadAllLines("urls.txt");

            foreach (string line in all)
            {
                var lines = line.Split(',');
                InfoGotByOldDocument.Add(lines[0], lines[1]);
            };
        }



        public void WriteCsvDocument()
        {
            CultureInfo cultureInfo = new CultureInfo("pt-BR");
            TextInfo myTI = cultureInfo.TextInfo;
            string data = DateTime.Now.ToString("dddd, dd MMMM yyyy HH-mm-ss", cultureInfo);

            string p1 = @"C:\\Users\\Public\\Desktop\";
            string p2 = myTI.ToTitleCase(data) + ".csv";

            string path = Path.Combine(p1, p2);




            ProductInf productType = new ProductInf();
            List<string> urls = new List<string>();
            var tList = new List<ProductInf>();

            var allLines = File.ReadAllLines("urls.txt");
            using (var writer = new StreamWriter(File.Create(path)))
            using (var write = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                write.WriteRecords("");
            }




            foreach (KeyValuePair<string, string> kvp in InfoGotByOldDocument)
            {
                Console.WriteLine($"{kvp.Key},{kvp.Value}");

                var httpClient = new HttpClient();
                var html = httpClient.GetStringAsync(kvp.Value).Result;
                var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(html);

                var productElement = htmlDocument.DocumentNode.SelectSingleNode("//h1[@class='ui-pdp-title']");
                productType.ProductName = productElement.InnerText.Trim();

                var productElement2 = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='andes-money-amount__fraction']");

                productType.Price = productElement2.InnerText.Trim();

                var productElement3 = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='ui-pdp-color--BLUE ui-pdp-family--REGULAR']");

                productElement3 = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='ui-pdp-color--BLUE ui-pdp-family--REGULAR']");
                productType.Seller = productElement3.InnerText.Trim();

                try
                {

                    // Select the desired element
                    var productElement4 = htmlDocument.DocumentNode.SelectSingleNode("//p[@class='ui-pdp-family--REGULAR ui-pdp-media__title']").InnerText.Trim(); ;

                    // Check if the element exists
                    if (productElement4.ToString().Contains("sem juros"))
                    {
                        productType.AdType = "Anuncio Premium";
                    }
                    else
                    {
                        productType.AdType = "Anuncio Classico";
                    }
                    //Console.WriteLine(productType.AdType);
                }
                catch (Exception)
                {
                    Console.WriteLine("não encontrado");
                }
                //Console.WriteLine($"{productType.ProductName},{productType.Price},{productType.Seller},{productType.AdType}\n
                tList.Add(new ProductInf() { Sku = kvp.Key, ProductName = productType.ProductName, Price = productType.Price, Seller = productType.Seller, AdType = productType.AdType });

                Thread.Sleep(200);



                using (var writer = new StreamWriter(path, false, Encoding.GetEncoding("ISO-8859-1")))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {

                    csv.WriteRecords(tList);

                }

            }
        }

        public void GetClientlinks(string ClientUrls)
        {
            string[] urls = ClientUrls.Split('\n');
            string[] all = File.ReadAllLines("urls.txt");

            if (all.Length > 0)
            {
                foreach (string Allline in all)
                {
                    if (Allline.Length <= 0)
                    {
                        continue;
                    }
                    var line = Allline.Split(',');
                    InfoGotByOldDocument.Add(line[0], line[1]);
                };
            }



            foreach (string urlLine in urls)
            {
                string[] dataLine = urlLine.Split(',');

                try
                {
                    InfoGotByOldDocument.Add(dataLine[0], dataLine[1]);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"An element with Key = \"{dataLine[0]}\" already exists.");
                }
            };

            using (var file = File.CreateText("urls.txt"))
            {
                foreach (KeyValuePair<string, string> kvp in InfoGotByOldDocument)
                {
                    file.WriteLine($"{kvp.Key},{kvp.Value}");
                };
                file.Close();
            }
        }
    }
}



        
   
