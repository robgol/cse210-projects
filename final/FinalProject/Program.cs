using System;
using System.Text.Json;
using System.Text.Json.Serialization;
class Program
{
    static void Main(string[] args)
    {

        int option = 0;

        do
        {
            option = Helper.DisplayMenu(Helper.mainMenu, Helper.mainMenuMsg);

            switch (option)
            {
                case 1:
                    Aircraft.ManageAircraft();
                    break;
                case 2:
                    Flight.ManageRoutes();
                    break;
                case 3:
                    Operation.ManageOperation();
                    break;


                default: break;
            }


        } while (option != 4);

    }
}