using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace prjLockStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }

        
        public static  void Welcome()
        {
            Console.Clear(); //clears the console
            Console.WriteLine("Welcome To Lock Stock & Barrel\nPress\n1- Add Stock\n2- Sale\n3- View Stock\n99 to exit\n");   
            try
            {
                int input = Convert.ToInt32(Console.ReadLine()); //copnverts string to int
                Choice(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("You didnt insert an int number!!!\n\n\n");
                Console.ReadLine();
                Welcome();
               
                
            }
           
        }

        public static void Choice(int input)
        {
               switch(input)
               {
                   case 1: addStock();
                       break;
                   case 2: sellStock();
                       break;
                   case 3: displayStock();
                       break;
                   case 99:
                       Environment.Exit(0);
                       break;
                   default: Console.WriteLine("You didnt insert a number which you had to select from selction\n");
                       Console.ReadLine(); Welcome();
                       break;

               }
               
        }

        public static void displayStock()
        {
            Console.Clear();
            Console.WriteLine("View Stock\n1- Keys\n2- Remotes\n3- Batteries\n4- Locks\n5- Shop\n6- Repairs\n7 - back to home page");
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 0 && input < 8) //makes it so only these numbers can selected
                {
                    switch (input)
                    {
                        case 1: displayKeys();
                            break;
                        case 2: displayRemotes();
                            break;
                        case 3: displayBatteries();
                            break;
                        case 4: displayLocks();
                            break;
                        case 5: displayShop();
                            break;
                        case 6: displayRepairs();
                            break;
                        case 7: Welcome();
                            break;
                    }
                }
                else
                {

                    Console.WriteLine("You didnt insert a number which you had to select from selction\n");
                    Console.ReadLine();
                    displayStock();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("You didnt insert an int number!!!\n\n\n");
                Console.ReadLine();
               displayStock();
            }

        }

        public static void displayKeys()
        {
             Console.Clear();
             try
             {
                 StreamReader sr = new StreamReader("keys.txt"); //opens up keys.txt
                 Console.WriteLine("_________________");
                 Console.WriteLine("|Keys\t|Stock\t|"); //formatting text
                 string line = sr.ReadLine(); 
                 while (line != null)
                 {
                     string[] temp = line.Split(',');
                     Console.WriteLine("_________________");//formatting text
                     Console.WriteLine("|" + temp[0] + "\t|" + temp[1] + "\t|");//formatting text
                     line = sr.ReadLine();
                 }
                 sr.Close();
                 Console.WriteLine("_________________");//formatting text
                
                 Console.ReadLine();
                 displayStock();
             }
            catch(Exception e)
             {
                 Console.WriteLine("Problem with text file");
                 Console.ReadLine();
             }
        }

        public static void displayBatteries()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("batteries.txt");//opens up batteries.txt
                Console.WriteLine("_________________________");
                Console.WriteLine("|Batteries\t|Stock\t|");//formatting text
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] temp = line.Split(',');
                    Console.WriteLine("_________________________");//formatting text
                    Console.WriteLine("|" + temp[0] + "\t\t|" + temp[1] + "\t|");//formatting text
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("_________________________");//formatting text

                Console.ReadLine();
                displayStock();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem with text file");
                Console.ReadLine();
            }
        }

        public static void displayShop ()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("shop.txt"); //opens up shop.txt
                Console.WriteLine("_________________________"); //formatting text
                Console.WriteLine("|Shop\t\t|Stock\t|");//formatting text
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] temp = line.Split(',');
                    if (temp[0].Length < 6) //formatting text cause some words are longer than others
                    {
                        Console.WriteLine("_________________________"); //formatting text
                        Console.WriteLine("|" + temp[0] + "\t\t|" + temp[1] + "\t|"); //formatting text
                    }
                    else
                    {
                        Console.WriteLine("_________________________"); //formatting text
                        Console.WriteLine("|" + temp[0] + "\t|" + temp[1] + "\t|"); //formatting text
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("_________________________"); //formatting text

                Console.ReadLine();
                displayStock();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem with text file");
                Console.ReadLine();
            }
        }
        public static void displayRepairs()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("repairs.txt"); //opening repairs.txt
                Console.WriteLine("_________________________"); //formatting text
                Console.WriteLine("|Repairs\t|Stock\t|"); //formatting text
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] temp = line.Split(',');
                    Console.WriteLine("_________________________"); //formatting text
                    Console.WriteLine("|" + temp[0] + "\t\t|" + temp[1] + "\t|"); //formatting text
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("_________________________"); //formatting text

                Console.ReadLine();
                displayStock();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem with text file");
                Console.ReadLine();
            }
        }

        public static void displayRemotes()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("Remotes.txt"); //opens remotes.txt
                Console.WriteLine("_________________________"); //formatting text
                Console.WriteLine("|Remotes\t|Stock\t|"); //formatting text
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] temp = line.Split(',');
                    Console.WriteLine("_________________________"); //formatting text
                    Console.WriteLine("|" + temp[0] + "\t|" + temp[1] + "\t|"); //formatting text
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("_________________________"); //formatting text

                Console.ReadLine();
                displayStock();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem with text file");
            }
        }
        public static void displayLocks()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("locks.txt"); //opens locks.txt
                Console.WriteLine("_________________________"); //formatting text
                Console.WriteLine("|locks\t\t|Stock\t|"); //formatting text
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] temp = line.Split(',');
                    Console.WriteLine("_________________________"); //formatting text
                    Console.WriteLine("|" + temp[0] + "\t|" + temp[1] + "\t|"); //formatting text
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("_________________________"); //formatting text

                Console.ReadLine();
                displayStock();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem with text file");
                Console.ReadLine();
            }
        }
        public static void addStock()
        {
            Console.Clear();
            Console.WriteLine("Add Stock\n1- Keys\n2- Remotes\n3- Batteries\n4- Locks\n5- Shop\n6- Repairs\n7 - back to home page");
             int input=0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input>0&&input<8) //makes it so only numbers from 1 - 7 can be chosen
                {
                    switch(input)
                    {
                        case 1:addKeys();
                             break;
                        case 2: addRemotes();
                             break;
                        case 3: addBatteries();
                             break;
                        case 4: addLocks();
                             break;
                        case 5: addShop();
                             break;
                        case 6: addRepairs();
                             break;
                        case 7: Welcome();
                             break;
                    }
                }
                else {
                   
                    Console.WriteLine("You didnt insert a number which you had to select from selction\n");
                    Console.ReadLine();
                    addStock();
                }
                  
               
            }
            catch (Exception e)
            {
                Console.WriteLine("You didnt insert an int number!!!\n\n\n");
                Console.ReadLine();
                addStock();
            }

 
        }

        public static void sellStock()
        {
            Console.Clear();
            Console.WriteLine("Sell Stock\n1- Keys\n2- Remotes\n3- Batteries\n4- Locks\n5- Shop\n6- Repairs\n7 - back to home page");
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 0 && input < 8) //makes it so only numbers from 1 - 7 can be chosen
                {
                    switch (input)
                    {
                        case 1:sellKeys();
                            break;
                        case 2: sellRemotes();
                            break;
                        case 3: sellBatteries();
                            break;
                        case 4: sellLocks();
                            break;
                        case 5: sellShop();
                            break;
                        case 6: sellRepairs();
                            break;
                        case 7: Welcome();
                            break;
                    }
                }
                else
                {

                    Console.WriteLine("You didnt insert a number which you had to select from selction\n");
                    Console.ReadLine();
                    addStock();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("You didnt insert an int number!!!\n\n\n");
                Console.ReadLine();
                addStock();
            }
        }

        public static void addKeys()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("keys.txt"); //opens keys.txt
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts how many items in txt file
                    line = sr.ReadLine();
                }
                sr.Close();
                string[,] keys = new string[cnt,3];

                StreamReader s = new StreamReader("keys.txt"); //opens keys.txt
                int cn = 0;
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
    
                    keys[cn, 0] = temp[0]; //this is the name of the stock
                    keys[cn, 1] = temp[1]; //this is the stock of the item
                    keys[cn, 2] = temp[2]; //this is the price for the item
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to add stock to\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, keys[i, 0]);
                }
                Console.WriteLine("{0}- Back to add stock", cn + 1);

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        addStock();
                    }

                    if (input > 0 && input <= cnt)
                    {
                        Console.WriteLine("How much stock of {0} would like to add", keys[input-1,0]);
                        int ad = Convert.ToInt32(Console.ReadLine());
                        if (ad > 0)
                        {


                            int tot = Convert.ToInt32(keys[input - 1, 1]) + ad;
                            keys[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("keys.txt")) //opens up keys.txt
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(keys[i, 0] + "," + keys[i, 1] + "," + keys[i, 2]); //writing to the txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                addStock();
                            }
                        }
                        else{
                            Console.WriteLine("You didnt insert a positive number to add stock by");
                            Console.ReadLine();
                            addKeys();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        addKeys();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    addKeys();
                }
  



            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }
           

        }


        public static void addRemotes()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("remotes.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    cnt++;
                }
                sr.Close();
                string[,] remotes = new string[cnt, 3];

                StreamReader s = new StreamReader("remotes.txt");
                int cn = 0;
                string lin = s.ReadLine();
                while (lin != null)
                { 
                    string[] temp = lin.Split(',');
                    remotes[cn, 0] = temp[0];
                    remotes[cn, 1] = temp[1];
                    remotes[cn, 2] = temp[2];
                    lin = s.ReadLine();
                    cn++;
                }
                s.Close();
                Console.WriteLine("What would you like to add stock to\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, remotes[i, 0]);
                }
                Console.WriteLine("{0}- Back to add stock", cn+1);
               
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input== cnt + 1)
                    {
                        addStock();
                    }

                    if (input > 0 && input <= cnt+1)
                    {
                        Console.WriteLine("How much stock of {0} would like to add", remotes[input - 1, 0]);
                        int ad = Convert.ToInt32(Console.ReadLine());
                        if (ad > 0)
                        {
                            int tot = Convert.ToInt32(remotes[input - 1, 1]) + ad;
                            remotes[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("remotes.txt"))
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(remotes[i, 0] + "," + remotes[i, 1] + "," + remotes[i, 2]);
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                addStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a positive number to add stock by");
                            Console.ReadLine();
                            addRemotes();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        addRemotes();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    addRemotes();
                }




            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }
        }

        public static void addBatteries()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("batteries.txt"); //opens up txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    cnt++; //counts how many items in txt file
                }
                sr.Close();
                string[,] batteries = new string[cnt, 3];

                StreamReader s = new StreamReader("batteries.txt"); //opens up txt file
                int cn = 0;

                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    batteries[cn, 0] = temp[0];
                    batteries[cn, 1] = temp[1];
                    batteries[cn, 2] = temp[2];
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to add stock to\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, batteries[i, 0]);
                }
                Console.WriteLine("{0}- Back to add stock", cn + 1);

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        addStock();
                    }

                    if (input > 0 && input <= cnt + 1)
                    {
                        Console.WriteLine("How much stock of {0} would like to add", batteries[input - 1, 0]);
                        int ad = Convert.ToInt32(Console.ReadLine());
                        if (ad > 0)
                        {
                            int tot = Convert.ToInt32(batteries[input - 1, 1]) + ad;
                            batteries[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("batteries.txt")) //opens up txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(batteries[i, 0] + "," + batteries[i, 1] + "," + batteries[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                addStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a positive number to add stock by");
                            Console.ReadLine();
                            addBatteries();
                        }

                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        addBatteries();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    addBatteries();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }
        }
        
        public static void addLocks()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("locks.txt"); //opens up txt files
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    cnt++; //counts how many items in the txt file
                }
                sr.Close();
                string[,] locks = new string[cnt, 3];

                StreamReader s = new StreamReader("locks.txt"); //opens up txt file
                int cn = 0;

                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    locks[cn, 0] = temp[0]; //this is the name of the product
                    locks[cn, 1] = temp[1]; //this is the price of the product
                    locks[cn, 2] = temp[2]; //this is the price of the product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to add stock to\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, locks[i, 0]);
                }
                Console.WriteLine("{0}- Back to add stock", cn + 1);
                
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        addStock();
                    }

                    if (input > 0 && input <= cnt + 1)
                    {
                        Console.WriteLine("How much stock of {0} would like to add", locks[input - 1, 0]);
                        int ad = Convert.ToInt32(Console.ReadLine());
                        if (ad > 0)
                        {
                            int tot = Convert.ToInt32(locks[input - 1, 1]) + ad;
                            locks[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("locks.txt")) //opens up txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(locks[i, 0] + "," + locks[i, 1] + "," + locks[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                addStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a positive number to add stock by");
                            Console.ReadLine();
                            addLocks();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        addLocks();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    addLocks();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }
        }

        public static void addShop()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("shop.txt"); //opens up txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    cnt++;
                }
                sr.Close();
                string[,] shop = new string[cnt, 3];

                StreamReader s = new StreamReader("shop.txt"); //opens up txt file
                int cn = 0;

                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    shop[cn, 0] = temp[0]; //this is the name of product
                    shop[cn, 1] = temp[1]; //this is thhe stock of the product
                    shop[cn, 2] = temp[2]; //this is the price of the product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to add stock to\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, shop[i, 0]);
                }
                Console.WriteLine("{0}- Back to add stock", cn + 1);

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        addStock();
                    }

                    if (input > 0 && input <= cnt + 1)
                    {
                        Console.WriteLine("How much stock of {0} would like to add", shop[input - 1, 0]);
                        int ad = Convert.ToInt32(Console.ReadLine());
                        if (ad > 0)
                        {

                            int tot = Convert.ToInt32(shop[input - 1, 1]) + ad;
                            shop[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("shop.txt")) //opens up txt fil to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(shop[i, 0] + "," + shop[i, 1] + "," + shop[i, 2]); //writes to file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                addStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a positive number to add stock by");
                            Console.ReadLine();
                            addShop();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        addShop();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    addShop();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }
        }

        public static void addRepairs()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("repairs.txt"); //opens up the txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    cnt++; //counts how many items 
                }
                sr.Close();
                string[,] repairs= new string[cnt, 3];

                StreamReader s = new StreamReader("repairs.txt"); //opens up the txt file
                int cn = 0;

                string lin = s.ReadLine();
                
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    repairs[cn, 0] = temp[0]; //name of product
                    repairs[cn, 1] = temp[1]; //stock of product
                    repairs[cn, 2] = temp[2]; //price of product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to add stock to\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, repairs[i, 0]);
                }
                Console.WriteLine("{0}- Back to add stock", cn + 1);
               
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        addStock();
                    }

                    if (input > 0 && input <= cnt + 1)
                    {
                        Console.WriteLine("How much stock of {0} would like to add", repairs[input - 1, 0]);
                        int ad = Convert.ToInt32(Console.ReadLine());
                        if (ad > 0)
                        {

                            int tot = Convert.ToInt32(repairs[input - 1, 1]) + ad;
                            repairs[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("repairs.txt")) //opens up the txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(repairs[i, 0] + "," + repairs[i, 1] + "," + repairs[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                addStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a positive number to add stock by");
                            Console.ReadLine();
                            addRepairs();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        addRepairs();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    addRepairs();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }

        }



        public static void sellKeys()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("keys.txt"); //opens up txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts how many items
                    line = sr.ReadLine();
                }
                sr.Close();
                string[,] keys = new string[cnt, 3];

                StreamReader s = new StreamReader("keys.txt"); //opens up txt files
                int cn = 0;
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');

                    keys[cn, 0] = temp[0]; //this is the name of the product
                    keys[cn, 1] = temp[1]; //this is the stock of the product
                    keys[cn, 2] = temp[2]; //this is the price of the product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to buy\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, keys[i, 0]);
                }
                Console.WriteLine("{0}- Back to sell stock", cn + 1);

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        sellStock();
                    }
                    

                    if (input > 0 && input <= cnt)
                    {
                        Console.WriteLine("How much of {0} would you like to buy", keys[input - 1, 0]);
                        int sub = Convert.ToInt32(Console.ReadLine());
                        if (sub > 0)
                        {
                           
                            if ((Convert.ToInt32(keys[input - 1, 1])-sub)<0)
                            {
                                Console.WriteLine("We currently dont have that much stock");
                                Console.ReadLine();
                                sellKeys();
                            }
                            Console.WriteLine("That will cost {0:c}", Convert.ToInt32(keys[input-1, 2])*sub);
                            int tot = Convert.ToInt32(keys[input - 1, 1]) - sub;
                            keys[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("keys.txt")) //opens up txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(keys[i, 0] + "," + keys[i, 1] + "," + keys[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                sellStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a negative number to subtract stock by");
                            Console.ReadLine();
                            sellKeys();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        sellKeys();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    sellKeys();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }

        }   
        public static void sellRemotes()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("remotes.txt"); //opens up txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++;//counts how many items
                    line = sr.ReadLine();
                }
                sr.Close();
                string[,] remotes = new string[cnt, 3];

                StreamReader s = new StreamReader("remotes.txt"); //opens up txt file
                int cn = 0;
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');

                    remotes[cn, 0] = temp[0]; //name of product
                    remotes[cn, 1] = temp[1]; //stock of product
                    remotes[cn, 2] = temp[2]; //price of product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to buy\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, remotes[i, 0]);
                }
                Console.WriteLine("{0}- Back to sell stock", cn + 1);
              
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input== cnt + 1)
                    {
                        sellStock();
                    }

                    if (input > 0 && input <= cnt)
                    {
                        Console.WriteLine("How much of {0} would you like to buy", remotes[input - 1, 0]);
                        int sub = Convert.ToInt32(Console.ReadLine());
                        if (sub > 0)
                        {

                            if ((Convert.ToInt32(remotes[input - 1, 1]) - sub) < 0)
                            {
                                Console.WriteLine("We currently dont have that much stock");
                                Console.ReadLine();
                                sellRemotes();
                            }
                            Console.WriteLine("That will cost {0:c}", Convert.ToInt32(remotes[input - 1, 2]) * sub);
                            int tot = Convert.ToInt32(remotes[input - 1, 1]) - sub;
                            remotes[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("remotes.txt")) //opens up txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(remotes[i, 0] + "," + remotes[i, 1] + "," + remotes[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                sellStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a negative number to subtract stock by");
                            Console.ReadLine();
                            sellRemotes();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        sellRemotes();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    sellRemotes();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }
        }

        public static void sellBatteries()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("batteries.txt"); //opens up txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts how many items
                    line = sr.ReadLine();
                }
                sr.Close();
                string[,] batteries = new string[cnt, 3];

                StreamReader s = new StreamReader("batteries.txt"); //opens up txt file
                int cn = 0;
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');

                    batteries[cn, 0] = temp[0]; //this it the name of the product
                    batteries[cn, 1] = temp[1]; //this is the stock of the product
                    batteries[cn, 2] = temp[2]; //this is the price of the product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to buy\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, batteries[i, 0]);
                }
                Console.WriteLine("{0}- Back to sell stock", cn + 1);
               
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input== cnt + 1)
                    {
                        sellStock();
                    }

                    if (input > 0 && input <= cnt)
                    {
                        Console.WriteLine("How much of {0} would you like to buy", batteries[input - 1, 0]);
                        int sub = Convert.ToInt32(Console.ReadLine());
                        if (sub > 0)
                        {

                            if ((Convert.ToInt32(batteries[input - 1, 1]) - sub) < 0)
                            {
                                Console.WriteLine("We currently dont have that much stock");
                                Console.ReadLine();
                                sellBatteries();
                            }
                            Console.WriteLine("That will cost {0:c}", Convert.ToInt32(batteries[input - 1, 2]) * sub);
                            int tot = Convert.ToInt32(batteries[input - 1, 1]) - sub;
                            batteries[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("batteries.txt")) //opens txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(batteries[i, 0] + "," + batteries[i, 1] + "," + batteries[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                sellStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a negative number to subtract stock by");
                            Console.ReadLine();
                            sellBatteries();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        sellBatteries();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    sellBatteries();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem with text file");
                Console.ReadLine();
            }
        }

        public static void sellRepairs()
        {

            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("repairs.txt"); //opens txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++;//counts how many items
                    line = sr.ReadLine();
                }
                sr.Close();
                string[,] repairs = new string[cnt, 3];

                StreamReader s = new StreamReader("repairs.txt"); //opens up txt file
                int cn = 0;
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');

                    repairs[cn, 0] = temp[0]; //this is the name of product
                    repairs[cn, 1] = temp[1]; //this is the stock of product
                    repairs[cn, 2] = temp[2]; //this is the price of product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to buy\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, repairs[i, 0]);
                }
                Console.WriteLine("{0}- Back to sell stock",cn+1);
              
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        sellStock();
                    }

                    if (input > 0 && input<= cnt)
                    {
                        Console.WriteLine("How much of {0} would you like to buy", repairs[input - 1, 0]);
                        int sub = Convert.ToInt32(Console.ReadLine());
                        if (sub > 0)
                        {

                            if ((Convert.ToInt32(repairs[input - 1, 1]) - sub) < 0)
                            {
                                Console.WriteLine("We currently dont have that much stock");
                                Console.ReadLine();
                                sellRepairs();
                            }
                            Console.WriteLine("That will cost {0:c}", Convert.ToInt32(repairs[input - 1, 2]) * sub);
                            int tot = Convert.ToInt32(repairs[input - 1, 1]) - sub;
                            repairs[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("repairs.txt")) //opens up txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(repairs[i, 0] + "," + repairs[i, 1] + "," + repairs[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                sellStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a negative number to subtract stock by");
                            Console.ReadLine();
                            sellRepairs();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        sellRepairs();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    sellRepairs();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem with text file");
                Console.ReadLine();
            }

        }

        public static void sellShop()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("shop.txt"); //opens up txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts how many items
                    line = sr.ReadLine();
                }
                sr.Close();
                string[,] shop = new string[cnt, 3];

                StreamReader s = new StreamReader("shop.txt"); //opens up txt file 
                int cn = 0;
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');

                    shop[cn, 0] = temp[0]; //this is the name of the product
                    shop[cn, 1] = temp[1]; //this is stock of the product
                    shop[cn, 2] = temp[2]; //this the price of the product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to buy\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, shop[i, 0]);
                }
                Console.WriteLine("{0}- Back to sell stock", cn + 1);
               
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        sellStock();
                    }
                    if (input > 0 && input <= cnt)
                    {
                        Console.WriteLine("How much of {0} would you like to buy", shop[input - 1, 0]);
                        int sub = Convert.ToInt32(Console.ReadLine());
                        if (sub > 0)
                        {

                            if ((Convert.ToInt32(shop[input - 1, 1]) - sub) < 0)
                            {
                                Console.WriteLine("We currently dont have that much stock");
                                Console.ReadLine();
                                sellShop();
                            }
                            Console.WriteLine("That will cost {0:c}", Convert.ToInt32(shop[input - 1, 2]) * sub);
                            int tot = Convert.ToInt32(shop[input - 1, 1]) - sub;
                            shop[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("shop.txt")) //opens up txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(shop[i, 0] + "," + shop[i, 1] + "," + shop[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                sellStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a negative number to subtract stock by");
                            Console.ReadLine();
                            sellShop();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        sellShop();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    sellShop();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }
        }

        public static void sellLocks()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("locks.txt"); //opens up txt file
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts items
                    line = sr.ReadLine();
                }
                sr.Close();
                string[,] locks = new string[cnt, 3];

                StreamReader s = new StreamReader("locks.txt"); //oens up txt file
                int cn = 0;
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');

                    locks[cn, 0] = temp[0]; //this is the name of product
                    locks[cn, 1] = temp[1]; //this is the stock of product
                    locks[cn, 2] = temp[2]; //this is the price of product
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
                Console.WriteLine("What would you like to buy\n");
                for (int i = 0; i < cnt; i++)
                {
                    Console.WriteLine("{0}- {1}\n", i + 1, locks[i, 0]);
                }
                Console.WriteLine("{0}- Back to sell stock", cn + 1);
               
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == cnt + 1)
                    {
                        sellStock();
                    }

                    if (input > 0 && input <= cnt)
                    {
                        Console.WriteLine("How much of {0} would you like to buy", locks[input - 1, 0]);
                        int sub = Convert.ToInt32(Console.ReadLine());
                        if (sub > 0)
                        {

                            if ((Convert.ToInt32(locks[input - 1, 1]) - sub) < 0)
                            {
                                Console.WriteLine("We currently dont have that much stock");
                                Console.ReadLine();
                                sellLocks();
                            }
                            Console.WriteLine("That will cost {0:c}", Convert.ToInt32(locks[input - 1, 2]) * sub);
                            int tot = Convert.ToInt32(locks[input - 1, 1]) - sub;
                            locks[input - 1, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("locks.txt")) //opens up txt file to write to
                            {
                                for (int i = 0; i < cn; i++)
                                {
                                    writer.WriteLine(locks[i, 0] + "," + locks[i, 1] + "," + locks[i, 2]); //writes to txt file
                                }
                                writer.Close();
                                Console.WriteLine("Written to text File");
                                Console.ReadLine();
                                sellStock();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You didnt insert a negative number to subtract stock by");
                            Console.ReadLine();
                            sellLocks();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didnt insert a correct number");
                        Console.ReadLine();
                        sellLocks();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You didnt insert a number");
                    Console.ReadLine();
                    sellLocks();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem opening text file");
                Console.ReadLine();
            }
        }
    }
    
       
}
