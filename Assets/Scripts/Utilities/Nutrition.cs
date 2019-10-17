public class Nutrition
{
    private float sugar;
    private float fat;
    private float salt;
    private float protein;

    public Nutrition()
    {
        this.sugar = 0;
        this.fat = 0;
        this.salt = 0;
        this.protein = 0;
    }

    public Nutrition(float sugar, float fat, float salt, float protein)
    {
        this.sugar = sugar;
        this.fat = fat;
        this.salt = salt;
        this.protein = protein;
    }

    public Nutrition(Nutrition nutrition)
    {
        sugar = nutrition.Sugar;
        fat = nutrition.Fat;
        salt = nutrition.Salt;
        protein = nutrition.Protein;
    }

    public static Nutrition operator+ (Nutrition nutrition1,Nutrition nutrition2)
    {
        Nutrition nutrition = new Nutrition();
        nutrition.Sugar = nutrition1.Sugar + nutrition2.Sugar;
        nutrition.Fat = nutrition1.Fat + nutrition2.Fat;
        nutrition.Salt = nutrition1.Salt + nutrition2.Salt;
        nutrition.Protein = nutrition1.Protein + nutrition2.Protein;
        return nutrition;
    }

    public float Sugar
    {
        get { return sugar; }
        set { sugar = value; }
    }

    public float Fat
    {
        get { return fat; }
        set { fat = value; }
    }

    public float Salt
    {
        get { return salt; }
        set { salt = value; }
    }

    public float Protein
    {
        get { return protein; }
        set { protein = value; }
    }


}
