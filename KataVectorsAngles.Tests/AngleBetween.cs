namespace KataVectorsAngles.Tests;

public class AngleBetween
{
    [Fact]
    public void should_return_1_18_as_the_angle_between_two_vectors(){
        KataVector vector = new KataVector(5, -1);
        KataVector other = new KataVector(6, 9);

        double result = vector.AngleBetween(other);

        Assert.Equal(result,1.18);
    }

    [Fact]
    public void should_return_an_exeption_if_it_recive_a_null_input(){
        KataVector vector = new KataVector(5, -1);

        Assert.Throws<ArgumentException>(()=>{vector.AngleBetween(null);});
    }

}