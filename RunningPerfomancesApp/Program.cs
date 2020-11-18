using System;

namespace Running_perfomance
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                RunningPerfomances perfomances = new RunningPerfomances();
                Console.WriteLine("Enter type of first perfomance: 1)Speed 2)Pace 3)Distance 4) Time");
                int firstData;
                string num = Console.ReadLine();
                if (!int.TryParse(num, out firstData) || firstData < 0 || firstData > 5)
                {
                    Console.WriteLine("It is not correct data");
                    break;
                }
                Console.WriteLine("Enter type of second perfomance: 1)Speed 2)Pace 3)Distance 4) Time");
                int secondData;
                num = Console.ReadLine();
                if (!int.TryParse(num, out secondData) || secondData < 0 || secondData > 5)
                {
                    Console.WriteLine("It is not correct data");
                    break;
                }

                double pace, speed, distance, time;
                switch (firstData)
                {
                    case 1:
                        Console.WriteLine("Enter speed:");
                        string s = Console.ReadLine();
                        if (!Double.TryParse(s, out speed) || speed < 0 || speed > 25)
                        {
                            Console.WriteLine("It is not correct data");
                            break;
                        }
                        switch (secondData)
                        {
                            case 1:
                                Console.WriteLine("Not possible to count");
                                break;
                            case 2:
                                Console.WriteLine("Enter pace:");
                                pace = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Not possible to count");
                                break;
                            case 3:
                                Console.WriteLine("Enter distance:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out distance) || distance < 0 || distance > 1000)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetPaceAndTime();
                                break;
                            case 4:
                                Console.WriteLine("Enter time in minutes:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out time) || time < 0 || time > 5000)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetPaceAndDistance();
                                break;
                            default:
                                Console.WriteLine("You enter wrong value");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter pace:");
                        s = Console.ReadLine();
                        if (!Double.TryParse(s, out pace) || pace < 0 || pace > 10)
                        {
                            Console.WriteLine("It is not correct data");
                            break;
                        }
                        switch (secondData)
                        {
                            case 1:
                                Console.WriteLine("Enter speed:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out speed) || speed < 0 || speed > 25)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                Console.WriteLine("Not possible to count");
                                break;
                            case 2:
                                Console.WriteLine("Not possible to count");
                                break;
                            case 3:
                                Console.WriteLine("Enter distance:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out distance) || distance < 0 || distance > 1000)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetSpeedAndTime();
                                break;
                            case 4:
                                Console.WriteLine("Enter time in minutes:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out time) || time < 0 || time > 5000)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetSpeedAndDistance();
                                break;
                            default:
                                Console.WriteLine("You enter wrong value");
                                break;

                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter distance:");
                        s = Console.ReadLine();
                        if (!Double.TryParse(s, out distance) || distance < 0 || distance > 1000)
                        {
                            Console.WriteLine("It is not correct data");
                            break;
                        }
                        switch (secondData)
                        {
                            case 1:
                                Console.WriteLine("Enter speed:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out speed) || speed < 0 || speed > 25)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetPaceAndTime();
                                break;
                            case 2:
                                Console.WriteLine("Enter pace:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out pace) || pace < 0 || pace > 10)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetSpeedAndTime();
                                break;
                            case 3:
                                Console.WriteLine("Not possible to count");
                                break;
                            case 4:
                                Console.WriteLine("Enter time in minutes:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out time) || time < 0 || time > 5000)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetPaceAndSpeed();
                                break;
                            default:
                                Console.WriteLine("You enter wrong value");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter time in minutes:");
                        s = Console.ReadLine();
                        if (!Double.TryParse(s, out time) || time < 0 || time > 5000)
                        {
                            Console.WriteLine("It is not correct data");
                            break;
                        }
                        switch (secondData)
                        {
                            case 1:
                                Console.WriteLine("Enter speed:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out speed) || speed < 0 || speed > 25)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetPaceAndDistance();
                                break;
                            case 2:
                                Console.WriteLine("Enter pace:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out pace) || pace < 0 || pace > 10)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetSpeedAndDistance();
                                break;
                            case 3:
                                Console.WriteLine("Enter distance:");
                                s = Console.ReadLine();
                                if (!Double.TryParse(s, out distance) || distance < 0 || distance > 1000)
                                {
                                    Console.WriteLine("It is not correct data");
                                    break;
                                }
                                GetPaceAndSpeed();
                                break;
                            case 4:
                                Console.WriteLine("Not possible to count");
                                break;
                            default:
                                Console.WriteLine("You enter wrong value");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("You enter wrong value");
                        break;
                }

                void GetPaceAndDistance()
                {
                    perfomances.Pace = 60 / speed;
                    perfomances.Distance = time / 60 * speed;
                    Console.WriteLine($" Your pace: {GetPaceInMinutes()},{GetPaceInSeconds()} min/km");
                    Console.WriteLine($" Your distance: {Math.Round(perfomances.Distance, 2)} km");
                }
                void GetPaceAndSpeed()
                {
                    perfomances.Pace = 60 / (distance / (time / 60));
                    perfomances.Speed = distance / (time / 60);
                    Console.WriteLine($" Your pace: {GetPaceInMinutes()},{GetPaceInSeconds()} min/km");
                    Console.WriteLine($" Your speed: {Math.Round(perfomances.Speed, 2)} km/hour");
                }

                void GetPaceAndTime()
                {
                    perfomances.Pace = 60 / speed;
                    perfomances.Time = distance / speed * 60;
                    Console.WriteLine($" Your pace: {GetPaceInMinutes()},{GetPaceInSeconds()} min/km");
                    Console.WriteLine($" Your time: {Math.Round(perfomances.Time, 2)} min ({GetTimeInHours()} hours {GetTimeInMinutes()} min )");
                }
                void GetSpeedAndDistance()
                {
                    perfomances.Speed = 60 / pace;
                    perfomances.Distance = time / pace;
                    Console.WriteLine($" Your speed: {Math.Round(perfomances.Speed, 2)} km/hour");
                    Console.WriteLine($" Your distance: {Math.Round(perfomances.Distance, 2)} km");

                }
                void GetSpeedAndTime()
                {
                    perfomances.Speed = 60 / pace;
                    perfomances.Time = 60 * (distance / (60 / pace));
                    Console.WriteLine($" Your speed: {Math.Round(perfomances.Speed, 2)} km/hour");
                    Console.WriteLine($" Your time: {Math.Round(perfomances.Time, 2)} min ({GetTimeInHours()} hours {GetTimeInMinutes()} min )");
                }
                double GetPaceInMinutes()
                {
                    double paceInMinutes = Math.Floor(perfomances.Pace / 1);
                    return paceInMinutes;
                }
                double GetPaceInSeconds()
                {
                    double paceInSeconds = Math.Round((perfomances.Pace % 1) * 60, 0);
                    return paceInSeconds;
                }
                double GetTimeInHours()
                {
                    double hours = Math.Floor(perfomances.Time / 60);
                    return hours;
                }
                double GetTimeInMinutes()
                {
                    double minutes = Math.Round(perfomances.Time % 60);
                    return minutes;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("For exit press key \"E\" and \"Enter\"");
                Console.WriteLine("For continue press any other key");
                string exit = Console.ReadLine();
                if (exit == "E")
                {
                    break;
                }
                Console.Clear();

            }


        }
    }
}