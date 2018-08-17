namespace FacadeExample
{
    public class Facade
    {
        public void DoSomething()
        {
            var a = new Library1.Class1();
            var b = new Library2.Class2();
            var c = new Library3.Class3();

            a.DoTask1();
            b.DoTask2();
            c.DoTask3();
        }
    }
}
