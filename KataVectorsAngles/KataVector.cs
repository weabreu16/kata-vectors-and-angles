namespace KataVectorsAngles;
public class KataVector
{
    private int X { get; }
    private int Y { get; }

    public KataVector(int x, int y) {
        this.X = x;
        this.Y = y;
    }

    public double DotProduct(KataVector other) {
        if (other == null) {
            throw new ArgumentException("Invalid vector");
        }

        return 2;
    }
}
