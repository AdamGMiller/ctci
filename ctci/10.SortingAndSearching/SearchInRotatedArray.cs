namespace ctci._10.SortingAndSearching
{
    public class SearchInRotatedArray
    {
        private int[] a;

        public SearchInRotatedArray(int[] a)
        {
            this.a = a;
        }

        public int FindIndex(int value)
        {
            var left = this.a[0];
            var right = this.a[^1];

            return this.SearchInArray(left, right, value, 0, this.a.Length - 1);
        }

        // Similar to a binary search, but we can throw out one side or the other if we know that it's sorted
        // and the value is not in that range
        private int SearchInArray(int left, int right, int value, int leftIndex, int rightIndex)
        {
            var midpointIndex = (leftIndex + rightIndex) / 2;
            var midpoint = this.a[midpointIndex];

            // if left is less than midpoint, then the left side is sorted
            var leftIsSorted = left < midpoint;
            var rightIsSorted = right > midpoint;

            if (left == value)
            {
                return leftIndex;
            }
            else if (right == value)
            {
                return rightIndex;
            }
            else if (midpoint == value)
            {
                return midpointIndex;
            }

            if (leftIsSorted)
            {
                if (value >= left && value <= midpoint)
                {
                    return SearchInArray(left, midpoint, value, leftIndex, midpointIndex);
                }
                else if (rightIsSorted)
                {
                    return SearchInArray(midpoint, right, value, midpointIndex, rightIndex);
                }
            }
            else if (rightIsSorted)
            {
                if (value >= midpoint && value <= right)
                {
                    return SearchInArray(midpoint, right, value, midpointIndex, rightIndex);
                }
            }

            return -1;
        }
    }
}
