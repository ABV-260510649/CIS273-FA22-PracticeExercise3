using System;

namespace PracticeExercise3
{
    public class Deque<T> : IDeque<T>
    {
        private LinkedList<T> linkedList;
        public Deque()
        {
            linkedList = new LinkedList<T>();
        }

        public T Front => IsEmpty ? throw new EmptyStackException() : linkedList.First.Value;

        public T Back => IsEmpty ? throw new EmptyStackException() : linkedList.Last.Value;

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public void AddBack(T item)
        {
            linkedList.AddLast(item);
        }

        public void AddFront(T item)
        {
            linkedList.AddFirst(item);
        }

        public T RemoveBack()
        {
            if (IsEmpty)
            {
                throw new EmptyStackException();
            }
            var back = linkedList.Last.Value;
            linkedList.RemoveLast();
            return back;
        }

        public T RemoveFront()
        {
            if (IsEmpty)
            {
                throw new EmptyStackException();
            }
            var front = linkedList.First.Value;
            linkedList.RemoveFirst();
            return front;
        }
    }
}
