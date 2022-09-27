This is DLRS, a simple, straightforward server originally coded to provide skin
resource serving for a CustomNPCs session so I do not have to reload custom
resourcepacks back and forth to get custom skins loaded.

However, DLRS can be used for any purpose other than serving something to
Internet. DLRS is not safe for serving Internet; use a properly designed server,
such as Apache httpd or IIS, as they are proven to be safe.

Internally, DLRS uses HttpListener, a .NET class which uses http.sys as backend
and uses a managed backend when it is not available (due to working on
GNU/Linux or so).

Licence informationa are available at LICENSE.txt file.