# CefSharpWinFormToDo

Simple app to demonstrate communication between an embedded Chromium browser and a WinForm app. It uses [jQuery TodoMVC](http://todomvc.com/examples/jquery/#/all) to implement the in browser functionality. Changes to the data in the browser are reflected in a DataGridView as they are written into the store. Additionally you can add a todo item in the WinForm and persist in the browser. 

All changes in the TodoMVC code are in app.js and identified by `// @cravelight`.
