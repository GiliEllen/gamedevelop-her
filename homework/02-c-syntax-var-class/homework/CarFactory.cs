using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFactory : MonoBehaviour
{
    //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0
    //https://stackoverflow.com/questions/434761/array-versus-listt-when-to-use-which
    // i chose a list for this because it is easier to manage dynamically.
    // array has fixed size, which was better for performance
    // if i had done only the first task which is "create two cars"

    List<Car> cars;
    
    private void Start() {
        // initialize the list requested on start
        cars = new List<Car>();
        // add cars to the list
        AddCar(new Car("Peugeot", "307", 2002, "White"));
        AddCar(new Car("Peugeot", "206", 2014, "Gray"));

         // since the size is dynamic and therefor "unknown", i chose to loop
         // the list to debug.log it. i believe a method
         // is a better and more neat way than to
         // log everything on start. what if we want to reuse the code?
        LogAllCarsDetails();

        // Find the oldest car
        Car oldestCar = GetOldestCarByComparingAgesFromArray();
        Debug.Log("The oldest car by age is: " + oldestCar.brand + " " + oldestCar.model + " from year " + oldestCar.year);
    }

    // this is the method meant to loop the
    // list and log the car ad the car age
    private void LogAllCarsDetails() {
         foreach (Car car in cars) {
            Debug.Log("Car: " + car.brand + " " + car.model + " Year: " + car.year);
            int carAge = car.CalculateCarAge();
            Debug.Log("The car's age is: " + carAge);
        }
    }

    // method to add a car to the list
    // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=net-8.0
    public void AddCar(Car car) {
        cars.Add(car);
        Debug.Log(car.brand + " " + car.model + " has been added.");
    }

    // method to remove a car from the list
    // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=net-8.0
    public void RemoveCar(Car car) {
        if (cars.Contains(car)) {
            cars.Remove(car);
            Debug.Log(car.brand + " " + car.model + " has been removed.");
        } else {
            Debug.Log(car.brand + " " + car.model + " was not found in the list.");
        }
    }

    private Car GetOldestCarByComparingAgesFromArray() {
        // i wanted to handle a case where there are no cars in
        // the array or that it somehow wast created properly
         if (cars == null || cars.Count == 0) {
            Debug.LogError("No cars available.");
            return null;
        }
        // using the car type, i created a reference variable that contains
        // the first car in the array, so that i can compare the other cars.
        Car oldestCar = cars[0];
        int oldestCarAge = oldestCar.CalculateCarAge();

        // i loop the array and compare the current oldest car with the potential new one
        foreach (Car car in cars) {
            int carAge = car.CalculateCarAge();
            if (carAge > oldestCarAge) {
                oldestCar = car;
                oldestCarAge = carAge;
            }
        }
        // at the end, return the oldest car
        return oldestCar;
    }
}