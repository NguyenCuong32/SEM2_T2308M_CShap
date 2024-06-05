using System;
namespace DemoEvent
{
    public delegate void Notify();
    public class BusinessProcess
	{
		public event Notify OnProcess;
		public void StartProcess()
		{
			Console.WriteLine("Start process");
			System.Threading.Thread.Sleep(5000);
			StopProcess();

		}
		private void StopProcess()
		{
			OnProcess?.Invoke();
		}
	}
}

