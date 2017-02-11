using UnityEngine;

public interface Message <T>
{
    void Receive(T param);
}

static public class TypedSendMessage
{
    static public void SendTypedMessage <T> (this GameObject target, T param = default(T))
    {
        var targs = target.GetComponents(typeof(Message<T>));
        foreach (var targ in targs) {
            (targ as Message<T>).Receive(param);
        }
    }
}