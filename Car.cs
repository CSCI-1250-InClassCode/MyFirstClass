public class Car
{
    private int speed;
    private string color;
    private string model;
    private string manufacturer;
    private bool isOn;
    private double gasLevel;
   

    public void Power(string key)
    {
        if(isOn && key == "secret key is")
        {
            isOn = false;
        }
        else if(key == "secret key is")
        {
            isOn = true;
        }
        
    }

    public bool IsMyCarOn()
    {
        return isOn;
    }

   public static string RoadCond(string data)
   {
       if(data.Contains("icy".ToUpper()))
       {
           return "Bad Conditions!";
       }
       else
       {
           return "Good Conditions!";
       }
   }

}
