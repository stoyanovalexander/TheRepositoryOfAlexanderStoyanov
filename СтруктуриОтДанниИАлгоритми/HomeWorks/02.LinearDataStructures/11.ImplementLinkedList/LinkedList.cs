using System;

class LinkedList<T>
{
    private ListItem<T> firstElement;
    private ListItem<T> currentElement;

    public int Count
    {
        get
        {
            int count = CheckCount();
            return count;
        }
        private set { }
    }

    private int CheckCount()
    {
        if (FirstElement == null)
        {
            return 0;
        }

        this.currentElement = this.FirstElement;

        int counter = 1;
        while (this.currentElement.NextItem != null)
        {
            counter++;
            this.currentElement = this.currentElement.NextItem;
        }

        return counter;
    }

    public ListItem<T> FirstElement
    {
        get
        {
            return this.firstElement;
        }
        set
        {
            this.firstElement = value;
        }
    }

    public LinkedList()
    {
        this.FirstElement = null;
    }

    public void AddFirst(T value)
    {
        if (this.FirstElement == null)
        {
            this.FirstElement = new ListItem<T>(value);
        }
        else
        {
            ListItem<T> newListItem = new ListItem<T>(value);
            newListItem.NextItem = this.FirstElement;
            this.FirstElement = newListItem;
        }
    }

    public void AddLast(T value)
    {
        if (this.FirstElement == null)
        {
            this.FirstElement = new ListItem<T>(value);
        }
        else
        {
            ListItem<T> next = this.FirstElement;

            while (next.NextItem != null)
            {
                next = next.NextItem;
            }

            next.NextItem = new ListItem<T>(value);
        }
    }

    public void AddAfter(ListItem<T> item, T value)
    {
        ListItem<T> next = this.FirstElement;
        while (next != item && next != null)
        {
            next = next.NextItem;
            if (next == null)
            {
                throw new ArgumentException("The ListItem is not in the linkedList!");
            }
        }
        ListItem<T> newItem = new ListItem<T>(value);
        newItem.NextItem = next.NextItem;
        next.NextItem = newItem;
    }

    public void AddBefore(ListItem<T> item, T value)
    {
        if (item == this.FirstElement)
        {
            ListItem<T> newList = new ListItem<T>(value);
            newList.NextItem = this.FirstElement;
            this.FirstElement = newList;
        }
        else
        {
            ListItem<T> next = this.FirstElement;

            while (next.NextItem != item)
            {
                next = next.NextItem;
                if (next == null)
                {
                    throw new ArgumentException("The ListItem is not in the linkedList!");
                }
            }

            ListItem<T> newList = new ListItem<T>(value);
            newList.NextItem = next.NextItem;
            next.NextItem = newList;


        }
    }

    public void RemoveFirst()
    {
        this.FirstElement = this.FirstElement.NextItem;
    }

    public void RemoveLast()
    {
        ListItem<T> next = this.FirstElement;

        while (next.NextItem != null)
        {
            next = next.NextItem;
        }
        ListItem<T> again = this.FirstElement;
        while (again.NextItem != next)
        {
            again = again.NextItem;
        }
        again.NextItem = null;
    }

    public void PrintList()
    {
        this.currentElement = this.FirstElement;

        Console.WriteLine(currentElement.Value);

        while (this.currentElement.NextItem != null)
        {
            this.currentElement = this.currentElement.NextItem;
            Console.WriteLine(this.currentElement.Value);
        }
    }
}