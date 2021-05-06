using System;

namespace Encryption_App_Console
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine(" Enter Your Key only 10 digit allowed");
            string Key = Console.ReadLine();
            for (int y = 0; y < Key.Length; y++)
                if (Key[y] == Key[y + 1])
                {
                    Console.WriteLine("\n Error wrong key:Key can't be duplicate number");
                    return 0;
                }
                else
                
                    for (int x = 0; x < 10; x++)
                        if (char.IsDigit(Key[x]))
                            if (Key.Length == 10)
                            {
                                Console.WriteLine("\n Enter Your message");
                                string Message = Console.ReadLine();
                                if (char.IsDigit(Message[x]))
                                {
                                    Console.WriteLine("\n Encrypted Message is: ");
                                    for (int i = 0; i < Message.Length; i++)
                                    {
                                        for (int j = 0; j < Key.Length; j++)
                                        {
                                            if (Message[i] == Key[j])
                                                Console.Write(j);
                                        }
                                    }
                                    Console.WriteLine("\n Key is: \n " + Key);
                                    break;
                                } 
                                    
                            else
                            {
                                Console.WriteLine("\n Message must be digits");
                                break;
                            }
                            }
                            else
                            {
                                Console.WriteLine("\n Key must be 10 digits");
                                break;
                            }
                        else
                        {
                            Console.WriteLine("\n Key must be digits ");
                            break;
                        } 
            return 0 ;
                }               

        
    }
}
