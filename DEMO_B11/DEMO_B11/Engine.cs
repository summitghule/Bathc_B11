using System;
using System.Collections.Generic;
using System.Text;

namespace DEMO_B11
{
    class ManualCarEngine : IEngineAction
    {
        public void Start()
        {
            Console.WriteLine("Called from manualCarEngine start");
        }

        public void Stop()
        {
            Console.WriteLine("Called from manualCarEngine stop");
        }
    }

    class ManualCarEngineWithKeyLess : IEngineAction
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    class ManualCarEngineCNG : IEngineAction
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    class BikeCarEngine : IEngineAction, IBikeEngine
    {
        void IEngineAction.Start()
        {
            throw new NotImplementedException();
        }

        void IEngineAction.Stop()
        {
            throw new NotImplementedException();
        }

        void IBikeEngine.Start()
        {
            throw new NotImplementedException();
        }

        void IBikeEngine.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
