namespace square_of_squares
{
    public class Square
    {

        public static bool IsSquare(int n)
        {
            var squaredRoot = Math.Sqrt(n);
            return (int)squaredRoot == squaredRoot;
        }
    }

}