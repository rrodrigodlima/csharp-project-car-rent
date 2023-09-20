using RentCars.Types;

namespace RentCars.Models;

//7 - Faça a classe `Motorcycle` herdar de `Vehicle`
public class Motorcycle : Vehicle
{
  public double SeatHeight { get; set; }
  public BrakeType FrontBrakeType { get; set; }
  public BrakeType RearBrakeType { get; set; }
}