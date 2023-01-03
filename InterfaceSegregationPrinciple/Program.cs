/*
 *             *** INTERFACE SEGREGATION PRINCIPLE ***
 * 
 * ISP states that a client should not be forced to depend on
 * interfaces that they don't use.
 * 
 * In the following example we have a monolithic ILibraryItem which is
 * applied to all of the classes however not all the properties
 * and methods are implemented by each class. Like a ReferenceBook
 * which is not borrowable.
 * 
 * Following the ISP we break down ILibraryItem into smaller pieces
 * Because of that a class may implements more than on interface
 * that is why we also create empty Interface which group the 
 * interfaces for each class.
 * Although those would be needed when giving a type to a variable
 * and making it implements all of the properties and classes
 * from the many interfaces
 * 
 */

namespace InterfaceSegregationPrinciple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}