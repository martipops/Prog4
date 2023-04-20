using System;

public class Dogs
{
    private bool isAdopted;

    public Dogs(string name, string breed, string sex, int age, string furColor, double price)
    {
        DogName = name;
        DogBreed = breed;
        DogGender = sex;
        DogAge = age;
        DogFurColor = furColor;
        DogPrice = price;
        isAdopted = false;
    }

    public string DogName { get; set; }
    public string DogBreed { get; set; }
    public string DogGender { get; set; }

    private int dogAge;
    public int DogAge
    {
        get { return dogAge; }
        set
        {
            dogAge = (value > 0) ? value : 3;
        }
    }

    public string DogFurColor { get; set; }
    public double DogPrice { get; set; }

    public void IsAvailable()
    {
        isAdopted = false;
    }

    public void IsAdopted()
    {
        isAdopted = true;
    }

    public bool Availability()
    {
        return isAdopted;
    }

    public override string ToString()
    {
        return $"Name: {DogName}{Environment.NewLine}Breed: {DogBreed}{Environment.NewLine}Gender: {DogGender}{Environment.NewLine}Age: {DogAge}{Environment.NewLine}Fur Color: {DogFurColor}{Environment.NewLine}Price: {DogPrice}{Environment.NewLine}Adopted: {isAdopted}";
    }
}
