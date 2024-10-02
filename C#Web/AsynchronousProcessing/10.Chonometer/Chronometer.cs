using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Chonometer
{
    public class Chronometer : IChronometer
    {
        private List<string> laps;
        private Stopwatch stopwatch;

        public Chronometer()
        {
            this.laps = new List<string>();
            this.stopwatch = new Stopwatch();
        }
        public string GetTime => stopwatch.Elapsed.ToString("mm\\:ss\\.ff");

        public List<string> Laps => laps;

        public string Lap()
        {
            string currLap = GetTime;
            this.laps.Add(currLap);
            return currLap;
        }

        public void Reset()
        {
            stopwatch.Stop();
            stopwatch.Reset();
            laps.Clear();

        }

        public void Start()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }
        public string Time()
        {
            return GetTime;
        }
    }
}
