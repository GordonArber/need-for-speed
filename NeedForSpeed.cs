using System;

class RemoteControlCar
{
    int _batteryPercentage = 100;
    internal int _speed;
    internal int _batteryDrain;
    int _timesDriven = 0;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return _batteryPercentage <= 0;
    }

    public int DistanceDriven()
    {
        return _speed * _timesDriven;
    }

    public void Drive()
    {
        if (BatteryDrained()) return;
        _batteryPercentage -= _batteryDrain;
        _timesDriven++;
        DistanceDriven();
    }

    public static RemoteControlCar Nitro()
    {
        var remoteControlCar = new RemoteControlCar(50, 4);

        return remoteControlCar;
        
    }
}

class RaceTrack
{
    int _distance;
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool CarCanFinish(RemoteControlCar car)
    {
        if ((_distance / (double)car._speed) * car._batteryDrain <= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
