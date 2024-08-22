using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    public int year;
    public string brand;
    public string model;
    public string color;
    public bool isCarMoving;

    public Car(string newBrand, string newModel, int newYear, string newColor)
    {
        brand = newBrand;
        model = newModel;
        year = newYear;
        color = newColor;  
        isCarMoving = false;
    }

    public bool startCar() {
        return this.isCarMoving = true;
    }
    public bool stopCar() {
        return this.isCarMoving = false;
    }

        public int CalculateCarAge()
    {
        int currentYear = System.DateTime.Now.Year;
        return currentYear - year;
    }

}

