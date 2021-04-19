using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{

    public class Phone : BaseViewModel
    {
        private string title;
        private int price;
        private string company;

        public string Title
        {
            get => title;
            set => SetValue(ref title, value);
        }
        public int Price
        {
            get => price;
            set => SetValue(ref price, value);
        }
        public string Company
        {
            get => company;
            set => SetValue(ref company, value);
        }

    }
}
