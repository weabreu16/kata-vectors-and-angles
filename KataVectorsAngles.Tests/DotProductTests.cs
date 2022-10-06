using KataVectorsAngles;

namespace KataVectorsAngles.Tests;

public class DotProductTests
{
    [Fact]
    public void Should_return_2_if_1_1_dot_product_1_1() {
        KataVector vector = new KataVector(1, 1);
        KataVector other = new KataVector(1, 1);
        
        double result = vector.DotProduct(other);
        
        Assert.Equal(result, 2);
    }

    [Fact]
    public void Should_throw_argument_exception_if_receive_null() {
        KataVector vector = new KataVector(1, 1);
        
        Assert.Throws<ArgumentException>(() => { vector.DotProduct(null); });
    }

    [Fact]
    public void Should_return_4_if_1_1_dot_product_2_2() {
        KataVector vector = new KataVector(1, 1);
        KataVector other = new KataVector(2, 2);
        
        double result = vector.DotProduct(other);
        
        Assert.Equal(result, 4);
    }
}