namespace mystudents;

class Student
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public string Email { get; set; }
    public int Leeftijd { get; set; }

    public Student(int id, string name, string email, int leeftijd)
    {
        Id = id;
        Naam = name;
        Email = email;
        Leeftijd = leeftijd;
    }
}
