using System;
using Ninject;
using Model;
using System.Threading;

namespace Presentation
{
    public class TransportPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ITransportView _view;
        private readonly ITransportService _service;

        private bool simulationInProces;
        private bool firstStart;
        private Thread thread;

        public TransportPresenter(IKernel kernel, ITransportView view, ITransportService service)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            _view.SetUp += SetUp;
            _view.StartSimulation += StartSimulation;
            _view.StopSimulation += StopSimulation;

            firstStart = true;
        }

        private void SetUp()
        {
            _kernel.Get<SetUpPresenter>().Run();
            _view.Close();
        }

        private void StartSimulation()
        {
            if (firstStart)
            {
                simulationInProces = true;
                thread = new Thread(Simulate);
                thread.Start();
                firstStart = false;
            }
            else
            {
                if (!simulationInProces)
                {
                    thread.Resume();
                    simulationInProces = true;
                }
            }
        }
        private void Simulate()
        {
            int i = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                _view.WriteTempLabel((i++).ToString());          
            }
        }

        private void StopSimulation()
        {
            if (!simulationInProces) return;
            simulationInProces = false;
            thread.Suspend();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
