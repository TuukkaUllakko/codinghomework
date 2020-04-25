namespace Exercise
{
  using System;
  public class TemperatureSensor : Sensor
  {
    private bool onOrOff = false;
    public TemperatureSensor()
    {
      this.onOrOff = false;
    }
    public bool IsOn()
    {
      return onOrOff;
    }


    public void SetOn()
    {
      this.onOrOff = true;
    }


    public void SetOff()
    {
      this.onOrOff = false;
    }


    public int Read()
    {
      int temp = 0;
      Random temperature = new Random();
      temp = temperature.Next(-30, 30);
      if (IsOn())
      {
      return temp;
      }
      else
      {
        throw new InvalidOperationException("Turn on the temperature sensor!");
      }
    }
  }
}