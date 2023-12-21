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

namespace ProjectFunctions
{

    internal class Functions
    {
        public Dictionary<string, string> Info = new Dictionary<string, string>();
        public List<string> Dados = new List<string>();
        public string op = "";
        public string filePath = "";


        public void GetTxtPath()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Text|*.txt|All|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
          
            {
                return;
            }

                filePath = openFileDialog1.FileName;
        }

        public void GetDocInfo()
        {
            string[] all = File.ReadAllLines(filePath);

            foreach (string line in all)
            {
                var lines = line.Split(',');
                Info.Add(lines[0], lines[1]);
            };
        }


        
        public void WriteCsvDocument()
        {
            
          
            ProductInf productType = new ProductInf();
            List<string> urls = new List<string>();
            var tList = new List<ProductInf>();
            
            var allLines = File.ReadAllLines(filePath);
        
            foreach (KeyValuePair<string, string> kvp in Info)
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

                //Console.WriteLine($"{productType.ProductName},{productType.Price},{productType.Seller},{productType.AdType}\n");


                tList.Add(new ProductInf() { Sku = kvp.Key,ProductName = productType.ProductName, Price = productType.Price, Seller = productType.Seller, AdType = productType.AdType });

                Thread.Sleep(200);
                using (var writer = new StreamWriter(@"C:\Users\rafael\source\repos\GuiMGP\GuiMGP\Tabela.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                 
                    csv.WriteRecords(tList);

                }
                
            }
        }

        public void GetClientlinks()
        {
            Form3 form3 = new Form3();
            

            var all = File.ReadAllLines(filePath);

            foreach(var line in all)
            {
                Dados.Add(line);
            }

            foreach (var item in Dados)
            {
                string[] data = item.Split(',');

                try
                {
                    Info.Add(data[0], data[1]);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Um produto com o Sku = {data[0]} Já foi adicionado");

                };

            }

            Console.WriteLine("\n\n");

            foreach (KeyValuePair<string, string> kvp in Info)
            {
                Console.WriteLine($"{kvp.Key},{kvp.Value}");
            };
            using (var file = File.CreateText(@"C:\Users\rafael\source\repos\GuiMGP\GuiMGP\urls.txt"))
            {
                foreach (KeyValuePair<string, string> kvp in Info)
                {
                    file.WriteLine($"{kvp.Key},{kvp.Value}");// Substitui o conteúdo do arquivo com este texto
                };

                file.Close();
                Console.WriteLine("\ngostaria de refazer o processo ? ");
                op = Console.ReadLine();
            }
        }   
    }
} 


        
   
