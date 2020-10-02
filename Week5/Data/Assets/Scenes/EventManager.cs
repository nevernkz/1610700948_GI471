using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventManager : MonoBehaviour
{
    Dictionary<string, UnityEvent> eventDict = new Dictionary<string, UnityEvent>();
    public static EventManager instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    public void StartListening(string eventName,UnityAction listenner)
    {
      
        if (eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEventDict = eventDict[eventName];
            thisEventDict.AddListener(listenner);
        }
        else
        {
            UnityEvent thisEvent = new UnityEvent();
            thisEvent.AddListener(listenner);
            eventDict.Add(eventName, thisEvent);
        }
   
    }

    public void StopListening(string eventName, UnityAction listenner)
    {
        if (eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEvent = eventDict[eventName];
            thisEvent.RemoveListener(listenner);

        }
    }

    public void TriggerEvent(string eventName)
    {
        if(eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEvent = eventDict[eventName];
            thisEvent.Invoke();

        }
    }
}
