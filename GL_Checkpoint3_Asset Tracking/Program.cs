using GL_Checkpoint3_Asset_Tracking;

Console.WriteLine("GL_Checkpoint3_Asset Tracking");
Console.WriteLine("Follow instuctions to enter new product. Press 'Q' to quit.");

DateTime dt1 = new DateTime();
dt1 = DateTime.Now;
List<Asset> Products = new List <Asset> ();

while (true)

{ 
     
    while (true)
    {   
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter a Type of Product");
        string InputType = Console.ReadLine();
        if (InputType.Trim().ToLower() == "q")
        {
            break;
        }

        if (String.IsNullOrEmpty(InputType))
        {
            Console.WriteLine("Incorrect Entry. Data missing");
            continue;
        }

        string InputBrand;
        while (true)                          //while loop needed to make program continue if conditions are not met, to next step product model 
        {
            Console.WriteLine("Enter a Product Brand");
            InputBrand = Console.ReadLine();
            if (InputBrand.Trim().ToLower() == "q")
            {
                break;
            }

            if (String.IsNullOrEmpty(InputBrand))
            {
                Console.WriteLine("Incorrect Entry. Data missing");
            }

            else                               //break commnand to make program continue if conditions are not met, to next step product model 
            {
                break;
            }
        }

        string InputModel;
        while (true)
        {
            Console.WriteLine("Enter a Product Model");
            InputModel = Console.ReadLine();
            if (InputModel.Trim().ToLower() == "q")
            {
                break;
            }

            if (String.IsNullOrEmpty(InputModel))
            {
                Console.WriteLine("Incorrect Entry. Data missing");
            }

            else
            {
                break;
            }
        }


       //DateTime InputDate();
       // while (true)
       //  {
       //     Console.WriteLine("Enter Purchase Date in yyyy-MM-dd format ");
       //     PurchaseDate = Console.ReadLine();
       //     if (PurchaseDate == "q")
       //     {
       //         break;
            //}

            //if (DateTime.IsNullOrEmpty(PurchaseDate))
            //{
            //    Console.WriteLine("Incorrect Entry. Data missing");
          //      continue;
          //  }

          //  //static DateTimeParse (string InputDate);

            
          //}
            
        
       string InputOffice;
          while (true)           
              {
                Console.WriteLine("Enter a Office Location. (USA / Sweden / other EU Country) ");
                InputOffice = Console.ReadLine();
                if (InputOffice.Trim().ToLower() == "q")
                {
                    break;
                }

                if (String.IsNullOrEmpty(InputOffice))
                {
                    Console.WriteLine("Incorrect Entry. Data missing");
                }

                else
                {
                    break;
                }
              }

        //string InputPrice;
        //int value = 0;
        //while (true)
        //{
        //    Console.WriteLine("Enter a Price in USD");
        //    InputPrice = Console.ReadLine;
        //    if (InputPrice.Trim().ToLower() == "q")
        //    {
        //        break;
        //    }

        //    if (String.IsNullOrEmpty(InputPrice))
        //    {
        //        Console.WriteLine("Incorrect Entry. Data missing");
        //        continue;

        //    }

        //    bool Number = int.TryParse(InputPrice, out value);
        //    if (!Number)
        //    {
        //        Console.WriteLine("Incorrect price! Input must be a number");
        //    }
        //    else
        //    {
        //        break;
        //    }
        //}

        string InputCurrency;
        while (true)
          {
            Console.WriteLine("Enter Currency. (US Dollar / SEK / EURO");
            InputCurrency = Console.ReadLine();
            if (InputCurrency.Trim().ToLower() == "q")
            {
                break;
            }

            if (String.IsNullOrEmpty(InputCurrency))
            {
                Console.WriteLine("Incorrect Entry. Data missing");
            }

            else
            {
                break;
            }
          }

        
    if (InputBrand.Trim().ToLower() == "q")
         {
                break;
         }


    if (InputModel.Trim().ToLower() == "q")
         {
                break;
         }


    if (InputOffice.Trim().ToLower() == "q")
         {
                break;
         }

    if (InputCurrency.Trim().ToLower() == "q")
         {
                break;
         }

            //if (InputDate == "q")
            //{
            //    break;
            //}

            //if (InputPrice.Trim().ToLower() == "q")
            //{
            //    break;
            //}

        //static DateTime GetDate(Inputdate)
        //{
        //    return DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        //}

        //double ExchangeRate = new ExchangeRate();
        //if (InputCurrency == "EURO")
        //  {
        //    ExchangeRate = InputPrice * 1.12;

        //  }
        
        //if (InputCurrency == "SEK")
        //  {
        //    ExchangeRate = InputPrice * 0.12;

        //  }
          
        //  else
        //  {
        //    ExchangeRate = InputPrice * 1.00;
        //  }


  Console.WriteLine("Correct Entry!");
  Asset assets = new Asset(InputType, InputBrand, InputModel, InputOffice, InputCurrency);
  Products.Add(assets);
        
}

    //int daysWarning = 913; //Approx 30 months
    //int daysAlarm = 1004;  //Approx 33 months
    //TimeSpan diff = DateTime.Now - purchaseDate;
    //DecideForegroundColor(daysWarning, daysAlarm, diff);

    //static void DecideForegroundColor(int daysWarning, int daysAlarm, TimeSpan diff)
    //  {
    //    if (diff.Days > daysAlarm)
    //    {
    //        Console.ForegroundColor = ConsoleColor.Red;
    //    }
    //    else if (diff.Days > daysWarning)
    //    {
    //        Console.ForegroundColor = ConsoleColor.Yellow;
    //    }
    //    else
    //    {
    //        Console.ForegroundColor = ConsoleColor.White;
    //    }

    //  }


  List<Asset> SortedAssetsByType = Products.OrderBy(assets => assets.Type).ToList();
    Console.WriteLine("Type".PadRight(20) + "Brand".PadRight(20) + "Model".PadRight(20) + "Office".PadRight(20) + "Currency".PadRight(20) +
        "Price in USD".PadRight(20) + "Local Price".PadRight(20) + "Purchase Date".PadRight(20));

    Console.WriteLine(
        "----".PadRight(20) +
        "-----".PadRight(20) +
        "------".PadRight(20) +
        "-------".PadRight(20) +
        "--------".PadRight(20) +
        "------------".PadRight(20) +
        "-------------".PadRight(20) +
        "-----------------".PadRight(20);

    foreach (Asset assets in SortedAssetsByType)
    {
        Console.WriteLine(assets.Type.PadRight(20) + assets.Brand.PadRight(20) + assets.Model.PadRight(20) + 
            assets.Office.PadRight(20) + assets.Currency.PadRight(20));
    }

    Console.WriteLine("Press enter to continue or 'q' to exit");
    string answer = Console.ReadLine();
    if (answer.ToLower().Trim() == "q")
    {
        break;
    }

}

Console.ReadLine();


 
 

