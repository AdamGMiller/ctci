using System;

namespace citi.Tests._3.StacksAndQueues
{
    public class StackOfStacks
    {
        private List<Stack<int>> stacks;

        private int stackCapacity;

        public StackOfStacks(int stackCapacity)
        {
            this.stackCapacity = stackCapacity;
            this.stacks = new List<Stack<int>>();
        }

        public void Push(int item)
        {
            var lastStack = this.stacks.LastOrDefault();
            if (lastStack == null || lastStack.Count >= this.stackCapacity)
            {
                lastStack = new Stack<int>();
                this.stacks.Add(lastStack);
            }
            lastStack.Push(item);
        }

        public int Pop()
        {
            var lastStack = this.GetLastStack();
            var item = lastStack.Pop();
            this.RemoveStackIfEmpty(lastStack, this.stacks.Count - 1);

            return item;
        }

        public int PopAt(int index)
        {
            if (index >= this.stacks.Count || index < 0)
            {
                throw new InvalidOperationException("Invalid stack number.");
            }

            var stack = this.stacks[index];
            var item = stack.Pop();
            this.RemoveStackIfEmpty(stack, index);

            return item;
        }

        public int Peek()
        {
            var lastStack = this.GetLastStack();
            return lastStack.Peek();
        }

        private Stack<int> GetLastStack()
        {
            if (this.stacks.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return this.stacks[^1];
        }

        private void RemoveStackIfEmpty(Stack<int> stack, int index)
        {
            if (stack.Count == 0)
            {
                this.stacks.RemoveAt(index);
            }
        }
    }
}