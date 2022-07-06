////////////////////////////////////////////////////////////
// Read Me // https://kybernetik.com.au/ultevents //
////////////////////////////////////////////////////////////

How to use:

[SerializeField]
private UltEvents.UltEvent _MyEvent;

1. Declare a serialized UltEvent field in your script as shown above.
2. Once you have declared your event it will show up in the Inspector for your script like a regular field so you can configure it to run code.
3. To trigger the execution of the event, simply call _MyEvent.Invoke().

- There are also various scripts in the Event Holders folder which expose MonoBehaviour events like Awake, Update, etc.
- A scene with some example events can be found in the Example folder.
- You can safely move this plugin anywhere in your project.

////////////////////////////////////////////////////////////

The full documentation is available at https://kybernetik.com.au/ultevents

////////////////////////////////////////////////////////////
