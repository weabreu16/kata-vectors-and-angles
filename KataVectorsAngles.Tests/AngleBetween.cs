using KataVectorsAngles;

namespace KataVectorsAngles.Tests;

public class AngleBetween
{
   
    [Fact]
    public void should_return_1_18_if_it_is_the_angle_between_thwo_vectors() {
        KataVector vector = new KataVector(5, -1);
        KataVector other = new KataVector(6, 9);
        
        double result = vector.AngleBetween(other);
        
        Assert.Equal(result, 1.18);
    }



}