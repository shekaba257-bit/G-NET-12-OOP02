using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Assignment_Session02_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part(1)


            #region Question01
            //a) Identify at least two problems with this design from an encapsulation perspective.
            //Answer
            //(1)الFields is Public Should Be Private 
            //(2)Withdrow بتسحب أي رقم حتى لو:بالسالب
            //

            //===================================================================
            //b) Describe how you would fix this class to follow proper encapsulation principles. You do not need to write the full code.

            //(1)نخلي الـ  fields private
            //(2)نضيف Validation ==> نمنع السحب لو المبلغ ≤ 0ونمنع السحب لو الرصيد مش كافي
            //=======================================================================
            //c) Explain why exposing fields directly (as public) is considered a bad practice in OOP.

            //(1) بتكسر مبدأ Encapsulation 
            //(2) مفيش Validation
            //(3) مفيش Business Rules
            #endregion

            #region Question02
            // Q02 : What is the difference between a field and a property in C#?
            // Can a property contain logic?
            // Give an example of a read-only property that returns a calculated value.
            //Answer



            //Field

            //متغير عادي بيخزن قيمة مباشرة.

            //غالبًا بيكون private.

            //مفيهوش تحكم ولا منطق.

            //مثال:

            //private double balance;

            //        Property

            //        وسيلة للوصول للـ field.

            //        ممكن يكون فيها get / set.

            //        تقدر تحط فيها logic و validation.

            //        مثال:

            //public double Balance

            //        {
            //            get { return balance; }
            //            set { balance = value; }
            //        }


            //==================================================================================

            // Can a property contain logic?



            //Validation

            //حسابات

            //شروط
            //==================================================================================
            // Give an example of a read-only property that returns a calculated value.
            //public class Rectangle
            //        {
            //            public double Width { get; set; }
            //            public double Height { get; set; }

            //            // Read-only calculated property
            //            public double Area
            //            {
            //                get { return Width * Height; }
            //            }
            //        }
            #endregion

            #region  Question03
            //a) What is `this[int index]` called? Explain its purpose.
            //اسمه Indexer
            //وظيفته إنه يسمح لك تتعامل مع Object كأنه Array



            //  b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer ?

            // IndexOutOfRangeException
            //السبب: الـ array حجمها 5(index من 0 لـ 4)

            // indexer safer?

            //نضيف validation جوه get و set:
            //index >= 0
            //index<names.Length
            //ولو غلط:
            //نرمي Exception 

            #endregion


            #region Question04
            //a) What does the `static` keyword mean on `TotalOrders`?
            //How is it different from the `Item` field?

            //Answer

            //static means the variable belongs to the class, not to each object.
            //TotalOrders has one copy for all Order objects.
            //Item is an instance field => each object has its own value

            //======================================================================
            //b) Can a static method inside `Order` access the `Item` field directly? Why or why not?

            //Answer

            //  A static method belongs to the class, not to an object.
            //مفيش object محدد.
            //Item needs an instance to be accessed.
            //Static methods can access only static members



            #endregion



            #endregion

            #region Part02
            //Cinema cinema = new Cinema();

            //// Input 3 tickets
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for Ticket {i + 1}:");

            //    Console.Write("Movie Name: ");
            //    string movieName = Console.ReadLine();

            //    Console.Write("Ticket Type (Regular/VIP/Student): ");
            //    TicketType type = Enum.Parse<TicketType>(Console.ReadLine(), true);

            //    Console.Write("Seat Row: ");
            //    int row = int.Parse(Console.ReadLine());

            //    Console.Write("Seat Number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine());

            //    Ticket t = new Ticket(movieName, type, new SeatLocation(row, number), price);
            //    cinema.AddTicket(t);
            //}

            //// Print tickets
            //Console.WriteLine("\n--- Tickets ---");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(cinema[i]);
            //}

            //// Search by movie name
            //Console.Write("\nEnter movie name to search: ");
            //string searchName = Console.ReadLine();
            //Ticket found = cinema.GetMovieByName(searchName);
            //Console.WriteLine(found != null ? found.ToString() : "Movie not found.");

            //// Total tickets sold
            //Console.WriteLine($"\nTotal Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            //// Booking references
            //Console.WriteLine($"Booking Ref 1: {BookingHelper.GenerateBookingReference()}");
            //Console.WriteLine($"Booking Ref 2: {BookingHelper.GenerateBookingReference()}");

            //// Group discount
            //double discountPrice = BookingHelper.CalcGroupDiscount(5, 80);
            //Console.WriteLine($"\nGroup Discount Price (5 tickets at 80 EGP): {discountPrice}");
            #endregion
        }
    }
}   

