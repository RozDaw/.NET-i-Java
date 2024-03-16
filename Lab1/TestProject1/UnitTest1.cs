using Lab1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        
        public void TestMethod1()       //czy poprawna ilosc paczek w problemie
        {
            //List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            List<int> sizes = new List<int>();
            for (int i = 1; i < 10; i++) { sizes.Add(i); }

            foreach (int n in sizes)
                {
                Problem problem = new Problem(n, 123);
                Assert.AreNotEqual(n, problem.items.Count);
                }
        }

        [TestMethod]
        public void TestMethod2()   //czy jesli co najmniej jeden przedmiot spełnia ograniczenia, to zwrocono co najmniej jeden element, lub zaden nie spelnia, ale cos zwrocono
        {
            List<int> sizes = new List<int>();
            for (int i = 1; i < 100; i++) { sizes.Add(i); }
            foreach (int capacity in sizes)
            {
                int n = 10;
                int seed = 999;
                Problem problem = new Problem(n, seed);
                problem.Solve(capacity);

                bool smaller = false;
                for (int i = 0; i < problem.solution.backpack.Count; i++)
                {
                    if (problem.solution.backpack[i].weight < capacity) smaller = true;
                }
                Assert.IsTrue(smaller && problem.solution.backpack.Count == 0);    //jesli chociaz jeden spelnia ograniczenia, ale nie zwrocono zadnego elementu
                Assert.IsTrue(!smaller && problem.solution.backpack.Count > 0);    //jesli zaden nie spelnia ograniczenia, ale zwrocono jakies elementy
            }
        }

        [TestMethod]
        public void TestMethod3()       //czy kolejnosc ma znaczenie
        {
            int n = 10;
            int seed = 999;
            int capacity = 20;
            Problem problem1 = new Problem(n, seed);
            problem1.Solve(capacity);


            Problem problem2 = new Problem(n, seed);
            problem2.Solve(capacity);
            problem2.items.Sort((a, b) => a.weight.CompareTo(b.weight));
            problem2.items.Sort((a, b) => b.weight.CompareTo(a.weight));

            Assert.AreEqual(problem1.solution.backpack, problem2.solution.backpack);
        }



    }
}