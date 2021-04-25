using System;
using System.Diagnostics;
using System.Threading;

namespace Engine.Models
{
	public class TimeCounter
	{
		public int AmountOfTime { get; set; }
		private bool IsRun { get; set; }
		private Thread TimeThread { get; set; }

		public TimeCounter(int amountOfTime)
		{
			AmountOfTime = amountOfTime;
		}

		public void StartStopwatch()
		{
			IsRun = true;

			TimeThread = new Thread(new ThreadStart(Time));
			TimeThread.Start();
		}

		private void Time()
		{
			var time = new Stopwatch();
			time.Start();

			while (IsRun)
			{
				AmountOfTime = time.Elapsed.Seconds;
				Thread.Sleep(500);
			}
		}

		public void Stop()
		{
			IsRun = false;
		}
	}
}
