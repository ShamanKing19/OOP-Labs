namespace Laba6;

public class EventGenerator
{
    private int MaxSubscribers { get; set; }

    public delegate void EventHandler();
    public event EventHandler SomeEvent;

    public EventGenerator(int maxSubscribers)
    {
        MaxSubscribers = maxSubscribers;
    }

    public void GenerateEvent(int numberOfEvents, int pauseMs)
    {
        for (int i = 0; i < numberOfEvents; i++)
        {
            if (SomeEvent == null) continue;

            Delegate[] subscribers = this.SomeEvent.GetInvocationList();
            for (int k = 0; k < this.MaxSubscribers && k < subscribers.Length; k++)
            {
                subscribers[k].DynamicInvoke();
            }
            
            Thread.Sleep(pauseMs);
        }
    }
}