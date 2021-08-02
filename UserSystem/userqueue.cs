namespace UserSystem
{
    public class userqueue<T>
    {
        public USERNODE<T> Head { get; set; }

        public USERNODE<T> Tail { get; set; }

        public int Count { get; set; }

        public USERNODE<T> Enqueue(T value)
        {
            USERNODE<T> node = new USERNODE<T>(value);

            if (this.Head == null)
            {
                Head = Tail = node;
                this.Count++;
                return node;
            }

            this.Tail.Next = node;
            this.Tail = node;
            this.Count++;
            return node;
            
      
        }

        public T Dequeue()
        {
            // if (Head == null)
            // {
            //     throw new InvalidOperationException("Queue is empty");
            // }
            

            T removedUser = this.Head.Value;
            this.Head = this.Head.Next;
            this.Count--;
            return removedUser;
        }

        public void Print()
        {
            var temp = Head;
            while (temp != null)
            {
                System.Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}