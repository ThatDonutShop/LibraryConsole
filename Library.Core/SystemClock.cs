﻿namespace Library.Core
{
    public class SystemClock : IClock
    {
        public DateTime Now => DateTime.Now;
    }
}
