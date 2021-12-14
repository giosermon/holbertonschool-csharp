using System;


enum Rating
{
    Good,
    Great,
    Excellent
}
struct Dog
{
    public Dog(string n, float a, string o, Rating r)
    {
        name = n;
        age = a;
        owner = o;
        rating = r;
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    
}
