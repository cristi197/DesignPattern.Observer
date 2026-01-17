namespace FirstExample;

public class ConcreteSubject : ISubject
{
    private readonly List<IObserver> _observers = [];
    private string _state = string.Empty;

    public void SetState(string state)
    {
        _state = state;
        Notify();
    }

    public string GetState()
    {
        return _state;
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach(var observer in _observers)
        {
            observer.Update();
        }
    }
}
