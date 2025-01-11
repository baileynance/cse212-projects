public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Create a new array for the doubles to get assigned to
        double[] multiples = new double[length];
        // Iterate through the number the requested amount of times
        for (int i = 0; i < length; i++) {
            // Assign the new multiplied value to the new multiples array
            multiples[i] = (i + 1) * number;
        }
        // Return multiples array
        return multiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Find the amount of rotations we are going to iterate through by 
        // subtracting the length of the array by requested ammount
        int rotate = data.Count - amount;
        // Iterate through array by requested amount
        for (var i = 0; i < rotate; i++) {
            // assign the first value of the array at each iteration
            var value = data[0];
            // Add the beginning value to the end of the array
            data.Add(value);
            // Remove beginning value
            data.RemoveAt(0);

            // By moving the beginning value of the array to the end x amount of times
            // We are essentially sliding the values one direction
        }
    }
}
