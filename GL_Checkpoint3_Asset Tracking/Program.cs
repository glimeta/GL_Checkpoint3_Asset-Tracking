Console.WriteLine("GL_Checkpoint3_Asset Tracking");
Console.WriteLine("Follow instuctions to enter new product. Press 'Q' to quit.");

DateTime dt1 = new DateTime();
dt1 = DateTime.Now;
List<Attribute> Products = new List<Attribute>();

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

        string InputOffice;
        while (true)
        {
            Console.WriteLine("Enter a Product Model");
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

        string InputCurrency;
        while (true)
        {
            Console.WriteLine("Enter a Product Model");
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


        string InputPrice;       
        int value = 0;
        while (true)
        {
            Console.WriteLine("Enter a Price in USD");      
            if (dataPrice.Trim().ToLower() == "q")
            {
                break;
            }

            if (String.IsNullOrEmpty(InputPrice))
            {
                Console.WriteLine("Incorrect Entry. Data missing");
                continue;

            }

            bool Number = int.TryParse(InputPrice, out value);
            if (!Number)
            {                                                                 
                Console.WriteLine("Incorrect price! Input must be a number");
            }
            else
            {
                break;
            }


            DateTime InputPurchaseDate;
            int value = 0;
            while (true)
            {
                Console.WriteLine("Enter Purchase Date in yyyy-MM-dd format ");
                InputPurchaseDate = Console.ReadLine();

                if (InputPurchaseDate.Trim().ToLower() == "q")
                {
                    break;
                }

                if (DateTime.IsNullOrEmpty(InputPurchaseDate))
                {
                    Console.WriteLine("Incorrect Entry. Data missing");
                    continue;

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

        if (InputPurchaseDate.Trim().ToLower() == "q")
            {
                break;
            }

        if (InputPrice.Trim().ToLower() == "q")
            {
                break;
            }


        Console.WriteLine("Correct Entry!");
       // Attribute item = new Attribute(InputType, InputBrand, value);
        Products.Add(item);
    }

    Console.WriteLine("-----------");
    Console.WriteLine("you have entered following products ");

        static void PrintHeader()
    Console.WriteLine(
        Tab("Type") +
        Tab("Brand") +
        Tab("Model") +
        Tab("Office") +
        Tab("Purchase Date") +
        Tab("Price in USD") +
        Tab("Currency") +
        Tab("Local price today")
        );
        Console.WriteLine(
            Tab("----") +
            Tab("-----") +
            Tab("-----") +
            Tab("------") +
            Tab("-------------") +
            Tab("------------") +
            Tab("--------") +
            Tab("-----------------")
            );

    }

    Console.ReadLine();


