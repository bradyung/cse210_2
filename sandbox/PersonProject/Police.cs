class Police : Person
{
    private string _weapons;

    public Police(string weapons, string firstName, string lastName, int age, int weight)
    : base(firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    // public string GetPoliceInformation()
    // {
    //     return $"Tools: {_weapons}, {GetPersonInformation()}";
    // }

    public override string GetPersonInformation()
    {
        return $"Tools: {_weapons}, {base.GetPersonInformation()}";
    }
}
