class RemoteControlCar
{
    int distance = 0;
    int battery = 100;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        string displayDistance = "Driven " + distance.ToString() + " meters";
        return displayDistance;
    }

    public string BatteryDisplay()
    {
        string batteryDisplay = "Battery at " + battery.ToString() + "%";
        if (battery > 1)
        {
            return batteryDisplay;
        }

        else
        {
            batteryDisplay = "Battery empty";
            return batteryDisplay;
        }
    }

    public void Drive()
    {
        if (battery != 0)
        {
            distance += 20;
            battery -= 1;
        }

    }
}
