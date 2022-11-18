using System;
namespace lecture12
{
    public class task2
    {




        public abstract class actorsObligation
        {
            public abstract void Request();
        }
        class RealActor : actorsObligation
        {
            public override void Request()
            {
                Console.WriteLine("simple scenes");
            }
        }


        public class stuntman : actorsObligation
        {
            RealActor realActor;
            public override void Request()
            {
                if (realActor == null)
                    realActor = new RealActor();
                realActor.Request();
                Console.WriteLine("rtuli da sashishi scenebi");
                Console.WriteLine("filmshi gadageba");
                Console.ReadLine();
            }

        }
    }
}


