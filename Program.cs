using System;

namespace ClockAngle{

    internal class Program{

        static void Main(string[] args){

            Console.WriteLine("Hours:");
            if (!int.TryParse(Console.ReadLine(), out int hour) || hour < 1 || hour > 12){
                Console.Write("Hours should be a number in range of 1-12");
                return;
            }

            Console.WriteLine("Minutes:");
            if (!int.TryParse(Console.ReadLine(), out int minute) || minute < 0 || minute > 59){
                Console.Write("Minutes should be a number in range of 0-59");
                return;
            }

            Console.WriteLine($"Angle: {GetAngle(hour, minute)} degrees");

        }

        static double GetAngle(int hour, int minute){
            
            // 360/12 deg every hour + 360/12/60 deg every minute
            double hourDegrees = hour * 30 + minute * 0.5;
            // 360/60 deg every minute
            double minuteDegrees = minute * 6;

            double angle = Math.Abs(hourDegrees - minuteDegrees);
            if (angle > 180){
                angle = 360 - angle;
            }
            return angle;
        }
    }
}