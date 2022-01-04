using System;
using System.IO;

//@author Ansari Mohammed Faisal - 000812671
namespace Lab3A
{
    /// <summary>
    /// Program is my main class it is derived from IEncryptable
    /// </summary>
    public class Program : IEncryptable
    {
        const string DATAFILE = "Data.txt";
        /// <summary>
        /// Main program highly modularize 
        /// it also involves exception catching and error checking
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Media[] media = new Media[100];
            media = ReadData();
            while (true)
            {
                bool searchresult = false;
                int ch = MainMenu();
                try
                {
                    switch (ch)
                    {
                        case 1 :
                            
                            foreach (Media m in media)
                            {
                                if (m is Book)
                                {
                                    Console.WriteLine(m.ToString());
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2 :
                            foreach (Media m in media)
                            {
                                if (m is Movie)
                                {
                                    Console.WriteLine(m.ToString());
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3 :
                            foreach (Media m in media)
                            {
                                if (m is Song)
                                {
                                    Console.WriteLine(m.ToString());
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            foreach (Media m in media)
                            {
                                Console.WriteLine(m.ToString());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 5:
                            Console.WriteLine("Enyter a search string ");
                            string s = Console.ReadLine();
                            //searching the string in array
                            foreach (Media m in media)
                            {
                                if (m.Search(s) == true)
                                {
                                    Console.WriteLine(m.ToString());
                                    searchresult = true;
                                }
                            }
                            if (searchresult)
                            {
                                Console.WriteLine("press any key to continue");
                            }
                            else
                            {
                                Console.WriteLine("Sorry no result found!");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break; 
                        case 6:
                            Environment.Exit(-1);
                            break;
                        default:
                            Console.WriteLine("That is not a valid choice, please try again, \npress any key to continue: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something Wrong:",e);
                }
            }
        }
        /// <summary>
        /// This method is for main menu screen of program
        /// it also checks if user has entered a alphabet or a digit
        /// </summary>
        /// <returns>return a digit which is used to display further information</returns>
        public static int MainMenu()
        {
        Start:
            Console.Clear();
            Console.WriteLine("Ansari's Media collection");
            Console.WriteLine("=========================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. List All Books\n2. List All Movies\n3. List All Songs\n4. List All Media\n5. Search All Media by Title\n\n6. Exit Program\n\n");

            Console.Write("Enter choice: ");
            int option;
            Boolean flag = int.TryParse(Console.ReadLine(), out option);//checking if it is a number or not
            if (!flag)
            {
                Console.WriteLine("Only Numbers Are Accepted!\n Press Enter to go back to Menu!");
                Console.ReadLine();
                goto Start;
            }
            return option;
        }


        /// <summary>
        /// this method reads data from data.txt into array
        /// </summary>
        /// <returns></returns>
        public static Media[] ReadData()
        {
            Media[] media = new Media[100];
            int medianumber = 0;
            string[] mediainfo;
            try
            {
                foreach (string File in File.ReadAllLines(DATAFILE)) //Reads whole file
                {
                    mediainfo = File.Split('|');//splits whole line into array
                    if (mediainfo[0] == "BOOK")
                    {
                        media[medianumber] = new Book(mediainfo[1], int.Parse(mediainfo[2]), mediainfo[3]);
                        medianumber++;
                    }
                    if (mediainfo[0] == "MOVIE")
                    {
                        media[medianumber] = new Movie(mediainfo[1], int.Parse(mediainfo[2]), mediainfo[3]);
                        medianumber++;
                    }
                    if (mediainfo[0] == "SONG")
                    {
                        media[medianumber] = new Song(mediainfo[1], int.Parse(mediainfo[2]), mediainfo[4], mediainfo[3]);
                        medianumber++;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error reading file " + ex.Message);
            }
            Array.Resize(ref media, medianumber);
            return media;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Decrypt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Encrypt()
        {
            throw new NotImplementedException();
        }
    }
    }
