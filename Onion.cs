namespace ConsoleApp1;

public class Onion: Plant
{
    private double _weight;
    public Onion(string fullName, int growingTime, bool isNeedRegrow, Season growingSeason, double landDepletion,
        double weight) :
        base("Onion", fullName, growingTime, isNeedRegrow, growingSeason, landDepletion, false)
    {
        _weight = weight;
        if (weight > 0.5)
        {
            LandDepletion = LandDepletion / weight + LandDepletion;
        }
    }

    public override bool IsHarvest()
    {
        return !Seeds && GetCurrentSeason() == GrowingSeason && LandDepletion <= MaxLandDepletion / 2;
    }
}