using System;

public class Cats
{
    private bool isAdopted;

    public Cats(string name, string breed, string sex, int age, string furColor, double price)
    {
        CatName = name;
        CatBreed = breed;
        CatGender = sex;
        CatAge = age;
        CatFurColor = furColor;
        CatPrice = price;
        isAdopted = false;
    }

    public string CatName { get; set; }
    public string CatBreed { get; set; }
    public string CatGender { get; set; }

    private int catAge;
    public int CatAge
    {
        get { return catAge; }
        set
        {
            catAge = (value > 0) ? value : 3;
        }
    }

    public string CatFurColor { get; set; }
    public double CatPrice { get; set; }

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
        return $"Name: {CatName}{Environment.NewLine}Breed: {CatBreed}{Environment.NewLine}Gender: {CatGender}{Environment.NewLine}Age: {CatAge}{Environment.NewLine}Fur Color: {CatFurColor}{Environment.NewLine}Price: {CatPrice}{Environment.NewLine}Adopted: {isAdopted}";
    }
}
