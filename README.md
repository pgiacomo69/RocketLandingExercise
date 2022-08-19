# Rocket Landing Exercise

## NOTE:
The library "stores" all landing coordinates that are correct, answering "clash" to new requests with conflicting coordinates.
If a checked position was "out of platform", a successive request for same position continues to answer in the same way.

So, I don't know if I interpreted correctly this paragraph:
```
if the rocket asks for a position that has previously been checked by another 
rocket (only last check counts), it replies with `clash`
```
Maybe I should respond 'clash' on a successive request if position is the same of previous request, regardless if the position was 'out of platform'?

  
  

