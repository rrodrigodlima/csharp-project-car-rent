using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    //10 - Crie o construtor de `Rent` seguindo as regras de negócio
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Vehicle = vehicle;
        Person = person;
        DaysRented = daysRented;
        Status = RentStatus.Confirmed;

        // Verificar se o locatário é uma pessoa jurídica
        if (person is LegalPerson)
        {
            // Pessoa jurídica recebe 10% de desconto
            Price = vehicle.PricePerDay * daysRented * 0.9;
        }
        else
        {
            Price = vehicle.PricePerDay * daysRented;
        }

        // Alterar o atributo IsRented do veículo para true
        vehicle.IsRented = true;

        // Alterar o débito da pessoa para o preço calculado
        person.Debit += Price;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Cancel()
    {
        throw new NotImplementedException();
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        throw new NotImplementedException();
    }
}