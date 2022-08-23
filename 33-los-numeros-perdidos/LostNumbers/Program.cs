namespace LostNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Enunciado: Dado un array de enteros ordenado y sin repetidos, 
             * crea una función que calcule y retorne todos los que faltan entre
             * el mayor y el menor.
             * - Lanza un error si el array de entrada no es correcto.
             * 
             * { 1, 3, 6, 7 } => { 2, 4, 5 }
             */
        }
        public static int[] LostNumbers(int[] a)
        {
            if (IsNotASetOfInts(a))
            {
                throw new ArgumentException("Input array must be an array of unique integers");
            }
            if (IsNotSortedArray(a))
            {
                throw new ArgumentException("Input array must be a sorted array");
            }

            List<int> result = new();

            for (int i = 0; i < (a.Length - 1); i++)
            {
                int current = a[i];
                int next = a[i + 1];

                int[] lostIntsBetween = LostIntsBetween(current, next);
                result.AddRange(lostIntsBetween);
            }

            return result.ToArray();
        }
        private static bool IsNotASetOfInts(int[] a)
        {
            HashSet<int> set = new(a);

            return a.Length != set.Count;
        }
        private static bool IsNotSortedArray(int[] a)
        {
            if (a.Length == 0 || a.Length == 1)
            {
                return false;
            }

            for (int i = 0; i < (a.Length - 1); i++)
            {
                int current = a[i];
                int next = a[i + 1];

                if (current > next)
                {
                    return true;
                }
            }

            return false;
        }
        private static int[] LostIntsBetween(int current, int next)
        {
            List<int> result = new();

            for (int i = current + 1; i < next; i++)
            {
                result.Add(i);
            }
            
            return result.ToArray();
        }
    }
}