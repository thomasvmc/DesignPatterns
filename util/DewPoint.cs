namespace ObserverPattern.util;

public class DewPoint
{
    public static float GetDewPoint(float temperature, float humidity)
    {
        float a = 17.27F;
        float b = 237.7F;
        float A = (float) (a * temperature / (b + temperature) + Math.Log(humidity / 100));
        return (float) (b * A) / (a - A); 
    }
}