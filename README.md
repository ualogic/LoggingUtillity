# Logging Utillity
Too lazy to type Debug.Log(), .ToString(), etc...

### To use:

One object

- u.l = ObjectToLog ex: u.l = transform.position

Multiple objects, separates with space
- u.log(param1,param2,param3....) ex: u.log("time", time, "position", transform.position)

Multiple objects, custom separator string
- u.slog(separator, param1, param2, param3...)

Debug text field
- Change DataManager.instance.DebugText.text to reference text field

then
- u.d
- u.debug()
