namespace ctci._10.SortingAndSearching
{
    public class SortedMerge
    {
        private int[] a;
        private int[] b;

        private int originalSizeA;

        private int indexA;
        private int indexB;

        private int writeIndex;

        // Given two sorted arrays, and with the first array having a large enough buffer to hold the second,
        // merge both arrays together in sorted order
        public SortedMerge(int[] a, int[] b)
        {
            this.originalSizeA = a.Length;
            this.a = a.Concat(new int[b.Length]).ToArray();
            this.b = b;

            this.writeIndex = this.a.Length - 1;
            this.indexA = a.Length - 1;
            this.indexB = b.Length - 1;
        }

        // Strategy: Start at the end of both arrays and write to the end of the buffer area
        public int[] GetMergedArray()
        {
            if (this.originalSizeA == 0)
            {
                return this.b;
            }

            while (this.writeIndex >= 0)
            {
                if (this.indexB < 0)
                {
                    break;
                }

                if (this.a[this.indexA] >= this.b[this.indexB])
                {
                    this.a[this.writeIndex] = this.a[this.indexA];
                    this.indexA--;
                }
                else
                {
                    this.a[this.writeIndex] = this.b[this.indexB];
                    this.indexB--;
                }
                this.writeIndex--;
            }

            return this.a;
        }
    }
}
