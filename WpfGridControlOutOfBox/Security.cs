﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGridControlOutOfBox
{
    public class Security
    {
        private int _id;
        private string _name;
        private string _brokerName;
        public int Id { get { return _id; } set { _id = value; }}

        public string Name { get { return _name; } set { _name = value; } }
        public string BrokerName { get { return _brokerName; } set { _brokerName = value; } }

    }
}
