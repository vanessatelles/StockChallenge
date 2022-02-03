﻿using System;
using System.Configuration;
using System.Globalization;

namespace StockAlert
{
    class Principal 
    {
        static void Main(string[] args)
        {
            string _chosenStock = args[0];
            float _salePrice = float.Parse(args[1], CultureInfo.InvariantCulture.NumberFormat);
            float _purchasePrice = float.Parse(args[2], CultureInfo.InvariantCulture.NumberFormat);            

            EmailMessage msg = new EmailMessage();
            msg.Message = ConfigurationManager.AppSettings["sale"] + _chosenStock;
            StockData stockData = new StockData();
            stockData.GetData();

            //msg.SendMessage();
            //Console.WriteLine(msg.Message);

        }
    }

}