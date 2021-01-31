using System;

namespace timestamptest
{
    class Program
    {
        static void Main(string[] args)
        {
            // hour : 60 minutes
            // day  : 1440 minutes
            // week : 10 080 minutes
            // month : 43 829 minutes
            // year : 525 948 minutes



            int year = 525948;
            int month = 43829;
            int week = 10080;
            int day = 1440;
            int hour = 60;


            long minutes = 1000000; // input value - > minutes you want converted 


            if (minutes >= year)
            {
                long years = minutes / year;
                long surplusYears = minutes % year;

                if (years > 1)
                {
                    if (surplusYears > month)
                    {
                        long months = surplusYears / month;
                        if (months == 1)
                        {
                            Console.WriteLine("You spent: " + years + " years " + months + " month");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + years + " years " + months + " months");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You spent: " + years + "years");
                    }
                }
                else
                {
                    if (surplusYears >= month)
                    {
                        long months = surplusYears / month;
                        if (months == 1)
                        {
                            Console.WriteLine("You spent: " + years + " year " + months + " month");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + years + " year " + months + " months");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You spent: " + years + "year");
                    }
                }
            }
            else if (minutes >= month)
            {
                long months = minutes / month;
                long surplusMonths = minutes % month;

                if (months > 1)
                {
                    if (surplusMonths > week)
                    {
                        long weeks = surplusMonths / week;

                        if (weeks == 1)
                        {
                            Console.WriteLine("You spent: " + months + " months " + weeks + " week");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + months + " months " + weeks + " weeks");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You spent: " + months + " months");
                    }
                }
                else
                {

                    if (surplusMonths >= week)
                    {
                        long weeks = surplusMonths / week;

                        if (weeks == 1)
                        {
                            Console.WriteLine("You spent: " + months + " month " + weeks + " week");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + months + " month " + weeks + " weeks");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You spent: " + months + " month");
                    }

                }

            }
            else if (minutes >= week)
            {

                long weeks = minutes / week;
                long surplusWeeks = minutes % week;

                if (weeks > 1)
                {
                    if (surplusWeeks >= day)
                    {
                        long days = surplusWeeks / day;

                        if (days == 1)
                        {
                            Console.WriteLine("You spent: " + weeks + " weeks " + days + " day ");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + weeks + " weeks " + days + " days ");
                        }


                    }
                    else
                    {
                        Console.WriteLine("You spent: " + weeks + "weeks");
                    }
                }
                else
                {
                    if (surplusWeeks >= day)
                    {
                        long days = surplusWeeks / day;

                        if (days == 1)
                        {
                            Console.WriteLine("You spent: " + weeks + " week " + days + " day ");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + weeks + " week " + days + " days ");
                        }


                    }
                    else
                    {
                        Console.WriteLine("You spent: " + weeks + "week");
                    }
                }

            }
            else if (minutes >= day)
            {
                long days = minutes / day;
                long surplusDays = minutes % day;

                if (days > 1)
                {

                    if (surplusDays >= hour)
                    {
                        long hours = surplusDays / hour;
                        if (hours == 1)
                        {
                            Console.WriteLine("You spent: " + days + " days " + hours + "hour");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + days + " days " + hours + "hours");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You spent: " + days + " days ");
                    }


                }
                else
                {
                    if (surplusDays >= hour)
                    {
                        long hours = surplusDays / hour;
                        if (hours == 1)
                        {
                            Console.WriteLine("You spent: " + days + " day " + hours + "hour");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + days + " day " + hours + "hours");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You spent: " + days + " day ");
                    }
                }

            }
            else if (minutes >= hour)
            {
                long hours = minutes / hour;
                long surplusHours = minutes % hour;

                if (hours > 1)
                {
                    if (surplusHours == 0)
                    {
                        Console.WriteLine("You spent: " + hours + " hours ");
                    }
                    else
                    {   if (surplusHours == 1)
                        {
                            Console.WriteLine("You spent: " + hours + " hours " + surplusHours + " minute");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + hours + " hours " + surplusHours + " minutes");
                        }
                        
                    }
                }
                else
                {
                    if (surplusHours == 0)
                    {
                        Console.WriteLine("You spent: " + hours + " hour ");
                    }
                    else
                    {
                        if (surplusHours == 1)
                        {
                            Console.WriteLine("You spent: " + hours + " hour " + surplusHours + " minute");
                        }
                        else
                        {
                            Console.WriteLine("You spent: " + hours + " hour " + surplusHours + " minutes");
                        }
                        
                    }
                }

            }
            else
            {
                if (minutes == 1)
                {
                    Console.WriteLine("You spent: " + minutes + " minute");
                }
                else
                {
                    Console.WriteLine("You spent: " + minutes + " minutes");
                }
                
            }

   
            Console.ReadLine();
        }
    }
}
