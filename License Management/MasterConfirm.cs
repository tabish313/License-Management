using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace License_Management
{
    public static class MasterConfirm
    {
        public static DialogResult Show()
        {
            MasterForm message = new MasterForm();
           
            return (message.ShowDialog());
        }
    }
}
