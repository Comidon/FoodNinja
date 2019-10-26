using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DataToAchievement
{
    public static Nutrition Expected { get; set; }
    public static Nutrition Max { get; set; }
    public static HashSet<Food> food;


    //for testing
    public static Nutrition Expected_Default = new Nutrition(100, 200, 300, 400, 500);
    public static Nutrition Max_Default = new Nutrition(500, 400, 300, 200, 100);
}
