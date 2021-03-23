using UnityEngine;

public class Fuel
{
    private float _fuelCount;
    public float  FuelCount { get => _fuelCount/10; set => _fuelCount = value; }
    public void UseFuel(float speed)
    {
        _fuelCount -= speed;
    }
}
