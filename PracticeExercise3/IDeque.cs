using System;

namespace PracticeExercise3
{
    public interface IDeque<T>
    {
        void AddFront(T item);

        void AddBack(T item);

        T RemoveFront();
        T RemoveBack();

        T Front { get;  }

        T Back { get;  }

        bool IsEmpty { get; }

        int Length { get; }
    }
}
