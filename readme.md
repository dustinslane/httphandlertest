# ~~This code is intended to crash FXServer past 1142~~
# This has been patched in recent FiveM server builds



To reproduce:
1. Either compile the code or use the resource in `httphandler.zip;
2. Set up the resource to load into the server, you should see `Test Loaded` in the server console.
3. Use insomnia or whatever other tool you have to do a GET request to `http://127.0.0.1:30120/httphandler/test`
4. Server will crash.


\* Assertion at W:\cf\mono\mono\utils\mono-threads.c:634, condition `info' not met

