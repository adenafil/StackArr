using System;

namespace tes
{
    public class StackArr {
    public int Top;
    public string[] arrayData;
    public int MaxSize;

    public StackArr(int maxSize)
    {
        this.MaxSize = maxSize;
        this.arrayData = new string[maxSize];

        this.Top = -1;
    }

    public void Push(string data)
    {
        if (this.Top == this.MaxSize-1)
        {
            Console.WriteLine("Stack sudah penuh");
        }
        else
        {
            this.Top++;
            arrayData[this.Top] = data;
        }
    }

    public string Pop()
    {
        if (this.Top == -1)
        {
            Console.WriteLine("Stack Masih Kosong");
            return null;
        }
        else
        {
            string popped = this.arrayData[this.Top];

            this.Top--;
            return popped;
        }
    }

    public bool IsEmpty()
    {
        return this.Top == -1;
    }
}
}