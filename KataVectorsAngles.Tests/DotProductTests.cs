using KataVectorsAngles;

namespace KataVectorsAngles.Tests;

public class DotProductTests
{
    [Fact]
    public void Should_return_2_if_1_1_dot_product_1_1()
    {
        KataVector vector = new KataVector(1, 1);
        KataVector other = new KataVector(1, 1);
        
        double result = vector.DotProduct(other);
        
        Assert.Equal(result, 2);
    }
}