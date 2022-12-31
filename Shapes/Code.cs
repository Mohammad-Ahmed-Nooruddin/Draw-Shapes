using System;

namespace File
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text;
            Console.WriteLine("This program makes the following shapes : Circle, Square, Rectangle, Diamond and Triangle.\nTo close the program type Close.\n");
            bool running = true;
            while(running)
            {
                text = "";
                Console.Write("Shape of your choice : ");
                string choice = Console.ReadLine().ToLower();
                Console.Write("\n");
                if(choice == "circle")
                {
                    Console.Write("Radius : ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    
                    double i = radius * -1;
                    while(i <= radius)
                    {
                        double j = radius * -1;
                        while(j <= radius)
                        {
                            if(i*i+j*j < radius*radius)
                            {
                                text += "##";
                            }
                            else
                            {
                                text += "  ";
                            }
                            j += 1;
                        }
                        text += "\n";
                        i += 1;
                    }
                }
                else if(choice == "square")
                {
                    Console.Write("Side length : ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    int i = 0;
                    while(i < length)
                    {
                        int j = 0;
                        while(j < length)
                        {
                            text += "##";
                            j += 1;
                        }
                        text += "\n";
                        i += 1;
                    }
                }
                else if(choice == "rectangle")
                {
                    Console.Write("Length : ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Breadth : ");
                    double breadth = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    int i = 0;
                    while(i < breadth)
                    {
                        int j = 0;
                        while(j < length)
                        {
                            text += "##";
                            j += 1;
                        }
                        text += "\n";
                        i += 1;
                    }
                }
                else if(choice == "triangle")
                {
                    Console.Write("Length : ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    int i = 0;
                    while(i < length)
                    {
                        int j = 0;
                        while(j < length)
                        {
                            if(j < length/2)
                            {
                                if(j >= (length-i)/2)
                                {
                                    text += "##";
                                }
                                else
                                {
                                    text += "  ";
                                }
                            }
                            else
                            {
                                if(j-length/2 <= i/2)
                                {
                                    text += "##";
                                }
                                else
                                {
                                    text += "  ";
                                }
                            }
                            j += 1;
                        }
                        text += "\n";
                        i += 1;
                    }
                }
                else if(choice == "diamond")
                {
                    Console.Write("Diagonal length : ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    int i = 0;
                    while(i < length)
                    {
                        int j = 0;
                        while(j < length)
                        {
                            if(j < length/2)
                            {
                                if(j >= (length-i)/2)
                                {
                                    text += "##";
                                }
                                else
                                {
                                    text += "  ";
                                }
                            }
                            else
                            {
                                if(j-length/2 <= i/2)
                                {
                                    text += "##";
                                }
                                else
                                {
                                    text += "  ";
                                }
                            }
                            j += 1;
                        }
                        text += "\n";
                        i += 2;
                    }
                    i = Convert.ToInt32(length)-1;
                    while(i > 0)
                    {
                        int j = Convert.ToInt32(length)-1;
                        while(j > 0)
                        {
                            if(j < length/2)
                            {
                                if(j >= (length-i)/2)
                                {
                                    text += "##";
                                }
                                else
                                {
                                    text += "  ";
                                }
                            }
                            else
                            {
                                if(j-length/2 <= i/2)
                                {
                                    text += "##";
                                }
                                else
                                {
                                    text += "  ";
                                }
                            }
                            j -= 1;
                        }
                        text += "\n";
                        i -= 2;
                    }
                }
                else if(choice == "close")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not support the shape " + choice + ". Please choose any of these shapes : Circle, Square, Rectangle, Diamond and Triangle\nTo close the program type Close.\n");
                }
                if(running)
                {
                    Console.Write(text);
                    Console.ReadLine(); 
                }
                Console.Clear();
            }
        }
    }
}