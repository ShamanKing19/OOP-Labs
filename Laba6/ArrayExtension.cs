namespace Laba6;

public static class ArrayExtension
{
    /**
     * Метод расширения для массива
     *
     * @param Predicate<T>  filter    Функция предикат, фильтрующая массив
     * @param bool          sort      Вид сортировки (По умолчанию - по возрастанию)
     * @return T[]                    Отфильтрованный и отсортированный массив
     */
    public static T[] CustomFilter<T> (this T[] array, Predicate<T> filter, bool asc = true)
    {
        T[] newArray = new T[] {};
        int validItems = 0;
        
        foreach (T item in array)
        {
            if (filter(item))
            {
                validItems++;
                Array.Resize(ref newArray, validItems);
                newArray[validItems-1] = item;
            }
        }
        
        Array.Sort(newArray);
        if (!asc) {
            Array.Reverse(newArray);
        }
        
        return newArray;
    }
}