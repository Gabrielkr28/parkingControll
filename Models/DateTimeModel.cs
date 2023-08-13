using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControleEstacionamento.Model
{
    public class DateTimeModel
    {
        public event Action<DateTime> DateTimeUpdated;

        public void StartUpdating()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    DateTime currentDateTime = DateTime.Now;
                   
                    DateTimeUpdated?.Invoke(currentDateTime);

                    Thread.Sleep(100);
                }
            });
        }
    }
}
