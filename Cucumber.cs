namespace ConsoleApp1;

public class Cucumber: Plant
{
    private double _weight;
    public Cucumber(string fullName, int growingTime, bool isNeedRegrow, Season growingSeason, double landDepletion,
        double weight) :
        base("Cucumber", fullName, growingTime, isNeedRegrow, growingSeason, landDepletion, false)
    {
        this._weight = weight;
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