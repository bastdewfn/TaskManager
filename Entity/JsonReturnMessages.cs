﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager.Entity
{
    public class JsonReturnMessages
    {
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Msg
        {
            get;
            set;
        }

        public object Data
        {
            get;
            set;
        }
    }
}
