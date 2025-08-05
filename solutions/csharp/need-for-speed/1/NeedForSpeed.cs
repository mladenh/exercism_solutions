class RemoteControlCar
{
    private int distance = 0;
    private int speed;
    private int batteryDrain;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }


    public bool BatteryDrained()
    {
        return battery < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if (battery < batteryDrain)
        {
            this.distance += 0;
        }
        else
        {
            this.distance += speed;
            this.battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        RemoteControlCar car = new RemoteControlCar(50, 4);
        return car;
    }
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        return  car.DistanceDriven() >= distance;

        //while (car.DistanceDriven() > distance)
        //{
        //    car.Drive();

        //    if (car.BatteryDrained() && car.DistanceDriven() == distance)
        //    {
        //        return true;
        //    }
        //    if (car.BatteryDrained())
        //    {
        //        return false;
        //    }
        //}
        //return true;

        //throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}
