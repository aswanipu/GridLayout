﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDemoLayout.ViewModel
{
    class MainPageViewModel
    {
        public string Prompt { get; set; }
        public string Name { get; set; }
        public MainPageViewModel()
        {
            Prompt = "First Name";
            Name = "Aswani";
        }
    }
}
