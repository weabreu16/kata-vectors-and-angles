namespace KataVectorsAngles.Tests;

public class UnitTest1
{
    [Fact]
    public void If_vector_is_3_and_2_return_the_correct_answer()
    {
        KataVector result = new KataVector(3, 2);
        Assert.Equal(result.Magnitude(), 3.605551275463989);
    }

    [Fact]
    public void If_vector_is_5_and_7_return_the_correct_answer()
    {
        KataVector result = new KataVector(5, 7);
        Assert.Equal(result.Magnitude(), 8.602325267042627);
    }

    [Fact]
        public void If_vector_is_4_and_6_return_the_correct_answer()
    {
        KataVector result = new KataVector(4, 6);
        Assert.Equal(result.Magnitude(),  7.211102550927978);
    }
}