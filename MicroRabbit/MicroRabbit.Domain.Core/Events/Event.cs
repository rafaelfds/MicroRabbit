using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.Xml.Xsl;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
