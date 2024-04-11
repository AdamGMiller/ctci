namespace citi.Tests._3.StacksAndQueues
{
    public class MultiStack
    {
        private readonly int numberOfStacks = 3;

        private int capacityPerStack;

        private int[] items;

        private int[] size;

        public MultiStack(int capacityPerStack)
        {
            this.size = new int[] { 0, 0, 0 };
            this.items = new int[capacityPerStack * this.numberOfStacks];
            this.capacityPerStack = capacityPerStack;
        }

        public int Pop(int stack)
        {
            this.ValidateStackNumber(stack);
            this.ValidateStackHasData(stack);

            var itemToPop = this.items[this.GetStackTopIndex(stack)];
            this.size[stack]--;

            return itemToPop;
        }

        public void Push(int stack, int item)
        {
            this.ValidateStackNumber(stack);
            this.ValidateStackIsNotFull(stack);

            this.size[stack]++;
            this.items[this.GetStackTopIndex(stack)] = item;
        }

        public int Peek(int stack)
        {
            this.ValidateStackNumber(stack);
            this.ValidateStackHasData(stack);

            return this.items[this.GetStackTopIndex(stack)];
        }

        public bool IsEmpty(int stack)
        {
            this.ValidateStackNumber(stack);
            return this.size[stack] == 0;
        }

        private int GetStackTopIndex(int stack)
        {
            return stack * this.size[stack];
        }

        private void ValidateStackNumber(int stack)
        {
            if (stack < 0 || stack >= this.numberOfStacks)
            {
                throw new InvalidOperationException("Invalid stack number.");
            }
        }

        private void ValidateStackHasData(int stack)
        {
            if (this.IsEmpty(stack))
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        private void ValidateStackIsNotFull(int stack)
        {
            if (this.size[stack] == this.capacityPerStack)
            {
                throw new InvalidOperationException("Stack is full.");
            }
        }
    }
}
