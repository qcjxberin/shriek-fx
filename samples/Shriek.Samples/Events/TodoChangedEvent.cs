﻿using System;
using Shriek.Events;

namespace Shriek.Samples.Events
{
    public class TodoChangedEvent : Event
    {
        public string Name { get; set; }

        public string Desception { get; set; }
        public DateTime FinishTime { get; set; }
    }
}