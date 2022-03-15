class data
{
    
    enum contacttype
    {
        SMS = 1,
        Email = 2,
        ID = 3
    }
    static int Main(string[] args)
    {
              int first = (int)contacttype.SMS;
              int second = (int)contacttype.Email;
              int end = (int)contacttype.ID;
        Console.WriteLine("please select your oprator :");
        Console.WriteLine("1 - write numbers of enum value");
        Console.WriteLine("2 - write string of enum");
        Console.WriteLine("3 - cast of numbers");
        var input =Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                { 
                        Console.WriteLine("SMS : {0}",first);
                        Console.WriteLine("Email : {0}",second);
                        Console.WriteLine("ID : {0}",end);
                    break;
                }
                case 2:
                {  
                   string[] item = Enum.GetNames(typeof(contacttype));
                        foreach (string str in item)
                        {
                                Console.WriteLine(str);

                        }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("please select a number between 1 till 3 :");
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch(i)
                    {
                        case 1:
                            {
                                Console.WriteLine(Enum.Format(typeof(contacttype),1,"g"));
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine(Enum.Format(typeof(contacttype), 2, "x"));
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine(Enum.Format(typeof(contacttype), 3, "f"));
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("your paramerts not value");
                                break;
                            }
                                     
                    }
                    break ;



                   
                
                }
            case 4:
                {

                    break;
                }

        }



            
        return 0;

    }
    


}




