namespace SubtractionAllTheWayDown
{
    class Functions
    {
        // a - b
        public static int Subtract(int a, int b)
        {
            return 0 - ((0 - b) - (0 - a));
        }

        // a + b
        public static int Add(int a, int b)
        {
            return Subtract(a, Subtract(0, b));
        }

        // a * b
        public static int Multiply(int a, int b)
        {
            int v = 0;
            for(int i = 0; i < a; Add(i,1))
            {
                v = Add(v, b);
            }
            return v;
        }

        // a / b
        public static int Divide(int a, int b, out int r)
        {
            int v = 0;
            int i = a;

            if (a >= b)
            {
                while(i >= b)
                {
                    i = Subtract(i, b);
                    v = Add(v, 1);
                }
            }

            r = i;
            
            return v;
        }
    }
}