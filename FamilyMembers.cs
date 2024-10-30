public enum Gender { female, male}
public class FamilyMembers
{
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public  string FullName { get; set; }
    public FamilyMembers ?Mother { get; set; }
    public FamilyMembers Father { get; set; }
    public FamilyMembers? Wife { get; set; }
    public FamilyMembers? Husband { get; set; }

    public FamilyMembers[] GetGrandMother()
    {
        return new FamilyMembers[] { Mother?.Mother, Father?.Mother };
    }


    public FamilyMembers[] GetGrandFather()
    {
        return new FamilyMembers[] { Father?.Father, Father?.Mother };
    }
    public FamilyMembers GetSpouse()
    {
        if (Gender == Gender.female)
            return Wife;
        else
            return Husband;
    }
    public FamilyMembers GetParent()
    {
        if (Gender == Gender.male)
            return Mother;
        else
            return Father;
    }
    public FamilyMembers GetChild()
    {
        if (Gender == Gender.male)
            return Wife;
        else
            return Husband;
    }
}
