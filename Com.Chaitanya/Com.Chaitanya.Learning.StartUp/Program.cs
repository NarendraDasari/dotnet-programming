

using Com.Chaitanya.Programming.Concepts.Arrays;
using Com.Chaitanya.Programming.Concepts.Collections;
using Com.Chaitanya.Programming.Concepts.Conditional.Loops;
using Com.Chaitanya.Programming.Concepts.Generic.Collections;

namespace Com.Chaitanya.Learning.StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");




            // this two lines are to test IfElse condition.
            //IfElseCondition con=new IfElseCondition();

            //con.TestIfelseCondition();


            //This lines are for testing while loop.
            //WhileLoop whi = new WhileLoop();
            //whi.RollTheDice();

            // SimpleArraysDemo demo= new SimpleArraysDemo();
            //demo.ForLoopProgram();

            //CollectionsDemo collect = new CollectionsDemo();
            //collect.TestCollections();

            ListDemo demo = new ListDemo();
            demo.TestingList();


        }
    }
}