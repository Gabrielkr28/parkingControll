using ControleEstacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace ControleEstacionamento.Controller
{
    public class DateTimeController : DateTimeModel
    {
        private Label label;

        public DateTimeController(Label label)
        {
            this.label = label;

            this.DateTimeUpdated += UpdateLabel;
        }

        public new void StartUpdating()
        {
            base.StartUpdating();
        }

        private void UpdateLabel(DateTime dateTime)
        {
            string formattedDateTime = dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            label.Invoke((MethodInvoker)(() => label.Text = formattedDateTime));
        }
    }
}
