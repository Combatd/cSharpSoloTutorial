using System;
namespace Dance
{
    public class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        // overload the + operator

        public static DancerPoints operator +(DancerPoints firstDancer, DancerPoints secondDancer)
        {
            return new DancerPoints($"{firstDancer.name} & {secondDancer.name}", firstDancer.points + secondDancer.points);
        }
    }
}
