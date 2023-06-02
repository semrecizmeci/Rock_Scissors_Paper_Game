internal class Program
    {
        static void Main(string[] args)
        {           
            int banasayim = 0;
            int onasayim = 0;
            Random random= new Random();
            int z = 6;
            for (int i = 0; i < z; i++)
            {   // rakibin hamlesi
                int y = random.Next(1, 99);
                // benim hamlem
                Console.WriteLine("hamlenizi girin.");
                string x= Console.ReadLine();
                if (y<=33)
                {
                    Console.WriteLine("rakibinizin hamlesi :K");                                     
                    if (x=="K")
                    {
                        ++z;
                        continue; 
                    }else if (x=="M")
                    {                    
                        ++banasayim;
                        Console.WriteLine("sadık:" + banasayim);
                        if (banasayim==3)
                        {
                            break;
                        }
                    }
                    else
                    {
                        onasayim++;
                        Console.WriteLine("rakip:"+onasayim);
                        if (onasayim==3)
                        {
                            break;
                        }
                    }
                }
                else if (y>33 && y<=66)
                {
                    Console.WriteLine("rakibinizin hamlesi :T");                   
                    if (x=="K") {
                        banasayim++;
                        Console.WriteLine("sadık:"+banasayim);
                        if (banasayim==3)
                        {
                            break;
                        }
                    }
                    else if (x=="T")
                    {
                        ++z;
                        continue;
                    }
                    else
                    {
                        onasayim++;
                        Console.WriteLine("rakip :"+onasayim);
                        if (onasayim==3)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("rakibinizin hamlesi :M");                  
                    if (x=="M")
                    {
                        ++z;
                        continue;
                    }
                    else if (x=="T")
                    {
                        banasayim++;
                        Console.WriteLine("sadık:"+banasayim);
                        if (banasayim==3)
                        {
                            break;
                        }
                    }
                    else
                    {
                        onasayim++;
                        Console.WriteLine("rakip :" + onasayim);
                        if (onasayim==3)
                        {
                            break;
                        }
                    }
                }
            }
            if (banasayim>onasayim)
            {
                Console.WriteLine("kazandın sadık.");
            }
            else
            {
                Console.WriteLine("rakip kazandı tebrik et.");
            }
            Console.ReadLine();
        }      
    }
