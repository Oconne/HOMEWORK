using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T> where T : IComparable<T>
    {
      private T[] arr;
 
      private int count;
 
      /// <summary>
      /// Returns the actual list length
      /// </summary>
      public int Count
      {
            get
            {
                  return count;
            }
      }
 
      private static readonly int INITIAL_CAPACITY = 16;
 
      /// <summary>
      /// Initializes the array-based list – allocate memory
      /// </summary>
      public GenericList()
      {
            arr = new T[INITIAL_CAPACITY];
            count = 0;
      }


      /// <summary>
      /// Adds element to the list
      /// </summary>
      /// <param name="item">The element you want to add</param>
      public void Add(T item)
      {
          Insert(count, item);
      }

      /// <summary>
      /// Inserts the specified element at а given
      /// position in this list
      /// </summary>
      /// <param name="index">
      /// Index, at which the specified element is to be inserted
      /// </param>
      /// <param name="item">Element to be inserted</param>
      /// <exception cref="System.IndexOutOfRangeException">Index is invalid</exception>
      /// 
      public void Insert(int index, T item)
      {
          if (index > count || index < 0)
          {
              throw new IndexOutOfRangeException(
                    "Invalid index: " + index);
          }
          T[] extendedArr = arr;
          if (count + 1 == arr.Length)
          {
              extendedArr = new T[arr.Length * 2];
          }
          Array.Copy(arr, extendedArr, index);
          count++;
          Array.Copy(arr, index, extendedArr, index + 1, count - index - 1);
          extendedArr[index] = item;
          arr = extendedArr;
      }


      /// <summary>
      /// Returns the index of the first occurrence
      /// of the specified element in this list.
      /// </summary>
      /// <param name="item">The element you are searching</param>
      /// <returns>
      /// The index of given element or -1 is not found
      /// </returns>
      public int IndexOf(T item)
      {
          for (int i = 0; i < arr.Length; i++)
          {
              if (this.arr[i].Equals(item))//
              {
                  return i;
              }
          }

          return -1;
      }

      /// <summary>
      /// Clears the list
      /// </summary>
      public void Clear()
      {
          arr = new T[INITIAL_CAPACITY];
          count = 0;
      }

      /// <summary>
      /// Checks if an element exists
      /// </summary>
      /// <param name="item">The item to be checked</param>
      /// <returns>If the item exists</returns>
      public bool Contains(T item)
      {
          int index = IndexOf(item);
          bool found = (index != -1);
          return found;
      }


      public T Max()
      {
          if (this.count < 1)
          {
              throw new InvalidOperationException("The list is empty");
          }

          T max = this.arr[0];
          for (int i = 1; i < this.count; i++)
          {
              if (this.arr[i].CompareTo(max) > 0)
              {
                  max = arr[i];
              }
          }
          return max;
      }


      public T Min()
      {
          if (this.count < 1)
          {
              throw new InvalidOperationException("The list is empty");
          }

          T min = this.arr[0];
          for (int i = 1; i < this.count; i++)
          {
              if (this.arr[i].CompareTo(min) < 0)
              {
                  min = arr[i];
              }
          }
          return min;
      }




      /// <summary>
      /// Retrieves the element on the set index
      /// </summary>
      /// <param name="index">Index of the element</param>
      /// <returns>The element on the current position</returns>
      public T this[int index]
      {
          get
          {
              if (index >= count || index < 0)
              {
                  throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
              }
              return arr[index];
          }
          set
          {
              if (index >= count || index < 0)
              {
                  throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
              }
              arr[index] = value;
          }
      }

      /// <summary>
      /// Removes the element at the specified index
      /// </summary>
      /// <param name="index">
      /// The index, whose element you want to remove
      /// </param>
      /// <returns>The removed element</returns>
      public object Remove(int index)
      {
          if (index >= count || index < 0)
          {
              throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
          }

          object item = arr[index];
          Array.Copy(arr, index + 1, arr, index, count - index + 1);
          arr[count - 1] = default(T);  //null
          count--;

          return item;
      }

      /// <summary>
      /// Removes the specified item
      /// </summary>
      /// <param name="item">The item you want to remove</param>
      /// <returns>Item index or -1 if item does not exists</returns>
      public int Remove(T item)
      {
          int index = IndexOf(item);
          if (index == -1)
          {
              return index;
          }

          Array.Copy(arr, index + 1, arr, index, count - index + 1);
          count--;

          return index;
      }





    }
}
