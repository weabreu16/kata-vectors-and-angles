namespace KataVectorsAngles;
public class KataVector
{
    public int X { get; }
    public int Y { get; }

    public KataVector(int x, int y) {
        this.X = x;
        this.Y = y;
    }

    public double DotProduct(KataVector other) {
        if (other == null) {
            throw new ArgumentException("Invalid vector");
        }

        return this.X * other.X + this.Y * other.Y;
    }
}
