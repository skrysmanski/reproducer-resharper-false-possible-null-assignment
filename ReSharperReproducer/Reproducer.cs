using System;
using System.Collections.Generic;

using JetBrains.Annotations;

namespace ReSharperReproducer
{
    public class Reproducer
    {
        [NotNull]
        public List<string> DoSomething(bool doIt)
        {
            List<string> logEntries = null;

            if (doIt)
            {
                Action action = () =>
                {
                    logEntries = PerformReadRequest();
                };

                action();
            }

            return logEntries ?? new List<string>();
        }

        [CanBeNull]
        private List<string> PerformReadRequest()
        {
            return null;
        }
    }
}
