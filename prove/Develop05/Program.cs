using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        User user = new User();

        do
        {
            Helper.ShowMenuOptions("Menu Options", Helper.menu);
            Console.Write("Select a choice from menu: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    user.CreateGoal();
                    break;
                case 2:
                    user.DisplayGoals();
                    break;

                case 3:
                    user.Save();
                    break;

                case 4:
                    user.Load();
                    break;

                case 5:
                    user.RecordEvent();
                    break;


                default: break;
            }
            
        } while (option != 6);
    }
}