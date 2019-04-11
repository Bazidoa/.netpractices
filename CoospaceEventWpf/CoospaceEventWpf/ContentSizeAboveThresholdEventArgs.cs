using System;

namespace CoospaceEventDemo
{
    public class ContentSizeAboveThresholdEventArgs : EventArgs
    {
        public int CurrentContentSize { get; private set; }
        public int MaximumSize { get; private set; }

        public ContentSizeAboveThresholdEventArgs(int maxSize, int currentContentSize)
        {
            MaximumSize = maxSize;
            CurrentContentSize = currentContentSize;
        }
    }
}
