using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFactory : MonoBehaviour
{
    //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0
    //https://stackoverflow.com/questions/434761/array-versus-listt-when-to-use-which
    // i chose an array for its fixes size, since we were
    // requested to create only two cars.
    // if i had needed a dynamic size i would have chosen a list
    Car[] cars;
    
    private void Start() {
        cars = new Car[2];
        cars[0] = new Car("Peugeot", "307", 2002, "White");
        cars[1] = new Car("Peugeot", "206", 2014, "Gray");
        Debug.Log(cars[0].year);
        Debug.Log(cars[1].year);
        int carAge = cars[0].CalculateCarAge();
        Debug.Log("The car's age is: " + carAge);
        int carAge2 = cars[1].CalculateCarAge();
        Debug.Log("The car's age is: " + carAge2);

        Car oldestCar = GetOldestCarByComparingAges();
        Debug.Log("The oldest car by age is: " + oldestCar.brand + " " + oldestCar.model + " from year " + oldestCar.year);
    }

    private Car GetOldestCarByComparingAgesFromArray() {
        // i wanted to handle a case where there are no cars in
        // the array or that it somehow wast created properly
        if (cars == null || cars.Length == 0)
        {
            return null;
        }
        // using the car type, i created a reference variable that contains
        // the first car in the array, so that i can compare the other cars.
        Car oldestCar = cars[0];
        int oldestCarAge = oldestCar.CalculateCarAge();

        // i loop the array and compare the current oldest car with the potential new one
        foreach (Car car in cars)
        {
            int carAge = car.CalculateCarAge();
            if (carAge > oldestCarAge)
            {
                oldestCar = car;
                oldestCarAge = carAge;
            }
        }
        // at the end, return the oldest car
        return oldestCar;
    }
}